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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Bitmap image_Camera;
        Bitmap image_GrabPic;

        public Form1()
        {
            InitializeComponent();
            pictureBox_Cam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                combobox_CamList.Items.Add(filterInfo.Name);
            combobox_CamList.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
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
            sfd.InitialDirectory = @"C:\Users\LWP1398\Desktop"; 
            sfd.Filter = "Bitmap Image|*.bmp | JPeg Image|*.jpg|Gif Image|*.gif";
            sfd.DefaultExt = "bmp";
            if (sfd.ShowDialog(this) == DialogResult.Cancel)
            {
                return;
            }
            image_GrabPic.Save(sfd.FileName);
        }
    }
}
