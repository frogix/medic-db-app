using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using dbApp.Utils;
using System.Security.Cryptography;
using WindowsFormsApp2.Forms;

namespace dbApp
{
    using static Helpers;

    public partial class RegistrationForm : Form
    {
        private DataTable testsInfo;

        private string firstName
        {
            get => firstnameTB.Text.Trim();
            set => firstnameTB.Text = value.Trim();
        }
        
        private string lastName
        {
            get => lastnameTB.Text.Trim();
            set => lastnameTB.Text = value.Trim();
        }

        private string groupName
        {
            get => groupTB.Text.Trim();
            set => groupTB.Text = value.Trim();
        }

        private string login
        {
            get => loginTB.Text.Trim();
            set => loginTB.Text = value.Trim();
        }

        private string password
        {
            get => passwordTB.Text.Trim();
            set => passwordTB.Text = value.Trim();
        }

        public RegistrationForm()
        {
            InitializeComponent();

            login    = "teacher";
            password = "asdfjkl;";
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (firstName == "" || lastName == "" || groupName == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля для продолжения.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddNewStudent();

            int studentID = GetStudentID();
            var testID = (int)testsInfo.Rows[variantCB.SelectedIndex]["test_id"];
            var testingForm = new TestingForm(testID, studentID);
            testingForm.Closed += (s, args) => this.Close();
            testingForm.Show();
            this.Hide();
            //this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            var dt = DB.ExecuteQuery("SELECT test_name, test_id FROM tests_info");

            testsInfo = dt;

            FillCombobox(dt, "test_name", variantCB);
            if (dt.Rows.Count > 0)
            {
                variantCB.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Отсутствуют заготовленные варианты тестов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddNewStudent()
        {
            SqlConnection connection = new SqlConnection(
                ConfigurationManager.ConnectionStrings[2].ConnectionString
            );
            SqlCommand cmd = new SqlCommand("add_new_student", connection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@firstname", firstName));
            cmd.Parameters.Add(new SqlParameter("@lastname",  lastName));
            cmd.Parameters.Add(new SqlParameter("@groupname", groupName));

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
        }

        private int GetStudentID ()
        {
            SqlConnection connection = new SqlConnection(
                ConfigurationManager.ConnectionStrings[2].ConnectionString
            );
            SqlCommand cmd = new SqlCommand($"SELECT id FROM students WHERE first_name = '{firstName}' AND last_name = '{lastName}' AND group_name = '{groupName}'", connection);

            try
            {
                connection.Open();
                return (int)cmd.ExecuteScalar();
            }
            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (login == "" || password == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля для продолжения.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = DB.ExecuteQuery($"SELECT login, password FROM users WHERE login = '{login}'");

            
            if (user.Rows.Count == 0)
            {
                MessageBox.Show("Пользователя с данным логином не существует", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dbPassword = user.Rows[0]["password"].ToString();

            if (DB.IsValidPassword(password, dbPassword))
            {
                new TestsListForm().Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void tests_infoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = DB.ExecuteQuery("SELECT test_name, test_id FROM tests_info");

            testsInfo = dt;

            FillCombobox(dt, "test_name", variantCB);
            if (dt.Rows.Count > 0)
            {
                variantCB.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Отсутствуют заготовленные варианты тестов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
