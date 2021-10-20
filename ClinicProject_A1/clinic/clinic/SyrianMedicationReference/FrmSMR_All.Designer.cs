namespace clinic.SyrianMedicationReference
{
    partial class FrmSMR_All
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
            this.TS_Main = new System.Windows.Forms.StatusStrip();
            this.GB_Main = new System.Windows.Forms.GroupBox();
            this.txt_MedicalOfConsultation = new System.Windows.Forms.TextBox();
            this.lbl_MedicalOfConsultation = new System.Windows.Forms.Label();
            this.txt_AntiOfMedical_Consultation = new System.Windows.Forms.TextBox();
            this.lbl_AntiOfMedical_Consultation = new System.Windows.Forms.Label();
            this.txt_Warning = new System.Windows.Forms.TextBox();
            this.lbl_Warning = new System.Windows.Forms.Label();
            this.txt_OverlapOfMedication = new System.Windows.Forms.TextBox();
            this.lbl_OverlapOfMedication = new System.Windows.Forms.Label();
            this.txt_SideOfEffect = new System.Windows.Forms.TextBox();
            this.lbl_SideOfEffect = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_MedicationName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Company = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_CompanyName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.TS_Main.SuspendLayout();
            this.GB_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TS_Main, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GB_Main, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.25843F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.741573F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 356);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TS_Main
            // 
            this.TS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Name,
            this.lbl_MedicationName,
            this.lbl_Company,
            this.lbl_CompanyName});
            this.TS_Main.Location = new System.Drawing.Point(0, 334);
            this.TS_Main.Name = "TS_Main";
            this.TS_Main.Size = new System.Drawing.Size(826, 22);
            this.TS_Main.TabIndex = 0;
            this.TS_Main.Text = "statusStrip1";
            // 
            // GB_Main
            // 
            this.GB_Main.Controls.Add(this.txt_SideOfEffect);
            this.GB_Main.Controls.Add(this.lbl_SideOfEffect);
            this.GB_Main.Controls.Add(this.txt_OverlapOfMedication);
            this.GB_Main.Controls.Add(this.lbl_OverlapOfMedication);
            this.GB_Main.Controls.Add(this.txt_Warning);
            this.GB_Main.Controls.Add(this.lbl_Warning);
            this.GB_Main.Controls.Add(this.txt_AntiOfMedical_Consultation);
            this.GB_Main.Controls.Add(this.lbl_AntiOfMedical_Consultation);
            this.GB_Main.Controls.Add(this.txt_MedicalOfConsultation);
            this.GB_Main.Controls.Add(this.lbl_MedicalOfConsultation);
            this.GB_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Main.Location = new System.Drawing.Point(3, 3);
            this.GB_Main.Name = "GB_Main";
            this.GB_Main.Size = new System.Drawing.Size(820, 326);
            this.GB_Main.TabIndex = 1;
            this.GB_Main.TabStop = false;
            this.GB_Main.Text = "معلومات الدواء :";
            // 
            // txt_MedicalOfConsultation
            // 
            this.txt_MedicalOfConsultation.Location = new System.Drawing.Point(433, 31);
            this.txt_MedicalOfConsultation.Multiline = true;
            this.txt_MedicalOfConsultation.Name = "txt_MedicalOfConsultation";
            this.txt_MedicalOfConsultation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_MedicalOfConsultation.Size = new System.Drawing.Size(308, 79);
            this.txt_MedicalOfConsultation.TabIndex = 3;
            // 
            // lbl_MedicalOfConsultation
            // 
            this.lbl_MedicalOfConsultation.AutoSize = true;
            this.lbl_MedicalOfConsultation.Location = new System.Drawing.Point(747, 34);
            this.lbl_MedicalOfConsultation.Name = "lbl_MedicalOfConsultation";
            this.lbl_MedicalOfConsultation.Size = new System.Drawing.Size(69, 13);
            this.lbl_MedicalOfConsultation.TabIndex = 2;
            this.lbl_MedicalOfConsultation.Text = "الاستطبابات :";
            // 
            // txt_AntiOfMedical_Consultation
            // 
            this.txt_AntiOfMedical_Consultation.Location = new System.Drawing.Point(6, 28);
            this.txt_AntiOfMedical_Consultation.Multiline = true;
            this.txt_AntiOfMedical_Consultation.Name = "txt_AntiOfMedical_Consultation";
            this.txt_AntiOfMedical_Consultation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_AntiOfMedical_Consultation.Size = new System.Drawing.Size(308, 79);
            this.txt_AntiOfMedical_Consultation.TabIndex = 5;
            // 
            // lbl_AntiOfMedical_Consultation
            // 
            this.lbl_AntiOfMedical_Consultation.AutoSize = true;
            this.lbl_AntiOfMedical_Consultation.Location = new System.Drawing.Point(320, 31);
            this.lbl_AntiOfMedical_Consultation.Name = "lbl_AntiOfMedical_Consultation";
            this.lbl_AntiOfMedical_Consultation.Size = new System.Drawing.Size(107, 13);
            this.lbl_AntiOfMedical_Consultation.TabIndex = 4;
            this.lbl_AntiOfMedical_Consultation.Text = "مضادات الاستطبابات :";
            // 
            // txt_Warning
            // 
            this.txt_Warning.Location = new System.Drawing.Point(6, 118);
            this.txt_Warning.Multiline = true;
            this.txt_Warning.Name = "txt_Warning";
            this.txt_Warning.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Warning.Size = new System.Drawing.Size(308, 79);
            this.txt_Warning.TabIndex = 7;
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.Location = new System.Drawing.Point(320, 121);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(93, 13);
            this.lbl_Warning.TabIndex = 6;
            this.lbl_Warning.Text = "التحذيرات الدوائية :";
            // 
            // txt_OverlapOfMedication
            // 
            this.txt_OverlapOfMedication.Location = new System.Drawing.Point(433, 121);
            this.txt_OverlapOfMedication.Multiline = true;
            this.txt_OverlapOfMedication.Name = "txt_OverlapOfMedication";
            this.txt_OverlapOfMedication.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_OverlapOfMedication.Size = new System.Drawing.Size(308, 79);
            this.txt_OverlapOfMedication.TabIndex = 9;
            // 
            // lbl_OverlapOfMedication
            // 
            this.lbl_OverlapOfMedication.AutoSize = true;
            this.lbl_OverlapOfMedication.Location = new System.Drawing.Point(747, 124);
            this.lbl_OverlapOfMedication.Name = "lbl_OverlapOfMedication";
            this.lbl_OverlapOfMedication.Size = new System.Drawing.Size(71, 13);
            this.lbl_OverlapOfMedication.TabIndex = 8;
            this.lbl_OverlapOfMedication.Text = "تداخل دوائي :";
            // 
            // txt_SideOfEffect
            // 
            this.txt_SideOfEffect.Location = new System.Drawing.Point(433, 206);
            this.txt_SideOfEffect.Multiline = true;
            this.txt_SideOfEffect.Name = "txt_SideOfEffect";
            this.txt_SideOfEffect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_SideOfEffect.Size = new System.Drawing.Size(308, 79);
            this.txt_SideOfEffect.TabIndex = 11;
            // 
            // lbl_SideOfEffect
            // 
            this.lbl_SideOfEffect.AutoSize = true;
            this.lbl_SideOfEffect.Location = new System.Drawing.Point(747, 209);
            this.lbl_SideOfEffect.Name = "lbl_SideOfEffect";
            this.lbl_SideOfEffect.Size = new System.Drawing.Size(63, 13);
            this.lbl_SideOfEffect.TabIndex = 10;
            this.lbl_SideOfEffect.Text = "تاثير جانبي :";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(54, 17);
            this.lbl_Name.Text = "اسم الدواء:";
            // 
            // lbl_MedicationName
            // 
            this.lbl_MedicationName.Name = "lbl_MedicationName";
            this.lbl_MedicationName.Size = new System.Drawing.Size(0, 17);
            // 
            // lbl_Company
            // 
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(63, 17);
            this.lbl_Company.Text = "اسم الشركة:";
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmSMR_All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(842, 394);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(842, 394);
            this.Name = "FrmSMR_All";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmSMR_All_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TS_Main.ResumeLayout(false);
            this.TS_Main.PerformLayout();
            this.GB_Main.ResumeLayout(false);
            this.GB_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip TS_Main;
        private System.Windows.Forms.GroupBox GB_Main;
        private System.Windows.Forms.TextBox txt_MedicalOfConsultation;
        private System.Windows.Forms.Label lbl_MedicalOfConsultation;
        private System.Windows.Forms.TextBox txt_Warning;
        private System.Windows.Forms.Label lbl_Warning;
        private System.Windows.Forms.TextBox txt_AntiOfMedical_Consultation;
        private System.Windows.Forms.Label lbl_AntiOfMedical_Consultation;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Name;
        private System.Windows.Forms.ToolStripStatusLabel lbl_MedicationName;
        private System.Windows.Forms.TextBox txt_SideOfEffect;
        private System.Windows.Forms.Label lbl_SideOfEffect;
        private System.Windows.Forms.TextBox txt_OverlapOfMedication;
        private System.Windows.Forms.Label lbl_OverlapOfMedication;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Company;
        private System.Windows.Forms.ToolStripStatusLabel lbl_CompanyName;
    }
}