namespace clinic.Analysis
{
    partial class FrmAnalysisType
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
            this.TS_AnalysisType = new System.Windows.Forms.ToolStrip();
            this.TS_Add_AnalysisType = new System.Windows.Forms.ToolStripButton();
            this.TS_UpData_AnalysisType = new System.Windows.Forms.ToolStripButton();
            this.TS_Delete_AnalysisType = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSS_Report = new System.Windows.Forms.ToolStripSplitButton();
            this.TSS_Report_All = new System.Windows.Forms.ToolStripMenuItem();
            this.TSS_Report_FlowChar = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_ImportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_BAckToMAin = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GB_AnalysisType = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_AnalysisTypeID = new System.Windows.Forms.TextBox();
            this.lbl_AnalysisTpyeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AnalysisType = new System.Windows.Forms.TextBox();
            this.lbl_AnalysisType = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GB_AnalysisSearch = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.DGV_AnalysisTpye = new System.Windows.Forms.DataGridView();
            this.AnalysisTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analysis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TS_AnalysisType.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GB_AnalysisType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.GB_AnalysisSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AnalysisTpye)).BeginInit();
            this.SuspendLayout();
            // 
            // TS_AnalysisType
            // 
            this.TS_AnalysisType.AutoSize = false;
            this.TS_AnalysisType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_AnalysisType.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_AnalysisType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add_AnalysisType,
            this.TS_UpData_AnalysisType,
            this.TS_Delete_AnalysisType,
            this.toolStripSeparator1,
            this.TSS_Report,
            this.TS_ImportExcel,
            this.toolStripSeparator2,
            this.TS_BAckToMAin});
            this.TS_AnalysisType.Location = new System.Drawing.Point(0, 0);
            this.TS_AnalysisType.Name = "TS_AnalysisType";
            this.TS_AnalysisType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TS_AnalysisType.Size = new System.Drawing.Size(655, 40);
            this.TS_AnalysisType.TabIndex = 0;
            this.TS_AnalysisType.Text = "TS_AnalysisType";
            // 
            // TS_Add_AnalysisType
            // 
            this.TS_Add_AnalysisType.Image = global::clinic.Properties.Resources.add;
            this.TS_Add_AnalysisType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add_AnalysisType.Name = "TS_Add_AnalysisType";
            this.TS_Add_AnalysisType.Size = new System.Drawing.Size(97, 37);
            this.TS_Add_AnalysisType.Text = "اضافة تحليل";
            this.TS_Add_AnalysisType.Click += new System.EventHandler(this.TS_Add_AnalysisType_Click);
            // 
            // TS_UpData_AnalysisType
            // 
            this.TS_UpData_AnalysisType.Image = global::clinic.Properties.Resources.accept;
            this.TS_UpData_AnalysisType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_UpData_AnalysisType.Name = "TS_UpData_AnalysisType";
            this.TS_UpData_AnalysisType.Size = new System.Drawing.Size(60, 37);
            this.TS_UpData_AnalysisType.Text = "تعديل";
            this.TS_UpData_AnalysisType.Click += new System.EventHandler(this.TS_UpData_AnalysisType_Click);
            // 
            // TS_Delete_AnalysisType
            // 
            this.TS_Delete_AnalysisType.Image = global::clinic.Properties.Resources.remove;
            this.TS_Delete_AnalysisType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Delete_AnalysisType.Name = "TS_Delete_AnalysisType";
            this.TS_Delete_AnalysisType.Size = new System.Drawing.Size(59, 37);
            this.TS_Delete_AnalysisType.Text = "حذف";
            this.TS_Delete_AnalysisType.Click += new System.EventHandler(this.TS_Delete_AnalysisType_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // TSS_Report
            // 
            this.TSS_Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSS_Report_All,
            this.TSS_Report_FlowChar});
            this.TSS_Report.Image = global::clinic.Properties.Resources.notes_edit;
            this.TSS_Report.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSS_Report.Name = "TSS_Report";
            this.TSS_Report.Size = new System.Drawing.Size(78, 37);
            this.TSS_Report.Text = "تقارير";
            // 
            // TSS_Report_All
            // 
            this.TSS_Report_All.Name = "TSS_Report_All";
            this.TSS_Report_All.Size = new System.Drawing.Size(199, 26);
            this.TSS_Report_All.Text = "تقرير باسماء التحاليل";
            this.TSS_Report_All.Click += new System.EventHandler(this.TSS_Report_All_Click);
            // 
            // TSS_Report_FlowChar
            // 
            this.TSS_Report_FlowChar.Image = global::clinic.Properties.Resources.chart;
            this.TSS_Report_FlowChar.Name = "TSS_Report_FlowChar";
            this.TSS_Report_FlowChar.Size = new System.Drawing.Size(199, 26);
            this.TSS_Report_FlowChar.Text = "تقرير احصائي للتحاليل";
            this.TSS_Report_FlowChar.Click += new System.EventHandler(this.TSS_Report_FlowChar_Click);
            // 
            // TS_ImportExcel
            // 
            this.TS_ImportExcel.Image = global::clinic.Properties.Resources.tdx_excel2__Custom_;
            this.TS_ImportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_ImportExcel.Name = "TS_ImportExcel";
            this.TS_ImportExcel.Size = new System.Drawing.Size(138, 37);
            this.TS_ImportExcel.Text = "استيراد ملف Excel";
            this.TS_ImportExcel.Click += new System.EventHandler(this.TS_ImportExcel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // TS_BAckToMAin
            // 
            this.TS_BAckToMAin.Image = global::clinic.Properties.Resources.computer_remove;
            this.TS_BAckToMAin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_BAckToMAin.Name = "TS_BAckToMAin";
            this.TS_BAckToMAin.Size = new System.Drawing.Size(64, 37);
            this.TS_BAckToMAin.Text = "اغلاق";
            this.TS_BAckToMAin.Click += new System.EventHandler(this.TS_BAckToMAin_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GB_AnalysisType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DGV_AnalysisTpye, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.42085F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.57915F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 387);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // GB_AnalysisType
            // 
            this.GB_AnalysisType.Controls.Add(this.pictureBox1);
            this.GB_AnalysisType.Controls.Add(this.txt_AnalysisTypeID);
            this.GB_AnalysisType.Controls.Add(this.lbl_AnalysisTpyeID);
            this.GB_AnalysisType.Controls.Add(this.label1);
            this.GB_AnalysisType.Controls.Add(this.txt_AnalysisType);
            this.GB_AnalysisType.Controls.Add(this.lbl_AnalysisType);
            this.GB_AnalysisType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_AnalysisType.Location = new System.Drawing.Point(3, 3);
            this.GB_AnalysisType.Name = "GB_AnalysisType";
            this.GB_AnalysisType.Size = new System.Drawing.Size(649, 120);
            this.GB_AnalysisType.TabIndex = 0;
            this.GB_AnalysisType.TabStop = false;
            this.GB_AnalysisType.Text = "بيانات التحاليل:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::clinic.Properties.Resources.wi0124_64;
            this.pictureBox1.Location = new System.Drawing.Point(546, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txt_AnalysisTypeID
            // 
            this.txt_AnalysisTypeID.Location = new System.Drawing.Point(292, 30);
            this.txt_AnalysisTypeID.Name = "txt_AnalysisTypeID";
            this.txt_AnalysisTypeID.ReadOnly = true;
            this.txt_AnalysisTypeID.Size = new System.Drawing.Size(100, 20);
            this.txt_AnalysisTypeID.TabIndex = 4;
            // 
            // lbl_AnalysisTpyeID
            // 
            this.lbl_AnalysisTpyeID.AutoSize = true;
            this.lbl_AnalysisTpyeID.Location = new System.Drawing.Point(418, 30);
            this.lbl_AnalysisTpyeID.Name = "lbl_AnalysisTpyeID";
            this.lbl_AnalysisTpyeID.Size = new System.Drawing.Size(64, 13);
            this.lbl_AnalysisTpyeID.TabIndex = 3;
            this.lbl_AnalysisTpyeID.Text = "رقم التحليل:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // txt_AnalysisType
            // 
            this.txt_AnalysisType.Location = new System.Drawing.Point(225, 71);
            this.txt_AnalysisType.Name = "txt_AnalysisType";
            this.txt_AnalysisType.Size = new System.Drawing.Size(182, 20);
            this.txt_AnalysisType.TabIndex = 1;
            // 
            // lbl_AnalysisType
            // 
            this.lbl_AnalysisType.AutoSize = true;
            this.lbl_AnalysisType.Location = new System.Drawing.Point(413, 74);
            this.lbl_AnalysisType.Name = "lbl_AnalysisType";
            this.lbl_AnalysisType.Size = new System.Drawing.Size(69, 13);
            this.lbl_AnalysisType.TabIndex = 0;
            this.lbl_AnalysisType.Text = "اسم التحليل:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.26028F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.739726F));
            this.tableLayoutPanel2.Controls.Add(this.GB_AnalysisSearch, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 129);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(649, 123);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // GB_AnalysisSearch
            // 
            this.GB_AnalysisSearch.Controls.Add(this.pictureBox2);
            this.GB_AnalysisSearch.Controls.Add(this.btn_Search);
            this.GB_AnalysisSearch.Controls.Add(this.txt_Search);
            this.GB_AnalysisSearch.Controls.Add(this.lbl_Search);
            this.GB_AnalysisSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_AnalysisSearch.Location = new System.Drawing.Point(21, 3);
            this.GB_AnalysisSearch.Name = "GB_AnalysisSearch";
            this.GB_AnalysisSearch.Size = new System.Drawing.Size(625, 117);
            this.GB_AnalysisSearch.TabIndex = 0;
            this.GB_AnalysisSearch.TabStop = false;
            this.GB_AnalysisSearch.Text = "بحث:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::clinic.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(522, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(263, 77);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(208, 51);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(186, 20);
            this.txt_Search.TabIndex = 1;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(400, 54);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(69, 13);
            this.lbl_Search.TabIndex = 0;
            this.lbl_Search.Text = "اسم التحليل:";
            this.lbl_Search.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGV_AnalysisTpye
            // 
            this.DGV_AnalysisTpye.AllowUserToAddRows = false;
            this.DGV_AnalysisTpye.AllowUserToDeleteRows = false;
            this.DGV_AnalysisTpye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AnalysisTpye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnalysisTypeID,
            this.Analysis});
            this.DGV_AnalysisTpye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_AnalysisTpye.Location = new System.Drawing.Point(3, 258);
            this.DGV_AnalysisTpye.Name = "DGV_AnalysisTpye";
            this.DGV_AnalysisTpye.ReadOnly = true;
            this.DGV_AnalysisTpye.Size = new System.Drawing.Size(649, 126);
            this.DGV_AnalysisTpye.TabIndex = 2;
            this.DGV_AnalysisTpye.Click += new System.EventHandler(this.DGV_AnalysisTpye_Click);
            // 
            // AnalysisTypeID
            // 
            this.AnalysisTypeID.DataPropertyName = "AnalysisTypeID";
            this.AnalysisTypeID.HeaderText = "رقم التحليل";
            this.AnalysisTypeID.Name = "AnalysisTypeID";
            this.AnalysisTypeID.ReadOnly = true;
            // 
            // Analysis
            // 
            this.Analysis.DataPropertyName = "Analysis";
            this.Analysis.HeaderText = "التحليل";
            this.Analysis.Name = "Analysis";
            this.Analysis.ReadOnly = true;
            this.Analysis.Width = 250;
            // 
            // FrmAnalysisType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TS_AnalysisType);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 465);
            this.MinimumSize = new System.Drawing.Size(671, 465);
            this.Name = "FrmAnalysisType";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انواع الحاليل";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAnalysisType_Load);
            this.TS_AnalysisType.ResumeLayout(false);
            this.TS_AnalysisType.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GB_AnalysisType.ResumeLayout(false);
            this.GB_AnalysisType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.GB_AnalysisSearch.ResumeLayout(false);
            this.GB_AnalysisSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AnalysisTpye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS_AnalysisType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GB_AnalysisType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox GB_AnalysisSearch;
        private System.Windows.Forms.DataGridView DGV_AnalysisTpye;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.ToolStripButton TS_Add_AnalysisType;
        private System.Windows.Forms.TextBox txt_AnalysisType;
        private System.Windows.Forms.Label lbl_AnalysisType;
        private System.Windows.Forms.ToolStripButton TS_UpData_AnalysisType;
        private System.Windows.Forms.ToolStripButton TS_Delete_AnalysisType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AnalysisTypeID;
        private System.Windows.Forms.Label lbl_AnalysisTpyeID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripSplitButton TSS_Report;
        private System.Windows.Forms.ToolStripMenuItem TSS_Report_All;
        private System.Windows.Forms.ToolStripMenuItem TSS_Report_FlowChar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TS_BAckToMAin;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalysisTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Analysis;
        private System.Windows.Forms.ToolStripButton TS_ImportExcel;
    }
}