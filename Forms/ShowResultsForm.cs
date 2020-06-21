using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbApp.Utils;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApp2.Forms
{
    public partial class ShowResultsForm : Form
    {
        public ShowResultsForm()
        {
            InitializeComponent();
        }

        private void test_completionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.test_completionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kr_dbDataSet);

        }

        private void ShowResultsForm_Load(object sender, EventArgs e)
        {
            cbTest.DataSource = DB.ExecuteQuery(new SqlCommand(@"SELECT * FROM tests_info"));
            cbTest.DisplayMember = "test_name";

            SqlCommand cmd = new SqlCommand(@"SELECT last_name, first_name, group_name, test_name, date, accuracy, mark
                                                FROM test_completions
                                          INNER JOIN students   ON student_id = students.id
                                          INNER JOIN tests_info ON test_completions.test_id = tests_info.test_id");

            dataGridView1.DataSource = DB.ExecuteQuery(cmd);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rbAnyDate.Checked = true;
            rbAnyGroup.Checked = true;
            rbAnyLastname.Checked = true;
            rbAnyMark.Checked = true;
            rbAnyTest.Checked = true;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($@"SELECT last_name, first_name, group_name, test_name, date, accuracy, mark
                                                FROM test_completions
                                          INNER JOIN students   ON student_id = students.id
                                          INNER JOIN tests_info ON test_completions.test_id = tests_info.test_id
                                          {FormWhereClause()}");

            dataGridView1.DataSource = DB.ExecuteQuery(cmd);
        }

        string FormWhereClause()
        {
            string clause = "";
            bool hasPrevious = false;

            if (rbSetTest.Checked)
            {
                hasPrevious = true;
                clause += $"test_name = '{cbTest.Text}'";
            }
            if (rbSetDate.Checked)
            { 
                if (hasPrevious) clause += " AND ";
                hasPrevious = true;
                clause += $"CONVERT(DATETIME, FLOOR(CONVERT(FLOAT, date))) = '{dateTimePicker1.Value:dd.MM.yyyy}'";
            }

            if (rbSetGroup.Checked)
            {
                if (hasPrevious) clause += " AND ";
                hasPrevious = true;
                clause += $"group_name = '{tbGroup.Text}'";
            }

            if (rbSetMark.Checked)
            {
                if (hasPrevious) clause += " AND ";
                hasPrevious = true;
                clause += $"mark = {numericUpDown1.Value}";
            }

            if (rbSetLastname.Checked)
            {
                if (hasPrevious) clause += " AND ";
                hasPrevious = true;
                clause += $"last_name = '{tbLastname.Text}'";
            }

            if (clause.Length != 0) clause = "WHERE " + clause;

            return clause;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveToCSV(dataGridView1);
        }


        private void SaveToCSV(DataGridView DGV)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Отчёт.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Невозможно записать файл по указанному пути." + ex.Message);
                    }
                }
                var sb = new StringBuilder();

                var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
                sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                }
                System.IO.File.WriteAllText(sfd.FileName, sb.ToString(), System.Text.Encoding.UTF8);
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Отчёт.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Невозможно записать данные на диск." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                            var font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}
