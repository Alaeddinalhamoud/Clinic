namespace clinic.Patient
{
    partial class Frm_Operation_Patient
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
            this.GB_Operation_Info = new System.Windows.Forms.GroupBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Full_Name = new System.Windows.Forms.Label();
            this.Cmb_Patient_Full = new System.Windows.Forms.ComboBox();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.Cmb_Operation = new System.Windows.Forms.ComboBox();
            this.DTP_opration = new System.Windows.Forms.DateTimePicker();
            this.txt_OperationID = new System.Windows.Forms.TextBox();
            this.lbl_OperationType = new System.Windows.Forms.Label();
            this.lbl_DateOfR = new System.Windows.Forms.Label();
            this.DGV_OPeration_Patient_All = new System.Windows.Forms.DataGridView();
            this.OperationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TS_Operation = new System.Windows.Forms.ToolStrip();
            this.TS_Add_Operation_Patient = new System.Windows.Forms.ToolStripButton();
            this.TS_UpData_Operation_Patient = new System.Windows.Forms.ToolStripButton();
            this.TS_Delete_Operation_Patient = new System.Windows.Forms.ToolStripButton();
            this.Ts_EmptyRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.لإٍ = new System.Windows.Forms.ToolStripSplitButton();
            this.TS_S_By_PatientID = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_S_By_Name_All_PAtient = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Back = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.GB_Operation_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OPeration_Patient_All)).BeginInit();
            this.TS_Operation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GB_Operation_Info, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DGV_OPeration_Patient_All, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.42424F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.57576F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 427);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GB_Operation_Info
            // 
            this.GB_Operation_Info.Controls.Add(this.txt_Note);
            this.GB_Operation_Info.Controls.Add(this.lbl_Note);
            this.GB_Operation_Info.Controls.Add(this.pictureBox1);
            this.GB_Operation_Info.Controls.Add(this.lbl_Full_Name);
            this.GB_Operation_Info.Controls.Add(this.Cmb_Patient_Full);
            this.GB_Operation_Info.Controls.Add(this.lbl_FullName);
            this.GB_Operation_Info.Controls.Add(this.Cmb_Operation);
            this.GB_Operation_Info.Controls.Add(this.DTP_opration);
            this.GB_Operation_Info.Controls.Add(this.txt_OperationID);
            this.GB_Operation_Info.Controls.Add(this.lbl_OperationType);
            this.GB_Operation_Info.Controls.Add(this.lbl_DateOfR);
            this.GB_Operation_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Operation_Info.Location = new System.Drawing.Point(3, 44);
            this.GB_Operation_Info.Name = "GB_Operation_Info";
            this.GB_Operation_Info.Size = new System.Drawing.Size(649, 135);
            this.GB_Operation_Info.TabIndex = 3;
            this.GB_Operation_Info.TabStop = false;
            this.GB_Operation_Info.Text = "بيانات العملية:";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(9, 35);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(177, 71);
            this.txt_Note.TabIndex = 14;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(190, 35);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(52, 13);
            this.lbl_Note.TabIndex = 13;
            this.lbl_Note.Text = "ملاحظات:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::clinic.Properties.Resources.ambulance_128;
            this.pictureBox1.Location = new System.Drawing.Point(510, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 116);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Full_Name
            // 
            this.lbl_Full_Name.AutoSize = true;
            this.lbl_Full_Name.Location = new System.Drawing.Point(443, 35);
            this.lbl_Full_Name.Name = "lbl_Full_Name";
            this.lbl_Full_Name.Size = new System.Drawing.Size(70, 13);
            this.lbl_Full_Name.TabIndex = 11;
            this.lbl_Full_Name.Text = "اسم المريض:";
            // 
            // Cmb_Patient_Full
            // 
            this.Cmb_Patient_Full.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_Patient_Full.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Patient_Full.FormattingEnabled = true;
            this.Cmb_Patient_Full.Location = new System.Drawing.Point(248, 32);
            this.Cmb_Patient_Full.Name = "Cmb_Patient_Full";
            this.Cmb_Patient_Full.Size = new System.Drawing.Size(192, 21);
            this.Cmb_Patient_Full.TabIndex = 10;
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Location = new System.Drawing.Point(351, 14);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(0, 13);
            this.lbl_FullName.TabIndex = 9;
            // 
            // Cmb_Operation
            // 
            this.Cmb_Operation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_Operation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Operation.FormattingEnabled = true;
            this.Cmb_Operation.Location = new System.Drawing.Point(248, 59);
            this.Cmb_Operation.Name = "Cmb_Operation";
            this.Cmb_Operation.Size = new System.Drawing.Size(192, 21);
            this.Cmb_Operation.TabIndex = 8;
            // 
            // DTP_opration
            // 
            this.DTP_opration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_opration.Location = new System.Drawing.Point(248, 86);
            this.DTP_opration.Name = "DTP_opration";
            this.DTP_opration.Size = new System.Drawing.Size(190, 20);
            this.DTP_opration.TabIndex = 7;
            // 
            // txt_OperationID
            // 
            this.txt_OperationID.Location = new System.Drawing.Point(354, 112);
            this.txt_OperationID.Name = "txt_OperationID";
            this.txt_OperationID.ReadOnly = true;
            this.txt_OperationID.Size = new System.Drawing.Size(84, 20);
            this.txt_OperationID.TabIndex = 4;
            this.txt_OperationID.Visible = false;
            // 
            // lbl_OperationType
            // 
            this.lbl_OperationType.AutoSize = true;
            this.lbl_OperationType.Location = new System.Drawing.Point(443, 62);
            this.lbl_OperationType.Name = "lbl_OperationType";
            this.lbl_OperationType.Size = new System.Drawing.Size(62, 13);
            this.lbl_OperationType.TabIndex = 3;
            this.lbl_OperationType.Text = "نوع العملية:";
            // 
            // lbl_DateOfR
            // 
            this.lbl_DateOfR.AutoSize = true;
            this.lbl_DateOfR.Location = new System.Drawing.Point(443, 90);
            this.lbl_DateOfR.Name = "lbl_DateOfR";
            this.lbl_DateOfR.Size = new System.Drawing.Size(68, 13);
            this.lbl_DateOfR.TabIndex = 1;
            this.lbl_DateOfR.Text = "تاريخ العملية:";
            // 
            // DGV_OPeration_Patient_All
            // 
            this.DGV_OPeration_Patient_All.AllowUserToAddRows = false;
            this.DGV_OPeration_Patient_All.AllowUserToDeleteRows = false;
            this.DGV_OPeration_Patient_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_OPeration_Patient_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OperationID,
            this.DateOfOperation,
            this.FirstName,
            this.OperationType,
            this.PatientID,
            this.OperationTypeID});
            this.DGV_OPeration_Patient_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_OPeration_Patient_All.Location = new System.Drawing.Point(3, 193);
            this.DGV_OPeration_Patient_All.Name = "DGV_OPeration_Patient_All";
            this.DGV_OPeration_Patient_All.ReadOnly = true;
            this.DGV_OPeration_Patient_All.Size = new System.Drawing.Size(649, 231);
            this.DGV_OPeration_Patient_All.TabIndex = 5;
            this.DGV_OPeration_Patient_All.Click += new System.EventHandler(this.DGV_OPeration_Patient_All_Click_1);
            // 
            // OperationID
            // 
            this.OperationID.DataPropertyName = "OperationID";
            this.OperationID.HeaderText = "رقم العملية";
            this.OperationID.Name = "OperationID";
            this.OperationID.ReadOnly = true;
            // 
            // DateOfOperation
            // 
            this.DateOfOperation.DataPropertyName = "DateOfOperation";
            this.DateOfOperation.HeaderText = "تاريخ العملية";
            this.DateOfOperation.Name = "DateOfOperation";
            this.DateOfOperation.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "اسم المريض";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // OperationType
            // 
            this.OperationType.DataPropertyName = "OperationType";
            this.OperationType.HeaderText = "اسم العملية";
            this.OperationType.Name = "OperationType";
            this.OperationType.ReadOnly = true;
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "رقم المريض";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Visible = false;
            // 
            // OperationTypeID
            // 
            this.OperationTypeID.DataPropertyName = "OperationTypeID";
            this.OperationTypeID.HeaderText = "رقم العملية";
            this.OperationTypeID.Name = "OperationTypeID";
            this.OperationTypeID.ReadOnly = true;
            this.OperationTypeID.Visible = false;
            // 
            // TS_Operation
            // 
            this.TS_Operation.AutoSize = false;
            this.TS_Operation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Operation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_Operation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add_Operation_Patient,
            this.TS_UpData_Operation_Patient,
            this.TS_Delete_Operation_Patient,
            this.Ts_EmptyRecord,
            this.toolStripSeparator2,
            this.لإٍ,
            this.toolStripSeparator1,
            this.TS_Back});
            this.TS_Operation.Location = new System.Drawing.Point(0, 0);
            this.TS_Operation.Name = "TS_Operation";
            this.TS_Operation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TS_Operation.Size = new System.Drawing.Size(655, 40);
            this.TS_Operation.TabIndex = 1;
            this.TS_Operation.Text = "toolStrip1";
            // 
            // TS_Add_Operation_Patient
            // 
            this.TS_Add_Operation_Patient.Image = global::clinic.Properties.Resources.add;
            this.TS_Add_Operation_Patient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add_Operation_Patient.Name = "TS_Add_Operation_Patient";
            this.TS_Add_Operation_Patient.Size = new System.Drawing.Size(144, 37);
            this.TS_Add_Operation_Patient.Text = "اضافة عملية للمريض";
            this.TS_Add_Operation_Patient.Click += new System.EventHandler(this.TS_Add_Operation_Patient_Click);
            // 
            // TS_UpData_Operation_Patient
            // 
            this.TS_UpData_Operation_Patient.Image = global::clinic.Properties.Resources.accept;
            this.TS_UpData_Operation_Patient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_UpData_Operation_Patient.Name = "TS_UpData_Operation_Patient";
            this.TS_UpData_Operation_Patient.Size = new System.Drawing.Size(61, 37);
            this.TS_UpData_Operation_Patient.Text = "تعديل";
            this.TS_UpData_Operation_Patient.Click += new System.EventHandler(this.TS_UpData_Operation_Patient_Click);
            // 
            // TS_Delete_Operation_Patient
            // 
            this.TS_Delete_Operation_Patient.Image = global::clinic.Properties.Resources.remove;
            this.TS_Delete_Operation_Patient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Delete_Operation_Patient.Name = "TS_Delete_Operation_Patient";
            this.TS_Delete_Operation_Patient.Size = new System.Drawing.Size(61, 37);
            this.TS_Delete_Operation_Patient.Text = "حذف";
            this.TS_Delete_Operation_Patient.Click += new System.EventHandler(this.TS_Delete_Operation_Patient_Click);
            // 
            // Ts_EmptyRecord
            // 
            this.Ts_EmptyRecord.Image = global::clinic.Properties.Resources.Empty_Recycle_Bin;
            this.Ts_EmptyRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ts_EmptyRecord.Name = "Ts_EmptyRecord";
            this.Ts_EmptyRecord.Size = new System.Drawing.Size(102, 37);
            this.Ts_EmptyRecord.Text = "تفريغ الحقول";
            this.Ts_EmptyRecord.Click += new System.EventHandler(this.Ts_EmptyRecord_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // لإٍ
            // 
            this.لإٍ.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_S_By_PatientID,
            this.TS_S_By_Name_All_PAtient});
            this.لإٍ.Image = global::clinic.Properties.Resources.notes_edit;
            this.لإٍ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.لإٍ.Name = "لإٍ";
            this.لإٍ.Size = new System.Drawing.Size(79, 37);
            this.لإٍ.Text = "تقارير";
            // 
            // TS_S_By_PatientID
            // 
            this.TS_S_By_PatientID.Name = "TS_S_By_PatientID";
            this.TS_S_By_PatientID.Size = new System.Drawing.Size(163, 26);
            this.TS_S_By_PatientID.Text = "باسم المريض";
            this.TS_S_By_PatientID.Click += new System.EventHandler(this.TS_S_By_PatientID_Click);
            // 
            // TS_S_By_Name_All_PAtient
            // 
            this.TS_S_By_Name_All_PAtient.Name = "TS_S_By_Name_All_PAtient";
            this.TS_S_By_Name_All_PAtient.Size = new System.Drawing.Size(163, 26);
            this.TS_S_By_Name_All_PAtient.Text = "باسماء المرضى";
            this.TS_S_By_Name_All_PAtient.Click += new System.EventHandler(this.TS_S_By_Name_All_PAtient_Click);
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
            // Frm_Operation_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.Controls.Add(this.TS_Operation);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 465);
            this.MinimumSize = new System.Drawing.Size(671, 465);
            this.Name = "Frm_Operation_Patient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عمليات المريض";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Operation_Patient_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GB_Operation_Info.ResumeLayout(false);
            this.GB_Operation_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OPeration_Patient_All)).EndInit();
            this.TS_Operation.ResumeLayout(false);
            this.TS_Operation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip TS_Operation;
        private System.Windows.Forms.ToolStripButton TS_Add_Operation_Patient;
        private System.Windows.Forms.GroupBox GB_Operation_Info;
        private System.Windows.Forms.ToolStripButton TS_UpData_Operation_Patient;
        private System.Windows.Forms.ToolStripButton TS_Delete_Operation_Patient;
        private System.Windows.Forms.ToolStripButton TS_Back;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lbl_OperationType;
        private System.Windows.Forms.Label lbl_DateOfR;
        private System.Windows.Forms.TextBox txt_OperationID;
        private System.Windows.Forms.DateTimePicker DTP_opration;
        private System.Windows.Forms.ComboBox Cmb_Operation;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_Full_Name;
        private System.Windows.Forms.ComboBox Cmb_Patient_Full;
        private System.Windows.Forms.DataGridView DGV_OPeration_Patient_All;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationTypeID;
        private System.Windows.Forms.ToolStripSplitButton لإٍ;
        private System.Windows.Forms.ToolStripMenuItem TS_S_By_PatientID;
        private System.Windows.Forms.ToolStripMenuItem TS_S_By_Name_All_PAtient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Ts_EmptyRecord;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label lbl_Note;
    }
}