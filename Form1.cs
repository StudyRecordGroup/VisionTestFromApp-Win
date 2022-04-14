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
        BackgroundWorker m_worker;
        bool m_worderIsWorking = false;
        byte m_workModule = 0;
        Bitmap image_Camera { get; set; }
        Bitmap image_GrabPic { get; set; }

        public Form1(CancellationToken cancelByUser)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            pictureBox_Cam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

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
        }

        private void finalDo()
        {
            if(m_worker!=null)
                m_worker.CancelAsync();
            
            switch (m_workModule)
            {
                case 1:
                    if (AForge_videoCaptureDevice.IsRunning)
                    {
                        AForge_videoCaptureDevice?.Stop();
                        AForge_videoCaptureDevice = null;
                    }
                    break;
                case 2:
                    if (OpenCV_videoCapture.IsOpened())
                    {
                        OpenCV_videoCapture.Release();
                        OpenCV_videoCapture = null;
                    }
                break ;
                default:
                    break;
            }
            m_worderIsWorking = false;
            m_workModule = 0;
            pictureBox_Cam.Image = image_Camera = null;
        }

        private void combobox_CamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int camsel = combobox_CamList.SelectedIndex;
            m_Cam_index = camsel;
        }

        private void button_Start_AForge_Click(object sender, EventArgs e)
        {
            AForge_videoCaptureDevice = new VideoCaptureDevice(AForge_filterInfoCollection[combobox_CamList.SelectedIndex].MonikerString);
            m_worker = new BackgroundWorker() { WorkerSupportsCancellation = true };
            m_worker.DoWork += M_worker_DoWork_AForge;
            m_worker.RunWorkerAsync();
            m_worderIsWorking = true;
            AForge_videoCaptureDevice.Start();
        }

        private void M_worker_DoWork_AForge(object sender, DoWorkEventArgs e)
        {
            m_workModule = 1;
            AForge_videoCaptureDevice.NewFrame += (s, eventArgs) =>
            {
                image_Camera = (Bitmap)eventArgs.Frame.Clone();
                pictureBox_Cam.Image = image_Camera;
            };
            //AForge_videoCaptureDevice.NewFrame += ViedoCaptureDecice_NewFrame;
        }

        //private void ViedoCaptureDecice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        //{
        //    image_Camera = (Bitmap)eventArgs.Frame.Clone();
        //    pictureBox_Cam.Image = image_Camera;
        //}

        private void button_Start_CV_Click(object sender, EventArgs e)
        {
            OpenCV_videoCapture = new VideoCapture();
            OpenCV_videoCapture.Open(combobox_CamList.Items.Count -1 - m_Cam_index); // becaues OpenCV camera's index is reverse of AForce FilterInfoCollection
            m_worker = new BackgroundWorker() { WorkerSupportsCancellation = true };
            m_worker.DoWork += M_worker_DoWork_OpenCV;
            m_worderIsWorking = true;
            m_worker.RunWorkerAsync();
        }

        private void M_worker_DoWork_OpenCV(object sender, DoWorkEventArgs e)
        {
            m_workModule = 2;
            while (!m_worker.CancellationPending)
            {
                Mat cFram = new Mat();
                OpenCV_videoCapture.Read(cFram);
                if (cFram.Empty()) continue;
                image_Camera = cFram.ToBitmap();
                if(m_worderIsWorking) // this if is avoid the m_worker cancel but it still read a black fram ,and set to the picturebox
                    pictureBox_Cam.Image = image_Camera;
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
            image_GrabPic = image_Camera;
            pictureBox_Pic.Image = image_GrabPic;
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
            image_GrabPic.Save(sfd.FileName);
        }

        private void foolproof_UI()
        {
            button_Start_AForge.Enabled = !m_worderIsWorking;
            button_Start_CV.Enabled = !m_worderIsWorking;
            button_Close_AForge.Enabled = m_worderIsWorking & (m_workModule == 1);
            button_Close_CV.Enabled = m_worderIsWorking & (m_workModule == 2);
            button_Grab.Enabled = m_worderIsWorking;
            button_Save.Enabled = image_GrabPic == null ? false : true;
        }

        private void timer_UI_Tick(object sender, EventArgs e)
        {
            foolproof_UI();
        }
    }
}
