namespace clinic.Pharmacy
{
    partial class FrmPatient_Prescrption
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
            this.TS_P_P = new System.Windows.Forms.ToolStrip();
            this.TS_Add_Pre = new System.Windows.Forms.ToolStripButton();
            this.TS_UpData_Pre = new System.Windows.Forms.ToolStripButton();
            this.TS_Delete_Pre = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_EmaptyTools = new System.Windows.Forms.ToolStripButton();
            this.TS_Browes_ALL = new System.Windows.Forms.ToolStripSplitButton();
            this.TS_Browes_ID = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_PatientPrecriptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Back_To_Main = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GB_Patient_Info = new System.Windows.Forms.GroupBox();
            this.txt_PatientInher = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_PreScription = new System.Windows.Forms.TextBox();
            this.DTP_Pre = new System.Windows.Forms.DateTimePicker();
            this.lbl_DatePre = new System.Windows.Forms.Label();
            this.Cmb_VisitID = new System.Windows.Forms.ComboBox();
            this.lbl_VisitID = new System.Windows.Forms.Label();
            this.Cmb_PatientName = new System.Windows.Forms.ComboBox();
            this.lbl_Patient = new System.Windows.Forms.Label();
            this.DGV_Patient = new System.Windows.Forms.DataGridView();
            this.PrescriptionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfPrescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TS_P_P.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GB_Patient_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Patient)).BeginInit();
            this.SuspendLayout();
            // 
            // TS_P_P
            // 
            this.TS_P_P.AutoSize = false;
            this.TS_P_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_P_P.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_P_P.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add_Pre,
            this.TS_UpData_Pre,
            this.TS_Delete_Pre,
            this.toolStripSeparator2,
            this.TS_EmaptyTools,
            this.TS_Browes_ALL,
            this.toolStripSeparator1,
            this.TS_Back_To_Main});
            this.TS_P_P.Location = new System.Drawing.Point(0, 0);
            this.TS_P_P.Name = "TS_P_P";
            this.TS_P_P.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TS_P_P.Size = new System.Drawing.Size(537, 40);
            this.TS_P_P.TabIndex = 0;
            this.TS_P_P.Text = "toolStrip1";
            // 
            // TS_Add_Pre
            // 
            this.TS_Add_Pre.Image = global::clinic.Properties.Resources.note_add;
            this.TS_Add_Pre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add_Pre.Name = "TS_Add_Pre";
            this.TS_Add_Pre.Size = new System.Drawing.Size(70, 37);
            this.TS_Add_Pre.Text = "اضافة ";
            this.TS_Add_Pre.Click += new System.EventHandler(this.TS_Add_Pre_Click);
            // 
            // TS_UpData_Pre
            // 
            this.TS_UpData_Pre.Image = global::clinic.Properties.Resources.note_accept;
            this.TS_UpData_Pre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_UpData_Pre.Name = "TS_UpData_Pre";
            this.TS_UpData_Pre.Size = new System.Drawing.Size(60, 37);
            this.TS_UpData_Pre.Text = "تعديل";
            this.TS_UpData_Pre.Click += new System.EventHandler(this.TS_UpData_Pre_Click);
            // 
            // TS_Delete_Pre
            // 
            this.TS_Delete_Pre.Image = global::clinic.Properties.Resources.note_remove;
            this.TS_Delete_Pre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Delete_Pre.Name = "TS_Delete_Pre";
            this.TS_Delete_Pre.Size = new System.Drawing.Size(59, 37);
            this.TS_Delete_Pre.Text = "حذف";
            this.TS_Delete_Pre.Click += new System.EventHandler(this.TS_Delete_Pre_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
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
            // TS_Browes_ALL
            // 
            this.TS_Browes_ALL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Browes_ID,
            this.TS_PatientPrecriptions});
            this.TS_Browes_ALL.Image = global::clinic.Properties.Resources.note_edit;
            this.TS_Browes_ALL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Browes_ALL.Name = "TS_Browes_ALL";
            this.TS_Browes_ALL.Size = new System.Drawing.Size(78, 37);
            this.TS_Browes_ALL.Text = "عرض";
            // 
            // TS_Browes_ID
            // 
            this.TS_Browes_ID.Name = "TS_Browes_ID";
            this.TS_Browes_ID.Size = new System.Drawing.Size(220, 24);
            this.TS_Browes_ID.Text = "استعراص وصفة";
            this.TS_Browes_ID.ToolTipText = "استعراص وصفة";
            this.TS_Browes_ID.Click += new System.EventHandler(this.TS_Browes_ID_Click);
            // 
            // TS_PatientPrecriptions
            // 
            this.TS_PatientPrecriptions.Name = "TS_PatientPrecriptions";
            this.TS_PatientPrecriptions.Size = new System.Drawing.Size(220, 24);
            this.TS_PatientPrecriptions.Text = "استعراص وصفات المريض";
            this.TS_PatientPrecriptions.Click += new System.EventHandler(this.TS_PatientPrecriptions_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // TS_Back_To_Main
            // 
            this.TS_Back_To_Main.Image = global::clinic.Properties.Resources.computer_remove;
            this.TS_Back_To_Main.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Back_To_Main.Name = "TS_Back_To_Main";
            this.TS_Back_To_Main.Size = new System.Drawing.Size(57, 37);
            this.TS_Back_To_Main.Text = "خلف";
            this.TS_Back_To_Main.Click += new System.EventHandler(this.TS_Back_To_Main_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GB_Patient_Info, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGV_Patient, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 389);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // GB_Patient_Info
            // 
            this.GB_Patient_Info.Controls.Add(this.txt_PatientInher);
            this.GB_Patient_Info.Controls.Add(this.pictureBox1);
            this.GB_Patient_Info.Controls.Add(this.txt_PreScription);
            this.GB_Patient_Info.Controls.Add(this.DTP_Pre);
            this.GB_Patient_Info.Controls.Add(this.lbl_DatePre);
            this.GB_Patient_Info.Controls.Add(this.Cmb_VisitID);
            this.GB_Patient_Info.Controls.Add(this.lbl_VisitID);
            this.GB_Patient_Info.Controls.Add(this.Cmb_PatientName);
            this.GB_Patient_Info.Controls.Add(this.lbl_Patient);
            this.GB_Patient_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Patient_Info.Location = new System.Drawing.Point(3, 3);
            this.GB_Patient_Info.Name = "GB_Patient_Info";
            this.GB_Patient_Info.Size = new System.Drawing.Size(531, 135);
            this.GB_Patient_Info.TabIndex = 1;
            this.GB_Patient_Info.TabStop = false;
            this.GB_Patient_Info.Text = "بيانات المريض:";
            // 
            // txt_PatientInher
            // 
            this.txt_PatientInher.Location = new System.Drawing.Point(28, 94);
            this.txt_PatientInher.Name = "txt_PatientInher";
            this.txt_PatientInher.Size = new System.Drawing.Size(42, 20);
            this.txt_PatientInher.TabIndex = 8;
            this.txt_PatientInher.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::clinic.Properties.Resources.notes_editb;
            this.pictureBox1.Location = new System.Drawing.Point(460, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 52);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txt_PreScription
            // 
            this.txt_PreScription.Location = new System.Drawing.Point(71, 21);
            this.txt_PreScription.Name = "txt_PreScription";
            this.txt_PreScription.ReadOnly = true;
            this.txt_PreScription.Size = new System.Drawing.Size(29, 20);
            this.txt_PreScription.TabIndex = 6;
            this.txt_PreScription.Visible = false;
            // 
            // DTP_Pre
            // 
            this.DTP_Pre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Pre.Location = new System.Drawing.Point(134, 91);
            this.DTP_Pre.Name = "DTP_Pre";
            this.DTP_Pre.Size = new System.Drawing.Size(225, 20);
            this.DTP_Pre.TabIndex = 5;
            this.DTP_Pre.Value = new System.DateTime(2008, 3, 22, 0, 0, 0, 0);
            // 
            // lbl_DatePre
            // 
            this.lbl_DatePre.AutoSize = true;
            this.lbl_DatePre.Location = new System.Drawing.Point(365, 93);
            this.lbl_DatePre.Name = "lbl_DatePre";
            this.lbl_DatePre.Size = new System.Drawing.Size(67, 13);
            this.lbl_DatePre.TabIndex = 4;
            this.lbl_DatePre.Text = "تاريخ الوصفة:";
            // 
            // Cmb_VisitID
            // 
            this.Cmb_VisitID.FormattingEnabled = true;
            this.Cmb_VisitID.Location = new System.Drawing.Point(134, 55);
            this.Cmb_VisitID.Name = "Cmb_VisitID";
            this.Cmb_VisitID.Size = new System.Drawing.Size(225, 21);
            this.Cmb_VisitID.TabIndex = 3;
            // 
            // lbl_VisitID
            // 
            this.lbl_VisitID.AutoSize = true;
            this.lbl_VisitID.Location = new System.Drawing.Point(365, 58);
            this.lbl_VisitID.Name = "lbl_VisitID";
            this.lbl_VisitID.Size = new System.Drawing.Size(37, 13);
            this.lbl_VisitID.TabIndex = 2;
            this.lbl_VisitID.Text = "الزياره:";
            // 
            // Cmb_PatientName
            // 
            this.Cmb_PatientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_PatientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_PatientName.FormattingEnabled = true;
            this.Cmb_PatientName.Location = new System.Drawing.Point(134, 21);
            this.Cmb_PatientName.Name = "Cmb_PatientName";
            this.Cmb_PatientName.Size = new System.Drawing.Size(225, 21);
            this.Cmb_PatientName.TabIndex = 1;
            this.Cmb_PatientName.SelectedIndexChanged += new System.EventHandler(this.Cmb_PatientName_SelectedIndexChanged);
            // 
            // lbl_Patient
            // 
            this.lbl_Patient.AutoSize = true;
            this.lbl_Patient.Location = new System.Drawing.Point(365, 24);
            this.lbl_Patient.Name = "lbl_Patient";
            this.lbl_Patient.Size = new System.Drawing.Size(70, 13);
            this.lbl_Patient.TabIndex = 0;
            this.lbl_Patient.Text = "اسم المريض:";
            // 
            // DGV_Patient
            // 
            this.DGV_Patient.AllowUserToAddRows = false;
            this.DGV_Patient.AllowUserToDeleteRows = false;
            this.DGV_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Patient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrescriptionID,
            this.FirstName,
            this.DataOfVisit,
            this.DateOfPrescription,
            this.PatientID,
            this.VisitID});
            this.DGV_Patient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Patient.Location = new System.Drawing.Point(3, 144);
            this.DGV_Patient.Name = "DGV_Patient";
            this.DGV_Patient.ReadOnly = true;
            this.DGV_Patient.Size = new System.Drawing.Size(531, 242);
            this.DGV_Patient.TabIndex = 2;
            this.DGV_Patient.DoubleClick += new System.EventHandler(this.DGV_Patient_DoubleClick);
            // 
            // PrescriptionID
            // 
            this.PrescriptionID.DataPropertyName = "PrescriptionID";
            this.PrescriptionID.HeaderText = "رقم الوصفة";
            this.PrescriptionID.Name = "PrescriptionID";
            this.PrescriptionID.ReadOnly = true;
            this.PrescriptionID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "أسم المريض";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 150;
            // 
            // DataOfVisit
            // 
            this.DataOfVisit.DataPropertyName = "DataOfVisit";
            this.DataOfVisit.HeaderText = "تاريخ الزيارة";
            this.DataOfVisit.Name = "DataOfVisit";
            this.DataOfVisit.ReadOnly = true;
            this.DataOfVisit.Width = 150;
            // 
            // DateOfPrescription
            // 
            this.DateOfPrescription.DataPropertyName = "DateOfPrescription";
            this.DateOfPrescription.HeaderText = "تاريخ الوصفة";
            this.DateOfPrescription.Name = "DateOfPrescription";
            this.DateOfPrescription.ReadOnly = true;
            this.DateOfPrescription.Width = 150;
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "رقم المريض";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Visible = false;
            this.PatientID.Width = 75;
            // 
            // VisitID
            // 
            this.VisitID.DataPropertyName = "VisitID";
            this.VisitID.HeaderText = "الزيارة";
            this.VisitID.Name = "VisitID";
            this.VisitID.ReadOnly = true;
            this.VisitID.Visible = false;
            this.VisitID.Width = 75;
            // 
            // FrmPatient_Prescrption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 429);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TS_P_P);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(553, 467);
            this.MinimumSize = new System.Drawing.Size(553, 467);
            this.Name = "FrmPatient_Prescrption";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "وصفات المرضى";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmPatient_Prescrption_Load);
            this.TS_P_P.ResumeLayout(false);
            this.TS_P_P.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GB_Patient_Info.ResumeLayout(false);
            this.GB_Patient_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Patient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS_P_P;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GB_Patient_Info;
        private System.Windows.Forms.DateTimePicker DTP_Pre;
        private System.Windows.Forms.Label lbl_DatePre;
        private System.Windows.Forms.ComboBox Cmb_VisitID;
        private System.Windows.Forms.Label lbl_VisitID;
        private System.Windows.Forms.ComboBox Cmb_PatientName;
        private System.Windows.Forms.Label lbl_Patient;
        private System.Windows.Forms.ToolStripButton TS_Add_Pre;
        private System.Windows.Forms.ToolStripButton TS_UpData_Pre;
        private System.Windows.Forms.ToolStripButton TS_Delete_Pre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TS_Back_To_Main;
        private System.Windows.Forms.TextBox txt_PreScription;
        private System.Windows.Forms.DataGridView DGV_Patient;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSplitButton TS_Browes_ALL;
        private System.Windows.Forms.ToolStripMenuItem TS_Browes_ID;
        private System.Windows.Forms.ToolStripMenuItem TS_PatientPrecriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrescriptionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataOfVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPrescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitID;
        private System.Windows.Forms.ToolStripButton TS_EmaptyTools;
        private System.Windows.Forms.TextBox txt_PatientInher;

    }
}