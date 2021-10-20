namespace clinic.Invoice
{
    partial class FrmInvoice
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
            this.TS_Invoice = new System.Windows.Forms.ToolStrip();
            this.TS_Add_Invoice = new System.Windows.Forms.ToolStripButton();
            this.TS_UpDate = new System.Windows.Forms.ToolStripButton();
            this.TS_Delete_Invoice = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_ReportInvoice = new System.Windows.Forms.ToolStripSplitButton();
            this.Tss_PatientReportInvfoice = new System.Windows.Forms.ToolStripMenuItem();
            this.TSS_Report_PatirntInvoiS = new System.Windows.Forms.ToolStripMenuItem();
            this.Tss_MonthReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_BAck = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GB_Info = new System.Windows.Forms.GroupBox();
            this.txt_PtientInher = new System.Windows.Forms.TextBox();
            this.lbl_DateInvoice = new System.Windows.Forms.Label();
            this.DPK_DateInvoice = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Cmb_VisitID = new System.Windows.Forms.ComboBox();
            this.Cmb_Patient = new System.Windows.Forms.ComboBox();
            this.lbl_VisitID = new System.Windows.Forms.Label();
            this.lbl_PatientID = new System.Windows.Forms.Label();
            this.GB_Invoice = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.txt_Reminder = new System.Windows.Forms.TextBox();
            this.lbl_Reminder = new System.Windows.Forms.Label();
            this.txt_PaidMoney = new System.Windows.Forms.TextBox();
            this.lbl_PaidMoney = new System.Windows.Forms.Label();
            this.txt_InvoiceID = new System.Windows.Forms.TextBox();
            this.DGV_Invoice_All = new System.Windows.Forms.DataGridView();
            this.InVoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reminder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TS_Invoice.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GB_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GB_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Invoice_All)).BeginInit();
            this.SuspendLayout();
            // 
            // TS_Invoice
            // 
            this.TS_Invoice.AutoSize = false;
            this.TS_Invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Invoice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_Invoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add_Invoice,
            this.TS_UpDate,
            this.TS_Delete_Invoice,
            this.toolStripSeparator1,
            this.TS_ReportInvoice,
            this.toolStripSeparator2,
            this.TS_BAck});
            this.TS_Invoice.Location = new System.Drawing.Point(0, 0);
            this.TS_Invoice.Name = "TS_Invoice";
            this.TS_Invoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TS_Invoice.Size = new System.Drawing.Size(655, 40);
            this.TS_Invoice.TabIndex = 1;
            this.TS_Invoice.Text = "toolStrip1";
            // 
            // TS_Add_Invoice
            // 
            this.TS_Add_Invoice.Image = global::clinic.Properties.Resources.add;
            this.TS_Add_Invoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add_Invoice.Name = "TS_Add_Invoice";
            this.TS_Add_Invoice.Size = new System.Drawing.Size(102, 37);
            this.TS_Add_Invoice.Text = "اضافة فاتوره";
            this.TS_Add_Invoice.Click += new System.EventHandler(this.TS_Add_Invoice_Click);
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
            // TS_Delete_Invoice
            // 
            this.TS_Delete_Invoice.Image = global::clinic.Properties.Resources.remove;
            this.TS_Delete_Invoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Delete_Invoice.Name = "TS_Delete_Invoice";
            this.TS_Delete_Invoice.Size = new System.Drawing.Size(59, 37);
            this.TS_Delete_Invoice.Text = "حذف";
            this.TS_Delete_Invoice.Click += new System.EventHandler(this.TS_Delete_Invoice_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // TS_ReportInvoice
            // 
            this.TS_ReportInvoice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tss_PatientReportInvfoice,
            this.TSS_Report_PatirntInvoiS,
            this.Tss_MonthReport});
            this.TS_ReportInvoice.Image = global::clinic.Properties.Resources.medical_insurance_32x32x8b;
            this.TS_ReportInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_ReportInvoice.Name = "TS_ReportInvoice";
            this.TS_ReportInvoice.Size = new System.Drawing.Size(76, 37);
            this.TS_ReportInvoice.Text = "فواتير";
            // 
            // Tss_PatientReportInvfoice
            // 
            this.Tss_PatientReportInvfoice.Name = "Tss_PatientReportInvfoice";
            this.Tss_PatientReportInvfoice.Size = new System.Drawing.Size(190, 24);
            this.Tss_PatientReportInvfoice.Text = "طباعة فاتورة ";
            this.Tss_PatientReportInvfoice.Click += new System.EventHandler(this.Tss_PatientReportInvfoice_Click);
            // 
            // TSS_Report_PatirntInvoiS
            // 
            this.TSS_Report_PatirntInvoiS.Name = "TSS_Report_PatirntInvoiS";
            this.TSS_Report_PatirntInvoiS.Size = new System.Drawing.Size(190, 24);
            this.TSS_Report_PatirntInvoiS.Text = "طباعة فواتير المريض";
            this.TSS_Report_PatirntInvoiS.Click += new System.EventHandler(this.TSS_Report_PatirntInvoiS_Click);
            // 
            // Tss_MonthReport
            // 
            this.Tss_MonthReport.Name = "Tss_MonthReport";
            this.Tss_MonthReport.Size = new System.Drawing.Size(190, 24);
            this.Tss_MonthReport.Text = "طباعة فواتير الشهر";
            this.Tss_MonthReport.Click += new System.EventHandler(this.Tss_MonthReport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GB_Info, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GB_Invoice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DGV_Invoice_All, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.59292F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.40708F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 387);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // GB_Info
            // 
            this.GB_Info.Controls.Add(this.txt_PtientInher);
            this.GB_Info.Controls.Add(this.lbl_DateInvoice);
            this.GB_Info.Controls.Add(this.DPK_DateInvoice);
            this.GB_Info.Controls.Add(this.pictureBox2);
            this.GB_Info.Controls.Add(this.Cmb_VisitID);
            this.GB_Info.Controls.Add(this.Cmb_Patient);
            this.GB_Info.Controls.Add(this.lbl_VisitID);
            this.GB_Info.Controls.Add(this.lbl_PatientID);
            this.GB_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Info.Location = new System.Drawing.Point(3, 3);
            this.GB_Info.Name = "GB_Info";
            this.GB_Info.Size = new System.Drawing.Size(649, 79);
            this.GB_Info.TabIndex = 0;
            this.GB_Info.TabStop = false;
            this.GB_Info.Text = "بيانات المريض:";
            // 
            // txt_PtientInher
            // 
            this.txt_PtientInher.Location = new System.Drawing.Point(92, 46);
            this.txt_PtientInher.Name = "txt_PtientInher";
            this.txt_PtientInher.Size = new System.Drawing.Size(100, 20);
            this.txt_PtientInher.TabIndex = 7;
            this.txt_PtientInher.Visible = false;
            // 
            // lbl_DateInvoice
            // 
            this.lbl_DateInvoice.AutoSize = true;
            this.lbl_DateInvoice.Location = new System.Drawing.Point(478, 51);
            this.lbl_DateInvoice.Name = "lbl_DateInvoice";
            this.lbl_DateInvoice.Size = new System.Drawing.Size(67, 13);
            this.lbl_DateInvoice.TabIndex = 6;
            this.lbl_DateInvoice.Text = "تاريخ الفاتوره:";
            // 
            // DPK_DateInvoice
            // 
            this.DPK_DateInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPK_DateInvoice.Location = new System.Drawing.Point(292, 46);
            this.DPK_DateInvoice.Name = "DPK_DateInvoice";
            this.DPK_DateInvoice.Size = new System.Drawing.Size(180, 20);
            this.DPK_DateInvoice.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::clinic.Properties.Resources.User_Accounts;
            this.pictureBox2.Location = new System.Drawing.Point(582, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Cmb_VisitID
            // 
            this.Cmb_VisitID.FormattingEnabled = true;
            this.Cmb_VisitID.Location = new System.Drawing.Point(24, 19);
            this.Cmb_VisitID.Name = "Cmb_VisitID";
            this.Cmb_VisitID.Size = new System.Drawing.Size(181, 21);
            this.Cmb_VisitID.TabIndex = 3;
            // 
            // Cmb_Patient
            // 
            this.Cmb_Patient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_Patient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Patient.FormattingEnabled = true;
            this.Cmb_Patient.Location = new System.Drawing.Point(292, 19);
            this.Cmb_Patient.Name = "Cmb_Patient";
            this.Cmb_Patient.Size = new System.Drawing.Size(180, 21);
            this.Cmb_Patient.TabIndex = 2;
            this.Cmb_Patient.SelectedIndexChanged += new System.EventHandler(this.Cmb_Patient_SelectedIndexChanged);
            // 
            // lbl_VisitID
            // 
            this.lbl_VisitID.AutoSize = true;
            this.lbl_VisitID.Location = new System.Drawing.Point(207, 22);
            this.lbl_VisitID.Name = "lbl_VisitID";
            this.lbl_VisitID.Size = new System.Drawing.Size(57, 13);
            this.lbl_VisitID.TabIndex = 1;
            this.lbl_VisitID.Text = "رقم الزياره:";
            // 
            // lbl_PatientID
            // 
            this.lbl_PatientID.AutoSize = true;
            this.lbl_PatientID.Location = new System.Drawing.Point(478, 22);
            this.lbl_PatientID.Name = "lbl_PatientID";
            this.lbl_PatientID.Size = new System.Drawing.Size(70, 13);
            this.lbl_PatientID.TabIndex = 0;
            this.lbl_PatientID.Text = "اسم المريض:";
            // 
            // GB_Invoice
            // 
            this.GB_Invoice.Controls.Add(this.pictureBox1);
            this.GB_Invoice.Controls.Add(this.txt_Total);
            this.GB_Invoice.Controls.Add(this.lbl_Total);
            this.GB_Invoice.Controls.Add(this.txt_Discount);
            this.GB_Invoice.Controls.Add(this.lbl_Discount);
            this.GB_Invoice.Controls.Add(this.txt_Reminder);
            this.GB_Invoice.Controls.Add(this.lbl_Reminder);
            this.GB_Invoice.Controls.Add(this.txt_PaidMoney);
            this.GB_Invoice.Controls.Add(this.lbl_PaidMoney);
            this.GB_Invoice.Controls.Add(this.txt_InvoiceID);
            this.GB_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Invoice.Location = new System.Drawing.Point(3, 88);
            this.GB_Invoice.Name = "GB_Invoice";
            this.GB_Invoice.Size = new System.Drawing.Size(649, 113);
            this.GB_Invoice.TabIndex = 1;
            this.GB_Invoice.TabStop = false;
            this.GB_Invoice.Text = "الفاتوره:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::clinic.Properties.Resources.medical_insurance_256x256x32b;
            this.pictureBox1.Location = new System.Drawing.Point(543, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(183, 71);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(100, 20);
            this.txt_Total.TabIndex = 8;
            this.txt_Total.Text = "0";
            this.txt_Total.Visible = false;
            this.txt_Total.TextChanged += new System.EventHandler(this.txt_Total_TextChanged);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(289, 74);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(68, 13);
            this.lbl_Total.TabIndex = 7;
            this.lbl_Total.Text = "المبلغ الكلي:";
            this.lbl_Total.Visible = false;
            // 
            // txt_Discount
            // 
            this.txt_Discount.Location = new System.Drawing.Point(362, 71);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(100, 20);
            this.txt_Discount.TabIndex = 6;
            this.txt_Discount.Text = "0";
            this.txt_Discount.TextChanged += new System.EventHandler(this.txt_Discount_TextChanged);
            this.txt_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PaidMoney_KeyPress);
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Location = new System.Drawing.Point(468, 78);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(44, 13);
            this.lbl_Discount.TabIndex = 5;
            this.lbl_Discount.Text = "الحسم:";
            // 
            // txt_Reminder
            // 
            this.txt_Reminder.Location = new System.Drawing.Point(183, 37);
            this.txt_Reminder.Name = "txt_Reminder";
            this.txt_Reminder.Size = new System.Drawing.Size(100, 20);
            this.txt_Reminder.TabIndex = 4;
            this.txt_Reminder.Text = "0";
            this.txt_Reminder.TextChanged += new System.EventHandler(this.txt_Reminder_TextChanged);
            this.txt_Reminder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PaidMoney_KeyPress);
            // 
            // lbl_Reminder
            // 
            this.lbl_Reminder.AutoSize = true;
            this.lbl_Reminder.Location = new System.Drawing.Point(289, 40);
            this.lbl_Reminder.Name = "lbl_Reminder";
            this.lbl_Reminder.Size = new System.Drawing.Size(40, 13);
            this.lbl_Reminder.TabIndex = 3;
            this.lbl_Reminder.Text = "الباقي:";
            // 
            // txt_PaidMoney
            // 
            this.txt_PaidMoney.Location = new System.Drawing.Point(362, 37);
            this.txt_PaidMoney.Name = "txt_PaidMoney";
            this.txt_PaidMoney.Size = new System.Drawing.Size(100, 20);
            this.txt_PaidMoney.TabIndex = 2;
            this.txt_PaidMoney.Text = "0";
            this.txt_PaidMoney.TextChanged += new System.EventHandler(this.txt_PaidMoney_TextChanged);
            this.txt_PaidMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PaidMoney_KeyPress);
            // 
            // lbl_PaidMoney
            // 
            this.lbl_PaidMoney.AutoSize = true;
            this.lbl_PaidMoney.Location = new System.Drawing.Point(467, 37);
            this.lbl_PaidMoney.Name = "lbl_PaidMoney";
            this.lbl_PaidMoney.Size = new System.Drawing.Size(77, 13);
            this.lbl_PaidMoney.TabIndex = 1;
            this.lbl_PaidMoney.Text = "المبلغ المدفوع:";
            // 
            // txt_InvoiceID
            // 
            this.txt_InvoiceID.Location = new System.Drawing.Point(69, 53);
            this.txt_InvoiceID.Name = "txt_InvoiceID";
            this.txt_InvoiceID.ReadOnly = true;
            this.txt_InvoiceID.Size = new System.Drawing.Size(35, 20);
            this.txt_InvoiceID.TabIndex = 0;
            this.txt_InvoiceID.Visible = false;
            // 
            // DGV_Invoice_All
            // 
            this.DGV_Invoice_All.AllowUserToAddRows = false;
            this.DGV_Invoice_All.AllowUserToDeleteRows = false;
            this.DGV_Invoice_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Invoice_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InVoiceID,
            this.VisitID,
            this.DataOfVisit,
            this.PatientID,
            this.FirstName,
            this.PaidMoney,
            this.Reminder,
            this.Discount,
            this.Total,
            this.DateInvoice});
            this.DGV_Invoice_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Invoice_All.Location = new System.Drawing.Point(3, 207);
            this.DGV_Invoice_All.Name = "DGV_Invoice_All";
            this.DGV_Invoice_All.ReadOnly = true;
            this.DGV_Invoice_All.Size = new System.Drawing.Size(649, 177);
            this.DGV_Invoice_All.TabIndex = 2;
            this.DGV_Invoice_All.Click += new System.EventHandler(this.DGV_Invoice_All_Click);
            // 
            // InVoiceID
            // 
            this.InVoiceID.DataPropertyName = "InVoiceID";
            this.InVoiceID.HeaderText = "رقم الفاتوره";
            this.InVoiceID.Name = "InVoiceID";
            this.InVoiceID.ReadOnly = true;
            this.InVoiceID.Visible = false;
            // 
            // VisitID
            // 
            this.VisitID.DataPropertyName = "VisitID";
            this.VisitID.HeaderText = "رقم الزياره";
            this.VisitID.Name = "VisitID";
            this.VisitID.ReadOnly = true;
            this.VisitID.Visible = false;
            // 
            // DataOfVisit
            // 
            this.DataOfVisit.DataPropertyName = "DataOfVisit";
            this.DataOfVisit.HeaderText = "تاريخ الزيارة";
            this.DataOfVisit.Name = "DataOfVisit";
            this.DataOfVisit.ReadOnly = true;
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "رقم المريض";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "اسم المريض";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // PaidMoney
            // 
            this.PaidMoney.DataPropertyName = "PaidMoney";
            this.PaidMoney.HeaderText = "المبلغ المدفوع";
            this.PaidMoney.Name = "PaidMoney";
            this.PaidMoney.ReadOnly = true;
            // 
            // Reminder
            // 
            this.Reminder.DataPropertyName = "Reminder";
            this.Reminder.HeaderText = "الباقي";
            this.Reminder.Name = "Reminder";
            this.Reminder.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "حسم %";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "المبلغ الكلي";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // DateInvoice
            // 
            this.DateInvoice.DataPropertyName = "DateInvoice";
            this.DateInvoice.HeaderText = "تاريخ الفاتورة";
            this.DateInvoice.Name = "DateInvoice";
            this.DateInvoice.ReadOnly = true;
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TS_Invoice);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 465);
            this.MinimumSize = new System.Drawing.Size(671, 465);
            this.Name = "FrmInvoice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الفواتير";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            this.TS_Invoice.ResumeLayout(false);
            this.TS_Invoice.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GB_Info.ResumeLayout(false);
            this.GB_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GB_Invoice.ResumeLayout(false);
            this.GB_Invoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Invoice_All)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS_Invoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GB_Info;
        private System.Windows.Forms.GroupBox GB_Invoice;
        private System.Windows.Forms.DataGridView DGV_Invoice_All;
        private System.Windows.Forms.ComboBox Cmb_Patient;
        private System.Windows.Forms.Label lbl_VisitID;
        private System.Windows.Forms.Label lbl_PatientID;
        private System.Windows.Forms.Label lbl_PaidMoney;
        private System.Windows.Forms.TextBox txt_InvoiceID;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.TextBox txt_Reminder;
        private System.Windows.Forms.Label lbl_Reminder;
        private System.Windows.Forms.TextBox txt_PaidMoney;
        private System.Windows.Forms.ToolStripButton TS_Add_Invoice;
        private System.Windows.Forms.ToolStripButton TS_UpDate;
        private System.Windows.Forms.ToolStripButton TS_Delete_Invoice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TS_BAck;
        private System.Windows.Forms.ComboBox Cmb_VisitID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSplitButton TS_ReportInvoice;
        private System.Windows.Forms.ToolStripMenuItem Tss_PatientReportInvfoice;
        private System.Windows.Forms.ToolStripMenuItem TSS_Report_PatirntInvoiS;
        private System.Windows.Forms.ToolStripMenuItem Tss_MonthReport;
        private System.Windows.Forms.DateTimePicker DPK_DateInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InVoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataOfVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reminder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateInvoice;
        private System.Windows.Forms.Label lbl_DateInvoice;
        private System.Windows.Forms.TextBox txt_PtientInher;
    }
}