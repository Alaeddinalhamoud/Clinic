namespace clinic.pharmacy
{
    partial class FrmMedication
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GB_Medication_Info = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_Medication = new System.Windows.Forms.TextBox();
            this.txt_MedicationID = new System.Windows.Forms.TextBox();
            this.lbl_Medication = new System.Windows.Forms.Label();
            this.lbl_MedicationID = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GB_Search_Medication = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_TEXT = new System.Windows.Forms.Label();
            this.GB_Search_by = new System.Windows.Forms.GroupBox();
            this.RD_btn_MedicationName = new System.Windows.Forms.RadioButton();
            this.RD_btn_MedicationID = new System.Windows.Forms.RadioButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.TS_Phrmacy = new System.Windows.Forms.ToolStrip();
            this.TS_Add_Medication = new System.Windows.Forms.ToolStripButton();
            this.TS_Update_Medication = new System.Windows.Forms.ToolStripButton();
            this.TS_Delete_Medication = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Rrport_All = new System.Windows.Forms.ToolStripButton();
            this.TS_ImportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_BAck_To_Main = new System.Windows.Forms.ToolStripButton();
            this.DVG_Medication_All = new System.Windows.Forms.DataGridView();
            this.MedicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupOfRemedial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Page = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalOfConsultation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntiOfMedical_Consultation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OverlapOfMedication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SideOfEffect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.GB_Medication_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.GB_Search_Medication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GB_Search_by.SuspendLayout();
            this.TS_Phrmacy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_Medication_All)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GB_Medication_Info, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TS_Phrmacy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DVG_Medication_All, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.77099F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.229F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 419);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GB_Medication_Info
            // 
            this.GB_Medication_Info.Controls.Add(this.pictureBox3);
            this.GB_Medication_Info.Controls.Add(this.pictureBox2);
            this.GB_Medication_Info.Controls.Add(this.txt_Medication);
            this.GB_Medication_Info.Controls.Add(this.txt_MedicationID);
            this.GB_Medication_Info.Controls.Add(this.lbl_Medication);
            this.GB_Medication_Info.Controls.Add(this.lbl_MedicationID);
            this.GB_Medication_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Medication_Info.Location = new System.Drawing.Point(3, 42);
            this.GB_Medication_Info.Name = "GB_Medication_Info";
            this.GB_Medication_Info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_Medication_Info.Size = new System.Drawing.Size(655, 86);
            this.GB_Medication_Info.TabIndex = 0;
            this.GB_Medication_Info.TabStop = false;
            this.GB_Medication_Info.Text = "بيانات الادوية:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::clinic.Properties.Resources.pill_256;
            this.pictureBox3.Location = new System.Drawing.Point(523, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::clinic.Properties.Resources.pills_128_hot;
            this.pictureBox2.Location = new System.Drawing.Point(585, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // txt_Medication
            // 
            this.txt_Medication.Location = new System.Drawing.Point(279, 55);
            this.txt_Medication.Name = "txt_Medication";
            this.txt_Medication.Size = new System.Drawing.Size(143, 20);
            this.txt_Medication.TabIndex = 3;
            // 
            // txt_MedicationID
            // 
            this.txt_MedicationID.Location = new System.Drawing.Point(278, 29);
            this.txt_MedicationID.Name = "txt_MedicationID";
            this.txt_MedicationID.ReadOnly = true;
            this.txt_MedicationID.Size = new System.Drawing.Size(143, 20);
            this.txt_MedicationID.TabIndex = 2;
            // 
            // lbl_Medication
            // 
            this.lbl_Medication.AutoSize = true;
            this.lbl_Medication.Location = new System.Drawing.Point(440, 62);
            this.lbl_Medication.Name = "lbl_Medication";
            this.lbl_Medication.Size = new System.Drawing.Size(35, 13);
            this.lbl_Medication.TabIndex = 1;
            this.lbl_Medication.Text = "الدواء:";
            // 
            // lbl_MedicationID
            // 
            this.lbl_MedicationID.AutoSize = true;
            this.lbl_MedicationID.Location = new System.Drawing.Point(440, 29);
            this.lbl_MedicationID.Name = "lbl_MedicationID";
            this.lbl_MedicationID.Size = new System.Drawing.Size(55, 13);
            this.lbl_MedicationID.TabIndex = 0;
            this.lbl_MedicationID.Text = "رقم الدواء:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.77863F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.221374F));
            this.tableLayoutPanel2.Controls.Add(this.GB_Search_Medication, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 134);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(655, 122);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // GB_Search_Medication
            // 
            this.GB_Search_Medication.Controls.Add(this.pictureBox1);
            this.GB_Search_Medication.Controls.Add(this.btn_Search);
            this.GB_Search_Medication.Controls.Add(this.lbl_TEXT);
            this.GB_Search_Medication.Controls.Add(this.GB_Search_by);
            this.GB_Search_Medication.Controls.Add(this.txt_Search);
            this.GB_Search_Medication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Search_Medication.Location = new System.Drawing.Point(12, 3);
            this.GB_Search_Medication.Name = "GB_Search_Medication";
            this.GB_Search_Medication.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_Search_Medication.Size = new System.Drawing.Size(640, 116);
            this.GB_Search_Medication.TabIndex = 0;
            this.GB_Search_Medication.TabStop = false;
            this.GB_Search_Medication.Text = "بحث";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::clinic.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(298, 77);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_TEXT
            // 
            this.lbl_TEXT.AutoSize = true;
            this.lbl_TEXT.Location = new System.Drawing.Point(415, 54);
            this.lbl_TEXT.Name = "lbl_TEXT";
            this.lbl_TEXT.Size = new System.Drawing.Size(55, 13);
            this.lbl_TEXT.TabIndex = 2;
            this.lbl_TEXT.Text = "رقم الدواء:";
            // 
            // GB_Search_by
            // 
            this.GB_Search_by.Controls.Add(this.RD_btn_MedicationName);
            this.GB_Search_by.Controls.Add(this.RD_btn_MedicationID);
            this.GB_Search_by.Dock = System.Windows.Forms.DockStyle.Right;
            this.GB_Search_by.Location = new System.Drawing.Point(511, 16);
            this.GB_Search_by.Name = "GB_Search_by";
            this.GB_Search_by.Size = new System.Drawing.Size(126, 97);
            this.GB_Search_by.TabIndex = 1;
            this.GB_Search_by.TabStop = false;
            this.GB_Search_by.Text = "بحث حسب";
            // 
            // RD_btn_MedicationName
            // 
            this.RD_btn_MedicationName.AutoSize = true;
            this.RD_btn_MedicationName.Location = new System.Drawing.Point(29, 58);
            this.RD_btn_MedicationName.Name = "RD_btn_MedicationName";
            this.RD_btn_MedicationName.Size = new System.Drawing.Size(74, 17);
            this.RD_btn_MedicationName.TabIndex = 1;
            this.RD_btn_MedicationName.Text = "اسم الدواء";
            this.RD_btn_MedicationName.UseVisualStyleBackColor = true;
            this.RD_btn_MedicationName.CheckedChanged += new System.EventHandler(this.RD_btn_MedicationName_CheckedChanged);
            // 
            // RD_btn_MedicationID
            // 
            this.RD_btn_MedicationID.AutoSize = true;
            this.RD_btn_MedicationID.Checked = true;
            this.RD_btn_MedicationID.Location = new System.Drawing.Point(35, 35);
            this.RD_btn_MedicationID.Name = "RD_btn_MedicationID";
            this.RD_btn_MedicationID.Size = new System.Drawing.Size(69, 17);
            this.RD_btn_MedicationID.TabIndex = 0;
            this.RD_btn_MedicationID.TabStop = true;
            this.RD_btn_MedicationID.Text = "رقم الدواء";
            this.RD_btn_MedicationID.UseVisualStyleBackColor = true;
            this.RD_btn_MedicationID.CheckedChanged += new System.EventHandler(this.RD_btn_MedicationID_CheckedChanged);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(266, 51);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(143, 20);
            this.txt_Search.TabIndex = 0;
            // 
            // TS_Phrmacy
            // 
            this.TS_Phrmacy.AutoSize = false;
            this.TS_Phrmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Phrmacy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_Phrmacy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add_Medication,
            this.TS_Update_Medication,
            this.TS_Delete_Medication,
            this.toolStripSeparator2,
            this.TS_Rrport_All,
            this.TS_ImportExcel,
            this.toolStripSeparator1,
            this.TS_BAck_To_Main});
            this.TS_Phrmacy.Location = new System.Drawing.Point(0, 0);
            this.TS_Phrmacy.Name = "TS_Phrmacy";
            this.TS_Phrmacy.Size = new System.Drawing.Size(661, 39);
            this.TS_Phrmacy.TabIndex = 3;
            this.TS_Phrmacy.Text = "toolStrip1";
            // 
            // TS_Add_Medication
            // 
            this.TS_Add_Medication.Image = global::clinic.Properties.Resources.add;
            this.TS_Add_Medication.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add_Medication.Name = "TS_Add_Medication";
            this.TS_Add_Medication.Size = new System.Drawing.Size(119, 36);
            this.TS_Add_Medication.Text = "اضافة دواء جديد";
            this.TS_Add_Medication.Click += new System.EventHandler(this.TS_Add_Medication_Click);
            // 
            // TS_Update_Medication
            // 
            this.TS_Update_Medication.Image = global::clinic.Properties.Resources.accept;
            this.TS_Update_Medication.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Update_Medication.Name = "TS_Update_Medication";
            this.TS_Update_Medication.Size = new System.Drawing.Size(60, 36);
            this.TS_Update_Medication.Text = "تعديل";
            this.TS_Update_Medication.Click += new System.EventHandler(this.TS_Update_Medication_Click);
            // 
            // TS_Delete_Medication
            // 
            this.TS_Delete_Medication.Image = global::clinic.Properties.Resources.remove;
            this.TS_Delete_Medication.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Delete_Medication.Name = "TS_Delete_Medication";
            this.TS_Delete_Medication.Size = new System.Drawing.Size(86, 36);
            this.TS_Delete_Medication.Text = "حذف دواء";
            this.TS_Delete_Medication.Click += new System.EventHandler(this.TS_Delete_Medication_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // TS_Rrport_All
            // 
            this.TS_Rrport_All.Image = global::clinic.Properties.Resources.notes_edit;
            this.TS_Rrport_All.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Rrport_All.Name = "TS_Rrport_All";
            this.TS_Rrport_All.Size = new System.Drawing.Size(106, 36);
            this.TS_Rrport_All.Text = "تقرير بالادوية";
            this.TS_Rrport_All.Click += new System.EventHandler(this.TS_Rrport_All_Click);
            // 
            // TS_ImportExcel
            // 
            this.TS_ImportExcel.Image = global::clinic.Properties.Resources.tdx_excel2__Custom_;
            this.TS_ImportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_ImportExcel.Name = "TS_ImportExcel";
            this.TS_ImportExcel.Size = new System.Drawing.Size(138, 36);
            this.TS_ImportExcel.Text = "استيراد ملف Excel";
            this.TS_ImportExcel.Click += new System.EventHandler(this.TS_ImportExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // TS_BAck_To_Main
            // 
            this.TS_BAck_To_Main.Image = global::clinic.Properties.Resources.computer_remove;
            this.TS_BAck_To_Main.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_BAck_To_Main.Name = "TS_BAck_To_Main";
            this.TS_BAck_To_Main.Size = new System.Drawing.Size(64, 36);
            this.TS_BAck_To_Main.Text = "اغلاق";
            this.TS_BAck_To_Main.Click += new System.EventHandler(this.TS_BAck_To_Main_Click);
            // 
            // DVG_Medication_All
            // 
            this.DVG_Medication_All.AllowUserToAddRows = false;
            this.DVG_Medication_All.AllowUserToDeleteRows = false;
            this.DVG_Medication_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVG_Medication_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicationID,
            this.MedicationName,
            this.Company,
            this.GroupOfRemedial,
            this.Classification,
            this.Page,
            this.MedicalOfConsultation,
            this.AntiOfMedical_Consultation,
            this.Warning,
            this.OverlapOfMedication,
            this.SideOfEffect});
            this.DVG_Medication_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVG_Medication_All.Location = new System.Drawing.Point(3, 262);
            this.DVG_Medication_All.Name = "DVG_Medication_All";
            this.DVG_Medication_All.ReadOnly = true;
            this.DVG_Medication_All.Size = new System.Drawing.Size(655, 154);
            this.DVG_Medication_All.TabIndex = 2;
            this.DVG_Medication_All.Click += new System.EventHandler(this.DVG_Medication_All_Click);
            // 
            // MedicationID
            // 
            this.MedicationID.DataPropertyName = "MedicationID";
            this.MedicationID.HeaderText = "رقم الدواء";
            this.MedicationID.Name = "MedicationID";
            this.MedicationID.ReadOnly = true;
            // 
            // MedicationName
            // 
            this.MedicationName.DataPropertyName = "MedicationName";
            this.MedicationName.HeaderText = "اسم الدواء";
            this.MedicationName.Name = "MedicationName";
            this.MedicationName.ReadOnly = true;
            this.MedicationName.Width = 200;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Visible = false;
            // 
            // GroupOfRemedial
            // 
            this.GroupOfRemedial.DataPropertyName = "GroupOfRemedial";
            this.GroupOfRemedial.HeaderText = "GroupOfRemedial";
            this.GroupOfRemedial.Name = "GroupOfRemedial";
            this.GroupOfRemedial.ReadOnly = true;
            this.GroupOfRemedial.Visible = false;
            // 
            // Classification
            // 
            this.Classification.DataPropertyName = "Classification";
            this.Classification.HeaderText = "Classification";
            this.Classification.Name = "Classification";
            this.Classification.ReadOnly = true;
            this.Classification.Visible = false;
            // 
            // Page
            // 
            this.Page.DataPropertyName = "Page";
            this.Page.HeaderText = "Page";
            this.Page.Name = "Page";
            this.Page.ReadOnly = true;
            this.Page.Visible = false;
            // 
            // MedicalOfConsultation
            // 
            this.MedicalOfConsultation.DataPropertyName = "MedicalOfConsultation";
            this.MedicalOfConsultation.HeaderText = "MedicalOfConsultation";
            this.MedicalOfConsultation.Name = "MedicalOfConsultation";
            this.MedicalOfConsultation.ReadOnly = true;
            this.MedicalOfConsultation.Visible = false;
            // 
            // AntiOfMedical_Consultation
            // 
            this.AntiOfMedical_Consultation.DataPropertyName = "AntiOfMedical_Consultation";
            this.AntiOfMedical_Consultation.HeaderText = "AntiOfMedical_Consultation";
            this.AntiOfMedical_Consultation.Name = "AntiOfMedical_Consultation";
            this.AntiOfMedical_Consultation.ReadOnly = true;
            this.AntiOfMedical_Consultation.Visible = false;
            // 
            // Warning
            // 
            this.Warning.DataPropertyName = "Warning";
            this.Warning.HeaderText = "Warning";
            this.Warning.Name = "Warning";
            this.Warning.ReadOnly = true;
            this.Warning.Visible = false;
            // 
            // OverlapOfMedication
            // 
            this.OverlapOfMedication.DataPropertyName = "OverlapOfMedication";
            this.OverlapOfMedication.HeaderText = "OverlapOfMedication";
            this.OverlapOfMedication.Name = "OverlapOfMedication";
            this.OverlapOfMedication.ReadOnly = true;
            this.OverlapOfMedication.Visible = false;
            // 
            // SideOfEffect
            // 
            this.SideOfEffect.DataPropertyName = "SideOfEffect";
            this.SideOfEffect.HeaderText = "SideOfEffect";
            this.SideOfEffect.Name = "SideOfEffect";
            this.SideOfEffect.ReadOnly = true;
            this.SideOfEffect.Visible = false;
            // 
            // FrmMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 465);
            this.MinimumSize = new System.Drawing.Size(671, 465);
            this.Name = "FrmMedication";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الادوية";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmPharmacy_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GB_Medication_Info.ResumeLayout(false);
            this.GB_Medication_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.GB_Search_Medication.ResumeLayout(false);
            this.GB_Search_Medication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GB_Search_by.ResumeLayout(false);
            this.GB_Search_by.PerformLayout();
            this.TS_Phrmacy.ResumeLayout(false);
            this.TS_Phrmacy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_Medication_All)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GB_Medication_Info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox GB_Search_Medication;
        private System.Windows.Forms.DataGridView DVG_Medication_All;
        private System.Windows.Forms.ToolStrip TS_Phrmacy;
        private System.Windows.Forms.Label lbl_Medication;
        private System.Windows.Forms.Label lbl_MedicationID;
        private System.Windows.Forms.TextBox txt_Medication;
        private System.Windows.Forms.TextBox txt_MedicationID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_TEXT;
        private System.Windows.Forms.GroupBox GB_Search_by;
        private System.Windows.Forms.RadioButton RD_btn_MedicationName;
        private System.Windows.Forms.RadioButton RD_btn_MedicationID;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ToolStripButton TS_Add_Medication;
        private System.Windows.Forms.ToolStripButton TS_Update_Medication;
        private System.Windows.Forms.ToolStripButton TS_Delete_Medication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TS_BAck_To_Main;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TS_Rrport_All;
        private System.Windows.Forms.ToolStripButton TS_ImportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupOfRemedial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Page;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalOfConsultation;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntiOfMedical_Consultation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warning;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverlapOfMedication;
        private System.Windows.Forms.DataGridViewTextBoxColumn SideOfEffect;
    }
}