namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabelayoutPanel0 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tabelayoutPanel0
            // 
            this.tabelayoutPanel0.AutoSize = true;
            this.tabelayoutPanel0.ColumnCount = 2;
            this.tabelayoutPanel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabelayoutPanel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabelayoutPanel0.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabelayoutPanel0.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tabelayoutPanel0.Location = new System.Drawing.Point(0, 0);
            this.tabelayoutPanel0.Margin = new System.Windows.Forms.Padding(10);
            this.tabelayoutPanel0.Name = "tabelayoutPanel0";
            this.tabelayoutPanel0.RowCount = 1;
            this.tabelayoutPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabelayoutPanel0.Size = new System.Drawing.Size(1584, 0);
            this.tabelayoutPanel0.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.tabelayoutPanel0);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabelayoutPanel0;
    }
}