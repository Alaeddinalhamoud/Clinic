namespace clinic.Pharmacy
{
    partial class FrmPharmacy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TL_Boss = new System.Windows.Forms.TableLayoutPanel();
            this.TC_Search = new System.Windows.Forms.TabControl();
            this.TP_SpeedSearch = new System.Windows.Forms.TabPage();
            this.GB_SpeedSearch = new System.Windows.Forms.GroupBox();
            this.GB_Search_By = new System.Windows.Forms.GroupBox();
            this.RB_OverlapOfMedication = new System.Windows.Forms.RadioButton();
            this.RB_MedicalOfConsultation = new System.Windows.Forms.RadioButton();
            this.RB_SideOfEffect = new System.Windows.Forms.RadioButton();
            this.RB_Company = new System.Windows.Forms.RadioButton();
            this.RB_Name = new System.Windows.Forms.RadioButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Search_by = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.TP_AdvancedSearch = new System.Windows.Forms.TabPage();
            this.GB_Adv = new System.Windows.Forms.GroupBox();
            this.lbl_SideOfEffect = new System.Windows.Forms.Label();
            this.txt_SideOfEffect = new System.Windows.Forms.TextBox();
            this.lbl_OverlapOfMedication = new System.Windows.Forms.Label();
            this.lbl_MedicalOfConsultation = new System.Windows.Forms.Label();
            this.txt_OverlapOfMedication = new System.Windows.Forms.TextBox();
            this.txt_MedicalOfConsultation = new System.Windows.Forms.TextBox();
            this.lbl_Classification = new System.Windows.Forms.Label();
            this.lbl_GroupOfRemedial = new System.Windows.Forms.Label();
            this.txt_Classification = new System.Windows.Forms.TextBox();
            this.txt_GroupOfRemedial = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DGV_Search_Pharmecy = new System.Windows.Forms.DataGridView();
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
            this.SST_Pharmacy = new System.Windows.Forms.StatusStrip();
            this.TSS_lbl_Count = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSS_Time_Exipred = new System.Windows.Forms.ToolStripStatusLabel();
            this.PIC_Search = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TL_Boss.SuspendLayout();
            this.TC_Search.SuspendLayout();
            this.TP_SpeedSearch.SuspendLayout();
            this.GB_SpeedSearch.SuspendLayout();
            this.GB_Search_By.SuspendLayout();
            this.TP_AdvancedSearch.SuspendLayout();
            this.GB_Adv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Search_Pharmecy)).BeginInit();
            this.SST_Pharmacy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TL_Boss
            // 
            this.TL_Boss.ColumnCount = 1;
            this.TL_Boss.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TL_Boss.Controls.Add(this.TC_Search, 0, 0);
            this.TL_Boss.Controls.Add(this.DGV_Search_Pharmecy, 0, 1);
            this.TL_Boss.Controls.Add(this.SST_Pharmacy, 0, 2);
            this.TL_Boss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TL_Boss.Location = new System.Drawing.Point(0, 0);
            this.TL_Boss.Name = "TL_Boss";
            this.TL_Boss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TL_Boss.RowCount = 3;
            this.TL_Boss.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.92025F));
            this.TL_Boss.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.07975F));
            this.TL_Boss.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TL_Boss.Size = new System.Drawing.Size(804, 487);
            this.TL_Boss.TabIndex = 0;
            // 
            // TC_Search
            // 
            this.TC_Search.Controls.Add(this.TP_SpeedSearch);
            this.TC_Search.Controls.Add(this.TP_AdvancedSearch);
            this.TC_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_Search.Location = new System.Drawing.Point(3, 3);
            this.TC_Search.Name = "TC_Search";
            this.TC_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TC_Search.RightToLeftLayout = true;
            this.TC_Search.SelectedIndex = 0;
            this.TC_Search.Size = new System.Drawing.Size(798, 230);
            this.TC_Search.TabIndex = 0;
            // 
            // TP_SpeedSearch
            // 
            this.TP_SpeedSearch.Controls.Add(this.GB_SpeedSearch);
            this.TP_SpeedSearch.Location = new System.Drawing.Point(4, 22);
            this.TP_SpeedSearch.Name = "TP_SpeedSearch";
            this.TP_SpeedSearch.Padding = new System.Windows.Forms.Padding(3);
            this.TP_SpeedSearch.Size = new System.Drawing.Size(790, 204);
            this.TP_SpeedSearch.TabIndex = 0;
            this.TP_SpeedSearch.Text = "بحث سريع";
            this.TP_SpeedSearch.UseVisualStyleBackColor = true;
            // 
            // GB_SpeedSearch
            // 
            this.GB_SpeedSearch.Controls.Add(this.GB_Search_By);
            this.GB_SpeedSearch.Controls.Add(this.PIC_Search);
            this.GB_SpeedSearch.Controls.Add(this.btn_Search);
            this.GB_SpeedSearch.Controls.Add(this.lbl_Search_by);
            this.GB_SpeedSearch.Controls.Add(this.txt_Search);
            this.GB_SpeedSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_SpeedSearch.Location = new System.Drawing.Point(3, 3);
            this.GB_SpeedSearch.Name = "GB_SpeedSearch";
            this.GB_SpeedSearch.Size = new System.Drawing.Size(784, 198);
            this.GB_SpeedSearch.TabIndex = 0;
            this.GB_SpeedSearch.TabStop = false;
            // 
            // GB_Search_By
            // 
            this.GB_Search_By.Controls.Add(this.RB_OverlapOfMedication);
            this.GB_Search_By.Controls.Add(this.RB_MedicalOfConsultation);
            this.GB_Search_By.Controls.Add(this.RB_SideOfEffect);
            this.GB_Search_By.Controls.Add(this.RB_Company);
            this.GB_Search_By.Controls.Add(this.RB_Name);
            this.GB_Search_By.Dock = System.Windows.Forms.DockStyle.Right;
            this.GB_Search_By.Location = new System.Drawing.Point(639, 16);
            this.GB_Search_By.Name = "GB_Search_By";
            this.GB_Search_By.Size = new System.Drawing.Size(142, 179);
            this.GB_Search_By.TabIndex = 6;
            this.GB_Search_By.TabStop = false;
            this.GB_Search_By.Text = "بحث بحسب :";
            // 
            // RB_OverlapOfMedication
            // 
            this.RB_OverlapOfMedication.AutoSize = true;
            this.RB_OverlapOfMedication.Location = new System.Drawing.Point(33, 129);
            this.RB_OverlapOfMedication.Name = "RB_OverlapOfMedication";
            this.RB_OverlapOfMedication.Size = new System.Drawing.Size(82, 17);
            this.RB_OverlapOfMedication.TabIndex = 4;
            this.RB_OverlapOfMedication.Text = "تداخل دوائي";
            this.RB_OverlapOfMedication.UseVisualStyleBackColor = true;
            this.RB_OverlapOfMedication.CheckedChanged += new System.EventHandler(this.RB_OverlapOfMedication_CheckedChanged);
            // 
            // RB_MedicalOfConsultation
            // 
            this.RB_MedicalOfConsultation.AutoSize = true;
            this.RB_MedicalOfConsultation.Location = new System.Drawing.Point(42, 104);
            this.RB_MedicalOfConsultation.Name = "RB_MedicalOfConsultation";
            this.RB_MedicalOfConsultation.Size = new System.Drawing.Size(73, 17);
            this.RB_MedicalOfConsultation.TabIndex = 3;
            this.RB_MedicalOfConsultation.Text = "استطبابات";
            this.RB_MedicalOfConsultation.UseVisualStyleBackColor = true;
            this.RB_MedicalOfConsultation.CheckedChanged += new System.EventHandler(this.RB_MedicalOfConsultation_CheckedChanged);
            // 
            // RB_SideOfEffect
            // 
            this.RB_SideOfEffect.AutoSize = true;
            this.RB_SideOfEffect.Location = new System.Drawing.Point(47, 79);
            this.RB_SideOfEffect.Name = "RB_SideOfEffect";
            this.RB_SideOfEffect.Size = new System.Drawing.Size(68, 17);
            this.RB_SideOfEffect.TabIndex = 2;
            this.RB_SideOfEffect.Text = "أثار جانبية";
            this.RB_SideOfEffect.UseVisualStyleBackColor = true;
            this.RB_SideOfEffect.CheckedChanged += new System.EventHandler(this.RB_SideOfEffect_CheckedChanged);
            // 
            // RB_Company
            // 
            this.RB_Company.AutoSize = true;
            this.RB_Company.Location = new System.Drawing.Point(31, 54);
            this.RB_Company.Name = "RB_Company";
            this.RB_Company.Size = new System.Drawing.Size(84, 17);
            this.RB_Company.TabIndex = 1;
            this.RB_Company.Text = "اسم الشركة";
            this.RB_Company.UseVisualStyleBackColor = true;
            this.RB_Company.CheckedChanged += new System.EventHandler(this.RB_Company_CheckedChanged);
            // 
            // RB_Name
            // 
            this.RB_Name.AutoSize = true;
            this.RB_Name.Checked = true;
            this.RB_Name.Location = new System.Drawing.Point(38, 29);
            this.RB_Name.Name = "RB_Name";
            this.RB_Name.Size = new System.Drawing.Size(77, 17);
            this.RB_Name.TabIndex = 0;
            this.RB_Name.TabStop = true;
            this.RB_Name.Text = "اسم الدواء ";
            this.RB_Name.UseVisualStyleBackColor = true;
            this.RB_Name.CheckedChanged += new System.EventHandler(this.RB_Name_CheckedChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(355, 125);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 32);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Search_by
            // 
            this.lbl_Search_by.AutoSize = true;
            this.lbl_Search_by.Location = new System.Drawing.Point(496, 83);
            this.lbl_Search_by.Name = "lbl_Search_by";
            this.lbl_Search_by.Size = new System.Drawing.Size(60, 13);
            this.lbl_Search_by.TabIndex = 2;
            this.lbl_Search_by.Text = "اسم الدواء:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(292, 81);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(196, 20);
            this.txt_Search.TabIndex = 0;
            // 
            // TP_AdvancedSearch
            // 
            this.TP_AdvancedSearch.Controls.Add(this.GB_Adv);
            this.TP_AdvancedSearch.Location = new System.Drawing.Point(4, 22);
            this.TP_AdvancedSearch.Name = "TP_AdvancedSearch";
            this.TP_AdvancedSearch.Padding = new System.Windows.Forms.Padding(3);
            this.TP_AdvancedSearch.Size = new System.Drawing.Size(790, 204);
            this.TP_AdvancedSearch.TabIndex = 1;
            this.TP_AdvancedSearch.Text = "بحث متقدم";
            this.TP_AdvancedSearch.UseVisualStyleBackColor = true;
            // 
            // GB_Adv
            // 
            this.GB_Adv.Controls.Add(this.lbl_SideOfEffect);
            this.GB_Adv.Controls.Add(this.txt_SideOfEffect);
            this.GB_Adv.Controls.Add(this.lbl_OverlapOfMedication);
            this.GB_Adv.Controls.Add(this.lbl_MedicalOfConsultation);
            this.GB_Adv.Controls.Add(this.txt_OverlapOfMedication);
            this.GB_Adv.Controls.Add(this.txt_MedicalOfConsultation);
            this.GB_Adv.Controls.Add(this.lbl_Classification);
            this.GB_Adv.Controls.Add(this.lbl_GroupOfRemedial);
            this.GB_Adv.Controls.Add(this.txt_Classification);
            this.GB_Adv.Controls.Add(this.txt_GroupOfRemedial);
            this.GB_Adv.Controls.Add(this.button1);
            this.GB_Adv.Controls.Add(this.label1);
            this.GB_Adv.Controls.Add(this.label3);
            this.GB_Adv.Controls.Add(this.textBox1);
            this.GB_Adv.Controls.Add(this.textBox2);
            this.GB_Adv.Controls.Add(this.pictureBox1);
            this.GB_Adv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Adv.Enabled = false;
            this.GB_Adv.Location = new System.Drawing.Point(3, 3);
            this.GB_Adv.Name = "GB_Adv";
            this.GB_Adv.Size = new System.Drawing.Size(784, 198);
            this.GB_Adv.TabIndex = 0;
            this.GB_Adv.TabStop = false;
            // 
            // lbl_SideOfEffect
            // 
            this.lbl_SideOfEffect.AutoSize = true;
            this.lbl_SideOfEffect.Location = new System.Drawing.Point(398, 105);
            this.lbl_SideOfEffect.Name = "lbl_SideOfEffect";
            this.lbl_SideOfEffect.Size = new System.Drawing.Size(54, 13);
            this.lbl_SideOfEffect.TabIndex = 22;
            this.lbl_SideOfEffect.Text = "آثار جانبية:";
            // 
            // txt_SideOfEffect
            // 
            this.txt_SideOfEffect.Location = new System.Drawing.Point(198, 103);
            this.txt_SideOfEffect.Name = "txt_SideOfEffect";
            this.txt_SideOfEffect.Size = new System.Drawing.Size(196, 20);
            this.txt_SideOfEffect.TabIndex = 20;
            // 
            // lbl_OverlapOfMedication
            // 
            this.lbl_OverlapOfMedication.AutoSize = true;
            this.lbl_OverlapOfMedication.Location = new System.Drawing.Point(398, 73);
            this.lbl_OverlapOfMedication.Name = "lbl_OverlapOfMedication";
            this.lbl_OverlapOfMedication.Size = new System.Drawing.Size(76, 13);
            this.lbl_OverlapOfMedication.TabIndex = 19;
            this.lbl_OverlapOfMedication.Text = "تداخلات دوائية:";
            // 
            // lbl_MedicalOfConsultation
            // 
            this.lbl_MedicalOfConsultation.AutoSize = true;
            this.lbl_MedicalOfConsultation.Location = new System.Drawing.Point(398, 37);
            this.lbl_MedicalOfConsultation.Name = "lbl_MedicalOfConsultation";
            this.lbl_MedicalOfConsultation.Size = new System.Drawing.Size(66, 13);
            this.lbl_MedicalOfConsultation.TabIndex = 18;
            this.lbl_MedicalOfConsultation.Text = "الاستطبابات:";
            // 
            // txt_OverlapOfMedication
            // 
            this.txt_OverlapOfMedication.Location = new System.Drawing.Point(198, 70);
            this.txt_OverlapOfMedication.Name = "txt_OverlapOfMedication";
            this.txt_OverlapOfMedication.Size = new System.Drawing.Size(196, 20);
            this.txt_OverlapOfMedication.TabIndex = 17;
            // 
            // txt_MedicalOfConsultation
            // 
            this.txt_MedicalOfConsultation.Location = new System.Drawing.Point(198, 35);
            this.txt_MedicalOfConsultation.Name = "txt_MedicalOfConsultation";
            this.txt_MedicalOfConsultation.Size = new System.Drawing.Size(196, 20);
            this.txt_MedicalOfConsultation.TabIndex = 16;
            // 
            // lbl_Classification
            // 
            this.lbl_Classification.AutoSize = true;
            this.lbl_Classification.Location = new System.Drawing.Point(687, 141);
            this.lbl_Classification.Name = "lbl_Classification";
            this.lbl_Classification.Size = new System.Drawing.Size(56, 13);
            this.lbl_Classification.TabIndex = 15;
            this.lbl_Classification.Text = "التصنيفات:";
            // 
            // lbl_GroupOfRemedial
            // 
            this.lbl_GroupOfRemedial.AutoSize = true;
            this.lbl_GroupOfRemedial.Location = new System.Drawing.Point(687, 106);
            this.lbl_GroupOfRemedial.Name = "lbl_GroupOfRemedial";
            this.lbl_GroupOfRemedial.Size = new System.Drawing.Size(96, 13);
            this.lbl_GroupOfRemedial.TabIndex = 14;
            this.lbl_GroupOfRemedial.Text = "المجموعة العلاجية:";
            // 
            // txt_Classification
            // 
            this.txt_Classification.Location = new System.Drawing.Point(486, 139);
            this.txt_Classification.Name = "txt_Classification";
            this.txt_Classification.Size = new System.Drawing.Size(196, 20);
            this.txt_Classification.TabIndex = 13;
            // 
            // txt_GroupOfRemedial
            // 
            this.txt_GroupOfRemedial.Location = new System.Drawing.Point(486, 104);
            this.txt_GroupOfRemedial.Name = "txt_GroupOfRemedial";
            this.txt_GroupOfRemedial.Size = new System.Drawing.Size(196, 20);
            this.txt_GroupOfRemedial.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "اسم الشركة:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "اسم الدواء:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(486, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 20);
            this.textBox2.TabIndex = 7;
            // 
            // DGV_Search_Pharmecy
            // 
            this.DGV_Search_Pharmecy.AllowUserToAddRows = false;
            this.DGV_Search_Pharmecy.AllowUserToDeleteRows = false;
            this.DGV_Search_Pharmecy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Search_Pharmecy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DGV_Search_Pharmecy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Search_Pharmecy.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Search_Pharmecy.Location = new System.Drawing.Point(3, 239);
            this.DGV_Search_Pharmecy.Name = "DGV_Search_Pharmecy";
            this.DGV_Search_Pharmecy.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Search_Pharmecy.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Search_Pharmecy.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver;
            this.DGV_Search_Pharmecy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Search_Pharmecy.Size = new System.Drawing.Size(798, 221);
            this.DGV_Search_Pharmecy.TabIndex = 1;
            this.DGV_Search_Pharmecy.DoubleClick += new System.EventHandler(this.DGV_Search_Pharmecy_DoubleClick);
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
            this.MedicationName.Width = 150;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "الشركة";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Width = 150;
            // 
            // GroupOfRemedial
            // 
            this.GroupOfRemedial.DataPropertyName = "GroupOfRemedial";
            this.GroupOfRemedial.HeaderText = "مجموعة العلاجات";
            this.GroupOfRemedial.Name = "GroupOfRemedial";
            this.GroupOfRemedial.ReadOnly = true;
            this.GroupOfRemedial.Width = 150;
            // 
            // Classification
            // 
            this.Classification.DataPropertyName = "Classification";
            this.Classification.HeaderText = "التصنيف";
            this.Classification.Name = "Classification";
            this.Classification.ReadOnly = true;
            // 
            // Page
            // 
            this.Page.DataPropertyName = "Page";
            this.Page.HeaderText = "الصفحة";
            this.Page.Name = "Page";
            this.Page.ReadOnly = true;
            this.Page.Visible = false;
            // 
            // MedicalOfConsultation
            // 
            this.MedicalOfConsultation.DataPropertyName = "MedicalOfConsultation";
            this.MedicalOfConsultation.HeaderText = "الاستطبابات";
            this.MedicalOfConsultation.Name = "MedicalOfConsultation";
            this.MedicalOfConsultation.ReadOnly = true;
            this.MedicalOfConsultation.Visible = false;
            // 
            // AntiOfMedical_Consultation
            // 
            this.AntiOfMedical_Consultation.DataPropertyName = "AntiOfMedical_Consultation";
            this.AntiOfMedical_Consultation.HeaderText = "مضادات الاستطبابات";
            this.AntiOfMedical_Consultation.Name = "AntiOfMedical_Consultation";
            this.AntiOfMedical_Consultation.ReadOnly = true;
            this.AntiOfMedical_Consultation.Visible = false;
            // 
            // Warning
            // 
            this.Warning.DataPropertyName = "Warning";
            this.Warning.HeaderText = "التحذيرات";
            this.Warning.Name = "Warning";
            this.Warning.ReadOnly = true;
            this.Warning.Visible = false;
            // 
            // OverlapOfMedication
            // 
            this.OverlapOfMedication.DataPropertyName = "OverlapOfMedication";
            this.OverlapOfMedication.HeaderText = "التداخل الدوائي";
            this.OverlapOfMedication.Name = "OverlapOfMedication";
            this.OverlapOfMedication.ReadOnly = true;
            this.OverlapOfMedication.Visible = false;
            // 
            // SideOfEffect
            // 
            this.SideOfEffect.DataPropertyName = "SideOfEffect";
            this.SideOfEffect.HeaderText = "التأثيرات الجانبية";
            this.SideOfEffect.Name = "SideOfEffect";
            this.SideOfEffect.ReadOnly = true;
            this.SideOfEffect.Visible = false;
            // 
            // SST_Pharmacy
            // 
            this.SST_Pharmacy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSS_lbl_Count,
            this.TSS_Time_Exipred});
            this.SST_Pharmacy.Location = new System.Drawing.Point(0, 465);
            this.SST_Pharmacy.Name = "SST_Pharmacy";
            this.SST_Pharmacy.Size = new System.Drawing.Size(804, 22);
            this.SST_Pharmacy.TabIndex = 2;
            this.SST_Pharmacy.Text = "statusStrip1";
            // 
            // TSS_lbl_Count
            // 
            this.TSS_lbl_Count.Name = "TSS_lbl_Count";
            this.TSS_lbl_Count.Size = new System.Drawing.Size(0, 17);
            // 
            // TSS_Time_Exipred
            // 
            this.TSS_Time_Exipred.Name = "TSS_Time_Exipred";
            this.TSS_Time_Exipred.Size = new System.Drawing.Size(0, 17);
            // 
            // PIC_Search
            // 
            this.PIC_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.PIC_Search.Image = global::clinic.Properties.Resources.Medical_Symbol;
            this.PIC_Search.Location = new System.Drawing.Point(3, 16);
            this.PIC_Search.Name = "PIC_Search";
            this.PIC_Search.Size = new System.Drawing.Size(221, 179);
            this.PIC_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_Search.TabIndex = 5;
            this.PIC_Search.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::clinic.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 487);
            this.Controls.Add(this.TL_Boss);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 525);
            this.MinimumSize = new System.Drawing.Size(820, 525);
            this.Name = "FrmPharmacy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الصيدلية";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmPharmacy_Load);
            this.TL_Boss.ResumeLayout(false);
            this.TL_Boss.PerformLayout();
            this.TC_Search.ResumeLayout(false);
            this.TP_SpeedSearch.ResumeLayout(false);
            this.GB_SpeedSearch.ResumeLayout(false);
            this.GB_SpeedSearch.PerformLayout();
            this.GB_Search_By.ResumeLayout(false);
            this.GB_Search_By.PerformLayout();
            this.TP_AdvancedSearch.ResumeLayout(false);
            this.GB_Adv.ResumeLayout(false);
            this.GB_Adv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Search_Pharmecy)).EndInit();
            this.SST_Pharmacy.ResumeLayout(false);
            this.SST_Pharmacy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TL_Boss;
        private System.Windows.Forms.TabControl TC_Search;
        private System.Windows.Forms.TabPage TP_SpeedSearch;
        private System.Windows.Forms.TabPage TP_AdvancedSearch;
        private System.Windows.Forms.DataGridView DGV_Search_Pharmecy;
        private System.Windows.Forms.StatusStrip SST_Pharmacy;
        private System.Windows.Forms.ToolStripStatusLabel TSS_lbl_Count;
        private System.Windows.Forms.ToolStripStatusLabel TSS_Time_Exipred;
        private System.Windows.Forms.GroupBox GB_SpeedSearch;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Search_by;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.PictureBox PIC_Search;
        private System.Windows.Forms.GroupBox GB_Adv;
        private System.Windows.Forms.Label lbl_SideOfEffect;
        private System.Windows.Forms.TextBox txt_SideOfEffect;
        private System.Windows.Forms.Label lbl_OverlapOfMedication;
        private System.Windows.Forms.Label lbl_MedicalOfConsultation;
        private System.Windows.Forms.TextBox txt_OverlapOfMedication;
        private System.Windows.Forms.TextBox txt_MedicalOfConsultation;
        private System.Windows.Forms.Label lbl_Classification;
        private System.Windows.Forms.Label lbl_GroupOfRemedial;
        private System.Windows.Forms.TextBox txt_Classification;
        private System.Windows.Forms.TextBox txt_GroupOfRemedial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.GroupBox GB_Search_By;
        private System.Windows.Forms.RadioButton RB_OverlapOfMedication;
        private System.Windows.Forms.RadioButton RB_MedicalOfConsultation;
        private System.Windows.Forms.RadioButton RB_SideOfEffect;
        private System.Windows.Forms.RadioButton RB_Company;
        private System.Windows.Forms.RadioButton RB_Name;
    }
}