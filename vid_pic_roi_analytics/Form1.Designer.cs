namespace vid_pic_roi_analytics
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenExistButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 348);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last opened projects";
            // 
            // OpenExistButton
            // 
            this.OpenExistButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenExistButton.Location = new System.Drawing.Point(12, 12);
            this.OpenExistButton.Name = "OpenExistButton";
            this.OpenExistButton.Size = new System.Drawing.Size(225, 51);
            this.OpenExistButton.TabIndex = 1;
            this.OpenExistButton.Text = "Open existing project";
            this.OpenExistButton.UseVisualStyleBackColor = true;
            this.OpenExistButton.Click += new System.EventHandler(this.OpenExistButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateButton.Location = new System.Drawing.Point(12, 69);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(225, 51);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Create new project";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(252, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.OpenExistButton);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.ChooseProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OpenExistButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label1;
    }
}