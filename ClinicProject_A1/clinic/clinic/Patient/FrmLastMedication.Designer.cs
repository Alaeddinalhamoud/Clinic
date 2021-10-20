namespace clinic.Patient
{
    partial class FrmLastMedication
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
            this.TS_LastMedication = new System.Windows.Forms.ToolStrip();
            this.TS_Add_LastMedication = new System.Windows.Forms.ToolStripButton();
            this.TS_UpData_LastMedication = new System.Windows.Forms.ToolStripButton();
            this.TS_Delete_LastMedication = new System.Windows.Forms.ToolStripButton();
            this.TS_Emaptytools = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Back = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GB_LastMedication = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cmb_Patient_All = new System.Windows.Forms.ComboBox();
            this.lbl_Patient_Full = new System.Windows.Forms.Label();
            this.txt_LastMedicationID = new System.Windows.Forms.TextBox();
            this.Cmb_MedcationID = new System.Windows.Forms.ComboBox();
            this.DPR_DateOfMedication = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateOfMedication = new System.Windows.Forms.Label();
            this.lbl_MedicationID = new System.Windows.Forms.Label();
            this.DGV_LastMedication = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastMedicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfMedication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TS_LastMedication.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GB_LastMedication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LastMedication)).BeginInit();
            this.SuspendLayout();
            // 
            // TS_LastMedication
            // 
            this.TS_LastMedication.AutoSize = false;
            this.TS_LastMedication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_LastMedication.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_LastMedication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add_LastMedication,
            this.TS_UpData_LastMedication,
            this.TS_Delete_LastMedication,
            this.TS_Emaptytools,
            this.toolStripSeparator1,
            this.TS_Back});
            this.TS_LastMedication.Location = new System.Drawing.Point(0, 0);
            this.TS_LastMedication.Name = "TS_LastMedication";
            this.TS_LastMedication.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TS_LastMedication.Size = new System.Drawing.Size(655, 40);
            this.TS_LastMedication.TabIndex = 0;
            this.TS_LastMedication.Text = "toolStrip1";
            // 
            // TS_Add_LastMedication
            // 
            this.TS_Add_LastMedication.Image = global::clinic.Properties.Resources.add;
            this.TS_Add_LastMedication.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add_LastMedication.Name = "TS_Add_LastMedication";
            this.TS_Add_LastMedication.Size = new System.Drawing.Size(125, 37);
            this.TS_Add_LastMedication.Text = "اضافة دواء سابق";
            this.TS_Add_LastMedication.Click += new System.EventHandler(this.TS_Add_LastMedication_Click_1);
            // 
            // TS_UpData_LastMedication
            // 
            this.TS_UpData_LastMedication.Image = global::clinic.Properties.Resources.accept;
            this.TS_UpData_LastMedication.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_UpData_LastMedication.Name = "TS_UpData_LastMedication";
            this.TS_UpData_LastMedication.Size = new System.Drawing.Size(61, 37);
            this.TS_UpData_LastMedication.Text = "تعديل";
            this.TS_UpData_LastMedication.Click += new System.EventHandler(this.TS_UpData_LastMedication_Click_1);
            // 
            // TS_Delete_LastMedication
            // 
            this.TS_Delete_LastMedication.Image = global::clinic.Properties.Resources.remove;
            this.TS_Delete_LastMedication.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Delete_LastMedication.Name = "TS_Delete_LastMedication";
            this.TS_Delete_LastMedication.Size = new System.Drawing.Size(61, 37);
            this.TS_Delete_LastMedication.Text = "حذف";
            this.TS_Delete_LastMedication.Click += new System.EventHandler(this.TS_Delete_LastMedication_Click_1);
            // 
            // TS_Emaptytools
            // 
            this.TS_Emaptytools.Image = global::clinic.Properties.Resources.Empty_Recycle_Bin;
            this.TS_Emaptytools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Emaptytools.Name = "TS_Emaptytools";
            this.TS_Emaptytools.Size = new System.Drawing.Size(95, 37);
            this.TS_Emaptytools.Text = "تفريغ حقول";
            this.TS_Emaptytools.Click += new System.EventHandler(this.TS_Emaptytools_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // TS_Back
            // 
            this.TS_Back.Image = global::clinic.Properties.Resources.computer_remove;
            this.TS_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Back.Name = "TS_Back";
            this.TS_Back.Size = new System.Drawing.Size(59, 37);
            this.TS_Back.Text = "خلف";
            this.TS_Back.Click += new System.EventHandler(this.TS_Back_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GB_LastMedication, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGV_LastMedication, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 387);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // GB_LastMedication
            // 
            this.GB_LastMedication.Controls.Add(this.pictureBox1);
            this.GB_LastMedication.Controls.Add(this.Cmb_Patient_All);
            this.GB_LastMedication.Controls.Add(this.lbl_Patient_Full);
            this.GB_LastMedication.Controls.Add(this.txt_LastMedicationID);
            this.GB_LastMedication.Controls.Add(this.Cmb_MedcationID);
            this.GB_LastMedication.Controls.Add(this.DPR_DateOfMedication);
            this.GB_LastMedication.Controls.Add(this.lbl_DateOfMedication);
            this.GB_LastMedication.Controls.Add(this.lbl_MedicationID);
            this.GB_LastMedication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_LastMedication.Location = new System.Drawing.Point(3, 3);
            this.GB_LastMedication.Name = "GB_LastMedication";
            this.GB_LastMedication.Size = new System.Drawing.Size(649, 119);
            this.GB_LastMedication.TabIndex = 1;
            this.GB_LastMedication.TabStop = false;
            this.GB_LastMedication.Text = "بيانات الادوية السابقة:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::clinic.Properties.Resources.pills_128_hot;
            this.pictureBox1.Location = new System.Drawing.Point(539, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Cmb_Patient_All
            // 
            this.Cmb_Patient_All.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_Patient_All.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Patient_All.FormattingEnabled = true;
            this.Cmb_Patient_All.Location = new System.Drawing.Point(253, 31);
            this.Cmb_Patient_All.Name = "Cmb_Patient_All";
            this.Cmb_Patient_All.Size = new System.Drawing.Size(170, 21);
            this.Cmb_Patient_All.TabIndex = 8;
            // 
            // lbl_Patient_Full
            // 
            this.lbl_Patient_Full.AutoSize = true;
            this.lbl_Patient_Full.Location = new System.Drawing.Point(438, 34);
            this.lbl_Patient_Full.Name = "lbl_Patient_Full";
            this.lbl_Patient_Full.Size = new System.Drawing.Size(70, 13);
            this.lbl_Patient_Full.TabIndex = 7;
            this.lbl_Patient_Full.Text = "اسم المريض:";
            // 
            // txt_LastMedicationID
            // 
            this.txt_LastMedicationID.Location = new System.Drawing.Point(9, 31);
            this.txt_LastMedicationID.Name = "txt_LastMedicationID";
            this.txt_LastMedicationID.ReadOnly = true;
            this.txt_LastMedicationID.Size = new System.Drawing.Size(42, 20);
            this.txt_LastMedicationID.TabIndex = 5;
            this.txt_LastMedicationID.Visible = false;
            // 
            // Cmb_MedcationID
            // 
            this.Cmb_MedcationID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_MedcationID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_MedcationID.FormattingEnabled = true;
            this.Cmb_MedcationID.Location = new System.Drawing.Point(253, 58);
            this.Cmb_MedcationID.Name = "Cmb_MedcationID";
            this.Cmb_MedcationID.Size = new System.Drawing.Size(170, 21);
            this.Cmb_MedcationID.TabIndex = 3;
            // 
            // DPR_DateOfMedication
            // 
            this.DPR_DateOfMedication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPR_DateOfMedication.Location = new System.Drawing.Point(253, 87);
            this.DPR_DateOfMedication.Name = "DPR_DateOfMedication";
            this.DPR_DateOfMedication.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DPR_DateOfMedication.Size = new System.Drawing.Size(170, 20);
            this.DPR_DateOfMedication.TabIndex = 2;
            // 
            // lbl_DateOfMedication
            // 
            this.lbl_DateOfMedication.AutoSize = true;
            this.lbl_DateOfMedication.Location = new System.Drawing.Point(438, 91);
            this.lbl_DateOfMedication.Name = "lbl_DateOfMedication";
            this.lbl_DateOfMedication.Size = new System.Drawing.Size(78, 13);
            this.lbl_DateOfMedication.TabIndex = 1;
            this.lbl_DateOfMedication.Text = "تاريخ اخذ الدواء:";
            // 
            // lbl_MedicationID
            // 
            this.lbl_MedicationID.AutoSize = true;
            this.lbl_MedicationID.Location = new System.Drawing.Point(438, 62);
            this.lbl_MedicationID.Name = "lbl_MedicationID";
            this.lbl_MedicationID.Size = new System.Drawing.Size(60, 13);
            this.lbl_MedicationID.TabIndex = 0;
            this.lbl_MedicationID.Text = "اسم الدواء:";
            // 
            // DGV_LastMedication
            // 
            this.DGV_LastMedication.AllowUserToAddRows = false;
            this.DGV_LastMedication.AllowUserToDeleteRows = false;
            this.DGV_LastMedication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LastMedication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.FirstName,
            this.MedicationID,
            this.MedicationName,
            this.LastMedicationID,
            this.DateOfMedication});
            this.DGV_LastMedication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_LastMedication.Location = new System.Drawing.Point(3, 128);
            this.DGV_LastMedication.Name = "DGV_LastMedication";
            this.DGV_LastMedication.ReadOnly = true;
            this.DGV_LastMedication.Size = new System.Drawing.Size(649, 256);
            this.DGV_LastMedication.TabIndex = 2;
            this.DGV_LastMedication.Click += new System.EventHandler(this.DGV_LastMedication_Click);
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
            // MedicationID
            // 
            this.MedicationID.DataPropertyName = "MedicationID";
            this.MedicationID.HeaderText = "رقم الدواء";
            this.MedicationID.Name = "MedicationID";
            this.MedicationID.ReadOnly = true;
            this.MedicationID.Visible = false;
            // 
            // MedicationName
            // 
            this.MedicationName.DataPropertyName = "MedicationName";
            this.MedicationName.HeaderText = "اسم الدواء ";
            this.MedicationName.Name = "MedicationName";
            this.MedicationName.ReadOnly = true;
            // 
            // LastMedicationID
            // 
            this.LastMedicationID.DataPropertyName = "LastMedicationID";
            this.LastMedicationID.HeaderText = "رقم الدواء الوراثي";
            this.LastMedicationID.Name = "LastMedicationID";
            this.LastMedicationID.ReadOnly = true;
            this.LastMedicationID.Visible = false;
            // 
            // DateOfMedication
            // 
            this.DateOfMedication.DataPropertyName = "DateOfMedication";
            this.DateOfMedication.HeaderText = "تاريخ اخذ الدواء";
            this.DateOfMedication.Name = "DateOfMedication";
            this.DateOfMedication.ReadOnly = true;
            // 
            // FrmLastMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TS_LastMedication);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 465);
            this.MinimumSize = new System.Drawing.Size(671, 465);
            this.Name = "FrmLastMedication";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الادوية السابقه";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLastMedication_Load);
            this.TS_LastMedication.ResumeLayout(false);
            this.TS_LastMedication.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GB_LastMedication.ResumeLayout(false);
            this.GB_LastMedication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LastMedication)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS_LastMedication;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GB_LastMedication;
        private System.Windows.Forms.DataGridView DGV_LastMedication;
        private System.Windows.Forms.TextBox txt_LastMedicationID;
        private System.Windows.Forms.ComboBox Cmb_MedcationID;
        private System.Windows.Forms.DateTimePicker DPR_DateOfMedication;
        private System.Windows.Forms.Label lbl_DateOfMedication;
        private System.Windows.Forms.Label lbl_MedicationID;
        private System.Windows.Forms.ToolStripButton TS_Add_LastMedication;
        private System.Windows.Forms.ToolStripButton TS_UpData_LastMedication;
        private System.Windows.Forms.ToolStripButton TS_Delete_LastMedication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TS_Back;
        private System.Windows.Forms.Label lbl_Patient_Full;
        private System.Windows.Forms.ComboBox Cmb_Patient_All;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastMedicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfMedication;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton TS_Emaptytools;
    }
}