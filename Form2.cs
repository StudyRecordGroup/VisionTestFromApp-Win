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
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Form2 : UserControl
    {
        string imagePath { get; set; }
        ShowProgressImage m_showProgressImage = new ShowProgressImage();
        bool isCalibrating = false;
        int H_Low { get; set; } = 100;
        int H_High { get; set; } = 140;
        int S_Low { get; set; } = 90;
        int S_High { get; set; } = 255;
        int V_Low { get; set; } = 90;
        int V_High { get; set; } = 255;

        public Form2(CancellationToken cancelByUser)
        {
            InitializeComponent();

            trackBar_H_Low.ValueChanged += TrackBar_ValueChanged;
            trackBar_H_High.ValueChanged += TrackBar_ValueChanged;
            trackBar_S_Low.ValueChanged += TrackBar_ValueChanged;
            trackBar_S_High.ValueChanged += TrackBar_ValueChanged;
            trackBar_V_Low.ValueChanged += TrackBar_ValueChanged;
            trackBar_V_High.ValueChanged += TrackBar_ValueChanged;

            label_H_Low.DataBindings.Add("Text", trackBar_H_Low, "Value");
            label_H_High.DataBindings.Add("Text", trackBar_H_High, "Value");
            label_S_Low.DataBindings.Add("Text", trackBar_S_Low, "Value");
            label_S_High.DataBindings.Add("Text", trackBar_S_High, "Value");
            label_V_Low.DataBindings.Add("Text", trackBar_V_Low, "Value");
            label_V_High.DataBindings.Add("Text", trackBar_V_High, "Value");

            pictureBox_Source.DataBindings.Add("Image", m_showProgressImage, "Image_Progress_Source", true);
            pictureBox_Result.DataBindings.Add("Image", m_showProgressImage, "Image_Progress_Result", true);

            timer_UI.Start();
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            H_Low = trackBar_H_Low.Value;
            H_High = trackBar_H_High.Value;
            S_Low = trackBar_S_Low.Value;
            S_High = trackBar_S_High.Value;
            V_Low = trackBar_V_Low.Value;
            V_High = trackBar_V_High.Value;
        }

        private void button_OpenPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            imagePath = openFileDialog.FileName;
            m_showProgressImage.SrcImg = new Mat(imagePath, ImreadModes.Color);
            m_showProgressImage.Image_Progress_Source = BitmapConverter.ToBitmap(m_showProgressImage.SrcImg);
        }

        private void imageProcess_Canny()
        {
            Cv2.Canny(m_showProgressImage.SrcImg, m_showProgressImage.DstImg, 50, 200);
            m_showProgressImage.Image_Progress_Result = BitmapConverter.ToBitmap(m_showProgressImage.DstImg);
        }

        private void imageProcess_Color()
        {
            Cv2.CvtColor(m_showProgressImage.SrcImg, m_showProgressImage.DstImg, ColorConversionCodes.RGB2HSV);
            Mat imgThresholded = new Mat();

            Cv2.InRange(m_showProgressImage.DstImg, new Scalar(H_Low, S_Low, V_Low), new Scalar(H_High, S_High, V_High), imgThresholded);
            m_showProgressImage.DstImg = new Mat(m_showProgressImage.DstImg.Size(), m_showProgressImage.DstImg.Type());
            for (int r = 0; r < m_showProgressImage.DstImg.Rows; r++)
            {
                for (int c = 0; c < m_showProgressImage.DstImg.Cols; c++)
                {
                    if (imgThresholded.At<byte>(r, c) == 255)
                    {
                        Vec3b vec3B = m_showProgressImage.DstImg.At<Vec3b>(r, c);
                        if (vec3B.Item0 == 0 && vec3B.Item1 == 0 && vec3B.Item2 == 0)
                        {
                            vec3B.Item0 = 255;
                            vec3B.Item1 = 255;
                            vec3B.Item2 = 255;
                        }
                        m_showProgressImage.DstImg.Set<Vec3b>(r, c, vec3B);
                    }
                }
            }

            m_showProgressImage.Image_Progress_Result = BitmapConverter.ToBitmap(m_showProgressImage.DstImg);
        }

        private void button_Progress_Canny_Click(object sender, EventArgs e)
        {
            imageProcess_Canny();
        }

        private void button_Calibrate_Click(object sender, EventArgs e)
        {
            isCalibrating = !isCalibrating;
            imageProgressTask();
        }

        private Task imageProgressTask()
        {
            return Task.Run(() =>
            {
                while (isCalibrating)
                {
                    imageProcess_Color();
                }
            });
        }
        private void foolproof_UI()
        {
            button_Progress_Canny.Enabled = m_showProgressImage.Image_Progress_Source != null & !isCalibrating;
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
        public Mat SrcImg { get; set; } = new Mat();
        public Mat DstImg { get; set; } = new Mat();

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
