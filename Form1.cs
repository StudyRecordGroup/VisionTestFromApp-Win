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
        /// <summary>
        /// AForge
        /// </summary>
        FilterInfoCollection aforge_filterInfoCollection;
        VideoCaptureDevice aforge_videoCaptureDevice;

        /// <summary>
        /// OpenCV
        /// </summary>
        VideoCapture cv_videoCapture;
        Thread threadCam;
        bool bPlatfalg = false;

        Bitmap image_Camera;
        Bitmap image_GrabPic;

        public Form1(CancellationToken cancelByUser)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            pictureBox_Cam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            aforge_filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in aforge_filterInfoCollection)
                combobox_CamList.Items.Add(filterInfo.Name);
            if(combobox_CamList.Items.Count > 0)
                combobox_CamList.SelectedIndex = 0;
            aforge_videoCaptureDevice = new VideoCaptureDevice();
            cv_videoCapture = new VideoCapture();

            cancelByUser.Register(() => finalDo());
        }

        private void finalDo()
        {
            if (aforge_videoCaptureDevice.IsRunning)
                aforge_videoCaptureDevice?.Stop();
            if(cv_videoCapture.IsOpened())
            {
                bPlatfalg = false;
                if(threadCam != null)
                    threadCam.Abort();
                cv_videoCapture.Release();
            }
        }

        private void ViedoCaptureDecice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            image_Camera = (Bitmap)eventArgs.Frame.Clone();
            pictureBox_Cam.Image = image_Camera;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            aforge_videoCaptureDevice = new VideoCaptureDevice(aforge_filterInfoCollection[combobox_CamList.SelectedIndex].MonikerString);
            aforge_videoCaptureDevice.NewFrame += ViedoCaptureDecice_NewFrame;
            aforge_videoCaptureDevice.Start();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            if (aforge_videoCaptureDevice.IsRunning)
                aforge_videoCaptureDevice.Stop();
            pictureBox_Cam.Image = image_Camera = null;
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

        private void button_Start_CV_Click(object sender, EventArgs e)
        {
            if(!bPlatfalg)
            {
                if (cv_videoCapture.IsOpened())
                    return;
                cv_videoCapture.Open(0);

                bPlatfalg = true;
                threadCam = new Thread(play_Camera);
                threadCam.Start();
            }
        }

        private void button_Close_CV_Click(object sender, EventArgs e)
        {
            bPlatfalg = false;
            threadCam.Abort();
            cv_videoCapture.Release();
            pictureBox_Cam.Image = image_Camera = null;
        }

        private void play_Camera()
        {

            while (bPlatfalg)
            {
                Mat cFram = new Mat();

                cv_videoCapture.Read(cFram);

                if (cFram.Empty())
                    continue;

                pictureBox_Cam.Image = cFram.ToBitmap();
                cFram.Release();
            }
        }

    }
}
