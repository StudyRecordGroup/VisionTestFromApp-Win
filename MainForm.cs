using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        CancellationTokenSource ctx;
        public MainForm()
        {
            InitializeComponent();

            ctx = new CancellationTokenSource();
            tabelayoutPanel0.Controls.Add(new Form1(ctx.Token), 0, 0);
            tabelayoutPanel0.Controls.Add(new Form2(ctx.Token), 1, 0);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Cancel();
        }
    }
}
