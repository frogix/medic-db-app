using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using dbApp.Utils;

namespace WindowsFormsApp2.Forms
{
    public partial class SelectTasksForm : Form
    {
        public int TestID;

        public SelectTasksForm(int testId)
        {
            TestID = testId;
            InitializeComponent();
        }

        private void SelectTasksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kr_dbDataSet.tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.kr_dbDataSet.tasks);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rbAnyAbn.Checked = true;
            rbAnyDate.Checked = true;
            rbAnyId.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
            MessageBox.Show(FormWhereClause());
        }

        string FormWhereClause ()
        {
            string clause = "";
            string dateFormat = "yyyy-MM-dd HH:mm:ss";
            bool hasPrevious = false;

            if (rbHasAbn.Checked)
            {
                hasPrevious = true;
                clause += "answer IS NOT NULL";
            } else if (rbNoAbn.Checked)
            {
                hasPrevious = true;
                clause += "answer IS NULL";
            }

            if (rbSetDate.Checked)
            {
                if (hasPrevious) clause += " AND ";
                hasPrevious = true;
                clause += $"created_at = '{dateTimePicker1.Value.ToString(dateFormat)}'";
            }

            if (rbSetId.Checked)
            {
                if (hasPrevious) clause += " AND ";
                hasPrevious = true;
                clause += $"id = {numericUpDown1.Value}";
            }

            if (rbHideRest.Checked)
            {
                if (hasPrevious) clause += " AND ";
                hasPrevious = true;
                clause += $"test_id = '{TestID}'";
            }

            if (clause.Length != 0) clause = "WHERE " + clause;

            return clause;
        }

        void UpdateDataGridView()
        {
            

            SqlCommand cmd = new SqlCommand(
                    $"SELECT tasks.id, picture, answer, created_at FROM tasks " +
                $"INNER JOIN tests_tasks ON tasks.id = task_id " +
                $"{FormWhereClause()}"
            );
            
            dataGridView1.DataSource = DB.ExecuteQuery(cmd);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string selectedString = Helpers.GetSelectedValuesCSV(dataGridView1, 0);

            if (selectedString.Length == 0)
            {
                MessageBox.Show("Не было выделено ни одного значения!");
                return;
            }

            SqlCommand cmd = new SqlCommand(
                $"DELETE FROM tests_tasks " +
                      $"WHERE test_id = '{TestID}' AND task_id IN ({selectedString})"
            );

            DB.ExecuteCmd(cmd);
            MessageBox.Show("Задания были успешно удалены");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string csvList = "";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();

                csvList += $"({TestID}, {id}), ";
            }

            if (csvList.Length == 0)
            {
                MessageBox.Show("Не было выделено ни одного значения!");
                return;
            }

            csvList = csvList.Substring(0, csvList.Length - 2);

            SqlCommand cmd = new SqlCommand(
                $"INSERT INTO tests_tasks (test_id, task_id) " +
                     $"VALUES {csvList}"
            );

            DB.ExecuteCmd(cmd);
            MessageBox.Show("Значения успешно были добавлены");
        }


    }
}
