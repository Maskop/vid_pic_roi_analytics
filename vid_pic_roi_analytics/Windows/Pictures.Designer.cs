namespace vid_pic_roi_analytics.Windows
{
    partial class Pictures
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
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("ZOOM IN");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("RESET");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("PROPERTIES", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Rectangle");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Circle");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Free select");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("ROI", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.ControlTable = new System.Windows.Forms.TreeView();
            this.BWbutton = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.ResetDrawnROIButton = new System.Windows.Forms.Button();
            this.ROIOnScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.selectedROIpictureBox = new System.Windows.Forms.PictureBox();
            this.existingROIselection = new System.Windows.Forms.CheckedListBox();
            this.DeleteRoi = new System.Windows.Forms.Button();
            this.addNewRoi = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.analyticsPanel = new System.Windows.Forms.Panel();
            this.RedL = new System.Windows.Forms.Label();
            this.GreenL = new System.Windows.Forms.Label();
            this.BlueL = new System.Windows.Forms.Label();
            this.ShowColourPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.imagePanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedROIpictureBox)).BeginInit();
            this.analyticsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowColourPB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.ImageLocation = "";
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(150, 162);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(75, 81);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagePanel_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagePanel_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // imagePanel
            // 
            this.imagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Controls.Add(this.pictureBox);
            this.imagePanel.Location = new System.Drawing.Point(20, 40);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(400, 370);
            this.imagePanel.TabIndex = 8;
            // 
            // ControlTable
            // 
            this.ControlTable.Location = new System.Drawing.Point(0, 0);
            this.ControlTable.Name = "ControlTable";
            treeNode8.Name = "zoomIn";
            treeNode8.Text = "ZOOM IN";
            treeNode9.Name = "resetImg";
            treeNode9.Text = "RESET";
            treeNode10.Name = "pictureSettings";
            treeNode10.Text = "PROPERTIES";
            treeNode11.Name = "ROIr";
            treeNode11.Text = "Rectangle";
            treeNode12.Name = "ROIc";
            treeNode12.Text = "Circle";
            treeNode13.Name = "ROIfs";
            treeNode13.Text = "Free select";
            treeNode14.Name = "ROIselect";
            treeNode14.Text = "ROI";
            this.ControlTable.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode14});
            this.ControlTable.ShowLines = false;
            this.ControlTable.Size = new System.Drawing.Size(112, 378);
            this.ControlTable.TabIndex = 9;
            this.ControlTable.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ControlTable_NodeMouseClick);
            // 
            // BWbutton
            // 
            this.BWbutton.Location = new System.Drawing.Point(185, 5);
            this.BWbutton.Name = "BWbutton";
            this.BWbutton.Size = new System.Drawing.Size(75, 23);
            this.BWbutton.TabIndex = 10;
            this.BWbutton.Text = "BW";
            this.BWbutton.UseVisualStyleBackColor = true;
            this.BWbutton.Click += new System.EventHandler(this.BWbutton_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.AutoSize = true;
            this.controlPanel.Controls.Add(this.analyticsPanel);
            this.controlPanel.Controls.Add(this.ResetDrawnROIButton);
            this.controlPanel.Controls.Add(this.ROIOnScreenCheckBox);
            this.controlPanel.Controls.Add(this.existingROIselection);
            this.controlPanel.Controls.Add(this.DeleteRoi);
            this.controlPanel.Controls.Add(this.addNewRoi);
            this.controlPanel.Controls.Add(this.ControlTable);
            this.controlPanel.Location = new System.Drawing.Point(426, 40);
            this.controlPanel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(506, 381);
            this.controlPanel.TabIndex = 11;
            // 
            // ResetDrawnROIButton
            // 
            this.ResetDrawnROIButton.Location = new System.Drawing.Point(177, 2);
            this.ResetDrawnROIButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetDrawnROIButton.Name = "ResetDrawnROIButton";
            this.ResetDrawnROIButton.Size = new System.Drawing.Size(56, 19);
            this.ResetDrawnROIButton.TabIndex = 16;
            this.ResetDrawnROIButton.Text = "Reset";
            this.ResetDrawnROIButton.UseVisualStyleBackColor = true;
            this.ResetDrawnROIButton.Click += new System.EventHandler(this.ResetDrawnROIButton_Click);
            // 
            // ROIOnScreenCheckBox
            // 
            this.ROIOnScreenCheckBox.AutoSize = true;
            this.ROIOnScreenCheckBox.Location = new System.Drawing.Point(156, 26);
            this.ROIOnScreenCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ROIOnScreenCheckBox.Name = "ROIOnScreenCheckBox";
            this.ROIOnScreenCheckBox.Size = new System.Drawing.Size(103, 17);
            this.ROIOnScreenCheckBox.TabIndex = 12;
            this.ROIOnScreenCheckBox.Text = "Show on screen";
            this.ROIOnScreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectedROIpictureBox
            // 
            this.selectedROIpictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedROIpictureBox.Location = new System.Drawing.Point(2, 2);
            this.selectedROIpictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectedROIpictureBox.Name = "selectedROIpictureBox";
            this.selectedROIpictureBox.Size = new System.Drawing.Size(75, 75);
            this.selectedROIpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedROIpictureBox.TabIndex = 15;
            this.selectedROIpictureBox.TabStop = false;
            // 
            // existingROIselection
            // 
            this.existingROIselection.FormattingEnabled = true;
            this.existingROIselection.Location = new System.Drawing.Point(116, 47);
            this.existingROIselection.Margin = new System.Windows.Forms.Padding(2);
            this.existingROIselection.Name = "existingROIselection";
            this.existingROIselection.Size = new System.Drawing.Size(179, 319);
            this.existingROIselection.TabIndex = 14;
            this.existingROIselection.SelectedIndexChanged += new System.EventHandler(this.existingROIselection_SelectedIndexChanged);
            // 
            // DeleteRoi
            // 
            this.DeleteRoi.Location = new System.Drawing.Point(238, 2);
            this.DeleteRoi.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteRoi.Name = "DeleteRoi";
            this.DeleteRoi.Size = new System.Drawing.Size(56, 19);
            this.DeleteRoi.TabIndex = 13;
            this.DeleteRoi.Text = "Delete";
            this.DeleteRoi.UseVisualStyleBackColor = true;
            this.DeleteRoi.Click += new System.EventHandler(this.DeleteRoi_Click);
            // 
            // addNewRoi
            // 
            this.addNewRoi.Location = new System.Drawing.Point(116, 2);
            this.addNewRoi.Margin = new System.Windows.Forms.Padding(2);
            this.addNewRoi.Name = "addNewRoi";
            this.addNewRoi.Size = new System.Drawing.Size(56, 19);
            this.addNewRoi.TabIndex = 12;
            this.addNewRoi.Text = "Add new";
            this.addNewRoi.UseVisualStyleBackColor = true;
            this.addNewRoi.Click += new System.EventHandler(this.addNewRoi_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(857, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Location = new System.Drawing.Point(20, 5);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(100, 23);
            this.backToMenuButton.TabIndex = 14;
            this.backToMenuButton.Text = "Back To Menu";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // analyticsPanel
            // 
            this.analyticsPanel.Controls.Add(this.ShowColourPB);
            this.analyticsPanel.Controls.Add(this.BlueL);
            this.analyticsPanel.Controls.Add(this.GreenL);
            this.analyticsPanel.Controls.Add(this.RedL);
            this.analyticsPanel.Controls.Add(this.selectedROIpictureBox);
            this.analyticsPanel.Location = new System.Drawing.Point(300, 47);
            this.analyticsPanel.Name = "analyticsPanel";
            this.analyticsPanel.Size = new System.Drawing.Size(200, 319);
            this.analyticsPanel.TabIndex = 17;
            // 
            // RedL
            // 
            this.RedL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RedL.AutoSize = true;
            this.RedL.Location = new System.Drawing.Point(82, 2);
            this.RedL.Name = "RedL";
            this.RedL.Size = new System.Drawing.Size(33, 13);
            this.RedL.TabIndex = 0;
            this.RedL.Text = "Red: ";
            // 
            // GreenL
            // 
            this.GreenL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GreenL.AutoSize = true;
            this.GreenL.Location = new System.Drawing.Point(82, 31);
            this.GreenL.Name = "GreenL";
            this.GreenL.Size = new System.Drawing.Size(42, 13);
            this.GreenL.TabIndex = 1;
            this.GreenL.Text = "Green: ";
            // 
            // BlueL
            // 
            this.BlueL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlueL.AutoSize = true;
            this.BlueL.Location = new System.Drawing.Point(82, 64);
            this.BlueL.Name = "BlueL";
            this.BlueL.Size = new System.Drawing.Size(34, 13);
            this.BlueL.TabIndex = 2;
            this.BlueL.Text = "Blue: ";
            // 
            // ShowColourPB
            // 
            this.ShowColourPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowColourPB.Location = new System.Drawing.Point(152, 3);
            this.ShowColourPB.Name = "ShowColourPB";
            this.ShowColourPB.Size = new System.Drawing.Size(45, 74);
            this.ShowColourPB.TabIndex = 16;
            this.ShowColourPB.TabStop = false;
            // 
            // Pictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 431);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.BWbutton);
            this.Controls.Add(this.imagePanel);
            this.Name = "Pictures";
            this.Text = "Pictures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pictures_FormClosing);
            this.Load += new System.EventHandler(this.Pictures_Load);
            this.SizeChanged += new System.EventHandler(this.Pictures_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.imagePanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedROIpictureBox)).EndInit();
            this.analyticsPanel.ResumeLayout(false);
            this.analyticsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowColourPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.TreeView ControlTable;
        private System.Windows.Forms.Button BWbutton;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button DeleteRoi;
        private System.Windows.Forms.Button addNewRoi;
        private System.Windows.Forms.CheckedListBox existingROIselection;
        private System.Windows.Forms.PictureBox selectedROIpictureBox;
        private System.Windows.Forms.CheckBox ROIOnScreenCheckBox;
        private System.Windows.Forms.Button ResetDrawnROIButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Panel analyticsPanel;
        private System.Windows.Forms.Label BlueL;
        private System.Windows.Forms.Label GreenL;
        private System.Windows.Forms.Label RedL;
        private System.Windows.Forms.PictureBox ShowColourPB;
    }
}