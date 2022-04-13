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
            this.pictureBox_Source = new System.Windows.Forms.PictureBox();
            this.button_OpenPhoto = new System.Windows.Forms.Button();
            this.pictureBox_Result = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Source
            // 
            this.pictureBox_Source.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox_Source.Location = new System.Drawing.Point(25, 22);
            this.pictureBox_Source.Name = "pictureBox_Source";
            this.pictureBox_Source.Size = new System.Drawing.Size(393, 337);
            this.pictureBox_Source.TabIndex = 0;
            this.pictureBox_Source.TabStop = false;
            // 
            // button_OpenPhoto
            // 
            this.button_OpenPhoto.Location = new System.Drawing.Point(461, 22);
            this.button_OpenPhoto.Name = "button_OpenPhoto";
            this.button_OpenPhoto.Size = new System.Drawing.Size(75, 23);
            this.button_OpenPhoto.TabIndex = 1;
            this.button_OpenPhoto.Text = "Open Photo";
            this.button_OpenPhoto.UseVisualStyleBackColor = true;
            this.button_OpenPhoto.Click += new System.EventHandler(this.button_OpenPhoto_Click);
            // 
            // pictureBox_Result
            // 
            this.pictureBox_Result.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox_Result.Location = new System.Drawing.Point(25, 383);
            this.pictureBox_Result.Name = "pictureBox_Result";
            this.pictureBox_Result.Size = new System.Drawing.Size(393, 337);
            this.pictureBox_Result.TabIndex = 2;
            this.pictureBox_Result.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_Result);
            this.Controls.Add(this.button_OpenPhoto);
            this.Controls.Add(this.pictureBox_Source);
            this.Name = "Form2";
            this.Size = new System.Drawing.Size(553, 763);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Source;
        private System.Windows.Forms.Button button_OpenPhoto;
        private System.Windows.Forms.PictureBox pictureBox_Result;
    }
}