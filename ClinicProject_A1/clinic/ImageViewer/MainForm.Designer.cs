namespace TumbnailDotnet
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
            this.buttonBrowseFolder = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMain = new TumbnailDotnet.ThumbnailFlowLayoutPanel();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.CmbImagePath = new System.Windows.Forms.ComboBox();
            this.GB_Size = new System.Windows.Forms.GroupBox();
            this.GB_InfoImage = new System.Windows.Forms.GroupBox();
            this.lbl_SelectFolder = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.GB_Size.SuspendLayout();
            this.GB_InfoImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowseFolder
            // 
            this.buttonBrowseFolder.Location = new System.Drawing.Point(91, 25);
            this.buttonBrowseFolder.Name = "buttonBrowseFolder";
            this.buttonBrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFolder.TabIndex = 1;
            this.buttonBrowseFolder.Text = " Õ„Ì· «·’Ê—";
            this.buttonBrowseFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseFolder.Click += new System.EventHandler(this.buttonBrowseFolder_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(9, 25);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "«·€«¡ «· Õ„Ì·";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.flowLayoutPanelMain);
            this.panelMain.Location = new System.Drawing.Point(12, 84);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(787, 457);
            this.panelMain.TabIndex = 4;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelMain.CausesValidation = false;
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(787, 457);
            this.flowLayoutPanelMain.TabIndex = 0;
            // 
            // trackBarSize
            // 
            this.trackBarSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSize.AutoSize = false;
            this.trackBarSize.LargeChange = 1;
            this.trackBarSize.Location = new System.Drawing.Point(6, 25);
            this.trackBarSize.Maximum = 2;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(264, 23);
            this.trackBarSize.TabIndex = 5;
            this.trackBarSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSize.Value = 1;
            this.trackBarSize.ValueChanged += new System.EventHandler(this.trackBarSize_ValueChanged);
            // 
            // CmbImagePath
            // 
            this.CmbImagePath.FormattingEnabled = true;
            this.CmbImagePath.Location = new System.Drawing.Point(172, 27);
            this.CmbImagePath.Name = "CmbImagePath";
            this.CmbImagePath.Size = new System.Drawing.Size(144, 21);
            this.CmbImagePath.TabIndex = 6;
            // 
            // GB_Size
            // 
            this.GB_Size.Controls.Add(this.trackBarSize);
            this.GB_Size.Location = new System.Drawing.Point(418, 14);
            this.GB_Size.Name = "GB_Size";
            this.GB_Size.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_Size.Size = new System.Drawing.Size(276, 63);
            this.GB_Size.TabIndex = 7;
            this.GB_Size.TabStop = false;
            this.GB_Size.Text = " ÕœÌœ ÕÃ„ «·’Ê—:";
            // 
            // GB_InfoImage
            // 
            this.GB_InfoImage.Controls.Add(this.lbl_SelectFolder);
            this.GB_InfoImage.Controls.Add(this.CmbImagePath);
            this.GB_InfoImage.Controls.Add(this.buttonCancel);
            this.GB_InfoImage.Controls.Add(this.buttonBrowseFolder);
            this.GB_InfoImage.Location = new System.Drawing.Point(12, 14);
            this.GB_InfoImage.Name = "GB_InfoImage";
            this.GB_InfoImage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_InfoImage.Size = new System.Drawing.Size(400, 64);
            this.GB_InfoImage.TabIndex = 8;
            this.GB_InfoImage.TabStop = false;
            this.GB_InfoImage.Text = "„⁄·Ê„«  «·’Ê—:";
            // 
            // lbl_SelectFolder
            // 
            this.lbl_SelectFolder.AutoSize = true;
            this.lbl_SelectFolder.Location = new System.Drawing.Point(322, 30);
            this.lbl_SelectFolder.Name = "lbl_SelectFolder";
            this.lbl_SelectFolder.Size = new System.Drawing.Size(69, 13);
            this.lbl_SelectFolder.TabIndex = 7;
            this.lbl_SelectFolder.Text = " ÕœÌœ «·„Ã·œ:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ImageViewer.Properties.Resources._226asmilies_com;
            this.pictureBox1.Location = new System.Drawing.Point(709, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GB_InfoImage);
            this.Controls.Add(this.GB_Size);
            this.Controls.Add(this.panelMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 589);
            this.MinimumSize = new System.Drawing.Size(822, 589);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "«·„” ⁄—÷";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.GB_Size.ResumeLayout(false);
            this.GB_InfoImage.ResumeLayout(false);
            this.GB_InfoImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ThumbnailFlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.Button buttonBrowseFolder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.ComboBox CmbImagePath;
        private System.Windows.Forms.GroupBox GB_Size;
        private System.Windows.Forms.GroupBox GB_InfoImage;
        private System.Windows.Forms.Label lbl_SelectFolder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

