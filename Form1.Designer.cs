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
            this.pictureBox_Cam = new System.Windows.Forms.PictureBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.combobox_CamList = new System.Windows.Forms.ComboBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Grab = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.pictureBox_Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Cam
            // 
            this.pictureBox_Cam.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox_Cam.Location = new System.Drawing.Point(27, 25);
            this.pictureBox_Cam.Name = "pictureBox_Cam";
            this.pictureBox_Cam.Size = new System.Drawing.Size(393, 337);
            this.pictureBox_Cam.TabIndex = 0;
            this.pictureBox_Cam.TabStop = false;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(546, 89);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // combobox_CamList
            // 
            this.combobox_CamList.FormattingEnabled = true;
            this.combobox_CamList.Location = new System.Drawing.Point(445, 25);
            this.combobox_CamList.Name = "combobox_CamList";
            this.combobox_CamList.Size = new System.Drawing.Size(176, 20);
            this.combobox_CamList.TabIndex = 4;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(546, 134);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Grab
            // 
            this.button_Grab.Location = new System.Drawing.Point(546, 179);
            this.button_Grab.Name = "button_Grab";
            this.button_Grab.Size = new System.Drawing.Size(75, 23);
            this.button_Grab.TabIndex = 6;
            this.button_Grab.Text = "Grab";
            this.button_Grab.UseVisualStyleBackColor = true;
            this.button_Grab.Click += new System.EventHandler(this.button_Grab_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(546, 224);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 7;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // pictureBox_Pic
            // 
            this.pictureBox_Pic.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox_Pic.Location = new System.Drawing.Point(27, 383);
            this.pictureBox_Pic.Name = "pictureBox_Pic";
            this.pictureBox_Pic.Size = new System.Drawing.Size(393, 337);
            this.pictureBox_Pic.TabIndex = 8;
            this.pictureBox_Pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 772);
            this.Controls.Add(this.pictureBox_Pic);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Grab);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.combobox_CamList);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.pictureBox_Cam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Cam;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.ComboBox combobox_CamList;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Grab;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.PictureBox pictureBox_Pic;
    }
}

