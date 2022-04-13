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
            imageProcess();
        }

        private void imageProcess()
        {
            Mat srcImg = new Mat(imagePath, ImreadModes.Color);
            bitmapImage_Source = BitmapConverter.ToBitmap(srcImg);
            pictureBox_Source.Image = bitmapImage_Source;
            //Cv2.ImShow("input", srcImg);
            Mat dstImg = new Mat();
            Cv2.Canny(srcImg, dstImg, 50, 200);
            bitmapImage_Result = BitmapConverter.ToBitmap(dstImg);
            pictureBox_Result.Image = bitmapImage_Result;
            //Cv2.ImShow("output", dstImg);
        }
    }
}
