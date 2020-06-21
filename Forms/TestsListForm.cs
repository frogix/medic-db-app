using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbApp;
using dbApp.Utils;

namespace WindowsFormsApp2.Forms
{
    using static Helpers;

    public partial class TestsListForm : Form
    {
        public TestsListForm()
        {
            InitializeComponent();
        }

        private void EditTestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kr_dbDataSet.tests_info' table. You can move, or remove it, as needed.
            this.tests_infoTableAdapter.Fill(this.kr_dbDataSet.tests_info);

            dgTests_SelectionChanged(null, null);

        }

        private void tests_tasksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.kr_dbDataSet);

        }

        private void tasksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.kr_dbDataSet);

        }

        private void tests_infoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tests_infoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kr_dbDataSet);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            DB.ExecuteCmd($"DELETE FROM tests_tasks WHERE test_id IN ({GetSelectedValuesCSV(dgTests, 0)})");
            DB.ExecuteCmd($"DELETE FROM test_completions WHERE test_id IN ({GetSelectedValuesCSV(dgTests, 0)})");
            DB.ExecuteCmd($"DELETE FROM tests_info WHERE test_id IN ({GetSelectedValuesCSV(dgTests, 0)})");

            MessageBox.Show("Успешно удалены записи!");
            UpdateDG();

        }

        private void UpdateDG ()
        {
            this.tableAdapterManager.UpdateAll(this.kr_dbDataSet);
            this.tests_infoTableAdapter.Fill(this.kr_dbDataSet.tests_info);
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            var cnt = new NewTestForm();

            cnt.ShowDialog();
            UpdateDG();
        }

        private void btnEditTasks_Click(object sender, EventArgs e)
        {
            string id    = dgTests.SelectedRows[0].Cells[0].Value.ToString();
            string name  = dgTests.SelectedRows[0].Cells[1].Value.ToString();
            string timer = dgTests.SelectedRows[0].Cells[2].Value.ToString();

            var cnt = new NewTestForm(id, name, timer);

            cnt.ShowDialog();
            UpdateDG();
        }

        private void dgTests_SelectionChanged(object sender, EventArgs e)
        {
            if (dgTests.SelectedRows.Count == 0)
            {
                btnEditTasks.Enabled = false;
                btnRemove.Enabled    = false;
            } else if (dgTests.SelectedRows.Count == 1)
            {
                btnEditTasks.Enabled = true;
                btnRemove.Enabled    = true;
            } else
            {
                btnEditTasks.Enabled = false;
                btnRemove.Enabled    = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var resultsForm = new ShowResultsForm();

            resultsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CreateTaskForm().Show();
        }
    }
}
