using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbApp.Utils;

namespace dbApp
{
    public partial class TestingForm : Form
    {
        List<Image> cleanImgs = new List<Image>();
        List<Image> tasks     = new List<Image>();
        List<Image> answers   = new List<Image>();
        List<Image> variants  = new List<Image>();

        int currentTaskNumber = 0;
        int tasksNumber
        {
            get
            {
                return tasks.Count;
            }
        }

        private int testID, studentID;

        public TestingForm(int testID, int studentID)
        {
            this.testID = testID;
            this.studentID = studentID;
            InitializeComponent();
        }

        private void LoadTasks()
        {
            var picturesDataTable = DB.ExecuteQuery($@"
                SELECT picture, 
                       answer 
                FROM   tests_info 
                       INNER JOIN tests_tasks 
                               ON tests_tasks.test_id = tests_info.test_id 
                       INNER JOIN tasks 
                               ON tasks.id = tests_tasks.task_id
                WHERE  tests_tasks.test_id = {testID}

            ");

            if (picturesDataTable.Rows.Count == 0)
            {
                MessageBox.Show("Выбранный тест не содержит ни одного задания!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
 
            tasks     = DataTableColumnToImageList(picturesDataTable, "picture", pictureBox1.Width);
            cleanImgs = DataTableColumnToImageList(picturesDataTable, "picture", pictureBox1.Width);
            answers   = DataTableColumnToImageList(picturesDataTable, "answer",  pictureBox1.Width);
            for (int i = 0; i < tasks.Count; i++)
            {
                variants.Add(new Bitmap(tasks[currentTaskNumber].Width, tasks[currentTaskNumber].Height));
            }

            pictureBox1.Image = tasks[0];
        }

        private void TestingForm_Load(object sender, EventArgs e)
        {
            LoadTasks();
            // Helpers.CompareImages(pictureBox1.Image, pictureBox2.Image);

            pictureBox2.Width   = pictureBox1.Width;
            pictureBox2.Height  = pictureBox1.Height;
            pictureBox2.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //pictureBox2.Visible = false;
            UpdateFormState();
        }

        private void UpdateFormState ()
        {
            UpdateLabelState();
            UpdateButtonsState();
            pictureBox1.Image = tasks[currentTaskNumber];
            pictureBox1.Width = tasks[currentTaskNumber].Width;
            pictureBox1.Height = tasks[currentTaskNumber].Height;
            pictureBox2.Image = variants[currentTaskNumber];
            pictureBox3.Image = answers[currentTaskNumber];
        }

        private void UpdateLabelState ()
        {
            counterLbl.Text = currentTaskNumber + 1 + "/" + tasksNumber;
        }

        private void UpdateButtonsState()
        {
            btnNextTask.Enabled = true;
            btnPrevTask.Enabled = true;

            if (currentTaskNumber == tasksNumber-1)
            {
                btnNextTask.Enabled = false;
                btnFinish.Visible = true;
                return;
            }

            if (currentTaskNumber == 0)
            {
                btnPrevTask.Enabled = false;
                return;
            }

        }
        private List<Image> DataTableColumnToImageList(DataTable dt, string columnName, int maxWidth)
        {
            List<Image> list = new List<Image>();

            foreach (DataRow dr in dt.Rows)
            {
                var value = dr[columnName];
                
                if (value is System.DBNull)
                {
                    list.Add(null);
                    continue;
                }
                byte[] data = (byte[])(dr[columnName]);
                MemoryStream ms = new MemoryStream(data);
                Image img = Image.FromStream(ms);
                img = Helpers.AdjustImage(img, maxWidth);
                list.Add(img);
            }

            return list;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            int[] tasksResults = new int[tasksNumber];

            for (int i = 0; i < tasksNumber; i++)
            {
                tasksResults[i] = (int)Math.Round(Helpers.CompareImages(variants[i], answers[i]) * 100);
            }

            int avg = (int)Math.Round((double)tasksResults.Sum() / tasksResults.Length);

            int mark;
            if (avg > 80) mark = 5;
            else if (avg > 60) mark = 4;
            else if (avg > 40) mark = 3;
            else mark = 2;

            DB.ExecuteCmd($"INSERT INTO test_completions (test_id, student_id, accuracy, mark) VALUES ({testID}, {studentID}, {avg}, {mark})");

            MessageBox.Show("Ваша точность: " + avg + "%", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void btnPrevTask_Click(object sender, EventArgs e)
        {
            currentTaskNumber--;

            UpdateFormState();
        }

        private void btnNextTask_Click(object sender, EventArgs e)
        {
            currentTaskNumber++;
            UpdateFormState();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = cleanImgs[currentTaskNumber];
            pictureBox2.Image = null;
            variants[currentTaskNumber] = null;
        }

        #region drawing
        GraphicsPath panelPath = new GraphicsPath();
        Graphics g, g2;
        List<Point> path = new List<Point>();
        bool hasMarks = false;

        Point lastPoint = Point.Empty;//Point.Empty represents null for a Point object

        bool isMouseDown = new Boolean();//this is used to evaluate whether our mousebutton is down or not



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)

        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = e.Location;//we assign the lastPoint to the current mouse position: e.Location ('e' is from the MouseEventArgs passed into the MouseDown event)

                isMouseDown = true;//we set to true because our mouse button is down (clicked)
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)

        {

            if (isMouseDown)//check to see if the mouse button is down

            {

                if (lastPoint != null)//if our last point is not null, which in this case we have assigned above

                {

                    if (pictureBox1.Image == null)//if no available bitmap exists on the picturebox to draw on
                        return;

                    g  = Graphics.FromImage(pictureBox1.Image);
                    g2 = Graphics.FromImage(pictureBox2.Image);

                    //we need to create a Graphics object to draw on the picture box, its our main tool

                    //when making a Pen object, you can just give it color only or give it color and pen size
                    path.Add(e.Location);
                    g.DrawLine(new Pen(Color.Red, 2), lastPoint, e.Location);
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    //this is to give the drawing a more smoother, less sharper look

                    pictureBox1.Invalidate();//refreshes the picturebox

                    lastPoint = e.Location;//keep assigning the lastPoint to the current mouse position

                }

            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;

            lastPoint = Point.Empty;

            if (path.Count == 0)
                return;

            panelPath.AddCurve(path.ToArray<Point>());
            path.Clear();

            g.FillPath(Brushes.Red, panelPath);
            g.DrawPath(Pens.Red, panelPath);
            g2.FillPath(Brushes.Red, panelPath);
            g2.DrawPath(Pens.Red, panelPath);
            panelPath = new GraphicsPath();
            pictureBox1.Invalidate();
            pictureBox2.Invalidate();

            variants[currentTaskNumber] = pictureBox2.Image;

            hasMarks = true;
        }

        #endregion

    }
}
