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
        TableLayoutPanel layoutPanel;
        CancellationTokenSource ctx;
        public MainForm()
        {
            InitializeComponent();

            ctx = new CancellationTokenSource();
            layoutPanel = new TableLayoutPanel() { Dock = DockStyle.Fill, Visible = true, CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble, AutoSize = true, AutoSizeMode = AutoSizeMode.GrowAndShrink };
            layoutPanel.Controls.Add(new Form1(ctx.Token), 0, 0);
            layoutPanel.Controls.Add(new Form2(ctx.Token), 1, 0);
            this.Controls.Add(layoutPanel);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Cancel();
        }
    }
}
