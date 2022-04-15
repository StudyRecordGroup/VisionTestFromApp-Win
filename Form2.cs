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
        string imagePath { get; set; }
        ShowProgressImage m_showProgressImage = new ShowProgressImage();
        bool isCalibrating = false;

        public Form2(CancellationToken cancelByUser)
        {
            InitializeComponent();

            initialCalibratePanel();
            pictureBox_Source.DataBindings.Add("Image", m_showProgressImage, "Image_Progress_Source", true);
            pictureBox_Result.DataBindings.Add("Image", m_showProgressImage, "Image_Progress_Result", true);

            timer_UI.Start();
        }

        private void initialCalibratePanel()
        {
            trackBar_H_Low.ValueChanged += TrackBar_ValueChanged;
            trackBar_H_High.ValueChanged += TrackBar_ValueChanged;
            trackBar_S_Low.ValueChanged += TrackBar_ValueChanged;
            trackBar_S_High.ValueChanged += TrackBar_ValueChanged;
            trackBar_V_Low.ValueChanged += TrackBar_ValueChanged;
            trackBar_V_High.ValueChanged += TrackBar_ValueChanged;
            label_H_Low.Text = trackBar_H_Low.Value.ToString();
            label_H_High.Text = trackBar_H_High.Value.ToString();
            label_S_Low.Text = trackBar_S_Low.Value.ToString();
            label_S_High.Text = trackBar_S_High.Value.ToString();
            label_V_Low.Text = trackBar_V_Low.Value.ToString();
            label_V_High.Text = trackBar_V_High.Value.ToString();
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            label_H_Low.Text = trackBar_H_Low.Value.ToString();
            label_H_High.Text = trackBar_H_High.Value.ToString();
            label_S_Low.Text = trackBar_S_Low.Value.ToString();
            label_S_High.Text = trackBar_S_High.Value.ToString();
            label_V_Low.Text = trackBar_V_Low.Value.ToString();
            label_V_High.Text = trackBar_V_High.Value.ToString();
            if (isCalibrating)
                imageProcess_Color();
        }

        private void button_OpenPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            imagePath = openFileDialog.FileName;
            Mat srcImg = new Mat(imagePath, ImreadModes.Color);
            m_showProgressImage.Image_Progress_Source = BitmapConverter.ToBitmap(srcImg);
        }

        private void imageProcess_Canny()
        {
            Mat srcImg = new Mat(imagePath, ImreadModes.Color);
            m_showProgressImage.Image_Progress_Source = BitmapConverter.ToBitmap(srcImg);
            Mat dstImg = new Mat();
            Cv2.Canny(srcImg, dstImg, 50, 200);  // 
            m_showProgressImage.Image_Progress_Result = BitmapConverter.ToBitmap(dstImg);
        }

        private void imageProcess_Color()
        {
            Mat srcImg = new Mat(imagePath, ImreadModes.Color);
            m_showProgressImage.Image_Progress_Source = BitmapConverter.ToBitmap(srcImg);
            Mat dstImg = new Mat();
            Cv2.CvtColor(srcImg, dstImg, ColorConversionCodes.RGB2HSV);
            Mat imgThresholded = new Mat();

            Cv2.InRange(dstImg, new Scalar(trackBar_H_Low.Value, trackBar_S_Low.Value, trackBar_V_Low.Value), new Scalar(trackBar_H_High.Value, trackBar_S_High.Value, trackBar_V_High.Value), imgThresholded);
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

            m_showProgressImage.Image_Progress_Result = BitmapConverter.ToBitmap(dstImg);
        }

        private void button_Progress_Canny_Click_1(object sender, EventArgs e)
        {
            imageProcess_Canny();
        }

        private void button_Calibrate_Click(object sender, EventArgs e)
        {
            isCalibrating = !isCalibrating;
            if (isCalibrating)
                imageProcess_Color();
        }

        private void foolproof_UI()
        {
            button_Progress_Canny.Enabled = m_showProgressImage.Image_Progress_Source != null;
            button_Calibrate.Enabled = m_showProgressImage.Image_Progress_Source != null;
            tableLayoutPanel_Calibrate.Enabled = isCalibrating;
            button_Calibrate.Text = isCalibrating ? "Stop Calibrate" : "Start Calibrate";
        }

        private void timer_UI_Tick(object sender, EventArgs e)
        {
            foolproof_UI();
        }
    }

    public class ShowProgressImage : INotifyPropertyChanged
    {
        
        private Image image_Progress_Source;
        private Image image_Progress_Result;

        public Image Image_Progress_Source
        {
            get { return image_Progress_Source; }
            set { image_Progress_Source = value; InvokePropertyChanged(new PropertyChangedEventArgs("Image_Progress_Source")); }
        }
        public Image Image_Progress_Result
        {
            get { return image_Progress_Result; }
            set { image_Progress_Result = value; InvokePropertyChanged(new PropertyChangedEventArgs("Image_Progress_Result")); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }
    }
}
