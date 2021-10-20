namespace clinic.Appointment
{
    partial class FrmAppointment
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
            this.TS_Appointment = new System.Windows.Forms.ToolStrip();
            this.TS_Add_Appointment = new System.Windows.Forms.ToolStripButton();
            this.TS_Updata_Appointment = new System.Windows.Forms.ToolStripButton();
            this.TS_Delete_Appointment = new System.Windows.Forms.ToolStripButton();
            this.TSB_Empty = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_BAckTOMAin = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GB_INFO_ADD_Appo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_AppointmentID = new System.Windows.Forms.TextBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.Cmb_VisitType = new System.Windows.Forms.ComboBox();
            this.lbl_VisitType = new System.Windows.Forms.Label();
            this.DPK_Info = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.Mtxt_Time = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.DGV_Appointment_All = new System.Windows.Forms.DataGridView();
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GB_Date_Now = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DPK_Appo = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TS_Appointment.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.GB_INFO_ADD_Appo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Appointment_All)).BeginInit();
            this.GB_Date_Now.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TS_Appointment
            // 
            this.TS_Appointment.AutoSize = false;
            this.TS_Appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Appointment.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_Appointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add_Appointment,
            this.TS_Updata_Appointment,
            this.TS_Delete_Appointment,
            this.TSB_Empty,
            this.toolStripSeparator1,
            this.TS_BAckTOMAin});
            this.TS_Appointment.Location = new System.Drawing.Point(0, 0);
            this.TS_Appointment.Name = "TS_Appointment";
            this.TS_Appointment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TS_Appointment.Size = new System.Drawing.Size(655, 40);
            this.TS_Appointment.TabIndex = 0;
            this.TS_Appointment.Text = "toolStrip1";
            // 
            // TS_Add_Appointment
            // 
            this.TS_Add_Appointment.Image = global::clinic.Properties.Resources.application_add;
            this.TS_Add_Appointment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add_Appointment.Name = "TS_Add_Appointment";
            this.TS_Add_Appointment.Size = new System.Drawing.Size(95, 37);
            this.TS_Add_Appointment.Text = "اضافة موعد";
            this.TS_Add_Appointment.Click += new System.EventHandler(this.TS_Add_Appointment_Click);
            // 
            // TS_Updata_Appointment
            // 
            this.TS_Updata_Appointment.Image = global::clinic.Properties.Resources.application_up;
            this.TS_Updata_Appointment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Updata_Appointment.Name = "TS_Updata_Appointment";
            this.TS_Updata_Appointment.Size = new System.Drawing.Size(60, 37);
            this.TS_Updata_Appointment.Text = "تعديل";
            this.TS_Updata_Appointment.Click += new System.EventHandler(this.TS_Updata_Appointment_Click);
            // 
            // TS_Delete_Appointment
            // 
            this.TS_Delete_Appointment.Image = global::clinic.Properties.Resources.application_remove;
            this.TS_Delete_Appointment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Delete_Appointment.Name = "TS_Delete_Appointment";
            this.TS_Delete_Appointment.Size = new System.Drawing.Size(59, 37);
            this.TS_Delete_Appointment.Text = "حذف";
            this.TS_Delete_Appointment.Click += new System.EventHandler(this.TS_Delete_Appointment_Click);
            // 
            // TSB_Empty
            // 
            this.TSB_Empty.Image = global::clinic.Properties.Resources.Empty_Recycle_Bin;
            this.TSB_Empty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Empty.Name = "TSB_Empty";
            this.TSB_Empty.Size = new System.Drawing.Size(100, 37);
            this.TSB_Empty.Text = "تفريغ الحقول";
            this.TSB_Empty.Click += new System.EventHandler(this.TSB_Empty_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // TS_BAckTOMAin
            // 
            this.TS_BAckTOMAin.Image = global::clinic.Properties.Resources.computer_remove;
            this.TS_BAckTOMAin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_BAckTOMAin.Name = "TS_BAckTOMAin";
            this.TS_BAckTOMAin.Size = new System.Drawing.Size(64, 37);
            this.TS_BAckTOMAin.Text = "اغلاق";
            this.TS_BAckTOMAin.Click += new System.EventHandler(this.TS_BAckTOMAin_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GB_INFO_ADD_Appo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGV_Appointment_All, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.GB_Date_Now, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 387);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // GB_INFO_ADD_Appo
            // 
            this.GB_INFO_ADD_Appo.Controls.Add(this.pictureBox1);
            this.GB_INFO_ADD_Appo.Controls.Add(this.txt_AppointmentID);
            this.GB_INFO_ADD_Appo.Controls.Add(this.txt_Note);
            this.GB_INFO_ADD_Appo.Controls.Add(this.lbl_Note);
            this.GB_INFO_ADD_Appo.Controls.Add(this.Cmb_VisitType);
            this.GB_INFO_ADD_Appo.Controls.Add(this.lbl_VisitType);
            this.GB_INFO_ADD_Appo.Controls.Add(this.DPK_Info);
            this.GB_INFO_ADD_Appo.Controls.Add(this.lbl_Date);
            this.GB_INFO_ADD_Appo.Controls.Add(this.Mtxt_Time);
            this.GB_INFO_ADD_Appo.Controls.Add(this.lbl_Time);
            this.GB_INFO_ADD_Appo.Controls.Add(this.txt_Name);
            this.GB_INFO_ADD_Appo.Controls.Add(this.lbl_Name);
            this.GB_INFO_ADD_Appo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_INFO_ADD_Appo.Location = new System.Drawing.Point(3, 3);
            this.GB_INFO_ADD_Appo.Name = "GB_INFO_ADD_Appo";
            this.GB_INFO_ADD_Appo.Size = new System.Drawing.Size(649, 117);
            this.GB_INFO_ADD_Appo.TabIndex = 0;
            this.GB_INFO_ADD_Appo.TabStop = false;
            this.GB_INFO_ADD_Appo.Text = "اضافة موعد:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::clinic.Properties.Resources.Date_and_Time;
            this.pictureBox1.Location = new System.Drawing.Point(544, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txt_AppointmentID
            // 
            this.txt_AppointmentID.Location = new System.Drawing.Point(421, 15);
            this.txt_AppointmentID.Name = "txt_AppointmentID";
            this.txt_AppointmentID.ReadOnly = true;
            this.txt_AppointmentID.Size = new System.Drawing.Size(10, 20);
            this.txt_AppointmentID.TabIndex = 2;
            this.txt_AppointmentID.Visible = false;
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(28, 78);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(254, 20);
            this.txt_Note.TabIndex = 9;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(289, 81);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(46, 13);
            this.lbl_Note.TabIndex = 8;
            this.lbl_Note.Text = "ملاحظة:";
            // 
            // Cmb_VisitType
            // 
            this.Cmb_VisitType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_VisitType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_VisitType.FormattingEnabled = true;
            this.Cmb_VisitType.Location = new System.Drawing.Point(340, 77);
            this.Cmb_VisitType.Name = "Cmb_VisitType";
            this.Cmb_VisitType.Size = new System.Drawing.Size(133, 21);
            this.Cmb_VisitType.TabIndex = 7;
            // 
            // lbl_VisitType
            // 
            this.lbl_VisitType.AutoSize = true;
            this.lbl_VisitType.Location = new System.Drawing.Point(479, 80);
            this.lbl_VisitType.Name = "lbl_VisitType";
            this.lbl_VisitType.Size = new System.Drawing.Size(55, 13);
            this.lbl_VisitType.TabIndex = 6;
            this.lbl_VisitType.Text = "نوع الزياره:";
            // 
            // DPK_Info
            // 
            this.DPK_Info.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPK_Info.Location = new System.Drawing.Point(29, 44);
            this.DPK_Info.Name = "DPK_Info";
            this.DPK_Info.Size = new System.Drawing.Size(140, 20);
            this.DPK_Info.TabIndex = 5;
            this.DPK_Info.Value = new System.DateTime(2008, 3, 13, 0, 0, 0, 0);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(175, 47);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(39, 13);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "التاريخ:";
            // 
            // Mtxt_Time
            // 
            this.Mtxt_Time.Location = new System.Drawing.Point(233, 44);
            this.Mtxt_Time.Mask = "00:00";
            this.Mtxt_Time.Name = "Mtxt_Time";
            this.Mtxt_Time.Size = new System.Drawing.Size(49, 20);
            this.Mtxt_Time.TabIndex = 3;
            this.Mtxt_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Mtxt_Time.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(288, 47);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(37, 13);
            this.lbl_Time.TabIndex = 2;
            this.lbl_Time.Text = "الوقت:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(340, 43);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(132, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(478, 46);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(70, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "اسم المريض:";
            // 
            // DGV_Appointment_All
            // 
            this.DGV_Appointment_All.AllowUserToAddRows = false;
            this.DGV_Appointment_All.AllowUserToDeleteRows = false;
            this.DGV_Appointment_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Appointment_All.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentID,
            this.PatientName,
            this.Date,
            this.Time,
            this.VisitTypeID,
            this.VisitType,
            this.Note});
            this.DGV_Appointment_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Appointment_All.Location = new System.Drawing.Point(3, 191);
            this.DGV_Appointment_All.Name = "DGV_Appointment_All";
            this.DGV_Appointment_All.ReadOnly = true;
            this.DGV_Appointment_All.Size = new System.Drawing.Size(649, 193);
            this.DGV_Appointment_All.TabIndex = 1;
            this.DGV_Appointment_All.DoubleClick += new System.EventHandler(this.DGV_Appointment_All_DoubleClick);
            // 
            // AppointmentID
            // 
            this.AppointmentID.DataPropertyName = "AppointmentID";
            this.AppointmentID.HeaderText = "رقم";
            this.AppointmentID.Name = "AppointmentID";
            this.AppointmentID.ReadOnly = true;
            this.AppointmentID.Visible = false;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "اسم المريض";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Width = 150;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "التاريخ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Visible = false;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "الوقت";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // VisitTypeID
            // 
            this.VisitTypeID.DataPropertyName = "VisitTypeID";
            this.VisitTypeID.HeaderText = "رقم الزيارة";
            this.VisitTypeID.Name = "VisitTypeID";
            this.VisitTypeID.ReadOnly = true;
            this.VisitTypeID.Visible = false;
            // 
            // VisitType
            // 
            this.VisitType.DataPropertyName = "VisitType";
            this.VisitType.HeaderText = "نوع الزيارة";
            this.VisitType.Name = "VisitType";
            this.VisitType.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "ملاحظة";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 200;
            // 
            // GB_Date_Now
            // 
            this.GB_Date_Now.Controls.Add(this.pictureBox2);
            this.GB_Date_Now.Controls.Add(this.DPK_Appo);
            this.GB_Date_Now.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Date_Now.Location = new System.Drawing.Point(3, 126);
            this.GB_Date_Now.Name = "GB_Date_Now";
            this.GB_Date_Now.Size = new System.Drawing.Size(649, 59);
            this.GB_Date_Now.TabIndex = 2;
            this.GB_Date_Now.TabStop = false;
            this.GB_Date_Now.Text = "تحديد الموعد:";
            this.GB_Date_Now.Enter += new System.EventHandler(this.GB_Date_Now_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::clinic.Properties.Resources.Clock__Custom_;
            this.pictureBox2.Location = new System.Drawing.Point(444, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // DPK_Appo
            // 
            this.DPK_Appo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPK_Appo.Location = new System.Drawing.Point(231, 24);
            this.DPK_Appo.Name = "DPK_Appo";
            this.DPK_Appo.Size = new System.Drawing.Size(200, 20);
            this.DPK_Appo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.DPK_Appo, "يمكنك تحديد اليوم للعرض");
            this.DPK_Appo.Value = new System.DateTime(2008, 3, 13, 0, 0, 0, 0);
            this.DPK_Appo.ValueChanged += new System.EventHandler(this.DPK_Appo_ValueChanged);
            // 
            // FrmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TS_Appointment);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 465);
            this.MinimumSize = new System.Drawing.Size(671, 465);
            this.Name = "FrmAppointment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جدول المواعيد";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAppointment_Load);
            this.TS_Appointment.ResumeLayout(false);
            this.TS_Appointment.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GB_INFO_ADD_Appo.ResumeLayout(false);
            this.GB_INFO_ADD_Appo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Appointment_All)).EndInit();
            this.GB_Date_Now.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS_Appointment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GB_INFO_ADD_Appo;
        private System.Windows.Forms.DataGridView DGV_Appointment_All;
        private System.Windows.Forms.GroupBox GB_Date_Now;
        private System.Windows.Forms.DateTimePicker DPK_Appo;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.MaskedTextBox Mtxt_Time;
        private System.Windows.Forms.Label lbl_VisitType;
        private System.Windows.Forms.DateTimePicker DPK_Info;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.ComboBox Cmb_VisitType;
        private System.Windows.Forms.ToolStripButton TS_Add_Appointment;
        private System.Windows.Forms.ToolStripButton TS_Updata_Appointment;
        private System.Windows.Forms.TextBox txt_AppointmentID;
        private System.Windows.Forms.ToolStripButton TS_Delete_Appointment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TS_BAckTOMAin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.ToolStripButton TSB_Empty;
    }
}