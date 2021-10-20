namespace clinic.Analysis
{
    partial class FrmAnalysis
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGV_Analysis_All = new System.Windows.Forms.DataGridView();
            this.AnalysisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analysis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GB_Analysis_Info = new System.Windows.Forms.GroupBox();
            this.txt_PatientInher = new System.Windows.Forms.TextBox();
            this.Cmb_PatientName_1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_AnalysisID = new System.Windows.Forms.TextBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.Cmb_AnalysisTypeID = new System.Windows.Forms.ComboBox();
            this.lbl_AnalysisType = new System.Windows.Forms.Label();
            this.Cmb_VisitID = new System.Windows.Forms.ComboBox();
            this.lbl_VisitID = new System.Windows.Forms.Label();
            this.lbl_PAtient_FullName = new System.Windows.Forms.Label();
            this.TS_Analysis = new System.Windows.Forms.ToolStrip();
            this.TS_Add_Anlysis = new System.Windows.Forms.ToolStripButton();
            this.TS_UpDate_Analysis = new System.Windows.Forms.ToolStripButton();
            this.TS_Delete_Analysis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Report_2 = new System.Windows.Forms.ToolStripSplitButton();
            this.Ts_ReportForPatientId = new System.Windows.Forms.ToolStripMenuItem();
            this.Ts_ReportForPatientIDS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Clear_TooLs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_BAck = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Analysis_All)).BeginInit();
            this.GB_Analysis_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TS_Analysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DGV_Analysis_All, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.GB_Analysis_Info, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TS_Analysis, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.63461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.36539F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 427);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGV_Analysis_All
            // 
            this.DGV_Analysis_All.AllowUserToAddRows = false;
            this.DGV_Analysis_All.AllowUserToDeleteRows = false;
            this.DGV_Analysis_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Analysis_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnalysisID,
            this.FirstName,
            this.DataOfVisit,
            this.Analysis,
            this.AnalysisTypeID,
            this.AnalysisSubject,
            this.AnalysisResult,
            this.VisitID,
            this.PatientID});
            this.DGV_Analysis_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Analysis_All.Location = new System.Drawing.Point(3, 194);
            this.DGV_Analysis_All.Name = "DGV_Analysis_All";
            this.DGV_Analysis_All.ReadOnly = true;
            this.DGV_Analysis_All.Size = new System.Drawing.Size(649, 230);
            this.DGV_Analysis_All.TabIndex = 1;
            this.DGV_Analysis_All.Click += new System.EventHandler(this.DGV_Analysis_All_Click);
            // 
            // AnalysisID
            // 
            this.AnalysisID.DataPropertyName = "AnalysisID";
            this.AnalysisID.HeaderText = "رقم التحليل";
            this.AnalysisID.Name = "AnalysisID";
            this.AnalysisID.ReadOnly = true;
            this.AnalysisID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "اسم المريض";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // DataOfVisit
            // 
            this.DataOfVisit.DataPropertyName = "DataOfVisit";
            this.DataOfVisit.HeaderText = "تاريخ الزيارة";
            this.DataOfVisit.Name = "DataOfVisit";
            this.DataOfVisit.ReadOnly = true;
            // 
            // Analysis
            // 
            this.Analysis.DataPropertyName = "Analysis";
            this.Analysis.HeaderText = "نوع التحليل";
            this.Analysis.Name = "Analysis";
            this.Analysis.ReadOnly = true;
            // 
            // AnalysisTypeID
            // 
            this.AnalysisTypeID.DataPropertyName = "AnalysisTypeID";
            this.AnalysisTypeID.HeaderText = "رقم نوع التحليل ";
            this.AnalysisTypeID.Name = "AnalysisTypeID";
            this.AnalysisTypeID.ReadOnly = true;
            this.AnalysisTypeID.Visible = false;
            // 
            // AnalysisSubject
            // 
            this.AnalysisSubject.DataPropertyName = "AnalysisSubject";
            this.AnalysisSubject.HeaderText = "موضوع التحليل";
            this.AnalysisSubject.Name = "AnalysisSubject";
            this.AnalysisSubject.ReadOnly = true;
            // 
            // AnalysisResult
            // 
            this.AnalysisResult.DataPropertyName = "AnalysisResult";
            this.AnalysisResult.HeaderText = "نتيجة التحليل";
            this.AnalysisResult.Name = "AnalysisResult";
            this.AnalysisResult.ReadOnly = true;
            this.AnalysisResult.Width = 125;
            // 
            // VisitID
            // 
            this.VisitID.DataPropertyName = "VisitID";
            this.VisitID.HeaderText = "رقم  الزياره";
            this.VisitID.Name = "VisitID";
            this.VisitID.ReadOnly = true;
            this.VisitID.Visible = false;
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "رقم المريض";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Visible = false;
            // 
            // GB_Analysis_Info
            // 
            this.GB_Analysis_Info.Controls.Add(this.txt_PatientInher);
            this.GB_Analysis_Info.Controls.Add(this.Cmb_PatientName_1);
            this.GB_Analysis_Info.Controls.Add(this.pictureBox1);
            this.GB_Analysis_Info.Controls.Add(this.txt_AnalysisID);
            this.GB_Analysis_Info.Controls.Add(this.txt_Result);
            this.GB_Analysis_Info.Controls.Add(this.lbl_Result);
            this.GB_Analysis_Info.Controls.Add(this.txt_Subject);
            this.GB_Analysis_Info.Controls.Add(this.lbl_Subject);
            this.GB_Analysis_Info.Controls.Add(this.Cmb_AnalysisTypeID);
            this.GB_Analysis_Info.Controls.Add(this.lbl_AnalysisType);
            this.GB_Analysis_Info.Controls.Add(this.Cmb_VisitID);
            this.GB_Analysis_Info.Controls.Add(this.lbl_VisitID);
            this.GB_Analysis_Info.Controls.Add(this.lbl_PAtient_FullName);
            this.GB_Analysis_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Analysis_Info.Location = new System.Drawing.Point(3, 44);
            this.GB_Analysis_Info.Name = "GB_Analysis_Info";
            this.GB_Analysis_Info.Size = new System.Drawing.Size(649, 144);
            this.GB_Analysis_Info.TabIndex = 0;
            this.GB_Analysis_Info.TabStop = false;
            this.GB_Analysis_Info.Text = "بيانات التحليل:";
            // 
            // txt_PatientInher
            // 
            this.txt_PatientInher.Location = new System.Drawing.Point(367, 12);
            this.txt_PatientInher.Name = "txt_PatientInher";
            this.txt_PatientInher.Size = new System.Drawing.Size(48, 20);
            this.txt_PatientInher.TabIndex = 13;
            this.txt_PatientInher.Visible = false;
            // 
            // Cmb_PatientName_1
            // 
            this.Cmb_PatientName_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_PatientName_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_PatientName_1.FormattingEnabled = true;
            this.Cmb_PatientName_1.Location = new System.Drawing.Point(261, 38);
            this.Cmb_PatientName_1.Name = "Cmb_PatientName_1";
            this.Cmb_PatientName_1.Size = new System.Drawing.Size(168, 21);
            this.Cmb_PatientName_1.TabIndex = 12;
            this.Cmb_PatientName_1.SelectedIndexChanged += new System.EventHandler(this.Cmb_PatientName_1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::clinic.Properties.Resources.microscope_128_hot;
            this.pictureBox1.Location = new System.Drawing.Point(516, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 125);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txt_AnalysisID
            // 
            this.txt_AnalysisID.Location = new System.Drawing.Point(147, 10);
            this.txt_AnalysisID.Name = "txt_AnalysisID";
            this.txt_AnalysisID.ReadOnly = true;
            this.txt_AnalysisID.Size = new System.Drawing.Size(19, 20);
            this.txt_AnalysisID.TabIndex = 10;
            this.txt_AnalysisID.Visible = false;
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(21, 109);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(408, 20);
            this.txt_Result.TabIndex = 9;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(435, 109);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(42, 13);
            this.lbl_Result.TabIndex = 8;
            this.lbl_Result.Text = "النتيجة:";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(21, 72);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(143, 20);
            this.txt_Subject.TabIndex = 7;
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(170, 75);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(79, 13);
            this.lbl_Subject.TabIndex = 6;
            this.lbl_Subject.Text = "موضوع التحليل:";
            // 
            // Cmb_AnalysisTypeID
            // 
            this.Cmb_AnalysisTypeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_AnalysisTypeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_AnalysisTypeID.FormattingEnabled = true;
            this.Cmb_AnalysisTypeID.Location = new System.Drawing.Point(261, 72);
            this.Cmb_AnalysisTypeID.Name = "Cmb_AnalysisTypeID";
            this.Cmb_AnalysisTypeID.Size = new System.Drawing.Size(168, 21);
            this.Cmb_AnalysisTypeID.TabIndex = 5;
            // 
            // lbl_AnalysisType
            // 
            this.lbl_AnalysisType.AutoSize = true;
            this.lbl_AnalysisType.Location = new System.Drawing.Point(435, 75);
            this.lbl_AnalysisType.Name = "lbl_AnalysisType";
            this.lbl_AnalysisType.Size = new System.Drawing.Size(62, 13);
            this.lbl_AnalysisType.TabIndex = 4;
            this.lbl_AnalysisType.Text = "نوع التحليل:";
            // 
            // Cmb_VisitID
            // 
            this.Cmb_VisitID.FormattingEnabled = true;
            this.Cmb_VisitID.Location = new System.Drawing.Point(21, 36);
            this.Cmb_VisitID.Name = "Cmb_VisitID";
            this.Cmb_VisitID.Size = new System.Drawing.Size(143, 21);
            this.Cmb_VisitID.TabIndex = 3;
            // 
            // lbl_VisitID
            // 
            this.lbl_VisitID.AutoSize = true;
            this.lbl_VisitID.Location = new System.Drawing.Point(173, 41);
            this.lbl_VisitID.Name = "lbl_VisitID";
            this.lbl_VisitID.Size = new System.Drawing.Size(37, 13);
            this.lbl_VisitID.TabIndex = 2;
            this.lbl_VisitID.Text = "الزياره:";
            // 
            // lbl_PAtient_FullName
            // 
            this.lbl_PAtient_FullName.AutoSize = true;
            this.lbl_PAtient_FullName.Location = new System.Drawing.Point(435, 40);
            this.lbl_PAtient_FullName.Name = "lbl_PAtient_FullName";
            this.lbl_PAtient_FullName.Size = new System.Drawing.Size(70, 13);
            this.lbl_PAtient_FullName.TabIndex = 0;
            this.lbl_PAtient_FullName.Text = "اسم المريض:";
            // 
            // TS_Analysis
            // 
            this.TS_Analysis.AutoSize = false;
            this.TS_Analysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Analysis.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_Analysis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add_Anlysis,
            this.TS_UpDate_Analysis,
            this.TS_Delete_Analysis,
            this.toolStripSeparator1,
            this.TS_Report_2,
            this.toolStripSeparator2,
            this.btn_Clear_TooLs,
            this.toolStripSeparator3,
            this.TS_BAck});
            this.TS_Analysis.Location = new System.Drawing.Point(0, 0);
            this.TS_Analysis.Name = "TS_Analysis";
            this.TS_Analysis.Size = new System.Drawing.Size(655, 40);
            this.TS_Analysis.TabIndex = 2;
            // 
            // TS_Add_Anlysis
            // 
            this.TS_Add_Anlysis.Image = global::clinic.Properties.Resources.add;
            this.TS_Add_Anlysis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add_Anlysis.Name = "TS_Add_Anlysis";
            this.TS_Add_Anlysis.Size = new System.Drawing.Size(97, 37);
            this.TS_Add_Anlysis.Text = "اضافة تحليل";
            this.TS_Add_Anlysis.Click += new System.EventHandler(this.TS_Add_Anlysis_Click);
            // 
            // TS_UpDate_Analysis
            // 
            this.TS_UpDate_Analysis.Image = global::clinic.Properties.Resources.accept;
            this.TS_UpDate_Analysis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_UpDate_Analysis.Name = "TS_UpDate_Analysis";
            this.TS_UpDate_Analysis.Size = new System.Drawing.Size(60, 37);
            this.TS_UpDate_Analysis.Text = "تعديل";
            this.TS_UpDate_Analysis.Click += new System.EventHandler(this.TS_UpDate_Analysis_Click);
            // 
            // TS_Delete_Analysis
            // 
            this.TS_Delete_Analysis.Image = global::clinic.Properties.Resources.remove;
            this.TS_Delete_Analysis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Delete_Analysis.Name = "TS_Delete_Analysis";
            this.TS_Delete_Analysis.Size = new System.Drawing.Size(59, 37);
            this.TS_Delete_Analysis.Text = "حذف";
            this.TS_Delete_Analysis.Click += new System.EventHandler(this.TS_Delete_Analysis_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // TS_Report_2
            // 
            this.TS_Report_2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ts_ReportForPatientId,
            this.Ts_ReportForPatientIDS});
            this.TS_Report_2.Image = global::clinic.Properties.Resources.notes_editb;
            this.TS_Report_2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Report_2.Name = "TS_Report_2";
            this.TS_Report_2.Size = new System.Drawing.Size(78, 37);
            this.TS_Report_2.Text = "تقارير";
            // 
            // Ts_ReportForPatientId
            // 
            this.Ts_ReportForPatientId.Name = "Ts_ReportForPatientId";
            this.Ts_ReportForPatientId.Size = new System.Drawing.Size(186, 24);
            this.Ts_ReportForPatientId.Text = "حسب اسم المريض";
            this.Ts_ReportForPatientId.Click += new System.EventHandler(this.Ts_ReportForPatientId_Click);
            // 
            // Ts_ReportForPatientIDS
            // 
            this.Ts_ReportForPatientIDS.Name = "Ts_ReportForPatientIDS";
            this.Ts_ReportForPatientIDS.Size = new System.Drawing.Size(186, 24);
            this.Ts_ReportForPatientIDS.Text = "حسب اسماء المرضى";
            this.Ts_ReportForPatientIDS.Click += new System.EventHandler(this.Ts_ReportForPatientIDS_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // btn_Clear_TooLs
            // 
            this.btn_Clear_TooLs.Image = global::clinic.Properties.Resources.Empty_Recycle_Bin;
            this.btn_Clear_TooLs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Clear_TooLs.Name = "btn_Clear_TooLs";
            this.btn_Clear_TooLs.Size = new System.Drawing.Size(100, 37);
            this.btn_Clear_TooLs.Text = "تفريغ الحقول";
            this.btn_Clear_TooLs.Click += new System.EventHandler(this.btn_Clear_TooLs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // TS_BAck
            // 
            this.TS_BAck.Image = global::clinic.Properties.Resources.computer_remove;
            this.TS_BAck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_BAck.Name = "TS_BAck";
            this.TS_BAck.Size = new System.Drawing.Size(57, 37);
            this.TS_BAck.Text = "خلف";
            this.TS_BAck.Click += new System.EventHandler(this.TS_BAck_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "التحاليل";
            // 
            // FrmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 465);
            this.MinimumSize = new System.Drawing.Size(671, 465);
            this.Name = "FrmAnalysis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التحاليل";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAnalysis_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Analysis_All)).EndInit();
            this.GB_Analysis_Info.ResumeLayout(false);
            this.GB_Analysis_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TS_Analysis.ResumeLayout(false);
            this.TS_Analysis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GB_Analysis_Info;
        private System.Windows.Forms.Label lbl_PAtient_FullName;
        private System.Windows.Forms.DataGridView DGV_Analysis_All;
        private System.Windows.Forms.ComboBox Cmb_AnalysisTypeID;
        private System.Windows.Forms.Label lbl_AnalysisType;
        private System.Windows.Forms.ComboBox Cmb_VisitID;
        private System.Windows.Forms.Label lbl_VisitID;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.ToolStrip TS_Analysis;
        private System.Windows.Forms.ToolStripButton TS_Add_Anlysis;
        private System.Windows.Forms.ToolStripButton TS_UpDate_Analysis;
        private System.Windows.Forms.ToolStripButton TS_Delete_Analysis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TS_BAck;
        private System.Windows.Forms.TextBox txt_AnalysisID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSplitButton TS_Report_2;
        private System.Windows.Forms.ComboBox Cmb_PatientName_1;
        private System.Windows.Forms.ToolStripMenuItem Ts_ReportForPatientId;
        private System.Windows.Forms.ToolStripMenuItem Ts_ReportForPatientIDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalysisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataOfVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Analysis;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalysisTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalysisSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalysisResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.ToolStripButton btn_Clear_TooLs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox txt_PatientInher;
    }
}