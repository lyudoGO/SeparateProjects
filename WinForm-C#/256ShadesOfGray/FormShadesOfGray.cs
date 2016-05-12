using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace _256ShadesOfGray
{
    public partial class FormShadesOfGray : Form
    {
        Bitmap bmp;
        string labelTextBrightness;
        string labelTextContrast;

        public FormShadesOfGray()
        {
            InitializeComponent();
            labelTextBrightness = labelBrightness.Text;
            labelTextContrast = labelContrast.Text;
            ChangeLabelsText();
        }

        private void buttonChangePicter_Click(object sender, EventArgs e)
        {
            ChangePicter();
        }

        private void buttonOpenPicter_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            DialogResult result =  openFileDialog.ShowDialog();
            LoadPicter(openFileDialog.FileName);
        }


        private void buttonSavePicter_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog.ShowDialog();
            SavePicter(saveFileDialog.FileName);
        }

        private void LoadPicter(string fileName)
        {
            try
            {
                if (fileName != string.Empty)
                {
                    bmp = new Bitmap(Image.FromFile(fileName));
                    textBoxPicter.Text = fileName;
                    pictureBox.Image = bmp;        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SavePicter(string fileName)
        {
            try
            {
                if (pictureBox.Image != null)
                {
                    Bitmap newBmp = new Bitmap(pictureBox.Image);
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            newBmp.Save(fileName, ImageFormat.Jpeg);
                            break;
                        case 2:
                            newBmp.Save(fileName, ImageFormat.Bmp);
                            break;
                        case 3:
                            newBmp.Save(fileName, ImageFormat.Gif);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangePicter()
        {
            Bitmap resultBmp = new Bitmap(bmp);
            bool isGray = checkBoxGrayScale.Checked;
            int brightness = trackBarBrigthness.Value; 
            int contrast = trackBarContrast.Value;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    if (isGray)
                    {
                        pixel = ChangeGrayScale(pixel);
                    }
                    if (brightness != 0)
                    {
                        pixel = ChangeBrightness(pixel, brightness);
                    }
                    if (contrast != 0)
                    {
                        pixel = ChangeContrast(pixel, contrast);
                    }
                    resultBmp.SetPixel(x, y, pixel);
                }
            }
            pictureBox.Image = resultBmp;
        }

        private Color ChangeContrast(Color pixel, int contrastValue)
        {
            float procent = contrastValue / 100f;
            return Color.FromArgb(
                ChangePixelContrast(pixel.R, procent),
                ChangePixelContrast(pixel.G, procent),
                ChangePixelContrast(pixel.B, procent)
                );
        }

        private int ChangePixelContrast(byte pixelValue, float procent)
        {
            int result;
            if (procent < 0)
            {
                result = (int)(pixelValue + procent * (pixelValue - 128));
            }
            else
            {
                result = (int)(128 + (pixelValue - 126) / (1 - procent));
            }
            if (result > 255)
            {
                result = 255;
            }
            if (result < 0)
            {
                result = 0;
            }
            return result;
        }

        private Color ChangeBrightness(Color pixel, int brightnessValue)
        {
            float procent = brightnessValue / 100f;
            return Color.FromArgb(
                ChangePixelBrightness(pixel.R, procent),
                ChangePixelBrightness(pixel.G, procent),
                ChangePixelBrightness(pixel.B, procent)
                );
        }

        private int ChangePixelBrightness(byte pixelValue, float procent)
        {
            int result = (int)(pixelValue + (procent * 128));
            if (result > 255)
            {
                result = 255;
            }
            if (result < 0)
            {
                result = 0;
            }
            return result;
        }

        private Color ChangeGrayScale(Color pixel)
        {
            int avg = (pixel.R + pixel.G + pixel.B + 1) / 3;
            return Color.FromArgb(avg, avg, avg);
        }

        private void trackBarBrigthness_ValueChanged(object sender, EventArgs e)
        {
            
            ChangeLabelsText();
        }

        private void ChangeLabelsText()
        {
            labelBrightness.Text = string.Format("{0} {1} %", labelTextBrightness, trackBarBrigthness.Value);
            labelContrast.Text = string.Format("{0} {1} %", labelTextContrast, trackBarContrast.Value);
        }

        private void trackBarContrast_ValueChanged(object sender, EventArgs e)
        {
            ChangeLabelsText();
        }
    }
}