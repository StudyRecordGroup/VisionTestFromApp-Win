using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;

namespace WindowsFormsApp1
{
    public partial class Form2 : UserControl
    {
        Bitmap Bitmap { get; set; }

        public Form2(CancellationToken cancelByUser)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button_OpenPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "(*.bmp) |*.bmp |(*.jpg) | *.jpg|(*.gif) |*.gif";
            ofd.DefaultExt = "bmp";
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            Bitmap = new Bitmap(ofd.FileName);
            pictureBox1.Image = Bitmap;
        }
    }
}
