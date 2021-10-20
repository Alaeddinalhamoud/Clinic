namespace clinic.FrmStamp
{
    partial class FrmStamptype
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
            this.TLP_Stamp = new System.Windows.Forms.TableLayoutPanel();
            this.TS_Stamp = new System.Windows.Forms.ToolStrip();
            this.TSB_Add_Stamp = new System.Windows.Forms.ToolStripButton();
            this.TSB_Update_Stamp = new System.Windows.Forms.ToolStripButton();
            this.TSB_Delete_Stamp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Empty = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Exit_Stamp = new System.Windows.Forms.ToolStripButton();
            this.GB_Stamp_info = new System.Windows.Forms.GroupBox();
            this.txt_StampName = new System.Windows.Forms.TextBox();
            this.txt_StampID = new System.Windows.Forms.TextBox();
            this.Lbl_StampName = new System.Windows.Forms.Label();
            this.Lbl_StampID = new System.Windows.Forms.Label();
            this.PB_LogoStamp = new System.Windows.Forms.PictureBox();
            this.GB_Search_Stamp = new System.Windows.Forms.GroupBox();
            this.PB_ImageSeach = new System.Windows.Forms.PictureBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.Lbl_Search = new System.Windows.Forms.Label();
            this.DGV_Stamp = new System.Windows.Forms.DataGridView();
            this.StampID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StampName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TLP_Stamp.SuspendLayout();
            this.TS_Stamp.SuspendLayout();
            this.GB_Stamp_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoStamp)).BeginInit();
            this.GB_Search_Stamp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ImageSeach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stamp)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP_Stamp
            // 
            this.TLP_Stamp.ColumnCount = 1;
            this.TLP_Stamp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Stamp.Controls.Add(this.TS_Stamp, 0, 0);
            this.TLP_Stamp.Controls.Add(this.GB_Stamp_info, 0, 1);
            this.TLP_Stamp.Controls.Add(this.GB_Search_Stamp, 0, 2);
            this.TLP_Stamp.Controls.Add(this.DGV_Stamp, 0, 3);
            this.TLP_Stamp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Stamp.Location = new System.Drawing.Point(0, 0);
            this.TLP_Stamp.Name = "TLP_Stamp";
            this.TLP_Stamp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TLP_Stamp.RowCount = 4;
            this.TLP_Stamp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.TLP_Stamp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.22222F));
            this.TLP_Stamp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.TLP_Stamp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.TLP_Stamp.Size = new System.Drawing.Size(655, 429);
            this.TLP_Stamp.TabIndex = 0;
            // 
            // TS_Stamp
            // 
            this.TS_Stamp.AutoSize = false;
            this.TS_Stamp.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_Stamp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Stamp.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.TS_Stamp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Add_Stamp,
            this.TSB_Update_Stamp,
            this.TSB_Delete_Stamp,
            this.toolStripSeparator1,
            this.TSB_Empty,
            this.toolStripSeparator2,
            this.TSB_Exit_Stamp});
            this.TS_Stamp.Location = new System.Drawing.Point(0, 0);
            this.TS_Stamp.Name = "TS_Stamp";
            this.TS_Stamp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TS_Stamp.Size = new System.Drawing.Size(655, 39);
            this.TS_Stamp.TabIndex = 1;
            this.TS_Stamp.Text = "toolStrip1";
            // 
            // TSB_Add_Stamp
            // 
            this.TSB_Add_Stamp.Image = global::clinic.Properties.Resources.add;
            this.TSB_Add_Stamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Add_Stamp.Name = "TSB_Add_Stamp";
            this.TSB_Add_Stamp.Size = new System.Drawing.Size(72, 36);
            this.TSB_Add_Stamp.Text = "اضافة";
            this.TSB_Add_Stamp.Click += new System.EventHandler(this.TSB_Add_Stamp_Click);
            // 
            // TSB_Update_Stamp
            // 
            this.TSB_Update_Stamp.Image = global::clinic.Properties.Resources.accept;
            this.TSB_Update_Stamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Update_Stamp.Name = "TSB_Update_Stamp";
            this.TSB_Update_Stamp.Size = new System.Drawing.Size(66, 36);
            this.TSB_Update_Stamp.Text = "تعديل";
            this.TSB_Update_Stamp.Click += new System.EventHandler(this.TSB_Update_Stamp_Click);
            // 
            // TSB_Delete_Stamp
            // 
            this.TSB_Delete_Stamp.Image = global::clinic.Properties.Resources.remove;
            this.TSB_Delete_Stamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Delete_Stamp.Name = "TSB_Delete_Stamp";
            this.TSB_Delete_Stamp.Size = new System.Drawing.Size(66, 36);
            this.TSB_Delete_Stamp.Text = "حذف";
            this.TSB_Delete_Stamp.Click += new System.EventHandler(this.TSB_Delete_Stamp_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // TSB_Empty
            // 
            this.TSB_Empty.Image = global::clinic.Properties.Resources.Empty_Recycle_Bin;
            this.TSB_Empty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Empty.Name = "TSB_Empty";
            this.TSB_Empty.Size = new System.Drawing.Size(107, 36);
            this.TSB_Empty.Text = "تفريغ الحقول";
            this.TSB_Empty.Click += new System.EventHandler(this.TSB_Empty_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // TSB_Exit_Stamp
            // 
            this.TSB_Exit_Stamp.Image = global::clinic.Properties.Resources.computer_remove;
            this.TSB_Exit_Stamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Exit_Stamp.Name = "TSB_Exit_Stamp";
            this.TSB_Exit_Stamp.Size = new System.Drawing.Size(71, 36);
            this.TSB_Exit_Stamp.Text = "اغلاق";
            this.TSB_Exit_Stamp.Click += new System.EventHandler(this.TSB_Exit_Stamp_Click);
            // 
            // GB_Stamp_info
            // 
            this.GB_Stamp_info.Controls.Add(this.txt_StampName);
            this.GB_Stamp_info.Controls.Add(this.txt_StampID);
            this.GB_Stamp_info.Controls.Add(this.Lbl_StampName);
            this.GB_Stamp_info.Controls.Add(this.Lbl_StampID);
            this.GB_Stamp_info.Controls.Add(this.PB_LogoStamp);
            this.GB_Stamp_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Stamp_info.Location = new System.Drawing.Point(3, 48);
            this.GB_Stamp_info.Name = "GB_Stamp_info";
            this.GB_Stamp_info.Size = new System.Drawing.Size(649, 111);
            this.GB_Stamp_info.TabIndex = 2;
            this.GB_Stamp_info.TabStop = false;
            this.GB_Stamp_info.Text = "العلامات :";
            // 
            // txt_StampName
            // 
            this.txt_StampName.Location = new System.Drawing.Point(224, 64);
            this.txt_StampName.Name = "txt_StampName";
            this.txt_StampName.Size = new System.Drawing.Size(164, 20);
            this.txt_StampName.TabIndex = 4;
            // 
            // txt_StampID
            // 
            this.txt_StampID.Location = new System.Drawing.Point(224, 34);
            this.txt_StampID.Name = "txt_StampID";
            this.txt_StampID.ReadOnly = true;
            this.txt_StampID.Size = new System.Drawing.Size(164, 20);
            this.txt_StampID.TabIndex = 3;
            // 
            // Lbl_StampName
            // 
            this.Lbl_StampName.AutoSize = true;
            this.Lbl_StampName.Location = new System.Drawing.Point(400, 65);
            this.Lbl_StampName.Name = "Lbl_StampName";
            this.Lbl_StampName.Size = new System.Drawing.Size(71, 13);
            this.Lbl_StampName.TabIndex = 2;
            this.Lbl_StampName.Text = "اسم العلامة :";
            // 
            // Lbl_StampID
            // 
            this.Lbl_StampID.AutoSize = true;
            this.Lbl_StampID.Location = new System.Drawing.Point(400, 34);
            this.Lbl_StampID.Name = "Lbl_StampID";
            this.Lbl_StampID.Size = new System.Drawing.Size(66, 13);
            this.Lbl_StampID.TabIndex = 1;
            this.Lbl_StampID.Text = "رقم العلامة :";
            // 
            // PB_LogoStamp
            // 
            this.PB_LogoStamp.Dock = System.Windows.Forms.DockStyle.Right;
            this.PB_LogoStamp.Location = new System.Drawing.Point(546, 16);
            this.PB_LogoStamp.Name = "PB_LogoStamp";
            this.PB_LogoStamp.Size = new System.Drawing.Size(100, 92);
            this.PB_LogoStamp.TabIndex = 0;
            this.PB_LogoStamp.TabStop = false;
            // 
            // GB_Search_Stamp
            // 
            this.GB_Search_Stamp.Controls.Add(this.PB_ImageSeach);
            this.GB_Search_Stamp.Controls.Add(this.btn_Search);
            this.GB_Search_Stamp.Controls.Add(this.txt_Search);
            this.GB_Search_Stamp.Controls.Add(this.Lbl_Search);
            this.GB_Search_Stamp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Search_Stamp.Location = new System.Drawing.Point(3, 165);
            this.GB_Search_Stamp.Name = "GB_Search_Stamp";
            this.GB_Search_Stamp.Size = new System.Drawing.Size(649, 105);
            this.GB_Search_Stamp.TabIndex = 3;
            this.GB_Search_Stamp.TabStop = false;
            this.GB_Search_Stamp.Text = "بحث :";
            // 
            // PB_ImageSeach
            // 
            this.PB_ImageSeach.Dock = System.Windows.Forms.DockStyle.Right;
            this.PB_ImageSeach.Image = global::clinic.Properties.Resources.Search;
            this.PB_ImageSeach.Location = new System.Drawing.Point(564, 16);
            this.PB_ImageSeach.Name = "PB_ImageSeach";
            this.PB_ImageSeach.Size = new System.Drawing.Size(82, 86);
            this.PB_ImageSeach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_ImageSeach.TabIndex = 4;
            this.PB_ImageSeach.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(275, 68);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(70, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(228, 35);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(164, 20);
            this.txt_Search.TabIndex = 2;
            // 
            // Lbl_Search
            // 
            this.Lbl_Search.AutoSize = true;
            this.Lbl_Search.Location = new System.Drawing.Point(400, 38);
            this.Lbl_Search.Name = "Lbl_Search";
            this.Lbl_Search.Size = new System.Drawing.Size(71, 13);
            this.Lbl_Search.TabIndex = 1;
            this.Lbl_Search.Text = "اسم العلامة :";
            // 
            // DGV_Stamp
            // 
            this.DGV_Stamp.AllowUserToAddRows = false;
            this.DGV_Stamp.AllowUserToDeleteRows = false;
            this.DGV_Stamp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Stamp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StampID,
            this.StampName});
            this.DGV_Stamp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Stamp.Location = new System.Drawing.Point(3, 276);
            this.DGV_Stamp.Name = "DGV_Stamp";
            this.DGV_Stamp.ReadOnly = true;
            this.DGV_Stamp.Size = new System.Drawing.Size(649, 150);
            this.DGV_Stamp.TabIndex = 4;
            this.DGV_Stamp.DoubleClick += new System.EventHandler(this.DGV_Stamp_DoubleClick);
            // 
            // StampID
            // 
            this.StampID.DataPropertyName = "StampID";
            this.StampID.HeaderText = "رقم العلامة";
            this.StampID.Name = "StampID";
            this.StampID.ReadOnly = true;
            // 
            // StampName
            // 
            this.StampName.DataPropertyName = "StampName";
            this.StampName.HeaderText = "اسم العلامة";
            this.StampName.Name = "StampName";
            this.StampName.ReadOnly = true;
            // 
            // FrmStamptype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 429);
            this.Controls.Add(this.TLP_Stamp);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 467);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(671, 467);
            this.Name = "FrmStamptype";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العلامات";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmStamptype_Load);
            this.TLP_Stamp.ResumeLayout(false);
            this.TS_Stamp.ResumeLayout(false);
            this.TS_Stamp.PerformLayout();
            this.GB_Stamp_info.ResumeLayout(false);
            this.GB_Stamp_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoStamp)).EndInit();
            this.GB_Search_Stamp.ResumeLayout(false);
            this.GB_Search_Stamp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ImageSeach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stamp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_Stamp;
        private System.Windows.Forms.ToolStrip TS_Stamp;
        private System.Windows.Forms.GroupBox GB_Stamp_info;
        private System.Windows.Forms.GroupBox GB_Search_Stamp;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label Lbl_Search;
        private System.Windows.Forms.PictureBox PB_ImageSeach;
        private System.Windows.Forms.DataGridView DGV_Stamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn StampID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StampName;
        private System.Windows.Forms.PictureBox PB_LogoStamp;
        private System.Windows.Forms.TextBox txt_StampName;
        private System.Windows.Forms.TextBox txt_StampID;
        private System.Windows.Forms.Label Lbl_StampName;
        private System.Windows.Forms.Label Lbl_StampID;
        private System.Windows.Forms.ToolStripButton TSB_Add_Stamp;
        private System.Windows.Forms.ToolStripButton TSB_Update_Stamp;
        private System.Windows.Forms.ToolStripButton TSB_Delete_Stamp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSB_Exit_Stamp;
        private System.Windows.Forms.ToolStripButton TSB_Empty;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}