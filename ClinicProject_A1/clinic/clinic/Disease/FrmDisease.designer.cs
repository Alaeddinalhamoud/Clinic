namespace clinic
{
    partial class FrmDisease
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
            this.GB_Disease_Info = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_Disease = new System.Windows.Forms.TextBox();
            this.txt_DiseaseID = new System.Windows.Forms.TextBox();
            this.lbl_Disease = new System.Windows.Forms.Label();
            this.lbl_DiseaseID = new System.Windows.Forms.Label();
            this.TS_Disease = new System.Windows.Forms.ToolStrip();
            this.TS_Add_Disease = new System.Windows.Forms.ToolStripButton();
            this.TS_Update_Disease = new System.Windows.Forms.ToolStripButton();
            this.TS_Delete_Disease = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSS_Report = new System.Windows.Forms.ToolStripSplitButton();
            this.TSS_Report_All = new System.Windows.Forms.ToolStripMenuItem();
            this.TSS_Report_Disiase_FlowChar = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_ImportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_BAck_To_Main = new System.Windows.Forms.ToolStripButton();
            this.DVG_Disease_All = new System.Windows.Forms.DataGridView();
            this.DiseaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.RD_btn_Disease = new System.Windows.Forms.RadioButton();
            this.RD_btn_DiseaseID = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GB_Search_Disease = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_TEXT = new System.Windows.Forms.Label();
            this.GB_Search_by = new System.Windows.Forms.GroupBox();
            this.GB_Disease_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TS_Disease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_Disease_All)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.GB_Search_Disease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GB_Search_by.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Disease_Info
            // 
            this.GB_Disease_Info.Controls.Add(this.pictureBox2);
            this.GB_Disease_Info.Controls.Add(this.txt_Disease);
            this.GB_Disease_Info.Controls.Add(this.txt_DiseaseID);
            this.GB_Disease_Info.Controls.Add(this.lbl_Disease);
            this.GB_Disease_Info.Controls.Add(this.lbl_DiseaseID);
            this.GB_Disease_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Disease_Info.Location = new System.Drawing.Point(3, 42);
            this.GB_Disease_Info.Name = "GB_Disease_Info";
            this.GB_Disease_Info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_Disease_Info.Size = new System.Drawing.Size(655, 109);
            this.GB_Disease_Info.TabIndex = 0;
            this.GB_Disease_Info.TabStop = false;
            this.GB_Disease_Info.Text = "بيانات المرض:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::clinic.Properties.Resources.Accessibility;
            this.pictureBox2.Location = new System.Drawing.Point(552, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // txt_Disease
            // 
            this.txt_Disease.Location = new System.Drawing.Point(261, 65);
            this.txt_Disease.Name = "txt_Disease";
            this.txt_Disease.Size = new System.Drawing.Size(165, 20);
            this.txt_Disease.TabIndex = 3;
            // 
            // txt_DiseaseID
            // 
            this.txt_DiseaseID.Location = new System.Drawing.Point(261, 39);
            this.txt_DiseaseID.Name = "txt_DiseaseID";
            this.txt_DiseaseID.ReadOnly = true;
            this.txt_DiseaseID.Size = new System.Drawing.Size(164, 20);
            this.txt_DiseaseID.TabIndex = 2;
            // 
            // lbl_Disease
            // 
            this.lbl_Disease.AutoSize = true;
            this.lbl_Disease.Location = new System.Drawing.Point(431, 72);
            this.lbl_Disease.Name = "lbl_Disease";
            this.lbl_Disease.Size = new System.Drawing.Size(42, 13);
            this.lbl_Disease.TabIndex = 1;
            this.lbl_Disease.Text = "المرض:";
            // 
            // lbl_DiseaseID
            // 
            this.lbl_DiseaseID.AutoSize = true;
            this.lbl_DiseaseID.Location = new System.Drawing.Point(431, 39);
            this.lbl_DiseaseID.Name = "lbl_DiseaseID";
            this.lbl_DiseaseID.Size = new System.Drawing.Size(62, 13);
            this.lbl_DiseaseID.TabIndex = 0;
            this.lbl_DiseaseID.Text = "رقم المرض:";
            // 
            // TS_Disease
            // 
            this.TS_Disease.AutoSize = false;
            this.TS_Disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Disease.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.TS_Disease.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add_Disease,
            this.TS_Update_Disease,
            this.TS_Delete_Disease,
            this.toolStripSeparator1,
            this.TSS_Report,
            this.TS_ImportExcel,
            this.toolStripSeparator2,
            this.TS_BAck_To_Main});
            this.TS_Disease.Location = new System.Drawing.Point(0, 0);
            this.TS_Disease.Name = "TS_Disease";
            this.TS_Disease.Size = new System.Drawing.Size(661, 39);
            this.TS_Disease.TabIndex = 3;
            this.TS_Disease.Text = "toolStrip1";
            // 
            // TS_Add_Disease
            // 
            this.TS_Add_Disease.Image = global::clinic.Properties.Resources.add;
            this.TS_Add_Disease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add_Disease.Name = "TS_Add_Disease";
            this.TS_Add_Disease.Size = new System.Drawing.Size(131, 36);
            this.TS_Add_Disease.Text = "اضافة مرض جديد";
            this.TS_Add_Disease.Click += new System.EventHandler(this.TS_Add_Disease_Click);
            // 
            // TS_Update_Disease
            // 
            this.TS_Update_Disease.Image = global::clinic.Properties.Resources.accept;
            this.TS_Update_Disease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Update_Disease.Name = "TS_Update_Disease";
            this.TS_Update_Disease.Size = new System.Drawing.Size(65, 36);
            this.TS_Update_Disease.Text = "تعديل";
            this.TS_Update_Disease.Click += new System.EventHandler(this.TS_Update_Disease_Click);
            // 
            // TS_Delete_Disease
            // 
            this.TS_Delete_Disease.Image = global::clinic.Properties.Resources.remove;
            this.TS_Delete_Disease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Delete_Disease.Name = "TS_Delete_Disease";
            this.TS_Delete_Disease.Size = new System.Drawing.Size(64, 36);
            this.TS_Delete_Disease.Text = "حذف";
            this.TS_Delete_Disease.ToolTipText = "حذف مرض";
            this.TS_Delete_Disease.Click += new System.EventHandler(this.TS_Delete_Disease_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // TSS_Report
            // 
            this.TSS_Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSS_Report_All,
            this.TSS_Report_Disiase_FlowChar});
            this.TSS_Report.Image = global::clinic.Properties.Resources.notes_edit;
            this.TSS_Report.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSS_Report.Name = "TSS_Report";
            this.TSS_Report.Size = new System.Drawing.Size(83, 36);
            this.TSS_Report.Text = "تقارير";
            // 
            // TSS_Report_All
            // 
            this.TSS_Report_All.Name = "TSS_Report_All";
            this.TSS_Report_All.Size = new System.Drawing.Size(226, 32);
            this.TSS_Report_All.Text = "تقرير باسماء الامراض..";
            this.TSS_Report_All.Click += new System.EventHandler(this.TSS_Report_All_Click);
            // 
            // TSS_Report_Disiase_FlowChar
            // 
            this.TSS_Report_Disiase_FlowChar.Image = global::clinic.Properties.Resources.chart;
            this.TSS_Report_Disiase_FlowChar.Name = "TSS_Report_Disiase_FlowChar";
            this.TSS_Report_Disiase_FlowChar.Size = new System.Drawing.Size(226, 32);
            this.TSS_Report_Disiase_FlowChar.Text = "تقرير احصائي بالامراض..";
            this.TSS_Report_Disiase_FlowChar.Click += new System.EventHandler(this.TSS_Report_Disiase_FlowChar_Click);
            // 
            // TS_ImportExcel
            // 
            this.TS_ImportExcel.Image = global::clinic.Properties.Resources.tdx_excel2__Custom_;
            this.TS_ImportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_ImportExcel.Name = "TS_ImportExcel";
            this.TS_ImportExcel.Size = new System.Drawing.Size(143, 36);
            this.TS_ImportExcel.Text = "استيراد ملف Excel";
            this.TS_ImportExcel.Click += new System.EventHandler(this.TS_ImportExcel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // TS_BAck_To_Main
            // 
            this.TS_BAck_To_Main.Image = global::clinic.Properties.Resources.computer_remove;
            this.TS_BAck_To_Main.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_BAck_To_Main.Name = "TS_BAck_To_Main";
            this.TS_BAck_To_Main.Size = new System.Drawing.Size(69, 36);
            this.TS_BAck_To_Main.Text = "اغلاق";
            this.TS_BAck_To_Main.Click += new System.EventHandler(this.TS_BAck_To_Main_Click);
            // 
            // DVG_Disease_All
            // 
            this.DVG_Disease_All.AllowUserToAddRows = false;
            this.DVG_Disease_All.AllowUserToDeleteRows = false;
            this.DVG_Disease_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVG_Disease_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiseaseID,
            this.DiseaseName});
            this.DVG_Disease_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVG_Disease_All.Location = new System.Drawing.Point(3, 264);
            this.DVG_Disease_All.Name = "DVG_Disease_All";
            this.DVG_Disease_All.ReadOnly = true;
            this.DVG_Disease_All.Size = new System.Drawing.Size(655, 152);
            this.DVG_Disease_All.TabIndex = 2;
            this.DVG_Disease_All.Click += new System.EventHandler(this.DVG_Disease_All_Click);
            // 
            // DiseaseID
            // 
            this.DiseaseID.DataPropertyName = "DiseaseID";
            this.DiseaseID.HeaderText = "رقم المرض";
            this.DiseaseID.Name = "DiseaseID";
            this.DiseaseID.ReadOnly = true;
            // 
            // DiseaseName
            // 
            this.DiseaseName.DataPropertyName = "DiseaseName";
            this.DiseaseName.HeaderText = "اسم المرض";
            this.DiseaseName.Name = "DiseaseName";
            this.DiseaseName.ReadOnly = true;
            this.DiseaseName.Width = 200;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(248, 35);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(164, 20);
            this.txt_Search.TabIndex = 0;
            // 
            // RD_btn_Disease
            // 
            this.RD_btn_Disease.AutoSize = true;
            this.RD_btn_Disease.Location = new System.Drawing.Point(17, 45);
            this.RD_btn_Disease.Name = "RD_btn_Disease";
            this.RD_btn_Disease.Size = new System.Drawing.Size(81, 17);
            this.RD_btn_Disease.TabIndex = 1;
            this.RD_btn_Disease.Text = "اسم المرض";
            this.RD_btn_Disease.UseVisualStyleBackColor = true;
            this.RD_btn_Disease.CheckedChanged += new System.EventHandler(this.RD_btn_Disease_CheckedChanged);
            // 
            // RD_btn_DiseaseID
            // 
            this.RD_btn_DiseaseID.AutoSize = true;
            this.RD_btn_DiseaseID.Checked = true;
            this.RD_btn_DiseaseID.Location = new System.Drawing.Point(23, 22);
            this.RD_btn_DiseaseID.Name = "RD_btn_DiseaseID";
            this.RD_btn_DiseaseID.Size = new System.Drawing.Size(76, 17);
            this.RD_btn_DiseaseID.TabIndex = 0;
            this.RD_btn_DiseaseID.TabStop = true;
            this.RD_btn_DiseaseID.Text = "رقم المرض";
            this.RD_btn_DiseaseID.UseVisualStyleBackColor = true;
            this.RD_btn_DiseaseID.CheckedChanged += new System.EventHandler(this.RD_btn_DiseaseID_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GB_Disease_Info, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TS_Disease, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DVG_Disease_All, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.76419F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.23581F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 419);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.62595F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.374046F));
            this.tableLayoutPanel2.Controls.Add(this.GB_Search_Disease, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 157);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(655, 101);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // GB_Search_Disease
            // 
            this.GB_Search_Disease.Controls.Add(this.pictureBox1);
            this.GB_Search_Disease.Controls.Add(this.btn_Search);
            this.GB_Search_Disease.Controls.Add(this.lbl_TEXT);
            this.GB_Search_Disease.Controls.Add(this.GB_Search_by);
            this.GB_Search_Disease.Controls.Add(this.txt_Search);
            this.GB_Search_Disease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Search_Disease.Location = new System.Drawing.Point(13, 3);
            this.GB_Search_Disease.Name = "GB_Search_Disease";
            this.GB_Search_Disease.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_Search_Disease.Size = new System.Drawing.Size(639, 95);
            this.GB_Search_Disease.TabIndex = 0;
            this.GB_Search_Disease.TabStop = false;
            this.GB_Search_Disease.Text = "بحث";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::clinic.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(318, 61);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(70, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_TEXT
            // 
            this.lbl_TEXT.AutoSize = true;
            this.lbl_TEXT.Location = new System.Drawing.Point(418, 38);
            this.lbl_TEXT.Name = "lbl_TEXT";
            this.lbl_TEXT.Size = new System.Drawing.Size(58, 13);
            this.lbl_TEXT.TabIndex = 2;
            this.lbl_TEXT.Text = "رقم المرض";
            // 
            // GB_Search_by
            // 
            this.GB_Search_by.Controls.Add(this.RD_btn_Disease);
            this.GB_Search_by.Controls.Add(this.RD_btn_DiseaseID);
            this.GB_Search_by.Dock = System.Windows.Forms.DockStyle.Right;
            this.GB_Search_by.Location = new System.Drawing.Point(513, 16);
            this.GB_Search_by.Name = "GB_Search_by";
            this.GB_Search_by.Size = new System.Drawing.Size(123, 76);
            this.GB_Search_by.TabIndex = 1;
            this.GB_Search_by.TabStop = false;
            this.GB_Search_by.Text = "بحث حسب";
            // 
            // FrmDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(671, 465);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 465);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(671, 465);
            this.Name = "FrmDisease";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الامراض";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmDisease_Load);
            this.GB_Disease_Info.ResumeLayout(false);
            this.GB_Disease_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TS_Disease.ResumeLayout(false);
            this.TS_Disease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_Disease_All)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.GB_Search_Disease.ResumeLayout(false);
            this.GB_Search_Disease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GB_Search_by.ResumeLayout(false);
            this.GB_Search_by.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Disease_Info;
        private System.Windows.Forms.TextBox txt_Disease;
        private System.Windows.Forms.TextBox txt_DiseaseID;
        private System.Windows.Forms.Label lbl_Disease;
        private System.Windows.Forms.Label lbl_DiseaseID;
        private System.Windows.Forms.ToolStripButton TS_Add_Disease;
        private System.Windows.Forms.ToolStripButton TS_Update_Disease;
        private System.Windows.Forms.ToolStrip TS_Disease;
        private System.Windows.Forms.ToolStripButton TS_Delete_Disease;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TS_BAck_To_Main;
        private System.Windows.Forms.DataGridView DVG_Disease_All;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.RadioButton RD_btn_Disease;
        private System.Windows.Forms.RadioButton RD_btn_DiseaseID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox GB_Search_Disease;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_TEXT;
        private System.Windows.Forms.GroupBox GB_Search_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripSplitButton TSS_Report;
        private System.Windows.Forms.ToolStripMenuItem TSS_Report_All;
        private System.Windows.Forms.ToolStripMenuItem TSS_Report_Disiase_FlowChar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TS_ImportExcel;
    }
}