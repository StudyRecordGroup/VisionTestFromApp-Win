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
        Image bitmapImage_Source { get; set; }
        Image bitmapImage_Result { get; set; }
        string imagePath { get; set; }
        int H_Low { get; set; }
        int H_High { get; set; }
        int S_Low { get; set; }
        int S_High { get; set; }
        int V_Low { get; set; }
        int V_High { get; set; }

        public Form2(CancellationToken cancelByUser)
        {
            InitializeComponent();
            button_OpenPhoto.Click += button_OpenPhoto_Click;
            trackBar_H_Low.ValueChanged += TrackBar_ValueChanged;
            trackBar_H_High.ValueChanged += TrackBar_ValueChanged;
            trackBar_S_Low.ValueChanged += TrackBar_ValueChanged;
            trackBar_S_High.ValueChanged += TrackBar_ValueChanged;
            trackBar_V_Low.ValueChanged += TrackBar_ValueChanged;
            trackBar_V_High.ValueChanged += TrackBar_ValueChanged;
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            H_Low = trackBar_H_Low.Value;
            H_High = trackBar_H_High.Value;
            S_Low = trackBar_S_Low.Value;
            S_High = trackBar_S_High.Value;
            V_Low = trackBar_V_Low.Value;
            V_High = trackBar_V_High.Value;

            label_H_Low.Text = H_Low.ToString();
            label_H_High.Text = H_High.ToString();
            label_S_Low.Text = S_Low.ToString();
            label_S_High.Text = S_High.ToString();
            label_V_Low.Text = V_Low.ToString();
            label_V_High.Text = V_High.ToString();
        }

        private void button_OpenPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            imagePath = openFileDialog.FileName;
            Mat srcImg = new Mat(imagePath, ImreadModes.Color);
            bitmapImage_Source = BitmapConverter.ToBitmap(srcImg);
            pictureBox_Source.Image = bitmapImage_Source;
        }

        private void imageProcess_Canny()
        {
            Mat srcImg = new Mat(imagePath, ImreadModes.Color);
            bitmapImage_Source = BitmapConverter.ToBitmap(srcImg);
            Mat dstImg = new Mat();
            Cv2.Canny(srcImg, dstImg, 50, 200);  // 
            bitmapImage_Result = BitmapConverter.ToBitmap(dstImg);
            pictureBox_Result.Image = bitmapImage_Result;
        }

        private void imageProcess_Color()
        {
            Mat srcImg = new Mat(imagePath, ImreadModes.Color);
            bitmapImage_Source = BitmapConverter.ToBitmap(srcImg);
            Mat dstImg = new Mat();
            Cv2.CvtColor(srcImg, dstImg, ColorConversionCodes.RGB2HSV);
            Mat imgThresholded = new Mat();

            Cv2.InRange(dstImg, new Scalar(H_Low, S_Low, V_Low), new Scalar(H_High, S_High, V_High), imgThresholded);
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

        private void button_ProgressPic_Click(object sender, EventArgs e)
        {
            //imageProcess();
            imageProcess_Color();
        }
    }
}
