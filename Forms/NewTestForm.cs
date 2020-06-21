using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbApp.Utils;

namespace WindowsFormsApp2.Forms
{
    public partial class NewTestForm : Form
    {
        public NewTestForm()
        {
            InitializeComponent();
        }

        public NewTestForm(string id, string name, string timer) : this()
        {
            NewTestId = Convert.ToInt32(id);
            TestName = name;
            TestTimer = Convert.ToInt32(timer);
            IsEditing = true;
        }

        public bool IsEditing = false;

        public string TestName
        {
            get => nameTB.Text.Trim();
            set => nameTB.Text = value.Trim();
        }

        public int TestTimer
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        public int NewTestId = -1;


        private void btnAddTasks_Click(object sender, EventArgs e)
        {
            var stf = new SelectTasksForm(NewTestId);

            stf.ShowDialog();

            UpdateDataView();
        }

        void UpdateDataView ()
        {
            dataGridView1.DataSource = DB.ExecuteQuery($@"
                        SELECT tasks.id, 
                               tasks.picture, 
                               tasks.answer 
                        FROM   tasks 
                               INNER JOIN tests_tasks 
                                       ON tasks.id = tests_tasks.task_id 
                        WHERE  tests_tasks.test_id = {NewTestId}
                ");
            dataGridView1.Invalidate();

        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {

            DB.ExecuteCmd($"UPDATE tests_info SET test_name = '{nameTB.Text}', test_timer = {TestTimer} WHERE test_id = {NewTestId}");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!IsEditing)
            {
                DB.ExecuteCmd($"DELETE FROM tests_tasks WHERE test_id = {NewTestId}");
                DB.ExecuteCmd($"DELETE FROM test_completions WHERE test_id = {NewTestId}");
                DB.ExecuteCmd($"DELETE FROM tests_info WHERE test_id = {NewTestId}");
            }
            this.Close();
        }

        private void CreateNewTest()
        {
            SqlConnection connection = DB.connection;
            SqlCommand cmd = new SqlCommand("INSERT INTO tests_info(test_name, test_timer) output INSERTED.TEST_ID VALUES ('New Test', 0)", connection);

            try
            {
                connection.Open();
                NewTestId = (int)cmd.ExecuteScalar();
            }
            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
        }

        private void NewTestForm_Load(object sender, EventArgs e)
        {
            if (NewTestId == -1)
                CreateNewTest();

            UpdateDataView();
        }

        private void btnRemoveTasks_Click(object sender, EventArgs e)
        {
            string selectedString = Helpers.GetSelectedValuesCSV(dataGridView1, 0);

            if (selectedString.Length == 0)
            {
                MessageBox.Show("Не было выделено ни одного значения!");
                return;
            }

            SqlCommand cmd = new SqlCommand(
                $"DELETE FROM tests_tasks " +
                      $"WHERE test_id = '{NewTestId}' AND task_id IN ({selectedString})"
            );

            DB.ExecuteCmd(cmd);
            MessageBox.Show("Задания были успешно удалены");

        }
    }
}
