namespace clinic.FrmAccident
{
    partial class FrmAccidentType
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
            this.TLP_Accident = new System.Windows.Forms.TableLayoutPanel();
            this.TS_Accident = new System.Windows.Forms.ToolStrip();
            this.TSB_Add_Accident = new System.Windows.Forms.ToolStripButton();
            this.TSB_UpDate_Accident = new System.Windows.Forms.ToolStripButton();
            this.TSB_Delete_Accident = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Empty_Accident = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Exit = new System.Windows.Forms.ToolStripButton();
            this.GB_AccidentInfo = new System.Windows.Forms.GroupBox();
            this.txt_AccidentName = new System.Windows.Forms.TextBox();
            this.txt_AccidentID = new System.Windows.Forms.TextBox();
            this.Lbl_AccidentName = new System.Windows.Forms.Label();
            this.Lbl_AccidentID = new System.Windows.Forms.Label();
            this.PIC_logo = new System.Windows.Forms.PictureBox();
            this.GB_Search = new System.Windows.Forms.GroupBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.Lbl_Search = new System.Windows.Forms.Label();
            this.PIC_Search = new System.Windows.Forms.PictureBox();
            this.DGV_Accident = new System.Windows.Forms.DataGridView();
            this.AccidentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccidentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TLP_Accident.SuspendLayout();
            this.TS_Accident.SuspendLayout();
            this.GB_AccidentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_logo)).BeginInit();
            this.GB_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Accident)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP_Accident
            // 
            this.TLP_Accident.ColumnCount = 1;
            this.TLP_Accident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Accident.Controls.Add(this.TS_Accident, 0, 0);
            this.TLP_Accident.Controls.Add(this.GB_AccidentInfo, 0, 1);
            this.TLP_Accident.Controls.Add(this.GB_Search, 0, 2);
            this.TLP_Accident.Controls.Add(this.DGV_Accident, 0, 3);
            this.TLP_Accident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Accident.Location = new System.Drawing.Point(0, 0);
            this.TLP_Accident.Name = "TLP_Accident";
            this.TLP_Accident.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TLP_Accident.RowCount = 4;
            this.TLP_Accident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.25698F));
            this.TLP_Accident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.74302F));
            this.TLP_Accident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.TLP_Accident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.TLP_Accident.Size = new System.Drawing.Size(655, 429);
            this.TLP_Accident.TabIndex = 0;
            // 
            // TS_Accident
            // 
            this.TS_Accident.AutoSize = false;
            this.TS_Accident.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Accident.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.TS_Accident.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Add_Accident,
            this.TSB_UpDate_Accident,
            this.TSB_Delete_Accident,
            this.toolStripSeparator1,
            this.TSB_Empty_Accident,
            this.toolStripSeparator2,
            this.TSB_Exit});
            this.TS_Accident.Location = new System.Drawing.Point(0, 0);
            this.TS_Accident.Name = "TS_Accident";
            this.TS_Accident.Size = new System.Drawing.Size(655, 39);
            this.TS_Accident.TabIndex = 0;
            this.TS_Accident.Text = "toolStrip1";
            // 
            // TSB_Add_Accident
            // 
            this.TSB_Add_Accident.Image = global::clinic.Properties.Resources.add;
            this.TSB_Add_Accident.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Add_Accident.Name = "TSB_Add_Accident";
            this.TSB_Add_Accident.Size = new System.Drawing.Size(72, 36);
            this.TSB_Add_Accident.Text = "اضافه";
            this.TSB_Add_Accident.Click += new System.EventHandler(this.TSB_Add_Accident_Click);
            // 
            // TSB_UpDate_Accident
            // 
            this.TSB_UpDate_Accident.Image = global::clinic.Properties.Resources.accept;
            this.TSB_UpDate_Accident.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_UpDate_Accident.Name = "TSB_UpDate_Accident";
            this.TSB_UpDate_Accident.Size = new System.Drawing.Size(66, 36);
            this.TSB_UpDate_Accident.Text = "تعديل";
            this.TSB_UpDate_Accident.Click += new System.EventHandler(this.TSB_UpDate_Accident_Click);
            // 
            // TSB_Delete_Accident
            // 
            this.TSB_Delete_Accident.Image = global::clinic.Properties.Resources.remove;
            this.TSB_Delete_Accident.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Delete_Accident.Name = "TSB_Delete_Accident";
            this.TSB_Delete_Accident.Size = new System.Drawing.Size(66, 36);
            this.TSB_Delete_Accident.Text = "حذف";
            this.TSB_Delete_Accident.Click += new System.EventHandler(this.TSB_Delete_Accident_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // TSB_Empty_Accident
            // 
            this.TSB_Empty_Accident.Image = global::clinic.Properties.Resources.Empty_Recycle_Bin;
            this.TSB_Empty_Accident.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Empty_Accident.Name = "TSB_Empty_Accident";
            this.TSB_Empty_Accident.Size = new System.Drawing.Size(108, 36);
            this.TSB_Empty_Accident.Text = "تغريغ الحقول";
            this.TSB_Empty_Accident.Click += new System.EventHandler(this.TSB_Empty_Accident_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // TSB_Exit
            // 
            this.TSB_Exit.Image = global::clinic.Properties.Resources.computer_remove;
            this.TSB_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Exit.Name = "TSB_Exit";
            this.TSB_Exit.Size = new System.Drawing.Size(71, 36);
            this.TSB_Exit.Text = "اغلاق";
            this.TSB_Exit.Click += new System.EventHandler(this.TSB_Exit_Click);
            // 
            // GB_AccidentInfo
            // 
            this.GB_AccidentInfo.Controls.Add(this.txt_AccidentName);
            this.GB_AccidentInfo.Controls.Add(this.txt_AccidentID);
            this.GB_AccidentInfo.Controls.Add(this.Lbl_AccidentName);
            this.GB_AccidentInfo.Controls.Add(this.Lbl_AccidentID);
            this.GB_AccidentInfo.Controls.Add(this.PIC_logo);
            this.GB_AccidentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_AccidentInfo.Location = new System.Drawing.Point(3, 50);
            this.GB_AccidentInfo.Name = "GB_AccidentInfo";
            this.GB_AccidentInfo.Size = new System.Drawing.Size(649, 126);
            this.GB_AccidentInfo.TabIndex = 1;
            this.GB_AccidentInfo.TabStop = false;
            this.GB_AccidentInfo.Text = "الاعراض :";
            // 
            // txt_AccidentName
            // 
            this.txt_AccidentName.Location = new System.Drawing.Point(235, 71);
            this.txt_AccidentName.Name = "txt_AccidentName";
            this.txt_AccidentName.Size = new System.Drawing.Size(171, 20);
            this.txt_AccidentName.TabIndex = 4;
            // 
            // txt_AccidentID
            // 
            this.txt_AccidentID.Location = new System.Drawing.Point(235, 38);
            this.txt_AccidentID.Name = "txt_AccidentID";
            this.txt_AccidentID.ReadOnly = true;
            this.txt_AccidentID.Size = new System.Drawing.Size(171, 20);
            this.txt_AccidentID.TabIndex = 3;
            // 
            // Lbl_AccidentName
            // 
            this.Lbl_AccidentName.AutoSize = true;
            this.Lbl_AccidentName.Location = new System.Drawing.Point(415, 74);
            this.Lbl_AccidentName.Name = "Lbl_AccidentName";
            this.Lbl_AccidentName.Size = new System.Drawing.Size(69, 13);
            this.Lbl_AccidentName.TabIndex = 2;
            this.Lbl_AccidentName.Text = "اسم العرض :";
            // 
            // Lbl_AccidentID
            // 
            this.Lbl_AccidentID.AutoSize = true;
            this.Lbl_AccidentID.Location = new System.Drawing.Point(415, 38);
            this.Lbl_AccidentID.Name = "Lbl_AccidentID";
            this.Lbl_AccidentID.Size = new System.Drawing.Size(64, 13);
            this.Lbl_AccidentID.TabIndex = 1;
            this.Lbl_AccidentID.Text = "رقم العرض :";
            // 
            // PIC_logo
            // 
            this.PIC_logo.Dock = System.Windows.Forms.DockStyle.Right;
            this.PIC_logo.Location = new System.Drawing.Point(546, 16);
            this.PIC_logo.Name = "PIC_logo";
            this.PIC_logo.Size = new System.Drawing.Size(100, 107);
            this.PIC_logo.TabIndex = 0;
            this.PIC_logo.TabStop = false;
            // 
            // GB_Search
            // 
            this.GB_Search.Controls.Add(this.txt_Search);
            this.GB_Search.Controls.Add(this.btn_Search);
            this.GB_Search.Controls.Add(this.Lbl_Search);
            this.GB_Search.Controls.Add(this.PIC_Search);
            this.GB_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Search.Location = new System.Drawing.Point(3, 182);
            this.GB_Search.Name = "GB_Search";
            this.GB_Search.Size = new System.Drawing.Size(649, 111);
            this.GB_Search.TabIndex = 2;
            this.GB_Search.TabStop = false;
            this.GB_Search.Text = "بحث :";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(235, 42);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(174, 20);
            this.txt_Search.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(286, 77);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Lbl_Search
            // 
            this.Lbl_Search.AutoSize = true;
            this.Lbl_Search.Location = new System.Drawing.Point(415, 49);
            this.Lbl_Search.Name = "Lbl_Search";
            this.Lbl_Search.Size = new System.Drawing.Size(69, 13);
            this.Lbl_Search.TabIndex = 1;
            this.Lbl_Search.Text = "اسم العرض :";
            // 
            // PIC_Search
            // 
            this.PIC_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.PIC_Search.Image = global::clinic.Properties.Resources.Search;
            this.PIC_Search.Location = new System.Drawing.Point(558, 16);
            this.PIC_Search.Name = "PIC_Search";
            this.PIC_Search.Size = new System.Drawing.Size(88, 92);
            this.PIC_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_Search.TabIndex = 0;
            this.PIC_Search.TabStop = false;
            // 
            // DGV_Accident
            // 
            this.DGV_Accident.AllowUserToAddRows = false;
            this.DGV_Accident.AllowUserToDeleteRows = false;
            this.DGV_Accident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Accident.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccidentID,
            this.AccidentName});
            this.DGV_Accident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Accident.Location = new System.Drawing.Point(3, 299);
            this.DGV_Accident.Name = "DGV_Accident";
            this.DGV_Accident.ReadOnly = true;
            this.DGV_Accident.Size = new System.Drawing.Size(649, 127);
            this.DGV_Accident.TabIndex = 3;
            this.DGV_Accident.DoubleClick += new System.EventHandler(this.DGV_Accident_DoubleClick);
            // 
            // AccidentID
            // 
            this.AccidentID.DataPropertyName = "AccidentID";
            this.AccidentID.HeaderText = "رقم العرض";
            this.AccidentID.Name = "AccidentID";
            this.AccidentID.ReadOnly = true;
            // 
            // AccidentName
            // 
            this.AccidentName.DataPropertyName = "AccidentName";
            this.AccidentName.HeaderText = "اسم العرض";
            this.AccidentName.Name = "AccidentName";
            this.AccidentName.ReadOnly = true;
            // 
            // FrmAccidentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 429);
            this.Controls.Add(this.TLP_Accident);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 467);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(671, 467);
            this.Name = "FrmAccidentType";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاعراض";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAccidentType_Load);
            this.TLP_Accident.ResumeLayout(false);
            this.TS_Accident.ResumeLayout(false);
            this.TS_Accident.PerformLayout();
            this.GB_AccidentInfo.ResumeLayout(false);
            this.GB_AccidentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_logo)).EndInit();
            this.GB_Search.ResumeLayout(false);
            this.GB_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Accident)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_Accident;
        private System.Windows.Forms.ToolStrip TS_Accident;
        private System.Windows.Forms.GroupBox GB_AccidentInfo;
        private System.Windows.Forms.TextBox txt_AccidentName;
        private System.Windows.Forms.TextBox txt_AccidentID;
        private System.Windows.Forms.Label Lbl_AccidentName;
        private System.Windows.Forms.Label Lbl_AccidentID;
        private System.Windows.Forms.PictureBox PIC_logo;
        private System.Windows.Forms.GroupBox GB_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label Lbl_Search;
        private System.Windows.Forms.PictureBox PIC_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView DGV_Accident;
        private System.Windows.Forms.ToolStripButton TSB_Add_Accident;
        private System.Windows.Forms.ToolStripButton TSB_UpDate_Accident;
        private System.Windows.Forms.ToolStripButton TSB_Delete_Accident;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSB_Empty_Accident;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSB_Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccidentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccidentName;
    }
}