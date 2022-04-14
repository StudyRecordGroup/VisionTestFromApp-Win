using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace WindowsFormsApp1
{
    public partial class Form2 : UserControl
    {
        Bitmap bitmapImage_Source { get; set; }
        Bitmap bitmapImage_Result { get; set; }
        string imagePath { get; set; }

        public Form2(CancellationToken cancelByUser)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            pictureBox_Source.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Result.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button_OpenPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            imagePath = openFileDialog.FileName;
            //imageProcess();
            test();
        }

        private void imageProcess()
        {
            Mat srcImg = new Mat(imagePath, ImreadModes.Color);
            bitmapImage_Source = BitmapConverter.ToBitmap(srcImg);
            pictureBox_Source.Image = bitmapImage_Source;
            Mat dstImg = new Mat();
            Cv2.Canny(srcImg, dstImg, 50, 200);  // 
            bitmapImage_Result = BitmapConverter.ToBitmap(dstImg);
            pictureBox_Result.Image = bitmapImage_Result;
        }

        private void test()
        {
            Mat srcImg = new Mat(imagePath, ImreadModes.Color);
            bitmapImage_Source = BitmapConverter.ToBitmap(srcImg);
            pictureBox_Source.Image = bitmapImage_Source;
            Mat dstImg = new Mat();
            Cv2.CvtColor(srcImg, dstImg, ColorConversionCodes.RGB2HSV);
            Mat imgThresholded = new Mat();


            int iLowH = 0;
            int iHighH = 100;

            int iLowS = 90;
            int iHighS = 255;

            int iLowV = 90;
            int iHighV = 255;

            Cv2.InRange(dstImg, new Scalar(iLowH, iLowS, iLowV), new Scalar(iHighH, iHighS, iHighV), imgThresholded);
            dstImg = new Mat(dstImg.Size(), dstImg.Type());
            for (int r = 0; r < dstImg.Rows; r++)
            {
                for (int c = 0; c < dstImg.Cols; c++)
                {
                    if (imgThresholded.At<byte>(r, c) == 255)
                    {
                        Vec3b vec3B = dstImg.At<Vec3b>(r, c);
                        if (vec3B.Item0 == 0 && vec3B.Item1 == 0 && vec3B.Item2 == 0)
                        {
                            vec3B.Item0 = 255;
                            vec3B.Item1 = 255;
                            vec3B.Item2 = 255;
                        }
                        dstImg.Set<Vec3b>(r, c, vec3B);
                    }
                }
            }

            bitmapImage_Result = BitmapConverter.ToBitmap(dstImg);
            pictureBox_Result.Image = bitmapImage_Result;

        }
    }
}
