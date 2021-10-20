namespace clinic.Radio
{
    partial class FrmRadio
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
            this.TS_Radio = new System.Windows.Forms.ToolStrip();
            this.TS_Add_RAdio = new System.Windows.Forms.ToolStripButton();
            this.TS_UpDate = new System.Windows.Forms.ToolStripButton();
            this.TS_Delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_EmaptyTools = new System.Windows.Forms.ToolStripButton();
            this.TS_Repo = new System.Windows.Forms.ToolStripSplitButton();
            this.Ts_Report_PatientID = new System.Windows.Forms.ToolStripMenuItem();
            this.Ts_PaientIDS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Back = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GB_Radio_Info = new System.Windows.Forms.GroupBox();
            this.txt_PateintInher = new System.Windows.Forms.TextBox();
            this.txt_Radio = new System.Windows.Forms.TextBox();
            this.txt_ImagePath = new System.Windows.Forms.TextBox();
            this.txt_RadioResult = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.Cmb_RadioType = new System.Windows.Forms.ComboBox();
            this.lbl_RadioTypeID = new System.Windows.Forms.Label();
            this.Cmb_VisitID = new System.Windows.Forms.ComboBox();
            this.lbl_VisitID = new System.Windows.Forms.Label();
            this.Cmb_PatientName = new System.Windows.Forms.ComboBox();
            this.lbl_Patient_Full = new System.Windows.Forms.Label();
            this.GB_Image = new System.Windows.Forms.GroupBox();
            this.PIC_X_RAY = new System.Windows.Forms.PictureBox();
            this.DGV_RAdio_All = new System.Windows.Forms.DataGridView();
            this.RadioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadioTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadioType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadioSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadioResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TS_Radio.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GB_Radio_Info.SuspendLayout();
            this.GB_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_X_RAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RAdio_All)).BeginInit();
            this.SuspendLayout();
            // 
            // TS_Radio
            // 
            this.TS_Radio.AutoSize = false;
            this.TS_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Radio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_Radio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add_RAdio,
            this.TS_UpDate,
            this.TS_Delete,
            this.toolStripSeparator1,
            this.TS_EmaptyTools,
            this.TS_Repo,
            this.toolStripSeparator2,
            this.TS_Back});
            this.TS_Radio.Location = new System.Drawing.Point(0, 0);
            this.TS_Radio.Name = "TS_Radio";
            this.TS_Radio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TS_Radio.Size = new System.Drawing.Size(655, 40);
            this.TS_Radio.TabIndex = 0;
            this.TS_Radio.Text = "toolStrip1";
            // 
            // TS_Add_RAdio
            // 
            this.TS_Add_RAdio.Image = global::clinic.Properties.Resources.add;
            this.TS_Add_RAdio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add_RAdio.Name = "TS_Add_RAdio";
            this.TS_Add_RAdio.Size = new System.Drawing.Size(66, 37);
            this.TS_Add_RAdio.Text = "اضافة";
            this.TS_Add_RAdio.Click += new System.EventHandler(this.TS_Add_RAdio_Click);
            // 
            // TS_UpDate
            // 
            this.TS_UpDate.Image = global::clinic.Properties.Resources.accept;
            this.TS_UpDate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_UpDate.Name = "TS_UpDate";
            this.TS_UpDate.Size = new System.Drawing.Size(60, 37);
            this.TS_UpDate.Text = "تعديل";
            this.TS_UpDate.Click += new System.EventHandler(this.TS_UpDate_Click);
            // 
            // TS_Delete
            // 
            this.TS_Delete.Image = global::clinic.Properties.Resources.remove;
            this.TS_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Delete.Name = "TS_Delete";
            this.TS_Delete.Size = new System.Drawing.Size(59, 37);
            this.TS_Delete.Text = "حذف";
            this.TS_Delete.Click += new System.EventHandler(this.TS_Delete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // TS_EmaptyTools
            // 
            this.TS_EmaptyTools.Image = global::clinic.Properties.Resources.Empty_Recycle_Bin;
            this.TS_EmaptyTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_EmaptyTools.Name = "TS_EmaptyTools";
            this.TS_EmaptyTools.Size = new System.Drawing.Size(100, 37);
            this.TS_EmaptyTools.Text = "تفريغ الحقول";
            this.TS_EmaptyTools.Click += new System.EventHandler(this.TS_EmaptyTools_Click);
            // 
            // TS_Repo
            // 
            this.TS_Repo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ts_Report_PatientID,
            this.Ts_PaientIDS});
            this.TS_Repo.Image = global::clinic.Properties.Resources.notes_editb;
            this.TS_Repo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Repo.Name = "TS_Repo";
            this.TS_Repo.Size = new System.Drawing.Size(78, 37);
            this.TS_Repo.Text = "تقارير";
            // 
            // Ts_Report_PatientID
            // 
            this.Ts_Report_PatientID.Name = "Ts_Report_PatientID";
            this.Ts_Report_PatientID.Size = new System.Drawing.Size(173, 24);
            this.Ts_Report_PatientID.Text = "حسب اسم المريض";
            this.Ts_Report_PatientID.Click += new System.EventHandler(this.Ts_Report_PatientID_Click);
            // 
            // Ts_PaientIDS
            // 
            this.Ts_PaientIDS.Name = "Ts_PaientIDS";
            this.Ts_PaientIDS.Size = new System.Drawing.Size(173, 24);
            this.Ts_PaientIDS.Text = "جميع المرضى";
            this.Ts_PaientIDS.Click += new System.EventHandler(this.Ts_PaientIDS_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // TS_Back
            // 
            this.TS_Back.Image = global::clinic.Properties.Resources.computer_remove;
            this.TS_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Back.Name = "TS_Back";
            this.TS_Back.Size = new System.Drawing.Size(57, 37);
            this.TS_Back.Text = "خلف";
            this.TS_Back.Click += new System.EventHandler(this.TS_Back_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GB_Radio_Info, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGV_RAdio_All, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 387);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // GB_Radio_Info
            // 
            this.GB_Radio_Info.Controls.Add(this.txt_PateintInher);
            this.GB_Radio_Info.Controls.Add(this.txt_Radio);
            this.GB_Radio_Info.Controls.Add(this.txt_ImagePath);
            this.GB_Radio_Info.Controls.Add(this.txt_RadioResult);
            this.GB_Radio_Info.Controls.Add(this.lbl_Result);
            this.GB_Radio_Info.Controls.Add(this.txt_Subject);
            this.GB_Radio_Info.Controls.Add(this.lbl_Subject);
            this.GB_Radio_Info.Controls.Add(this.Cmb_RadioType);
            this.GB_Radio_Info.Controls.Add(this.lbl_RadioTypeID);
            this.GB_Radio_Info.Controls.Add(this.Cmb_VisitID);
            this.GB_Radio_Info.Controls.Add(this.lbl_VisitID);
            this.GB_Radio_Info.Controls.Add(this.Cmb_PatientName);
            this.GB_Radio_Info.Controls.Add(this.lbl_Patient_Full);
            this.GB_Radio_Info.Controls.Add(this.GB_Image);
            this.GB_Radio_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Radio_Info.Location = new System.Drawing.Point(3, 3);
            this.GB_Radio_Info.Name = "GB_Radio_Info";
            this.GB_Radio_Info.Size = new System.Drawing.Size(649, 187);
            this.GB_Radio_Info.TabIndex = 0;
            this.GB_Radio_Info.TabStop = false;
            this.GB_Radio_Info.Text = "بيانات الصوره الاشعاعية:";
            // 
            // txt_PateintInher
            // 
            this.txt_PateintInher.Location = new System.Drawing.Point(299, 154);
            this.txt_PateintInher.Name = "txt_PateintInher";
            this.txt_PateintInher.Size = new System.Drawing.Size(100, 20);
            this.txt_PateintInher.TabIndex = 14;
            this.txt_PateintInher.Visible = false;
            // 
            // txt_Radio
            // 
            this.txt_Radio.Location = new System.Drawing.Point(432, 156);
            this.txt_Radio.Name = "txt_Radio";
            this.txt_Radio.ReadOnly = true;
            this.txt_Radio.Size = new System.Drawing.Size(100, 20);
            this.txt_Radio.TabIndex = 13;
            this.txt_Radio.Visible = false;
            // 
            // txt_ImagePath
            // 
            this.txt_ImagePath.Location = new System.Drawing.Point(538, 156);
            this.txt_ImagePath.Name = "txt_ImagePath";
            this.txt_ImagePath.ReadOnly = true;
            this.txt_ImagePath.Size = new System.Drawing.Size(34, 20);
            this.txt_ImagePath.TabIndex = 12;
            this.txt_ImagePath.Visible = false;
            // 
            // txt_RadioResult
            // 
            this.txt_RadioResult.Location = new System.Drawing.Point(192, 109);
            this.txt_RadioResult.Name = "txt_RadioResult";
            this.txt_RadioResult.Size = new System.Drawing.Size(358, 20);
            this.txt_RadioResult.TabIndex = 10;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(553, 112);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(42, 13);
            this.lbl_Result.TabIndex = 9;
            this.lbl_Result.Text = "النتيجة:";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(195, 67);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(134, 20);
            this.txt_Subject.TabIndex = 8;
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(332, 71);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(78, 13);
            this.lbl_Subject.TabIndex = 7;
            this.lbl_Subject.Text = "موضوع التصوير:";
            // 
            // Cmb_RadioType
            // 
            this.Cmb_RadioType.FormattingEnabled = true;
            this.Cmb_RadioType.Location = new System.Drawing.Point(413, 68);
            this.Cmb_RadioType.Name = "Cmb_RadioType";
            this.Cmb_RadioType.Size = new System.Drawing.Size(137, 21);
            this.Cmb_RadioType.TabIndex = 6;
            // 
            // lbl_RadioTypeID
            // 
            this.lbl_RadioTypeID.AutoSize = true;
            this.lbl_RadioTypeID.Location = new System.Drawing.Point(554, 74);
            this.lbl_RadioTypeID.Name = "lbl_RadioTypeID";
            this.lbl_RadioTypeID.Size = new System.Drawing.Size(97, 13);
            this.lbl_RadioTypeID.TabIndex = 5;
            this.lbl_RadioTypeID.Text = " التصوير الاشعاعي:";
            // 
            // Cmb_VisitID
            // 
            this.Cmb_VisitID.FormattingEnabled = true;
            this.Cmb_VisitID.Location = new System.Drawing.Point(194, 32);
            this.Cmb_VisitID.Name = "Cmb_VisitID";
            this.Cmb_VisitID.Size = new System.Drawing.Size(134, 21);
            this.Cmb_VisitID.TabIndex = 4;
            // 
            // lbl_VisitID
            // 
            this.lbl_VisitID.AutoSize = true;
            this.lbl_VisitID.Location = new System.Drawing.Point(334, 35);
            this.lbl_VisitID.Name = "lbl_VisitID";
            this.lbl_VisitID.Size = new System.Drawing.Size(37, 13);
            this.lbl_VisitID.TabIndex = 3;
            this.lbl_VisitID.Text = "الزياره:";
            // 
            // Cmb_PatientName
            // 
            this.Cmb_PatientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_PatientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_PatientName.FormattingEnabled = true;
            this.Cmb_PatientName.Location = new System.Drawing.Point(413, 32);
            this.Cmb_PatientName.Name = "Cmb_PatientName";
            this.Cmb_PatientName.Size = new System.Drawing.Size(139, 21);
            this.Cmb_PatientName.TabIndex = 2;
            this.Cmb_PatientName.SelectedIndexChanged += new System.EventHandler(this.Cmb_PatientName_SelectedIndexChanged);
            // 
            // lbl_Patient_Full
            // 
            this.lbl_Patient_Full.AutoSize = true;
            this.lbl_Patient_Full.Location = new System.Drawing.Point(555, 35);
            this.lbl_Patient_Full.Name = "lbl_Patient_Full";
            this.lbl_Patient_Full.Size = new System.Drawing.Size(70, 13);
            this.lbl_Patient_Full.TabIndex = 1;
            this.lbl_Patient_Full.Text = "اسم المريض:";
            // 
            // GB_Image
            // 
            this.GB_Image.Controls.Add(this.PIC_X_RAY);
            this.GB_Image.Dock = System.Windows.Forms.DockStyle.Left;
            this.GB_Image.Location = new System.Drawing.Point(3, 16);
            this.GB_Image.Name = "GB_Image";
            this.GB_Image.Size = new System.Drawing.Size(183, 168);
            this.GB_Image.TabIndex = 0;
            this.GB_Image.TabStop = false;
            this.GB_Image.Text = "الصوره:";
            // 
            // PIC_X_RAY
            // 
            this.PIC_X_RAY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PIC_X_RAY.Dock = System.Windows.Forms.DockStyle.Top;
            this.PIC_X_RAY.Location = new System.Drawing.Point(3, 16);
            this.PIC_X_RAY.Name = "PIC_X_RAY";
            this.PIC_X_RAY.Size = new System.Drawing.Size(177, 144);
            this.PIC_X_RAY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_X_RAY.TabIndex = 0;
            this.PIC_X_RAY.TabStop = false;
            // 
            // DGV_RAdio_All
            // 
            this.DGV_RAdio_All.AllowUserToAddRows = false;
            this.DGV_RAdio_All.AllowUserToDeleteRows = false;
            this.DGV_RAdio_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_RAdio_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RadioID,
            this.FirstName,
            this.DataOfVisit,
            this.RadioTypeID,
            this.RadioType,
            this.RadioSubject,
            this.RadioResult,
            this.VisitID,
            this.PatientID,
            this.ImagePath});
            this.DGV_RAdio_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_RAdio_All.Location = new System.Drawing.Point(3, 196);
            this.DGV_RAdio_All.Name = "DGV_RAdio_All";
            this.DGV_RAdio_All.ReadOnly = true;
            this.DGV_RAdio_All.Size = new System.Drawing.Size(649, 188);
            this.DGV_RAdio_All.TabIndex = 1;
            this.DGV_RAdio_All.DoubleClick += new System.EventHandler(this.DGV_RAdio_All_DoubleClick);
            // 
            // RadioID
            // 
            this.RadioID.DataPropertyName = "RadioID";
            this.RadioID.HeaderText = "رقم الصوره";
            this.RadioID.Name = "RadioID";
            this.RadioID.ReadOnly = true;
            this.RadioID.Visible = false;
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
            // RadioTypeID
            // 
            this.RadioTypeID.DataPropertyName = "RadioTypeID";
            this.RadioTypeID.HeaderText = "نوع التصوير";
            this.RadioTypeID.Name = "RadioTypeID";
            this.RadioTypeID.ReadOnly = true;
            this.RadioTypeID.Visible = false;
            // 
            // RadioType
            // 
            this.RadioType.DataPropertyName = "RadioType";
            this.RadioType.HeaderText = "نوع التصوير الاشعاعي";
            this.RadioType.Name = "RadioType";
            this.RadioType.ReadOnly = true;
            this.RadioType.Width = 125;
            // 
            // RadioSubject
            // 
            this.RadioSubject.DataPropertyName = "RadioSubject";
            this.RadioSubject.HeaderText = "موضوع التصوير";
            this.RadioSubject.Name = "RadioSubject";
            this.RadioSubject.ReadOnly = true;
            // 
            // RadioResult
            // 
            this.RadioResult.DataPropertyName = "RadioResult";
            this.RadioResult.HeaderText = "النتيجة";
            this.RadioResult.Name = "RadioResult";
            this.RadioResult.ReadOnly = true;
            this.RadioResult.Width = 125;
            // 
            // VisitID
            // 
            this.VisitID.DataPropertyName = "VisitID";
            this.VisitID.HeaderText = "رقم الزياره";
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
            // ImagePath
            // 
            this.ImagePath.DataPropertyName = "ImagePath";
            this.ImagePath.HeaderText = "مسار الصوره";
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.ReadOnly = true;
            this.ImagePath.Visible = false;
            // 
            // FrmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TS_Radio);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 465);
            this.MinimumSize = new System.Drawing.Size(671, 465);
            this.Name = "FrmRadio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " الصور الشعاعية";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmRadio_Load);
            this.TS_Radio.ResumeLayout(false);
            this.TS_Radio.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GB_Radio_Info.ResumeLayout(false);
            this.GB_Radio_Info.PerformLayout();
            this.GB_Image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_X_RAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RAdio_All)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS_Radio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GB_Radio_Info;
        private System.Windows.Forms.GroupBox GB_Image;
        private System.Windows.Forms.Label lbl_RadioTypeID;
        private System.Windows.Forms.ComboBox Cmb_VisitID;
        private System.Windows.Forms.Label lbl_VisitID;
        private System.Windows.Forms.ComboBox Cmb_PatientName;
        private System.Windows.Forms.Label lbl_Patient_Full;
        private System.Windows.Forms.PictureBox PIC_X_RAY;
        private System.Windows.Forms.TextBox txt_RadioResult;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.ComboBox Cmb_RadioType;
        private System.Windows.Forms.TextBox txt_ImagePath;
        private System.Windows.Forms.DataGridView DGV_RAdio_All;
        private System.Windows.Forms.ToolStripButton TS_Add_RAdio;
        private System.Windows.Forms.ToolStripButton TS_UpDate;
        private System.Windows.Forms.ToolStripButton TS_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TS_Back;
        private System.Windows.Forms.TextBox txt_Radio;
        private System.Windows.Forms.ToolStripSplitButton TS_Repo;
        private System.Windows.Forms.ToolStripMenuItem Ts_Report_PatientID;
        private System.Windows.Forms.ToolStripMenuItem Ts_PaientIDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataOfVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadioTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadioType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadioSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadioResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagePath;
        private System.Windows.Forms.ToolStripButton TS_EmaptyTools;
        private System.Windows.Forms.TextBox txt_PateintInher;
    }
}