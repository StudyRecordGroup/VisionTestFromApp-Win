using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Threading;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace WindowsFormsApp1
{
    public partial class Form1 : UserControl
    {
        #region // AForce
        FilterInfoCollection AForge_filterInfoCollection { get; set; }
        VideoCaptureDevice AForge_videoCaptureDevice { get; set; }
        #endregion

        #region // OpenCVsharp
        VideoCapture OpenCV_videoCapture { get; set; }
        #endregion

        int m_Cam_index { get; set; } = -1;
        ShowImage m_showImage = new ShowImage();
        Task m_videoTask;

        public Form1(CancellationToken cancelByUser)
        {
            InitializeComponent();

            AForge_filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in AForge_filterInfoCollection)
            {
                combobox_CamList.Items.Add(filterInfo.Name);
            }
            if (combobox_CamList.Items.Count > 0)
            {
                combobox_CamList.SelectedIndex = 0;
                m_Cam_index = 0;
            }
            cancelByUser.Register(() => finalDo());
            timer_UI.Start();

            pictureBox_Cam.DataBindings.Add("Image", m_showImage, "Image_Camera", true);
            pictureBox_Pic.DataBindings.Add("Image", m_showImage, "Image_GrabPic", true);
        }

        private void finalDo()
        {
            m_videoTask = null;
            if (AForge_videoCaptureDevice != null)
                if (AForge_videoCaptureDevice.IsRunning)
                {
                    AForge_videoCaptureDevice?.Stop();
                    AForge_videoCaptureDevice = null;
                }
            if (OpenCV_videoCapture != null)
                if (OpenCV_videoCapture.IsOpened())
                {
                    OpenCV_videoCapture.Release();
                    OpenCV_videoCapture = null;
                }
            m_showImage.Image_Camera = null;
        }

        private void combobox_CamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int camsel = combobox_CamList.SelectedIndex;
            m_Cam_index = camsel;
        }

        private void button_Start_AForge_Click(object sender, EventArgs e)
        {
            AForge_videoCaptureDevice = new VideoCaptureDevice(AForge_filterInfoCollection[combobox_CamList.SelectedIndex].MonikerString);
            AForge_videoCaptureDevice.Start();
            m_videoTask = new Task(VideoAForge);
            m_videoTask.Start();
        }

        void VideoAForge()
        {
            AForge_videoCaptureDevice.NewFrame += (s, eventArgs) =>
            {
                m_showImage.Image_Camera = (Bitmap)eventArgs.Frame.Clone();
            };
        }

        private void button_Start_CV_Click(object sender, EventArgs e)
        {
            OpenCV_videoCapture = new VideoCapture();
            OpenCV_videoCapture.Open(combobox_CamList.Items.Count -1 - m_Cam_index); // becaues OpenCV camera's index is reverse of AForce FilterInfoCollection
            m_videoTask = new Task(videoOpenCV);
            m_videoTask.Start();
        }

        void videoOpenCV()
        {
            while (m_videoTask!=null)
            {
                Mat cFram = new Mat();
                OpenCV_videoCapture.Read(cFram);
                if (cFram.Empty()) continue;
                m_showImage.Image_Camera = cFram.ToBitmap();
                //if(m_worderIsWorking) // this if is avoid the m_worker cancel but it still read a black fram ,and set to the picturebox
                //    pictureBox_Cam.Image = image_Camera;
                cFram.Release();
            }
        }
        private void button_Close_AForge_Click(object sender, EventArgs e)
        {
            finalDo();
        }

        private void button_Close_CV_Click(object sender, EventArgs e)
        {
            finalDo();
        }

        private void button_Grab_Click(object sender, EventArgs e)
        {
            m_showImage.Image_GrabPic = m_showImage.Image_Camera;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string sfdDicPath = Path.Combine(Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName), "picture");
            System.IO.Directory.CreateDirectory(sfdDicPath);
            sfd.InitialDirectory = @sfdDicPath;
            sfd.Filter = "(*.bmp) |*.bmp |(*.jpg) | *.jpg|(*.gif) |*.gif";
            sfd.DefaultExt = "bmp";
            if (sfd.ShowDialog(this) == DialogResult.Cancel)
                return;
            m_showImage.Image_GrabPic.Save(sfd.FileName);
        }

        private void foolproof_UI()
        {
            button_Start_AForge.Enabled = m_videoTask == null;
            button_Start_CV.Enabled = m_videoTask == null;
            button_Close_AForge.Enabled = m_videoTask!=null;
            button_Close_CV.Enabled = m_videoTask != null;
            button_Grab.Enabled = m_videoTask != null;
            button_Save.Enabled = m_showImage.Image_GrabPic == null ? false : true;
        }

        private void timer_UI_Tick(object sender, EventArgs e)
        {
            foolproof_UI();
        }
    }

    public class ShowImage : INotifyPropertyChanged
    {
        private Image image_Camera;
        private Image image_GrabPic;

        public Image Image_Camera
        {
            get { return image_Camera; }
            set { image_Camera = value; InvokePropertyChanged(new PropertyChangedEventArgs("Image_Camera")); }
        }
        public Image Image_GrabPic
        {
            get { return image_GrabPic; }
            set { image_GrabPic = value; InvokePropertyChanged(new PropertyChangedEventArgs("Image_GrabPic")); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }
    }
}
