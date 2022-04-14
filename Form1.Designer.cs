namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox_Cam = new System.Windows.Forms.PictureBox();
            this.button_Start_AForge = new System.Windows.Forms.Button();
            this.combobox_CamList = new System.Windows.Forms.ComboBox();
            this.pictureBox_Pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Close_AForge = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Grab = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Start_CV = new System.Windows.Forms.Button();
            this.button_Close_CV = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.timer_UI = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pic)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Cam
            // 
            this.pictureBox_Cam.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox_Cam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Cam.Location = new System.Drawing.Point(3, 27);
            this.pictureBox_Cam.Name = "pictureBox_Cam";
            this.pictureBox_Cam.Size = new System.Drawing.Size(427, 350);
            this.pictureBox_Cam.TabIndex = 0;
            this.pictureBox_Cam.TabStop = false;
            // 
            // button_Start_AForge
            // 
            this.button_Start_AForge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Start_AForge.Location = new System.Drawing.Point(3, 53);
            this.button_Start_AForge.Name = "button_Start_AForge";
            this.button_Start_AForge.Size = new System.Drawing.Size(243, 76);
            this.button_Start_AForge.TabIndex = 1;
            this.button_Start_AForge.Text = "Start_AForge";
            this.button_Start_AForge.UseVisualStyleBackColor = true;
            this.button_Start_AForge.Click += new System.EventHandler(this.button_Start_AForge_Click);
            // 
            // combobox_CamList
            // 
            this.combobox_CamList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combobox_CamList.FormattingEnabled = true;
            this.combobox_CamList.Location = new System.Drawing.Point(3, 23);
            this.combobox_CamList.Name = "combobox_CamList";
            this.combobox_CamList.Size = new System.Drawing.Size(243, 20);
            this.combobox_CamList.TabIndex = 4;
            this.combobox_CamList.SelectedIndexChanged += new System.EventHandler(this.combobox_CamList_SelectedIndexChanged);
            // 
            // pictureBox_Pic
            // 
            this.pictureBox_Pic.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox_Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Pic.Location = new System.Drawing.Point(3, 27);
            this.pictureBox_Pic.Name = "pictureBox_Pic";
            this.pictureBox_Pic.Size = new System.Drawing.Size(427, 350);
            this.pictureBox_Pic.TabIndex = 8;
            this.pictureBox_Pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Camera image (Live)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Grab image";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_Cam, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 380);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox_Pic, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 389);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(433, 380);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.combobox_CamList, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button_Start_AForge, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button_Close_AForge, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.button_Save, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.button_Grab, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_Start_CV, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.button_Close_CV, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(442, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(499, 380);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // button_Close_AForge
            // 
            this.button_Close_AForge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Close_AForge.Location = new System.Drawing.Point(3, 135);
            this.button_Close_AForge.Name = "button_Close_AForge";
            this.button_Close_AForge.Size = new System.Drawing.Size(243, 76);
            this.button_Close_AForge.TabIndex = 5;
            this.button_Close_AForge.Text = "Close_AForge";
            this.button_Close_AForge.UseVisualStyleBackColor = true;
            this.button_Close_AForge.Click += new System.EventHandler(this.button_Close_AForge_Click);
            // 
            // button_Save
            // 
            this.button_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Save.Location = new System.Drawing.Point(3, 299);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(243, 78);
            this.button_Save.TabIndex = 7;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Grab
            // 
            this.button_Grab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Grab.Location = new System.Drawing.Point(3, 217);
            this.button_Grab.Name = "button_Grab";
            this.button_Grab.Size = new System.Drawing.Size(243, 76);
            this.button_Grab.TabIndex = 6;
            this.button_Grab.Text = "Grab";
            this.button_Grab.UseVisualStyleBackColor = true;
            this.button_Grab.Click += new System.EventHandler(this.button_Grab_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "AForge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(252, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "OpenCV";
            // 
            // button_Start_CV
            // 
            this.button_Start_CV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Start_CV.Location = new System.Drawing.Point(252, 53);
            this.button_Start_CV.Name = "button_Start_CV";
            this.button_Start_CV.Size = new System.Drawing.Size(244, 76);
            this.button_Start_CV.TabIndex = 10;
            this.button_Start_CV.Text = "Start_CV";
            this.button_Start_CV.UseVisualStyleBackColor = true;
            this.button_Start_CV.Click += new System.EventHandler(this.button_Start_CV_Click);
            // 
            // button_Close_CV
            // 
            this.button_Close_CV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Close_CV.Location = new System.Drawing.Point(252, 135);
            this.button_Close_CV.Name = "button_Close_CV";
            this.button_Close_CV.Size = new System.Drawing.Size(244, 76);
            this.button_Close_CV.TabIndex = 11;
            this.button_Close_CV.Text = "Close_CV";
            this.button_Close_CV.UseVisualStyleBackColor = true;
            this.button_Close_CV.Click += new System.EventHandler(this.button_Close_CV_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(944, 772);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // timer_UI
            // 
            this.timer_UI.Enabled = true;
            this.timer_UI.Interval = 5;
            this.timer_UI.Tick += new System.EventHandler(this.timer_UI_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(944, 772);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pic)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Cam;
        private System.Windows.Forms.Button button_Start_AForge;
        private System.Windows.Forms.ComboBox combobox_CamList;
        private System.Windows.Forms.PictureBox pictureBox_Pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_Close_AForge;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Grab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Start_CV;
        private System.Windows.Forms.Button button_Close_CV;
        private System.Windows.Forms.Timer timer_UI;
    }
}

