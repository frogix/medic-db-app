using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbApp.Utils
{
    public static class Helpers
    {
        /// <summary>
        /// Функция сравнения двух избражений
        /// </summary>
        /// <param name="img1">Изображение 1</param>
        /// <param name="img2">Изображение 2</param>
        /// <returns>Число от 0 до 1 - соотношение совпадений к общему числу сравнений</returns>
        public static double CompareImages (Image img1, Image img2)
        {
            if (img1 == null ^ img2 == null) return 0; // XOR

            if (img1 == null && img2 == null) return 1;

            Color bgColor = (new Bitmap(1, 1)).GetPixel(0, 0);

            const int COMPARE_WIDTH = 100;

            Image resized1 = AdjustImage(img1, COMPARE_WIDTH);
            Image resized2 = AdjustImage(img2, COMPARE_WIDTH);

            Bitmap bmp1 = new Bitmap(resized1);
            Bitmap bmp2 = new Bitmap(resized2);

            int totalComparisons = 0;
            int validComparisons = 0;

            int compareHeight = Math.Min(bmp1.Height, bmp2.Height);

            for (int i = 0; i < COMPARE_WIDTH; i++)
            {
                for (int j = 0; j < compareHeight; j++)
                {

                    Color c1, c2;

                    c1 = bmp1.GetPixel(i, j);
                    c2 = bmp2.GetPixel(i, j);

                    if (c1 == bgColor)
                    {
                        if (c2 != c1) totalComparisons++;
                        continue;
                    }
                    else
                    {
                        if (c1 == c2) validComparisons++;

                        totalComparisons++;

                        continue;
                    }
                }
            }

            if (totalComparisons == 0) throw new ArgumentException("Были переданы некорректные изображения для сравнения");

            double validPercentage = (double)validComparisons / totalComparisons;

            return validPercentage;
        }

        public static void FillCombobox (DataTable dataTable, string fieldName, ComboBox comboBox)
        {
            comboBox.Items.Clear();
           foreach (DataRow dr in dataTable.Rows)
            {
                comboBox.Items.Add(dr[fieldName]).ToString();
            } 
        }

        public static string GetSelectedValuesCSV(DataGridView dgv, int col)
        {
            string idList = "";

            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                string id = row.Cells[col].Value.ToString();

                idList += id + ", ";
            }

            if (idList.Length == 0)
                return "";

            return idList.Substring(0, idList.Length - 2);
        }

        /// <summary>
        /// Adjusts image size to the specified width keeping the ratio
        /// </summary>
        /// <param name="image">The image to resize</param>
        /// <param name="newWidth">The new width</param>
        /// <returns>The resized image</returns>
        public static Image AdjustImage (Image image, int newWidth)
        {
            int newHeight = (int)((double)newWidth / image.Width * image.Height);
            return ResizeImage(image, newWidth, newHeight);
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
