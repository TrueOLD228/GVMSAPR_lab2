using System;
using System.Drawing;
using System.Windows.Forms;

namespace GVMSAPR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private Bitmap bitmap;
        private Bitmap contrastBitmap;

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файлы изображений| *.bmp; *.png;* .jpg; |Все файлы|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                bitmap = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
                saveFileDialog1.FileName = openFileDialog1.FileName;
                pictureBox1.Image = bitmap;
                labelY.Text = "Y=" + bitmap.Size.Width;
                labelX.Text = "X=" + bitmap.Size.Height;

            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }
        }

        private void buttonRotateLeft_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Image = bitmap;
            }


        }

        private void buttonRotateRight_Click(object sender, EventArgs e)
        {
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = bitmap;
        }

        private void ReflectX_Click(object sender, EventArgs e)
        {
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = bitmap;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = bitmap;
        }

        private void buttonDecrease_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(bitmap, bitmap.Size.Width / 3 * 2, bitmap.Size.Height / 3 * 2);
                pictureBox1.Image = bitmap;
                labelY.Text = "Y=" + bitmap.Size.Width;
                labelX.Text = "X=" + bitmap.Size.Height;
            }
            catch
            {

            }
        }

        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            if (bitmap.Size.Width < 5000 && bitmap.Size.Height < 5000)
            {
                try
                {
                    bitmap = new Bitmap(bitmap, bitmap.Size.Width * 3 / 2, bitmap.Size.Height * 3 / 2);
                    pictureBox1.Image = bitmap;
                    labelY.Text = "Y=" + bitmap.Size.Width;
                    labelX.Text = "X=" + bitmap.Size.Height;
                }
                catch
                {

                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var bitmapSave = bitmap;
                bitmapSave.Save(saveFileDialog1.FileName);
            }
            catch (Exception NullReferenceException)
            {

            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Файлы изображений| *.bmp; *.png;* .jpg; |Все файлы|*.*";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            bitmap.Save(saveFileDialog1.FileName);
        }

        private void buttonInvert_Click(object sender, EventArgs e)
        {
            for (int Y = 0; Y < bitmap.Height; Y++)
            {
                for (int X = 0; X < bitmap.Width; X++)
                {
                    Color oldColor = bitmap.GetPixel(X, Y);
                    Color newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                    bitmap.SetPixel(X, Y, newColor);
                    pictureBox1.Image = bitmap;
                }
            }
        }

        private void buttonContrast_Click(object sender, EventArgs e)
        {
            float contrastTemp = 0;
            try
            {
                contrastTemp = Convert.ToInt16(textBox1.Text);
            }
            catch (Exception)
            {

            }
            if (contrastTemp > 100 || contrastTemp < -100)
            {
                return;
            }
            float contrast = 1 + (contrastTemp / 200);
            for (int Y = 0; Y < bitmap.Height; Y++)
            {
                for (int X = 0; X < bitmap.Width; X++)
                {
                    Color oldColor = bitmap.GetPixel(X, Y);
                    byte newRed;
                    byte newGreen;
                    byte newBlue;
                    if (oldColor.R * contrast > 255)
                    {
                        newRed = Convert.ToByte(255);
                    }
                    else if (oldColor.R * contrast < 0)
                    {
                        newRed = Convert.ToByte(0);
                    }
                    else
                    {
                        newRed = Convert.ToByte(oldColor.R * contrast);
                    }

                    if (oldColor.G * contrast > 255)
                    {
                        newGreen = Convert.ToByte(255);
                    }
                    else if (oldColor.G * contrast < 0)
                    {
                        newGreen = Convert.ToByte(0);
                    }
                    else
                    {
                        newGreen = Convert.ToByte(oldColor.G * contrast);
                    }

                    if (oldColor.B * contrast > 255)
                    {
                        newBlue = Convert.ToByte(255);
                    }
                    else if (oldColor.B * contrast < 0)
                    {
                        newBlue = Convert.ToByte(0);
                    }
                    else
                    {
                        newBlue = Convert.ToByte(oldColor.B * contrast);
                    }

                    Color newColor = Color.FromArgb(oldColor.A, newRed, newGreen, newBlue);
                    bitmap.SetPixel(X, Y, newColor);
                }
            }

            pictureBox1.Image = bitmap;
        }

        public static Bitmap sharpen(Bitmap image, int power)
        {
            Bitmap sharpenImage = new Bitmap(image.Width, image.Height);
            int filterWidth = power;
            int filterHeight = power;
            int w = image.Width;
            int h = image.Height;
            double[,] filter = new double[filterWidth, filterHeight];
            filter[0, 0] = filter[0, 1] = filter[0, 2] = filter[1, 0] = filter[1, 2] = filter[2, 0] = filter[2, 1] = filter[2, 2] = -1; filter[1, 1] = 9;
            double factor = 1.0;
            double bias = 0.0;
            Color[,] result = new Color[image.Width, image.Height];
            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    double red = 0.0, green = 0.0, blue = 0.0;
                    for (int filterX = 0; filterX < filterWidth; filterX++)
                    {
                        for (int filterY = 0; filterY < filterHeight; filterY++)
                        {
                            int imageX = (x - filterWidth / 2 + filterX + w) % w;
                            int imageY = (y - filterHeight / 2 + filterY + h) % h;
                            Color imageColor = image.GetPixel(imageX, imageY);
                            red += imageColor.R * filter[filterX, filterY];
                            green += imageColor.G * filter[filterX, filterY];
                            blue += imageColor.B * filter[filterX, filterY];
                        }
                        int r = Math.Min(Math.Max((int)(factor * red + bias), 0), 255);
                        int g = Math.Min(Math.Max((int)(factor * green + bias), 0), 255);
                        int b = Math.Min(Math.Max((int)(factor * blue + bias), 0), 255);
                        result[x, y] = Color.FromArgb(r, g, b);
                    }
                }
            }
            for (int i = 0; i < w; ++i)
            {
                for (int j = 0; j < h; ++j)
                {
                    sharpenImage.SetPixel(i, j, result[i, j]);
                }
            }
            return sharpenImage;
        }

        private void Sharpen_click(object sender, EventArgs e)
        {
           bitmap = sharpen(bitmap,5);
           pictureBox1.Image = bitmap;
        }
    }
}
