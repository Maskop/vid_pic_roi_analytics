namespace vid_pic_roi_analytics.Windows
{
    partial class SaveForm
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
            this.selectedPathTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PathButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.selectedNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectedPathTextBox
            // 
            this.selectedPathTextBox.Location = new System.Drawing.Point(12, 38);
            this.selectedPathTextBox.Name = "selectedPathTextBox";
            this.selectedPathTextBox.Size = new System.Drawing.Size(237, 20);
            this.selectedPathTextBox.TabIndex = 0;
            this.selectedPathTextBox.Text = "Directory Path...";
            this.selectedPathTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 64);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(93, 64);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(75, 23);
            this.PathButton.TabIndex = 3;
            this.PathButton.Text = "Explorer";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(174, 64);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // selectedNameTextBox
            // 
            this.selectedNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.selectedNameTextBox.MaxLength = 10;
            this.selectedNameTextBox.Name = "selectedNameTextBox";
            this.selectedNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.selectedNameTextBox.TabIndex = 5;
            this.selectedNameTextBox.Text = "Name...";
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(258, 93);
            this.ControlBox = false;
            this.Controls.Add(this.selectedNameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.selectedPathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save";
            this.Load += new System.EventHandler(this.SaveForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selectedPathTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox selectedNameTextBox;
    }
}