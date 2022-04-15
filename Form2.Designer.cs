namespace WindowsFormsApp1
{
    partial class Form2
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Source = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button_OpenPhoto = new System.Windows.Forms.Button();
            this.trackBar_H_Low = new System.Windows.Forms.TrackBar();
            this.trackBar_H_High = new System.Windows.Forms.TrackBar();
            this.trackBar_S_Low = new System.Windows.Forms.TrackBar();
            this.trackBar_S_High = new System.Windows.Forms.TrackBar();
            this.trackBar_V_Low = new System.Windows.Forms.TrackBar();
            this.trackBar_V_High = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_H_Low = new System.Windows.Forms.Label();
            this.label_H_High = new System.Windows.Forms.Label();
            this.label_S_Low = new System.Windows.Forms.Label();
            this.label_S_High = new System.Windows.Forms.Label();
            this.label_V_Low = new System.Windows.Forms.Label();
            this.label_V_High = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_Result = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Source)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_H_Low)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_H_High)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_S_Low)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_S_High)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_V_Low)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_V_High)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.pictureBox_Source, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(369, 394);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // pictureBox_Source
            // 
            this.pictureBox_Source.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox_Source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Source.Location = new System.Drawing.Point(3, 33);
            this.pictureBox_Source.Name = "pictureBox_Source";
            this.pictureBox_Source.Size = new System.Drawing.Size(363, 358);
            this.pictureBox_Source.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Source.TabIndex = 11;
            this.pictureBox_Source.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Source picture image";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.3169F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.42267F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.26043F));
            this.tableLayoutPanel5.Controls.Add(this.button_OpenPhoto, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.trackBar_H_Low, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.trackBar_H_High, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.trackBar_S_Low, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.trackBar_S_High, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.trackBar_V_Low, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.trackBar_V_High, 1, 8);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.label_H_Low, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.label_H_High, 2, 4);
            this.tableLayoutPanel5.Controls.Add(this.label_S_Low, 2, 5);
            this.tableLayoutPanel5.Controls.Add(this.label_S_High, 2, 6);
            this.tableLayoutPanel5.Controls.Add(this.label_V_Low, 2, 7);
            this.tableLayoutPanel5.Controls.Add(this.label_V_High, 2, 8);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(378, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 9;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel5, 2);
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(369, 794);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // button_OpenPhoto
            // 
            this.button_OpenPhoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.SetColumnSpan(this.button_OpenPhoto, 3);
            this.button_OpenPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OpenPhoto.Location = new System.Drawing.Point(3, 3);
            this.button_OpenPhoto.Name = "button_OpenPhoto";
            this.button_OpenPhoto.Size = new System.Drawing.Size(363, 82);
            this.button_OpenPhoto.TabIndex = 19;
            this.button_OpenPhoto.Text = "Open Photo";
            this.button_OpenPhoto.UseVisualStyleBackColor = true;
            // 
            // trackBar_H_Low
            // 
            this.trackBar_H_Low.AutoSize = false;
            this.trackBar_H_Low.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_H_Low.Location = new System.Drawing.Point(100, 267);
            this.trackBar_H_Low.Maximum = 179;
            this.trackBar_H_Low.Name = "trackBar_H_Low";
            this.trackBar_H_Low.Size = new System.Drawing.Size(228, 82);
            this.trackBar_H_Low.TabIndex = 0;
            // 
            // trackBar_H_High
            // 
            this.trackBar_H_High.AutoSize = false;
            this.trackBar_H_High.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_H_High.Location = new System.Drawing.Point(100, 355);
            this.trackBar_H_High.Maximum = 179;
            this.trackBar_H_High.Name = "trackBar_H_High";
            this.trackBar_H_High.Size = new System.Drawing.Size(228, 82);
            this.trackBar_H_High.TabIndex = 1;
            // 
            // trackBar_S_Low
            // 
            this.trackBar_S_Low.AutoSize = false;
            this.trackBar_S_Low.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_S_Low.Location = new System.Drawing.Point(100, 443);
            this.trackBar_S_Low.Maximum = 255;
            this.trackBar_S_Low.Name = "trackBar_S_Low";
            this.trackBar_S_Low.Size = new System.Drawing.Size(228, 82);
            this.trackBar_S_Low.TabIndex = 2;
            // 
            // trackBar_S_High
            // 
            this.trackBar_S_High.AutoSize = false;
            this.trackBar_S_High.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_S_High.Location = new System.Drawing.Point(100, 531);
            this.trackBar_S_High.Maximum = 255;
            this.trackBar_S_High.Name = "trackBar_S_High";
            this.trackBar_S_High.Size = new System.Drawing.Size(228, 82);
            this.trackBar_S_High.TabIndex = 3;
            // 
            // trackBar_V_Low
            // 
            this.trackBar_V_Low.AutoSize = false;
            this.trackBar_V_Low.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_V_Low.Location = new System.Drawing.Point(100, 619);
            this.trackBar_V_Low.Maximum = 255;
            this.trackBar_V_Low.Name = "trackBar_V_Low";
            this.trackBar_V_Low.Size = new System.Drawing.Size(228, 82);
            this.trackBar_V_Low.TabIndex = 4;
            // 
            // trackBar_V_High
            // 
            this.trackBar_V_High.AutoSize = false;
            this.trackBar_V_High.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_V_High.Location = new System.Drawing.Point(100, 707);
            this.trackBar_V_High.Maximum = 255;
            this.trackBar_V_High.Name = "trackBar_V_High";
            this.trackBar_V_High.Size = new System.Drawing.Size(228, 84);
            this.trackBar_V_High.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 82);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hue_Low";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 82);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hue_High";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 443);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 82);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saturation_Low";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 531);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 82);
            this.label6.TabIndex = 10;
            this.label6.Text = "Saturation_High";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 619);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 82);
            this.label7.TabIndex = 11;
            this.label7.Text = "Value_Low";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 707);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 84);
            this.label8.TabIndex = 12;
            this.label8.Text = "Value_High";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_H_Low
            // 
            this.label_H_Low.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_H_Low.Location = new System.Drawing.Point(334, 267);
            this.label_H_Low.Margin = new System.Windows.Forms.Padding(3);
            this.label_H_Low.Name = "label_H_Low";
            this.label_H_Low.Size = new System.Drawing.Size(32, 82);
            this.label_H_Low.TabIndex = 13;
            this.label_H_Low.Text = "100";
            this.label_H_Low.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_H_High
            // 
            this.label_H_High.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_H_High.Location = new System.Drawing.Point(334, 355);
            this.label_H_High.Margin = new System.Windows.Forms.Padding(3);
            this.label_H_High.Name = "label_H_High";
            this.label_H_High.Size = new System.Drawing.Size(32, 82);
            this.label_H_High.TabIndex = 14;
            this.label_H_High.Text = "100";
            this.label_H_High.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_S_Low
            // 
            this.label_S_Low.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_S_Low.Location = new System.Drawing.Point(334, 443);
            this.label_S_Low.Margin = new System.Windows.Forms.Padding(3);
            this.label_S_Low.Name = "label_S_Low";
            this.label_S_Low.Size = new System.Drawing.Size(32, 82);
            this.label_S_Low.TabIndex = 15;
            this.label_S_Low.Text = "100";
            this.label_S_Low.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_S_High
            // 
            this.label_S_High.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_S_High.Location = new System.Drawing.Point(334, 531);
            this.label_S_High.Margin = new System.Windows.Forms.Padding(3);
            this.label_S_High.Name = "label_S_High";
            this.label_S_High.Size = new System.Drawing.Size(32, 82);
            this.label_S_High.TabIndex = 16;
            this.label_S_High.Text = "100";
            this.label_S_High.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_V_Low
            // 
            this.label_V_Low.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_V_Low.Location = new System.Drawing.Point(334, 619);
            this.label_V_Low.Margin = new System.Windows.Forms.Padding(3);
            this.label_V_Low.Name = "label_V_Low";
            this.label_V_Low.Size = new System.Drawing.Size(32, 82);
            this.label_V_Low.TabIndex = 17;
            this.label_V_Low.Text = "100";
            this.label_V_Low.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_V_High
            // 
            this.label_V_High.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_V_High.Location = new System.Drawing.Point(334, 707);
            this.label_V_High.Margin = new System.Windows.Forms.Padding(3);
            this.label_V_High.Name = "label_V_High";
            this.label_V_High.Size = new System.Drawing.Size(32, 84);
            this.label_V_High.TabIndex = 18;
            this.label_V_High.Text = "100";
            this.label_V_High.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 800);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox_Result, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 403);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(369, 394);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Result picture image";
            // 
            // pictureBox_Result
            // 
            this.pictureBox_Result.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Result.Location = new System.Drawing.Point(3, 33);
            this.pictureBox_Result.Name = "pictureBox_Result";
            this.pictureBox_Result.Size = new System.Drawing.Size(363, 358);
            this.pictureBox_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Result.TabIndex = 2;
            this.pictureBox_Result.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form2";
            this.Size = new System.Drawing.Size(750, 800);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Source)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_H_Low)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_H_High)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_S_Low)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_S_High)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_V_Low)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_V_High)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TrackBar trackBar_H_Low;
        private System.Windows.Forms.TrackBar trackBar_H_High;
        private System.Windows.Forms.TrackBar trackBar_S_Low;
        private System.Windows.Forms.TrackBar trackBar_S_High;
        private System.Windows.Forms.TrackBar trackBar_V_Low;
        private System.Windows.Forms.TrackBar trackBar_V_High;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_H_Low;
        private System.Windows.Forms.Label label_H_High;
        private System.Windows.Forms.Label label_S_Low;
        private System.Windows.Forms.Label label_S_High;
        private System.Windows.Forms.Label label_V_Low;
        private System.Windows.Forms.Label label_V_High;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_OpenPhoto;
        private System.Windows.Forms.PictureBox pictureBox_Source;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_Result;
    }
}