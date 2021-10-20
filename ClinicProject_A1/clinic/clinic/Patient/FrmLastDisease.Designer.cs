namespace clinic.Patient
{
    partial class FrmLastDisease
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
            this.TS_LastDisease = new System.Windows.Forms.ToolStrip();
            this.TS_Add_LastDisease = new System.Windows.Forms.ToolStripButton();
            this.TS_UpData_LastDisease = new System.Windows.Forms.ToolStripButton();
            this.TS_Delete_LastDisease = new System.Windows.Forms.ToolStripButton();
            this.TS_emptyTools = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Back = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GB_LastDisease_Info = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cmb_Patient_Full = new System.Windows.Forms.ComboBox();
            this.lbl_Full_Name = new System.Windows.Forms.Label();
            this.GB_LastDisease_In = new System.Windows.Forms.GroupBox();
            this.CKB_FamilyDisease = new System.Windows.Forms.CheckBox();
            this.lbl_DateOfDisease = new System.Windows.Forms.Label();
            this.DPK_DateOfDiesase = new System.Windows.Forms.DateTimePicker();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.txt_LastDiseaseID = new System.Windows.Forms.TextBox();
            this.Cmb_DiseaseID = new System.Windows.Forms.ComboBox();
            this.lbl_DiseaseID = new System.Windows.Forms.Label();
            this.DGV_LastDisease_All = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiseaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDiseaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyDisease = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DateOfDisease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TS_LastDisease.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GB_LastDisease_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GB_LastDisease_In.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LastDisease_All)).BeginInit();
            this.SuspendLayout();
            // 
            // TS_LastDisease
            // 
            this.TS_LastDisease.AutoSize = false;
            this.TS_LastDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_LastDisease.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_LastDisease.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add_LastDisease,
            this.TS_UpData_LastDisease,
            this.TS_Delete_LastDisease,
            this.TS_emptyTools,
            this.toolStripSeparator1,
            this.TS_Back});
            this.TS_LastDisease.Location = new System.Drawing.Point(0, 0);
            this.TS_LastDisease.Name = "TS_LastDisease";
            this.TS_LastDisease.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TS_LastDisease.Size = new System.Drawing.Size(655, 40);
            this.TS_LastDisease.TabIndex = 0;
            this.TS_LastDisease.Text = "toolStrip1";
            // 
            // TS_Add_LastDisease
            // 
            this.TS_Add_LastDisease.Image = global::clinic.Properties.Resources.add;
            this.TS_Add_LastDisease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add_LastDisease.Name = "TS_Add_LastDisease";
            this.TS_Add_LastDisease.Size = new System.Drawing.Size(130, 37);
            this.TS_Add_LastDisease.Text = "اضافة مرض سابق";
            this.TS_Add_LastDisease.Click += new System.EventHandler(this.TS_Add_LastDisease_Click);
            // 
            // TS_UpData_LastDisease
            // 
            this.TS_UpData_LastDisease.Image = global::clinic.Properties.Resources.accept;
            this.TS_UpData_LastDisease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_UpData_LastDisease.Name = "TS_UpData_LastDisease";
            this.TS_UpData_LastDisease.Size = new System.Drawing.Size(60, 37);
            this.TS_UpData_LastDisease.Text = "تعديل";
            this.TS_UpData_LastDisease.Click += new System.EventHandler(this.TS_UpData_LastDisease_Click);
            // 
            // TS_Delete_LastDisease
            // 
            this.TS_Delete_LastDisease.Image = global::clinic.Properties.Resources.remove;
            this.TS_Delete_LastDisease.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Delete_LastDisease.Name = "TS_Delete_LastDisease";
            this.TS_Delete_LastDisease.Size = new System.Drawing.Size(59, 37);
            this.TS_Delete_LastDisease.Text = "حذف";
            this.TS_Delete_LastDisease.Click += new System.EventHandler(this.TS_Delete_LastDisease_Click);
            // 
            // TS_emptyTools
            // 
            this.TS_emptyTools.Image = global::clinic.Properties.Resources.Empty_Recycle_Bin;
            this.TS_emptyTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_emptyTools.Name = "TS_emptyTools";
            this.TS_emptyTools.Size = new System.Drawing.Size(100, 37);
            this.TS_emptyTools.Text = "تفريغ الحقول";
            this.TS_emptyTools.Click += new System.EventHandler(this.TS_emptyTools_Click);
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
            this.TS_Back.Size = new System.Drawing.Size(57, 37);
            this.TS_Back.Text = "خلف";
            this.TS_Back.Click += new System.EventHandler(this.TS_Back_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GB_LastDisease_Info, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGV_LastDisease_All, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.06173F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.938272F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 387);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // GB_LastDisease_Info
            // 
            this.GB_LastDisease_Info.Controls.Add(this.pictureBox1);
            this.GB_LastDisease_Info.Controls.Add(this.Cmb_Patient_Full);
            this.GB_LastDisease_Info.Controls.Add(this.lbl_Full_Name);
            this.GB_LastDisease_Info.Controls.Add(this.GB_LastDisease_In);
            this.GB_LastDisease_Info.Controls.Add(this.lbl_DateOfDisease);
            this.GB_LastDisease_Info.Controls.Add(this.DPK_DateOfDiesase);
            this.GB_LastDisease_Info.Controls.Add(this.lbl_FullName);
            this.GB_LastDisease_Info.Controls.Add(this.txt_LastDiseaseID);
            this.GB_LastDisease_Info.Controls.Add(this.Cmb_DiseaseID);
            this.GB_LastDisease_Info.Controls.Add(this.lbl_DiseaseID);
            this.GB_LastDisease_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_LastDisease_Info.Location = new System.Drawing.Point(3, 3);
            this.GB_LastDisease_Info.Name = "GB_LastDisease_Info";
            this.GB_LastDisease_Info.Size = new System.Drawing.Size(649, 147);
            this.GB_LastDisease_Info.TabIndex = 0;
            this.GB_LastDisease_Info.TabStop = false;
            this.GB_LastDisease_Info.Text = "بيانات الامراض السابقة:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::clinic.Properties.Resources.Accessibility;
            this.pictureBox1.Location = new System.Drawing.Point(508, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Cmb_Patient_Full
            // 
            this.Cmb_Patient_Full.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_Patient_Full.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Patient_Full.FormattingEnabled = true;
            this.Cmb_Patient_Full.Location = new System.Drawing.Point(210, 36);
            this.Cmb_Patient_Full.Name = "Cmb_Patient_Full";
            this.Cmb_Patient_Full.Size = new System.Drawing.Size(183, 21);
            this.Cmb_Patient_Full.TabIndex = 10;
            // 
            // lbl_Full_Name
            // 
            this.lbl_Full_Name.AutoSize = true;
            this.lbl_Full_Name.Location = new System.Drawing.Point(399, 39);
            this.lbl_Full_Name.Name = "lbl_Full_Name";
            this.lbl_Full_Name.Size = new System.Drawing.Size(73, 13);
            this.lbl_Full_Name.TabIndex = 9;
            this.lbl_Full_Name.Text = "اسم المريض :";
            // 
            // GB_LastDisease_In
            // 
            this.GB_LastDisease_In.Controls.Add(this.CKB_FamilyDisease);
            this.GB_LastDisease_In.Location = new System.Drawing.Point(22, 35);
            this.GB_LastDisease_In.Name = "GB_LastDisease_In";
            this.GB_LastDisease_In.Size = new System.Drawing.Size(154, 54);
            this.GB_LastDisease_In.TabIndex = 8;
            this.GB_LastDisease_In.TabStop = false;
            this.GB_LastDisease_In.Text = "هل هو مرض ورائي : ";
            // 
            // CKB_FamilyDisease
            // 
            this.CKB_FamilyDisease.AutoSize = true;
            this.CKB_FamilyDisease.Location = new System.Drawing.Point(19, 23);
            this.CKB_FamilyDisease.Name = "CKB_FamilyDisease";
            this.CKB_FamilyDisease.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CKB_FamilyDisease.Size = new System.Drawing.Size(79, 17);
            this.CKB_FamilyDisease.TabIndex = 7;
            this.CKB_FamilyDisease.Text = "مرض وراثي";
            this.CKB_FamilyDisease.UseVisualStyleBackColor = true;
            // 
            // lbl_DateOfDisease
            // 
            this.lbl_DateOfDisease.AutoSize = true;
            this.lbl_DateOfDisease.Location = new System.Drawing.Point(399, 105);
            this.lbl_DateOfDisease.Name = "lbl_DateOfDisease";
            this.lbl_DateOfDisease.Size = new System.Drawing.Size(103, 13);
            this.lbl_DateOfDisease.TabIndex = 6;
            this.lbl_DateOfDisease.Text = "تاريخ الاصابة بالمرض:";
            // 
            // DPK_DateOfDiesase
            // 
            this.DPK_DateOfDiesase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPK_DateOfDiesase.Location = new System.Drawing.Point(210, 101);
            this.DPK_DateOfDiesase.Name = "DPK_DateOfDiesase";
            this.DPK_DateOfDiesase.Size = new System.Drawing.Size(183, 20);
            this.DPK_DateOfDiesase.TabIndex = 5;
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Location = new System.Drawing.Point(159, 39);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(0, 13);
            this.lbl_FullName.TabIndex = 4;
            // 
            // txt_LastDiseaseID
            // 
            this.txt_LastDiseaseID.Location = new System.Drawing.Point(9, 97);
            this.txt_LastDiseaseID.Name = "txt_LastDiseaseID";
            this.txt_LastDiseaseID.ReadOnly = true;
            this.txt_LastDiseaseID.Size = new System.Drawing.Size(24, 20);
            this.txt_LastDiseaseID.TabIndex = 3;
            this.txt_LastDiseaseID.Visible = false;
            // 
            // Cmb_DiseaseID
            // 
            this.Cmb_DiseaseID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_DiseaseID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_DiseaseID.FormattingEnabled = true;
            this.Cmb_DiseaseID.Location = new System.Drawing.Point(210, 68);
            this.Cmb_DiseaseID.Name = "Cmb_DiseaseID";
            this.Cmb_DiseaseID.Size = new System.Drawing.Size(183, 21);
            this.Cmb_DiseaseID.TabIndex = 1;
            // 
            // lbl_DiseaseID
            // 
            this.lbl_DiseaseID.AutoSize = true;
            this.lbl_DiseaseID.Location = new System.Drawing.Point(396, 71);
            this.lbl_DiseaseID.Name = "lbl_DiseaseID";
            this.lbl_DiseaseID.Size = new System.Drawing.Size(67, 13);
            this.lbl_DiseaseID.TabIndex = 0;
            this.lbl_DiseaseID.Text = "اسم المرض:";
            // 
            // DGV_LastDisease_All
            // 
            this.DGV_LastDisease_All.AllowUserToAddRows = false;
            this.DGV_LastDisease_All.AllowUserToDeleteRows = false;
            this.DGV_LastDisease_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LastDisease_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.FirstName,
            this.DiseaseID,
            this.DiseaseName,
            this.LastDiseaseID,
            this.FamilyDisease,
            this.DateOfDisease});
            this.DGV_LastDisease_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_LastDisease_All.Location = new System.Drawing.Point(3, 163);
            this.DGV_LastDisease_All.Name = "DGV_LastDisease_All";
            this.DGV_LastDisease_All.ReadOnly = true;
            this.DGV_LastDisease_All.Size = new System.Drawing.Size(649, 221);
            this.DGV_LastDisease_All.TabIndex = 2;
            this.DGV_LastDisease_All.Click += new System.EventHandler(this.DGV_LastDisease_All_Click);
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.PatientID.DefaultCellStyle = dataGridViewCellStyle1;
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
            // DiseaseID
            // 
            this.DiseaseID.DataPropertyName = "DiseaseID";
            this.DiseaseID.HeaderText = "رقم ا لمرض";
            this.DiseaseID.Name = "DiseaseID";
            this.DiseaseID.ReadOnly = true;
            this.DiseaseID.Visible = false;
            // 
            // DiseaseName
            // 
            this.DiseaseName.DataPropertyName = "DiseaseName";
            this.DiseaseName.HeaderText = "اسم المرض";
            this.DiseaseName.Name = "DiseaseName";
            this.DiseaseName.ReadOnly = true;
            // 
            // LastDiseaseID
            // 
            this.LastDiseaseID.DataPropertyName = "LastDiseaseID";
            this.LastDiseaseID.HeaderText = "المرض السابق";
            this.LastDiseaseID.Name = "LastDiseaseID";
            this.LastDiseaseID.ReadOnly = true;
            this.LastDiseaseID.Visible = false;
            this.LastDiseaseID.Width = 200;
            // 
            // FamilyDisease
            // 
            this.FamilyDisease.DataPropertyName = "FamilyDisease";
            this.FamilyDisease.HeaderText = "الامراض الوراثية";
            this.FamilyDisease.Name = "FamilyDisease";
            this.FamilyDisease.ReadOnly = true;
            this.FamilyDisease.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FamilyDisease.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DateOfDisease
            // 
            this.DateOfDisease.DataPropertyName = "DateOfDisease";
            this.DateOfDisease.HeaderText = "تاريخ الاصابة بامرض";
            this.DateOfDisease.Name = "DateOfDisease";
            this.DateOfDisease.ReadOnly = true;
            // 
            // FrmLastDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TS_LastDisease);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 465);
            this.MinimumSize = new System.Drawing.Size(671, 465);
            this.Name = "FrmLastDisease";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "امراض المريض";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLastDisease_Load);
            this.TS_LastDisease.ResumeLayout(false);
            this.TS_LastDisease.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GB_LastDisease_Info.ResumeLayout(false);
            this.GB_LastDisease_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GB_LastDisease_In.ResumeLayout(false);
            this.GB_LastDisease_In.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LastDisease_All)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS_LastDisease;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GB_LastDisease_Info;
        private System.Windows.Forms.TextBox txt_LastDiseaseID;
        private System.Windows.Forms.ComboBox Cmb_DiseaseID;
        private System.Windows.Forms.Label lbl_DiseaseID;
        private System.Windows.Forms.DataGridView DGV_LastDisease_All;
        private System.Windows.Forms.ToolStripButton TS_Add_LastDisease;
        private System.Windows.Forms.ToolStripButton TS_UpData_LastDisease;
        private System.Windows.Forms.ToolStripButton TS_Delete_LastDisease;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TS_Back;
        private System.Windows.Forms.CheckBox CKB_FamilyDisease;
        private System.Windows.Forms.Label lbl_DateOfDisease;
        private System.Windows.Forms.DateTimePicker DPK_DateOfDiesase;
        private System.Windows.Forms.Label lbl_Full_Name;
        private System.Windows.Forms.GroupBox GB_LastDisease_In;
        private System.Windows.Forms.ComboBox Cmb_Patient_Full;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiseaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDiseaseID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FamilyDisease;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfDisease;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton TS_emptyTools;
    }
}