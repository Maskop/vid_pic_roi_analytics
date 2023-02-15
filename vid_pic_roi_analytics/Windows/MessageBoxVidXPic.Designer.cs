namespace vid_pic_roi_analytics.Windows
{
    partial class MessageBoxVidXPic
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
            this.pictureButton = new System.Windows.Forms.Button();
            this.videoButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pictureButton
            // 
            this.pictureButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.pictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pictureButton.Location = new System.Drawing.Point(12, 12);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(75, 23);
            this.pictureButton.TabIndex = 0;
            this.pictureButton.Text = "picture";
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.pictureButton_Click);
            // 
            // videoButton
            // 
            this.videoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.videoButton.Location = new System.Drawing.Point(113, 12);
            this.videoButton.Name = "videoButton";
            this.videoButton.Size = new System.Drawing.Size(75, 23);
            this.videoButton.TabIndex = 1;
            this.videoButton.Text = "video";
            this.videoButton.UseVisualStyleBackColor = true;
            this.videoButton.Click += new System.EventHandler(this.videoButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(90, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessageBoxVidXPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(200, 52);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.videoButton);
            this.Controls.Add(this.pictureButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MessageBoxVidXPic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose project";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pictureButton;
        private System.Windows.Forms.Button videoButton;
        private System.Windows.Forms.Button closeButton;
    }
}