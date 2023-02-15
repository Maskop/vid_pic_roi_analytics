namespace vid_pic_roi_analytics.Windows
{
    partial class Videos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Videos));
            this.vidPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.vidPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // vidPlayer
            // 
            this.vidPlayer.Enabled = true;
            this.vidPlayer.Location = new System.Drawing.Point(12, 12);
            this.vidPlayer.Name = "vidPlayer";
            this.vidPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vidPlayer.OcxState")));
            this.vidPlayer.Size = new System.Drawing.Size(478, 426);
            this.vidPlayer.TabIndex = 0;
            // 
            // Videos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vidPlayer);
            this.Name = "Videos";
            this.Text = "Videos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Videos_FormClosing);
            this.Load += new System.EventHandler(this.Videos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vidPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer vidPlayer;
    }
}