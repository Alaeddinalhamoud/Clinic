namespace clinic.Security
{
    partial class FrmPermission
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
            this.TS_Permission = new System.Windows.Forms.ToolStrip();
            this.btn_Add = new System.Windows.Forms.ToolStripButton();
            this.btn_Updata = new System.Windows.Forms.ToolStripButton();
            this.btn_Delelte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_FillAlCheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Back = new System.Windows.Forms.ToolStripButton();
            this.GB_Permission = new System.Windows.Forms.GroupBox();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.STB_State = new System.Windows.Forms.ToolStripStatusLabel();
            this.STB_UserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.GB_ToolsBox = new System.Windows.Forms.GroupBox();
            this.CHB_BrowesImage = new System.Windows.Forms.CheckBox();
            this.CHB_CameraWatiching = new System.Windows.Forms.CheckBox();
            this.CHB_Prescription = new System.Windows.Forms.CheckBox();
            this.CHB_Appointment = new System.Windows.Forms.CheckBox();
            this.CHB_BackUp = new System.Windows.Forms.CheckBox();
            this.CHB_Invoice = new System.Windows.Forms.CheckBox();
            this.CHB_UserContolPanel = new System.Windows.Forms.CheckBox();
            this.CHB_Radio = new System.Windows.Forms.CheckBox();
            this.CHB_AdminControlPanal = new System.Windows.Forms.CheckBox();
            this.CHB_Visit = new System.Windows.Forms.CheckBox();
            this.CHB_ControlPanel = new System.Windows.Forms.CheckBox();
            this.CHB_Analysis = new System.Windows.Forms.CheckBox();
            this.PrescriptionMeun = new System.Windows.Forms.CheckBox();
            this.CHB_LastMedication = new System.Windows.Forms.CheckBox();
            this.AppointmentMeun = new System.Windows.Forms.CheckBox();
            this.CHB_lastDisease = new System.Windows.Forms.CheckBox();
            this.ToolsMeun = new System.Windows.Forms.CheckBox();
            this.CHB_OperationOfPatient = new System.Windows.Forms.CheckBox();
            this.InvoiceMeun = new System.Windows.Forms.CheckBox();
            this.CHB_FilePatient = new System.Windows.Forms.CheckBox();
            this.AnalysisMenu = new System.Windows.Forms.CheckBox();
            this.PatientMenu = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.TS_Permission.SuspendLayout();
            this.GB_Permission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.GB_ToolsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TS_Permission, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GB_Permission, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.33987F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.66013F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TS_Permission
            // 
            this.TS_Permission.AutoSize = false;
            this.TS_Permission.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_Permission.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.btn_Updata,
            this.btn_Delelte,
            this.toolStripSeparator2,
            this.TS_FillAlCheck,
            this.toolStripSeparator1,
            this.btn_Back});
            this.TS_Permission.Location = new System.Drawing.Point(0, 0);
            this.TS_Permission.Name = "TS_Permission";
            this.TS_Permission.Size = new System.Drawing.Size(804, 46);
            this.TS_Permission.TabIndex = 0;
            this.TS_Permission.Text = "toolStrip1";
            // 
            // btn_Add
            // 
            this.btn_Add.Image = global::clinic.Properties.Resources.add1;
            this.btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(58, 43);
            this.btn_Add.Text = "اضافة";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Updata
            // 
            this.btn_Updata.Image = global::clinic.Properties.Resources.accept;
            this.btn_Updata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Updata.Name = "btn_Updata";
            this.btn_Updata.Size = new System.Drawing.Size(56, 43);
            this.btn_Updata.Text = "تعديل";
            this.btn_Updata.Click += new System.EventHandler(this.btn_Updata_Click);
            // 
            // btn_Delelte
            // 
            this.btn_Delelte.Image = global::clinic.Properties.Resources.remove;
            this.btn_Delelte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delelte.Name = "btn_Delelte";
            this.btn_Delelte.Size = new System.Drawing.Size(52, 43);
            this.btn_Delelte.Text = "حذف";
            this.btn_Delelte.Click += new System.EventHandler(this.btn_Delelte_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // TS_FillAlCheck
            // 
            this.TS_FillAlCheck.Image = global::clinic.Properties.Resources.Good_Shield;
            this.TS_FillAlCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_FillAlCheck.Name = "TS_FillAlCheck";
            this.TS_FillAlCheck.Size = new System.Drawing.Size(78, 43);
            this.TS_FillAlCheck.Text = "تحديد الكل";
            this.TS_FillAlCheck.Click += new System.EventHandler(this.TS_FillAlCheck_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // btn_Back
            // 
            this.btn_Back.Image = global::clinic.Properties.Resources.computer_remove;
            this.btn_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(55, 43);
            this.btn_Back.Text = "اغلاق";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // GB_Permission
            // 
            this.GB_Permission.Controls.Add(this.txt_UserID);
            this.GB_Permission.Controls.Add(this.pictureBox1);
            this.GB_Permission.Controls.Add(this.statusStrip1);
            this.GB_Permission.Controls.Add(this.GB_ToolsBox);
            this.GB_Permission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Permission.Location = new System.Drawing.Point(3, 52);
            this.GB_Permission.Name = "GB_Permission";
            this.GB_Permission.Size = new System.Drawing.Size(798, 245);
            this.GB_Permission.TabIndex = 1;
            this.GB_Permission.TabStop = false;
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(722, 120);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(53, 20);
            this.txt_UserID.TabIndex = 8;
            this.txt_UserID.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::clinic.Properties.Resources.Locker;
            this.pictureBox1.Location = new System.Drawing.Point(696, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STB_State,
            this.STB_UserName});
            this.statusStrip1.Location = new System.Drawing.Point(3, 220);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // STB_State
            // 
            this.STB_State.Image = global::clinic.Properties.Resources.she_user;
            this.STB_State.Name = "STB_State";
            this.STB_State.Size = new System.Drawing.Size(98, 17);
            this.STB_State.Text = "تعديل سماحيات :";
            // 
            // STB_UserName
            // 
            this.STB_UserName.Name = "STB_UserName";
            this.STB_UserName.Size = new System.Drawing.Size(0, 17);
            // 
            // GB_ToolsBox
            // 
            this.GB_ToolsBox.Controls.Add(this.CHB_BrowesImage);
            this.GB_ToolsBox.Controls.Add(this.CHB_CameraWatiching);
            this.GB_ToolsBox.Controls.Add(this.CHB_Prescription);
            this.GB_ToolsBox.Controls.Add(this.CHB_Appointment);
            this.GB_ToolsBox.Controls.Add(this.CHB_BackUp);
            this.GB_ToolsBox.Controls.Add(this.CHB_Invoice);
            this.GB_ToolsBox.Controls.Add(this.CHB_UserContolPanel);
            this.GB_ToolsBox.Controls.Add(this.CHB_Radio);
            this.GB_ToolsBox.Controls.Add(this.CHB_AdminControlPanal);
            this.GB_ToolsBox.Controls.Add(this.CHB_Visit);
            this.GB_ToolsBox.Controls.Add(this.CHB_ControlPanel);
            this.GB_ToolsBox.Controls.Add(this.CHB_Analysis);
            this.GB_ToolsBox.Controls.Add(this.PrescriptionMeun);
            this.GB_ToolsBox.Controls.Add(this.CHB_LastMedication);
            this.GB_ToolsBox.Controls.Add(this.AppointmentMeun);
            this.GB_ToolsBox.Controls.Add(this.CHB_lastDisease);
            this.GB_ToolsBox.Controls.Add(this.ToolsMeun);
            this.GB_ToolsBox.Controls.Add(this.CHB_OperationOfPatient);
            this.GB_ToolsBox.Controls.Add(this.InvoiceMeun);
            this.GB_ToolsBox.Controls.Add(this.CHB_FilePatient);
            this.GB_ToolsBox.Controls.Add(this.AnalysisMenu);
            this.GB_ToolsBox.Controls.Add(this.PatientMenu);
            this.GB_ToolsBox.Location = new System.Drawing.Point(3, 10);
            this.GB_ToolsBox.Name = "GB_ToolsBox";
            this.GB_ToolsBox.Size = new System.Drawing.Size(687, 207);
            this.GB_ToolsBox.TabIndex = 0;
            this.GB_ToolsBox.TabStop = false;
            this.GB_ToolsBox.Text = "شريط القوائم";
            this.GB_ToolsBox.Enter += new System.EventHandler(this.GB_ToolsBox_Enter);
            // 
            // CHB_BrowesImage
            // 
            this.CHB_BrowesImage.AutoSize = true;
            this.CHB_BrowesImage.Location = new System.Drawing.Point(243, 78);
            this.CHB_BrowesImage.Name = "CHB_BrowesImage";
            this.CHB_BrowesImage.Size = new System.Drawing.Size(98, 17);
            this.CHB_BrowesImage.TabIndex = 7;
            this.CHB_BrowesImage.Text = "استعراض الصور";
            this.CHB_BrowesImage.UseVisualStyleBackColor = true;
            // 
            // CHB_CameraWatiching
            // 
            this.CHB_CameraWatiching.AutoSize = true;
            this.CHB_CameraWatiching.Location = new System.Drawing.Point(243, 55);
            this.CHB_CameraWatiching.Name = "CHB_CameraWatiching";
            this.CHB_CameraWatiching.Size = new System.Drawing.Size(98, 17);
            this.CHB_CameraWatiching.TabIndex = 6;
            this.CHB_CameraWatiching.Text = "كميرات المراقبة";
            this.CHB_CameraWatiching.UseVisualStyleBackColor = true;
            // 
            // CHB_Prescription
            // 
            this.CHB_Prescription.AutoSize = true;
            this.CHB_Prescription.Location = new System.Drawing.Point(2, 55);
            this.CHB_Prescription.Name = "CHB_Prescription";
            this.CHB_Prescription.Size = new System.Drawing.Size(95, 17);
            this.CHB_Prescription.TabIndex = 0;
            this.CHB_Prescription.Text = "وصفات المريض";
            this.CHB_Prescription.UseVisualStyleBackColor = true;
            // 
            // CHB_Appointment
            // 
            this.CHB_Appointment.AutoSize = true;
            this.CHB_Appointment.Location = new System.Drawing.Point(119, 55);
            this.CHB_Appointment.Name = "CHB_Appointment";
            this.CHB_Appointment.Size = new System.Drawing.Size(94, 17);
            this.CHB_Appointment.TabIndex = 0;
            this.CHB_Appointment.Text = "مواعيد المريض";
            this.CHB_Appointment.UseVisualStyleBackColor = true;
            // 
            // CHB_BackUp
            // 
            this.CHB_BackUp.AutoSize = true;
            this.CHB_BackUp.Location = new System.Drawing.Point(236, 167);
            this.CHB_BackUp.Name = "CHB_BackUp";
            this.CHB_BackUp.Size = new System.Drawing.Size(105, 17);
            this.CHB_BackUp.TabIndex = 3;
            this.CHB_BackUp.Text = "النسخ الاحتياطي";
            this.CHB_BackUp.UseVisualStyleBackColor = true;
            // 
            // CHB_Invoice
            // 
            this.CHB_Invoice.AutoSize = true;
            this.CHB_Invoice.Location = new System.Drawing.Point(346, 55);
            this.CHB_Invoice.Name = "CHB_Invoice";
            this.CHB_Invoice.Size = new System.Drawing.Size(113, 17);
            this.CHB_Invoice.TabIndex = 0;
            this.CHB_Invoice.Text = "اعطاء فواتير لمريض";
            this.CHB_Invoice.UseVisualStyleBackColor = true;
            // 
            // CHB_UserContolPanel
            // 
            this.CHB_UserContolPanel.AutoSize = true;
            this.CHB_UserContolPanel.Location = new System.Drawing.Point(215, 144);
            this.CHB_UserContolPanel.Name = "CHB_UserContolPanel";
            this.CHB_UserContolPanel.Size = new System.Drawing.Size(126, 17);
            this.CHB_UserContolPanel.TabIndex = 2;
            this.CHB_UserContolPanel.Text = "لوحة تحكم المستخدم";
            this.CHB_UserContolPanel.UseVisualStyleBackColor = true;
            // 
            // CHB_Radio
            // 
            this.CHB_Radio.AutoSize = true;
            this.CHB_Radio.Location = new System.Drawing.Point(457, 78);
            this.CHB_Radio.Name = "CHB_Radio";
            this.CHB_Radio.Size = new System.Drawing.Size(109, 17);
            this.CHB_Radio.TabIndex = 1;
            this.CHB_Radio.Text = "التصوير الاشعاعي";
            this.CHB_Radio.UseVisualStyleBackColor = true;
            // 
            // CHB_AdminControlPanal
            // 
            this.CHB_AdminControlPanal.AutoSize = true;
            this.CHB_AdminControlPanal.Location = new System.Drawing.Point(237, 121);
            this.CHB_AdminControlPanal.Name = "CHB_AdminControlPanal";
            this.CHB_AdminControlPanal.Size = new System.Drawing.Size(104, 17);
            this.CHB_AdminControlPanal.TabIndex = 1;
            this.CHB_AdminControlPanal.Text = "لوحة تحكم المدير";
            this.CHB_AdminControlPanal.UseVisualStyleBackColor = true;
            // 
            // CHB_Visit
            // 
            this.CHB_Visit.AutoSize = true;
            this.CHB_Visit.Location = new System.Drawing.Point(585, 144);
            this.CHB_Visit.Name = "CHB_Visit";
            this.CHB_Visit.Size = new System.Drawing.Size(89, 17);
            this.CHB_Visit.TabIndex = 4;
            this.CHB_Visit.Text = "زيارات المريض";
            this.CHB_Visit.UseVisualStyleBackColor = true;
            // 
            // CHB_ControlPanel
            // 
            this.CHB_ControlPanel.AutoSize = true;
            this.CHB_ControlPanel.Location = new System.Drawing.Point(260, 101);
            this.CHB_ControlPanel.Name = "CHB_ControlPanel";
            this.CHB_ControlPanel.Size = new System.Drawing.Size(81, 17);
            this.CHB_ControlPanel.TabIndex = 0;
            this.CHB_ControlPanel.Text = "لوحة التحكم";
            this.CHB_ControlPanel.UseVisualStyleBackColor = true;
            // 
            // CHB_Analysis
            // 
            this.CHB_Analysis.AutoSize = true;
            this.CHB_Analysis.Location = new System.Drawing.Point(475, 55);
            this.CHB_Analysis.Name = "CHB_Analysis";
            this.CHB_Analysis.Size = new System.Drawing.Size(91, 17);
            this.CHB_Analysis.TabIndex = 0;
            this.CHB_Analysis.Text = "تحاليل المريض";
            this.CHB_Analysis.UseVisualStyleBackColor = true;
            // 
            // PrescriptionMeun
            // 
            this.PrescriptionMeun.AutoSize = true;
            this.PrescriptionMeun.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionMeun.Location = new System.Drawing.Point(34, 32);
            this.PrescriptionMeun.Name = "PrescriptionMeun";
            this.PrescriptionMeun.Size = new System.Drawing.Size(63, 17);
            this.PrescriptionMeun.TabIndex = 5;
            this.PrescriptionMeun.Text = "الوصفة";
            this.PrescriptionMeun.UseVisualStyleBackColor = true;
            this.PrescriptionMeun.CheckedChanged += new System.EventHandler(this.PrescriptionMeun_CheckedChanged);
            // 
            // CHB_LastMedication
            // 
            this.CHB_LastMedication.AutoSize = true;
            this.CHB_LastMedication.Location = new System.Drawing.Point(531, 121);
            this.CHB_LastMedication.Name = "CHB_LastMedication";
            this.CHB_LastMedication.Size = new System.Drawing.Size(143, 17);
            this.CHB_LastMedication.TabIndex = 3;
            this.CHB_LastMedication.Text = "اضافة ادوية سابقة لمريض";
            this.CHB_LastMedication.UseVisualStyleBackColor = true;
            // 
            // AppointmentMeun
            // 
            this.AppointmentMeun.AutoSize = true;
            this.AppointmentMeun.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentMeun.Location = new System.Drawing.Point(145, 32);
            this.AppointmentMeun.Name = "AppointmentMeun";
            this.AppointmentMeun.Size = new System.Drawing.Size(68, 17);
            this.AppointmentMeun.TabIndex = 4;
            this.AppointmentMeun.Text = "المواعيد";
            this.AppointmentMeun.UseVisualStyleBackColor = true;
            this.AppointmentMeun.CheckedChanged += new System.EventHandler(this.AppointmentMeun_CheckedChanged);
            // 
            // CHB_lastDisease
            // 
            this.CHB_lastDisease.AutoSize = true;
            this.CHB_lastDisease.Location = new System.Drawing.Point(523, 101);
            this.CHB_lastDisease.Name = "CHB_lastDisease";
            this.CHB_lastDisease.Size = new System.Drawing.Size(151, 17);
            this.CHB_lastDisease.TabIndex = 2;
            this.CHB_lastDisease.Text = "اضافة امراض سابقة لمريض";
            this.CHB_lastDisease.UseVisualStyleBackColor = true;
            // 
            // ToolsMeun
            // 
            this.ToolsMeun.AutoSize = true;
            this.ToolsMeun.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsMeun.Location = new System.Drawing.Point(285, 32);
            this.ToolsMeun.Name = "ToolsMeun";
            this.ToolsMeun.Size = new System.Drawing.Size(56, 17);
            this.ToolsMeun.TabIndex = 3;
            this.ToolsMeun.Text = "ادوات";
            this.ToolsMeun.UseVisualStyleBackColor = true;
            this.ToolsMeun.CheckedChanged += new System.EventHandler(this.ToolsMeun_CheckedChanged);
            // 
            // CHB_OperationOfPatient
            // 
            this.CHB_OperationOfPatient.AutoSize = true;
            this.CHB_OperationOfPatient.Location = new System.Drawing.Point(577, 78);
            this.CHB_OperationOfPatient.Name = "CHB_OperationOfPatient";
            this.CHB_OperationOfPatient.Size = new System.Drawing.Size(97, 17);
            this.CHB_OperationOfPatient.TabIndex = 1;
            this.CHB_OperationOfPatient.Text = "عمليات المريض";
            this.CHB_OperationOfPatient.UseVisualStyleBackColor = true;
            // 
            // InvoiceMeun
            // 
            this.InvoiceMeun.AutoSize = true;
            this.InvoiceMeun.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceMeun.Location = new System.Drawing.Point(383, 32);
            this.InvoiceMeun.Name = "InvoiceMeun";
            this.InvoiceMeun.Size = new System.Drawing.Size(76, 17);
            this.InvoiceMeun.TabIndex = 2;
            this.InvoiceMeun.Text = "المحاسبة";
            this.InvoiceMeun.UseVisualStyleBackColor = true;
            this.InvoiceMeun.CheckedChanged += new System.EventHandler(this.InvoiceMeun_CheckedChanged);
            // 
            // CHB_FilePatient
            // 
            this.CHB_FilePatient.AutoSize = true;
            this.CHB_FilePatient.Location = new System.Drawing.Point(591, 55);
            this.CHB_FilePatient.Name = "CHB_FilePatient";
            this.CHB_FilePatient.Size = new System.Drawing.Size(83, 17);
            this.CHB_FilePatient.TabIndex = 0;
            this.CHB_FilePatient.Text = "ملف المريض";
            this.CHB_FilePatient.UseVisualStyleBackColor = true;
            // 
            // AnalysisMenu
            // 
            this.AnalysisMenu.AutoSize = true;
            this.AnalysisMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalysisMenu.Location = new System.Drawing.Point(499, 32);
            this.AnalysisMenu.Name = "AnalysisMenu";
            this.AnalysisMenu.Size = new System.Drawing.Size(67, 17);
            this.AnalysisMenu.TabIndex = 1;
            this.AnalysisMenu.Text = "التحاليل";
            this.AnalysisMenu.UseVisualStyleBackColor = true;
            this.AnalysisMenu.CheckedChanged += new System.EventHandler(this.AnalysisMenu_CheckedChanged);
            // 
            // PatientMenu
            // 
            this.PatientMenu.AutoSize = true;
            this.PatientMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientMenu.Location = new System.Drawing.Point(608, 32);
            this.PatientMenu.Name = "PatientMenu";
            this.PatientMenu.Size = new System.Drawing.Size(67, 17);
            this.PatientMenu.TabIndex = 0;
            this.PatientMenu.Text = "المريض";
            this.PatientMenu.UseVisualStyleBackColor = true;
            this.PatientMenu.CheckedChanged += new System.EventHandler(this.PatientMenu_CheckedChanged);
            // 
            // FrmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 300);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 336);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 336);
            this.Name = "FrmPermission";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "السماحيات";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmPermission_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TS_Permission.ResumeLayout(false);
            this.TS_Permission.PerformLayout();
            this.GB_Permission.ResumeLayout(false);
            this.GB_Permission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.GB_ToolsBox.ResumeLayout(false);
            this.GB_ToolsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip TS_Permission;
        private System.Windows.Forms.ToolStripButton btn_Add;
        private System.Windows.Forms.ToolStripButton btn_Updata;
        private System.Windows.Forms.ToolStripButton btn_Delelte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Back;
        private System.Windows.Forms.GroupBox GB_Permission;
        private System.Windows.Forms.GroupBox GB_ToolsBox;
        private System.Windows.Forms.CheckBox ToolsMeun;
        private System.Windows.Forms.CheckBox InvoiceMeun;
        private System.Windows.Forms.CheckBox AnalysisMenu;
        private System.Windows.Forms.CheckBox PatientMenu;
        private System.Windows.Forms.CheckBox PrescriptionMeun;
        private System.Windows.Forms.CheckBox AppointmentMeun;
        private System.Windows.Forms.CheckBox CHB_Visit;
        private System.Windows.Forms.CheckBox CHB_LastMedication;
        private System.Windows.Forms.CheckBox CHB_lastDisease;
        private System.Windows.Forms.CheckBox CHB_OperationOfPatient;
        private System.Windows.Forms.CheckBox CHB_FilePatient;
        private System.Windows.Forms.CheckBox CHB_Radio;
        private System.Windows.Forms.CheckBox CHB_Analysis;
        private System.Windows.Forms.CheckBox CHB_ControlPanel;
        private System.Windows.Forms.CheckBox CHB_Invoice;
        private System.Windows.Forms.CheckBox CHB_AdminControlPanal;
        private System.Windows.Forms.CheckBox CHB_Prescription;
        private System.Windows.Forms.CheckBox CHB_Appointment;
        private System.Windows.Forms.CheckBox CHB_UserContolPanel;
        private System.Windows.Forms.CheckBox CHB_BackUp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel STB_State;
        private System.Windows.Forms.ToolStripStatusLabel STB_UserName;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.ToolStripButton TS_FillAlCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.CheckBox CHB_BrowesImage;
        private System.Windows.Forms.CheckBox CHB_CameraWatiching;
    }
}