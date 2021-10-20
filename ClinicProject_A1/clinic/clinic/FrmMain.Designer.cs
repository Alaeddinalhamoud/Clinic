namespace clinic
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_ChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MS_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.PatientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.filePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastDiseaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmLastMedicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.visitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalysisMeun = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frmRadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoiceMeun = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Invoice = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMeun = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Camera = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlMeun = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSS_UserAcount = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_AdminControlPanal = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_UserContolPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Bakup = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_MakeBakup = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_RestporBAckup = new System.Windows.Forms.ToolStripMenuItem();
            this.AppointmentMeun = new System.Windows.Forms.ToolStripMenuItem();
            this.frmAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrescriptionMeun = new System.Windows.Forms.ToolStripMenuItem();
            this.frmPrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Pharmacy = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_SMR = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Help_MAin = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_HelpsOUS = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_AboutOus = new System.Windows.Forms.ToolStripMenuItem();
            this.SSB_MAin = new System.Windows.Forms.StatusStrip();
            this.TS_UserImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.TS_UserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TS_Clock = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_UserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TS_Main = new System.Windows.Forms.ToolStrip();
            this.MU_Appoentent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TSS_Patient = new System.Windows.Forms.ToolStripButton();
            this.Mu_Visit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Analysis_MAin = new System.Windows.Forms.ToolStripButton();
            this.TS_Radio_Main = new System.Windows.Forms.ToolStripButton();
            this.TS_Help = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.Mu_Prescrption = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Mu_Invoice = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.CMeunTaskBAr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TS_Show_Programs = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Hide_Prgoram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_EXIT_User = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Exit_P = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Main.SuspendLayout();
            this.SSB_MAin.SuspendLayout();
            this.TS_Main.SuspendLayout();
            this.CMeunTaskBAr.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_Main
            // 
            this.MS_Main.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.PatientMenu,
            this.AnalysisMeun,
            this.InvoiceMeun,
            this.ToolsMeun,
            this.AppointmentMeun,
            this.PrescriptionMeun,
            this.TS_Help_MAin});
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MS_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MS_Main.Size = new System.Drawing.Size(900, 26);
            this.MS_Main.TabIndex = 6;
            this.MS_Main.Text = "القائمة الرئيسية";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_ChangeUser,
            this.toolStripSeparator2,
            this.MS_Exit});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FileMenu.Size = new System.Drawing.Size(48, 26);
            this.FileMenu.Text = "&ملف";
            // 
            // TS_ChangeUser
            // 
            this.TS_ChangeUser.Name = "TS_ChangeUser";
            this.TS_ChangeUser.Size = new System.Drawing.Size(188, 26);
            this.TS_ChangeUser.Text = "تسجيل الخروج";
            this.TS_ChangeUser.Click += new System.EventHandler(this.TS_ChangeUser_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // MS_Exit
            // 
            this.MS_Exit.Image = global::clinic.Properties.Resources.exit;
            this.MS_Exit.Name = "MS_Exit";
            this.MS_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MS_Exit.Size = new System.Drawing.Size(188, 26);
            this.MS_Exit.Text = "خروج";
            this.MS_Exit.Click += new System.EventHandler(this.MS_Exit_Click);
            // 
            // PatientMenu
            // 
            this.PatientMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filePatientToolStripMenuItem,
            this.operationToolStripMenuItem,
            this.lastDiseaseToolStripMenuItem,
            this.frmLastMedicationToolStripMenuItem,
            this.toolStripSeparator1,
            this.visitToolStripMenuItem});
            this.PatientMenu.Name = "PatientMenu";
            this.PatientMenu.Size = new System.Drawing.Size(72, 26);
            this.PatientMenu.Text = "المر&يض";
            // 
            // filePatientToolStripMenuItem
            // 
            this.filePatientToolStripMenuItem.Image = global::clinic.Properties.Resources.User_Accounts1;
            this.filePatientToolStripMenuItem.Name = "filePatientToolStripMenuItem";
            this.filePatientToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.filePatientToolStripMenuItem.Text = "ملف المريض";
            this.filePatientToolStripMenuItem.Click += new System.EventHandler(this.filePatientToolStripMenuItem_Click);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.Image = global::clinic.Properties.Resources.Ambulance_Add;
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.operationToolStripMenuItem.Text = "عمليات المريض";
            this.operationToolStripMenuItem.Click += new System.EventHandler(this.operationToolStripMenuItem_Click);
            // 
            // lastDiseaseToolStripMenuItem
            // 
            this.lastDiseaseToolStripMenuItem.Name = "lastDiseaseToolStripMenuItem";
            this.lastDiseaseToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.lastDiseaseToolStripMenuItem.Text = "امراض سابقة";
            this.lastDiseaseToolStripMenuItem.Click += new System.EventHandler(this.lastDiseaseToolStripMenuItem_Click);
            // 
            // frmLastMedicationToolStripMenuItem
            // 
            this.frmLastMedicationToolStripMenuItem.Name = "frmLastMedicationToolStripMenuItem";
            this.frmLastMedicationToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.frmLastMedicationToolStripMenuItem.Text = "ادوية سايقة";
            this.frmLastMedicationToolStripMenuItem.Click += new System.EventHandler(this.frmLastMedicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // visitToolStripMenuItem
            // 
            this.visitToolStripMenuItem.Image = global::clinic.Properties.Resources.user_48;
            this.visitToolStripMenuItem.Name = "visitToolStripMenuItem";
            this.visitToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.visitToolStripMenuItem.Text = "زياره";
            this.visitToolStripMenuItem.Click += new System.EventHandler(this.visitToolStripMenuItem_Click);
            // 
            // AnalysisMeun
            // 
            this.AnalysisMeun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analysisToolStripMenuItem1,
            this.frmRadioToolStripMenuItem});
            this.AnalysisMeun.Name = "AnalysisMeun";
            this.AnalysisMeun.Size = new System.Drawing.Size(68, 26);
            this.AnalysisMeun.Text = "التحاليل";
            // 
            // analysisToolStripMenuItem1
            // 
            this.analysisToolStripMenuItem1.Image = global::clinic.Properties.Resources.microscope_128_hot;
            this.analysisToolStripMenuItem1.Name = "analysisToolStripMenuItem1";
            this.analysisToolStripMenuItem1.Size = new System.Drawing.Size(196, 26);
            this.analysisToolStripMenuItem1.Text = "التحاليل";
            this.analysisToolStripMenuItem1.Click += new System.EventHandler(this.analysisToolStripMenuItem1_Click);
            // 
            // frmRadioToolStripMenuItem
            // 
            this.frmRadioToolStripMenuItem.Image = global::clinic.Properties.Resources.AllDesign_biz_12;
            this.frmRadioToolStripMenuItem.Name = "frmRadioToolStripMenuItem";
            this.frmRadioToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.frmRadioToolStripMenuItem.Text = "التصوير الاشعاعي";
            this.frmRadioToolStripMenuItem.Click += new System.EventHandler(this.frmRadioToolStripMenuItem_Click);
            // 
            // InvoiceMeun
            // 
            this.InvoiceMeun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Invoice});
            this.InvoiceMeun.Name = "InvoiceMeun";
            this.InvoiceMeun.Size = new System.Drawing.Size(73, 26);
            this.InvoiceMeun.Text = "المحاسبة";
            // 
            // MS_Invoice
            // 
            this.MS_Invoice.Name = "MS_Invoice";
            this.MS_Invoice.Size = new System.Drawing.Size(116, 26);
            this.MS_Invoice.Text = "فاتوره";
            this.MS_Invoice.Click += new System.EventHandler(this.frmInvoiceToolStripMenuItem_Click);
            // 
            // ToolsMeun
            // 
            this.ToolsMeun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Camera,
            this.ImageViewer,
            this.ControlMeun,
            this.toolStripSeparator3,
            this.TSS_UserAcount,
            this.toolStripSeparator7,
            this.TS_Bakup});
            this.ToolsMeun.Name = "ToolsMeun";
            this.ToolsMeun.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.ToolsMeun.Size = new System.Drawing.Size(58, 26);
            this.ToolsMeun.Text = "ادوات";
            // 
            // TS_Camera
            // 
            this.TS_Camera.Image = global::clinic.Properties.Resources.pc_webcam;
            this.TS_Camera.Name = "TS_Camera";
            this.TS_Camera.Size = new System.Drawing.Size(204, 26);
            this.TS_Camera.Text = "كاميرات المراقبة";
            this.TS_Camera.Click += new System.EventHandler(this.TS_Camera_Click);
            // 
            // ImageViewer
            // 
            this.ImageViewer.Image = global::clinic.Properties.Resources._226asmilies_com;
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.Size = new System.Drawing.Size(204, 26);
            this.ImageViewer.Text = "مستعرض الصور";
            this.ImageViewer.Click += new System.EventHandler(this.ImageViewer_Click);
            // 
            // ControlMeun
            // 
            this.ControlMeun.Image = global::clinic.Properties.Resources.Control_Panel;
            this.ControlMeun.Name = "ControlMeun";
            this.ControlMeun.Size = new System.Drawing.Size(204, 26);
            this.ControlMeun.Text = "لوحة تحكم البرنامج";
            this.ControlMeun.ToolTipText = "لوحة تحكم البرنامج";
            this.ControlMeun.Click += new System.EventHandler(this.ControlMeun_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
            // 
            // TSS_UserAcount
            // 
            this.TSS_UserAcount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_AdminControlPanal,
            this.TS_UserContolPanel});
            this.TSS_UserAcount.Image = global::clinic.Properties.Resources._253asmilies_com;
            this.TSS_UserAcount.Name = "TSS_UserAcount";
            this.TSS_UserAcount.Size = new System.Drawing.Size(204, 26);
            this.TSS_UserAcount.Text = "حسابات المستخدمين";
            // 
            // TS_AdminControlPanal
            // 
            this.TS_AdminControlPanal.Name = "TS_AdminControlPanal";
            this.TS_AdminControlPanal.Size = new System.Drawing.Size(199, 26);
            this.TS_AdminControlPanal.Text = "لوحة تحكم المدير";
            this.TS_AdminControlPanal.Click += new System.EventHandler(this.TS_AdminControlPanal_Click);
            // 
            // TS_UserContolPanel
            // 
            this.TS_UserContolPanel.Name = "TS_UserContolPanel";
            this.TS_UserContolPanel.Size = new System.Drawing.Size(199, 26);
            this.TS_UserContolPanel.Text = "لوحة تحكم المستخدم";
            this.TS_UserContolPanel.Click += new System.EventHandler(this.TS_UserContolPanel_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(201, 6);
            // 
            // TS_Bakup
            // 
            this.TS_Bakup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_MakeBakup,
            this.TS_RestporBAckup});
            this.TS_Bakup.Image = global::clinic.Properties.Resources.data_server;
            this.TS_Bakup.Name = "TS_Bakup";
            this.TS_Bakup.Size = new System.Drawing.Size(204, 26);
            this.TS_Bakup.Text = "النسخ الاحتياطي";
            // 
            // TS_MakeBakup
            // 
            this.TS_MakeBakup.Image = global::clinic.Properties.Resources.database_down;
            this.TS_MakeBakup.Name = "TS_MakeBakup";
            this.TS_MakeBakup.Size = new System.Drawing.Size(162, 26);
            this.TS_MakeBakup.Text = "صنع نسخة";
            this.TS_MakeBakup.Click += new System.EventHandler(this.TS_MakeBakup_Click);
            // 
            // TS_RestporBAckup
            // 
            this.TS_RestporBAckup.Image = global::clinic.Properties.Resources.database_up;
            this.TS_RestporBAckup.Name = "TS_RestporBAckup";
            this.TS_RestporBAckup.Size = new System.Drawing.Size(162, 26);
            this.TS_RestporBAckup.Text = "استعاده نسخة";
            this.TS_RestporBAckup.Click += new System.EventHandler(this.TS_RestporBAckup_Click);
            // 
            // AppointmentMeun
            // 
            this.AppointmentMeun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmAppointmentToolStripMenuItem});
            this.AppointmentMeun.Name = "AppointmentMeun";
            this.AppointmentMeun.Size = new System.Drawing.Size(70, 26);
            this.AppointmentMeun.Text = "المواعيد";
            // 
            // frmAppointmentToolStripMenuItem
            // 
            this.frmAppointmentToolStripMenuItem.Image = global::clinic.Properties.Resources.Date_and_Time;
            this.frmAppointmentToolStripMenuItem.Name = "frmAppointmentToolStripMenuItem";
            this.frmAppointmentToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.frmAppointmentToolStripMenuItem.Text = "جدول المواعيد";
            this.frmAppointmentToolStripMenuItem.ToolTipText = "جدول المواعيد";
            this.frmAppointmentToolStripMenuItem.Click += new System.EventHandler(this.frmAppointmentToolStripMenuItem_Click);
            // 
            // PrescriptionMeun
            // 
            this.PrescriptionMeun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmPrescriptionToolStripMenuItem,
            this.TSM_Pharmacy,
            this.TSM_SMR});
            this.PrescriptionMeun.Name = "PrescriptionMeun";
            this.PrescriptionMeun.Size = new System.Drawing.Size(73, 26);
            this.PrescriptionMeun.Text = "الصيدلية";
            // 
            // frmPrescriptionToolStripMenuItem
            // 
            this.frmPrescriptionToolStripMenuItem.Image = global::clinic.Properties.Resources.snake_cup_032;
            this.frmPrescriptionToolStripMenuItem.Name = "frmPrescriptionToolStripMenuItem";
            this.frmPrescriptionToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.frmPrescriptionToolStripMenuItem.Text = "الوصفة";
            this.frmPrescriptionToolStripMenuItem.Click += new System.EventHandler(this.frmPrescriptionToolStripMenuItem_Click);
            // 
            // TSM_Pharmacy
            // 
            this.TSM_Pharmacy.Name = "TSM_Pharmacy";
            this.TSM_Pharmacy.Size = new System.Drawing.Size(226, 26);
            this.TSM_Pharmacy.Text = "الصيدلية";
            this.TSM_Pharmacy.Click += new System.EventHandler(this.TSM_Pharmacy_Click);
            // 
            // TSM_SMR
            // 
            this.TSM_SMR.Image = global::clinic.Properties.Resources.LaST__Cobalt__Books;
            this.TSM_SMR.Name = "TSM_SMR";
            this.TSM_SMR.Size = new System.Drawing.Size(226, 26);
            this.TSM_SMR.Text = "المرجع الدوائي السوري";
            this.TSM_SMR.Click += new System.EventHandler(this.TSM_SMR_Click);
            // 
            // TS_Help_MAin
            // 
            this.TS_Help_MAin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_HelpsOUS,
            this.TS_AboutOus});
            this.TS_Help_MAin.Name = "TS_Help_MAin";
            this.TS_Help_MAin.Size = new System.Drawing.Size(64, 26);
            this.TS_Help_MAin.Text = "مساعده";
            // 
            // TS_HelpsOUS
            // 
            this.TS_HelpsOUS.Image = global::clinic.Properties.Resources.Help_1;
            this.TS_HelpsOUS.Name = "TS_HelpsOUS";
            this.TS_HelpsOUS.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.TS_HelpsOUS.Size = new System.Drawing.Size(188, 26);
            this.TS_HelpsOUS.Text = "مساعده";
            this.TS_HelpsOUS.Click += new System.EventHandler(this.TS_HelpsOUS_Click);
            // 
            // TS_AboutOus
            // 
            this.TS_AboutOus.Name = "TS_AboutOus";
            this.TS_AboutOus.Size = new System.Drawing.Size(188, 26);
            this.TS_AboutOus.Text = "نبذه عن البرنامج ";
            this.TS_AboutOus.Click += new System.EventHandler(this.TS_AboutOus_Click);
            // 
            // SSB_MAin
            // 
            this.SSB_MAin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SSB_MAin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_UserImage,
            this.TS_UserName,
            this.TS_Clock,
            this.lbl_UserName});
            this.SSB_MAin.Location = new System.Drawing.Point(0, 464);
            this.SSB_MAin.Name = "SSB_MAin";
            this.SSB_MAin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SSB_MAin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SSB_MAin.Size = new System.Drawing.Size(900, 25);
            this.SSB_MAin.TabIndex = 8;
            // 
            // TS_UserImage
            // 
            this.TS_UserImage.Image = global::clinic.Properties.Resources.she_user;
            this.TS_UserImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TS_UserImage.Name = "TS_UserImage";
            this.TS_UserImage.Size = new System.Drawing.Size(104, 20);
            this.TS_UserImage.Text = "المستخدم الحالي:";
            this.TS_UserImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TS_UserImage.ToolTipText = "المستخدم الحالي:";
            // 
            // TS_UserName
            // 
            this.TS_UserName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TS_UserName.Name = "TS_UserName";
            this.TS_UserName.Size = new System.Drawing.Size(390, 20);
            this.TS_UserName.Spring = true;
            this.TS_UserName.Text = "User";
            this.TS_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TS_Clock
            // 
            this.TS_Clock.Image = global::clinic.Properties.Resources._381asmilies_com;
            this.TS_Clock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TS_Clock.Name = "TS_Clock";
            this.TS_Clock.Size = new System.Drawing.Size(390, 20);
            this.TS_Clock.Spring = true;
            this.TS_Clock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(0, 20);
            // 
            // TS_Main
            // 
            this.TS_Main.AutoSize = false;
            this.TS_Main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_Main.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.TS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MU_Appoentent,
            this.toolStripSeparator6,
            this.TSS_Patient,
            this.Mu_Visit,
            this.toolStripSeparator5,
            this.TS_Analysis_MAin,
            this.TS_Radio_Main,
            this.TS_Help,
            this.toolStripSeparator8,
            this.Mu_Prescrption,
            this.toolStripSeparator4,
            this.Mu_Invoice});
            this.TS_Main.Location = new System.Drawing.Point(0, 26);
            this.TS_Main.Name = "TS_Main";
            this.TS_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TS_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TS_Main.Size = new System.Drawing.Size(900, 50);
            this.TS_Main.TabIndex = 9;
            // 
            // MU_Appoentent
            // 
            this.MU_Appoentent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MU_Appoentent.Image = global::clinic.Properties.Resources.Date_and_Time__Custom_;
            this.MU_Appoentent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MU_Appoentent.Name = "MU_Appoentent";
            this.MU_Appoentent.Size = new System.Drawing.Size(44, 47);
            this.MU_Appoentent.Text = "جدول المواعيد";
            this.MU_Appoentent.Click += new System.EventHandler(this.MU_Appoentent_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 50);
            // 
            // TSS_Patient
            // 
            this.TSS_Patient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSS_Patient.Image = global::clinic.Properties.Resources.User_Accounts1;
            this.TSS_Patient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSS_Patient.Name = "TSS_Patient";
            this.TSS_Patient.Size = new System.Drawing.Size(44, 47);
            this.TSS_Patient.ToolTipText = "ملف المريض";
            this.TSS_Patient.Click += new System.EventHandler(this.TSS_Patient_Click);
            // 
            // Mu_Visit
            // 
            this.Mu_Visit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Mu_Visit.Image = global::clinic.Properties.Resources.user_48;
            this.Mu_Visit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Mu_Visit.Name = "Mu_Visit";
            this.Mu_Visit.Size = new System.Drawing.Size(44, 47);
            this.Mu_Visit.Text = "زياره";
            this.Mu_Visit.Click += new System.EventHandler(this.Mu_Visit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 50);
            // 
            // TS_Analysis_MAin
            // 
            this.TS_Analysis_MAin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_Analysis_MAin.Image = global::clinic.Properties.Resources.microscope_48;
            this.TS_Analysis_MAin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Analysis_MAin.Name = "TS_Analysis_MAin";
            this.TS_Analysis_MAin.Size = new System.Drawing.Size(44, 47);
            this.TS_Analysis_MAin.Text = "تحاليل";
            this.TS_Analysis_MAin.Click += new System.EventHandler(this.TS_Analysis_MAin_Click);
            // 
            // TS_Radio_Main
            // 
            this.TS_Radio_Main.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_Radio_Main.Image = global::clinic.Properties.Resources.AllDesign_biz_12;
            this.TS_Radio_Main.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Radio_Main.Name = "TS_Radio_Main";
            this.TS_Radio_Main.Size = new System.Drawing.Size(44, 47);
            this.TS_Radio_Main.Text = "تصوير شعاعي";
            this.TS_Radio_Main.Click += new System.EventHandler(this.TS_Radio_Main_Click);
            // 
            // TS_Help
            // 
            this.TS_Help.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TS_Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_Help.Image = global::clinic.Properties.Resources.Help_1;
            this.TS_Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Help.Name = "TS_Help";
            this.TS_Help.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TS_Help.Size = new System.Drawing.Size(44, 47);
            this.TS_Help.Text = "مساعده";
            this.TS_Help.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TS_Help.Click += new System.EventHandler(this.TS_Help_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 50);
            // 
            // Mu_Prescrption
            // 
            this.Mu_Prescrption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Mu_Prescrption.Image = global::clinic.Properties.Resources.snake_cup_048;
            this.Mu_Prescrption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Mu_Prescrption.Name = "Mu_Prescrption";
            this.Mu_Prescrption.Size = new System.Drawing.Size(44, 47);
            this.Mu_Prescrption.Text = "الوصفة";
            this.Mu_Prescrption.Click += new System.EventHandler(this.Mu_Prescrption_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 50);
            // 
            // Mu_Invoice
            // 
            this.Mu_Invoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Mu_Invoice.Image = global::clinic.Properties.Resources.medical_insurance_32x32x8b;
            this.Mu_Invoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Mu_Invoice.Name = "Mu_Invoice";
            this.Mu_Invoice.Size = new System.Drawing.Size(44, 47);
            this.Mu_Invoice.Text = "فاتوره";
            this.Mu_Invoice.Click += new System.EventHandler(this.Mu_Invoice_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notify
            // 
            this.notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notify.ContextMenuStrip = this.CMeunTaskBAr;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Futuer Clinic";
            this.notify.Visible = true;
            // 
            // CMeunTaskBAr
            // 
            this.CMeunTaskBAr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Show_Programs,
            this.TS_Hide_Prgoram,
            this.toolStripSeparator10,
            this.TS_EXIT_User,
            this.toolStripSeparator9,
            this.TS_Exit_P});
            this.CMeunTaskBAr.Name = "CMeunTaskBAr";
            this.CMeunTaskBAr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CMeunTaskBAr.Size = new System.Drawing.Size(140, 104);
            // 
            // TS_Show_Programs
            // 
            this.TS_Show_Programs.Name = "TS_Show_Programs";
            this.TS_Show_Programs.Size = new System.Drawing.Size(139, 22);
            this.TS_Show_Programs.Text = "اظهار البرنامج";
            this.TS_Show_Programs.Click += new System.EventHandler(this.TS_Show_Programs_Click);
            // 
            // TS_Hide_Prgoram
            // 
            this.TS_Hide_Prgoram.Name = "TS_Hide_Prgoram";
            this.TS_Hide_Prgoram.Size = new System.Drawing.Size(139, 22);
            this.TS_Hide_Prgoram.Text = "اخفاء البرنامج";
            this.TS_Hide_Prgoram.Click += new System.EventHandler(this.TS_Hide_Prgoram_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(136, 6);
            // 
            // TS_EXIT_User
            // 
            this.TS_EXIT_User.Enabled = false;
            this.TS_EXIT_User.Name = "TS_EXIT_User";
            this.TS_EXIT_User.Size = new System.Drawing.Size(139, 22);
            this.TS_EXIT_User.Text = "تسجيل خروج ";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(136, 6);
            // 
            // TS_Exit_P
            // 
            this.TS_Exit_P.Name = "TS_Exit_P";
            this.TS_Exit_P.Size = new System.Drawing.Size(139, 22);
            this.TS_Exit_P.Text = "خروج";
            this.TS_Exit_P.Click += new System.EventHandler(this.TS_Exit_P_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 489);
            this.Controls.Add(this.TS_Main);
            this.Controls.Add(this.SSB_MAin);
            this.Controls.Add(this.MS_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Futuer Clinic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.SSB_MAin.ResumeLayout(false);
            this.SSB_MAin.PerformLayout();
            this.TS_Main.ResumeLayout(false);
            this.TS_Main.PerformLayout();
            this.CMeunTaskBAr.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.StatusStrip SSB_MAin;
        private System.Windows.Forms.ToolStrip TS_Main;
        private System.Windows.Forms.ToolStripMenuItem PatientMenu;
        private System.Windows.Forms.ToolStripMenuItem filePatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsMeun;
        private System.Windows.Forms.ToolStripMenuItem lastDiseaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmLastMedicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppointmentMeun;
        private System.Windows.Forms.ToolStripMenuItem frmAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvoiceMeun;
        private System.Windows.Forms.ToolStripMenuItem MS_Invoice;
        private System.Windows.Forms.ToolStripMenuItem AnalysisMeun;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem frmRadioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrescriptionMeun;
        private System.Windows.Forms.ToolStripMenuItem frmPrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MS_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem TS_Bakup;
        private System.Windows.Forms.ToolStripMenuItem TS_MakeBakup;
        private System.Windows.Forms.ToolStripMenuItem TS_RestporBAckup;
        private System.Windows.Forms.ToolStripButton TSS_Patient;
        private System.Windows.Forms.ToolStripStatusLabel TS_Clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton Mu_Visit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Mu_Invoice;
        private System.Windows.Forms.ToolStripButton Mu_Prescrption;
        private System.Windows.Forms.ToolStripButton MU_Appoentent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton TS_Analysis_MAin;
        private System.Windows.Forms.ToolStripButton TS_Radio_Main;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton TS_Help;
        private System.Windows.Forms.ToolStripMenuItem TS_Help_MAin;
        private System.Windows.Forms.ToolStripMenuItem TS_HelpsOUS;
        private System.Windows.Forms.ToolStripMenuItem TS_AboutOus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem TS_ChangeUser;
        private System.Windows.Forms.ToolStripMenuItem TSS_UserAcount;
        private System.Windows.Forms.ToolStripMenuItem TS_AdminControlPanal;
        private System.Windows.Forms.ToolStripMenuItem TS_UserContolPanel;
        private System.Windows.Forms.ToolStripStatusLabel lbl_UserName;
        private System.Windows.Forms.ToolStripMenuItem ControlMeun;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip CMeunTaskBAr;
        private System.Windows.Forms.ToolStripMenuItem TS_Show_Programs;
        private System.Windows.Forms.ToolStripMenuItem TS_Hide_Prgoram;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem TS_EXIT_User;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem TS_Exit_P;
        private System.Windows.Forms.ToolStripStatusLabel TS_UserImage;
        private System.Windows.Forms.ToolStripStatusLabel TS_UserName;
        private System.Windows.Forms.ToolStripMenuItem ImageViewer;
        private System.Windows.Forms.ToolStripMenuItem TS_Camera;
        private System.Windows.Forms.ToolStripMenuItem TSM_Pharmacy;
        private System.Windows.Forms.ToolStripMenuItem TSM_SMR;

    }
}

