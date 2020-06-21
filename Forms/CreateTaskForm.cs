using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using dbApp.Utils;

namespace dbApp
{
    public partial class CreateTaskForm : Form
    {
        public readonly int IMG_FIXED_WIDTH = 300;

        bool hasMarks = false;

        public CreateTaskForm()
        {
            InitializeComponent();
        }

        Image cleanImg = null;

        private void openBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);

                int newHeight =  (int)((double)IMG_FIXED_WIDTH / img.Width * img.Height);
                img = Helpers.ResizeImage(img, IMG_FIXED_WIDTH, newHeight);

                pictureBox1.Image = (Image)img.Clone();
                cleanImg = (Image)img.Clone();
                pictureBox1.Width = pictureBox1.Image.Width;

                pictureBox2.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }
        }

        byte[] imageToByteArray(Image img)
        {
            var converter = new ImageConverter();
            byte[] arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            return arr;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var taskByteArray   = imageToByteArray(cleanImg);
            var answerByteArray = imageToByteArray(pictureBox2.Image);

            pictureBox1.Image = new Bitmap(300, 300);

            SqlConnection connection = new SqlConnection(
                ConfigurationManager.ConnectionStrings[2].ConnectionString
            );
            SqlCommand cmd = new SqlCommand("INSERT INTO tasks (picture, answer) values (@picture, @answer)", connection);

            cmd.Parameters.Add(new SqlParameter("@picture", taskByteArray));
            cmd.Parameters.Add(new SqlParameter("@answer",  hasMarks ? answerByteArray : null));

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }

            UpdateDataGridView();
            MessageBox.Show("Задание успешно добавлено!");

        }

        void UpdateDataGridView()
        {
            SqlConnection connection = new SqlConnection(
                           ConfigurationManager.ConnectionStrings["WindowsFormsApp2.Properties.Settings.dbx"].ConnectionString
            );
            SqlCommand cmd = new SqlCommand("SELECT * FROM tasks", connection);

            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
            }
            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }
            
        }

        private void CreateTaskForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        #region drawing
        GraphicsPath panelPath = new GraphicsPath();
        Graphics g, g2;
        List<Point> path = new List<Point>();

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

        private void clearButton_Click(object sender, EventArgs e)//our clearing button
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
                Invalidate();
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

                    g = Graphics.FromImage(pictureBox1.Image);
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

            hasMarks = true;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)cleanImg.Clone();
            pictureBox1.Invalidate();
            pictureBox2.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox2.Invalidate();
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
           


        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string idList = "";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();

                idList += id + ", ";
            }

            if (idList.Length == 0)
                return;

            idList = idList.Substring(0, idList.Length - 2);


            SqlConnection connection = new SqlConnection(
                ConfigurationManager.ConnectionStrings[2].ConnectionString
            );
            var cmd = new SqlCommand("DELETE FROM tasks WHERE id IN (" + idList + ")", connection);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
            }

            UpdateDataGridView();
            MessageBox.Show("Задания успешно удалены!");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
