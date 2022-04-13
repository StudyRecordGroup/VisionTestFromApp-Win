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

namespace WindowsFormsApp1
{
    public partial class Form1 : UserControl
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Bitmap image_Camera;
        Bitmap image_GrabPic;

        public Form1(CancellationToken cancelByUser)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            pictureBox_Cam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                combobox_CamList.Items.Add(filterInfo.Name);
            if(combobox_CamList.Items.Count > 0)
                combobox_CamList.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();

            cancelByUser.Register(() => videoCaptureDevice?.Stop());
        }

        private void ViedoCaptureDecice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            image_Camera = (Bitmap)eventArgs.Frame.Clone();
            pictureBox_Cam.Image = image_Camera;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[combobox_CamList.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += ViedoCaptureDecice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
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
            sfd.InitialDirectory = @"D:\"; 
            //sfd.Filter = "Bitmap Image|*.bmp | JPeg Image|*.jpg|Gif Image|*.gif";
            sfd.Filter = "(*.bmp) |*.bmp |(*.jpg) | *.jpg|(*.gif) |*.gif";
            sfd.DefaultExt = "bmp";
            if (sfd.ShowDialog(this) == DialogResult.Cancel)
            {
                return;
            }
            image_GrabPic.Save(sfd.FileName);
        }
    }
}
