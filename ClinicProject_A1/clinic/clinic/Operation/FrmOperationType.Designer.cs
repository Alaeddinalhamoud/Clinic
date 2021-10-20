namespace clinic.Operation
{
    partial class FrmOperationType
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
            this.TS_Operation = new System.Windows.Forms.ToolStrip();
            this.TS_Add_OperationType = new System.Windows.Forms.ToolStripButton();
            this.TS_UpData_OperationTpye = new System.Windows.Forms.ToolStripButton();
            this.TS_Delete_OperationType = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSS_Reoprt = new System.Windows.Forms.ToolStripSplitButton();
            this.TSS_Report_All = new System.Windows.Forms.ToolStripMenuItem();
            this.TSS_Report_FlowChar = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_ImportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Back_To_Main = new System.Windows.Forms.ToolStripButton();
            this.DGV_OperationType = new System.Windows.Forms.DataGridView();
            this.OperationTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GB_Operation_INfo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_OperationType = new System.Windows.Forms.TextBox();
            this.txt_OperationTypeID = new System.Windows.Forms.TextBox();
            this.lbl_OperationType = new System.Windows.Forms.Label();
            this.lbl_OperationTypeID = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GB_Search = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_TEXT = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.TS_Operation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OperationType)).BeginInit();
            this.GB_Operation_INfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.GB_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TS_Operation, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGV_OperationType, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.GB_Operation_INfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.36842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.63158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 427);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TS_Operation
            // 
            this.TS_Operation.AutoSize = false;
            this.TS_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Operation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_Operation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add_OperationType,
            this.TS_UpData_OperationTpye,
            this.TS_Delete_OperationType,
            this.toolStripSeparator2,
            this.TSS_Reoprt,
            this.TS_ImportExcel,
            this.toolStripSeparator1,
            this.TS_Back_To_Main});
            this.TS_Operation.Location = new System.Drawing.Point(0, 0);
            this.TS_Operation.Name = "TS_Operation";
            this.TS_Operation.Size = new System.Drawing.Size(655, 40);
            this.TS_Operation.TabIndex = 0;
            // 
            // TS_Add_OperationType
            // 
            this.TS_Add_OperationType.Image = global::clinic.Properties.Resources.add;
            this.TS_Add_OperationType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add_OperationType.Name = "TS_Add_OperationType";
            this.TS_Add_OperationType.Size = new System.Drawing.Size(162, 37);
            this.TS_Add_OperationType.Text = "اضافة إلى جدول العمليات";
            this.TS_Add_OperationType.Click += new System.EventHandler(this.TS_Add_OperationType_Click);
            // 
            // TS_UpData_OperationTpye
            // 
            this.TS_UpData_OperationTpye.Image = global::clinic.Properties.Resources.accept;
            this.TS_UpData_OperationTpye.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_UpData_OperationTpye.Name = "TS_UpData_OperationTpye";
            this.TS_UpData_OperationTpye.Size = new System.Drawing.Size(60, 37);
            this.TS_UpData_OperationTpye.Text = "تعديل";
            this.TS_UpData_OperationTpye.Click += new System.EventHandler(this.TS_UpData_OperationTpye_Click);
            // 
            // TS_Delete_OperationType
            // 
            this.TS_Delete_OperationType.Image = global::clinic.Properties.Resources.remove;
            this.TS_Delete_OperationType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Delete_OperationType.Name = "TS_Delete_OperationType";
            this.TS_Delete_OperationType.Size = new System.Drawing.Size(59, 37);
            this.TS_Delete_OperationType.Text = "حذف";
            this.TS_Delete_OperationType.Click += new System.EventHandler(this.TS_Delete_OperationType_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // TSS_Reoprt
            // 
            this.TSS_Reoprt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSS_Report_All,
            this.TSS_Report_FlowChar});
            this.TSS_Reoprt.Image = global::clinic.Properties.Resources.notes_edit;
            this.TSS_Reoprt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSS_Reoprt.Name = "TSS_Reoprt";
            this.TSS_Reoprt.Size = new System.Drawing.Size(78, 37);
            this.TSS_Reoprt.Text = "تقارير";
            // 
            // TSS_Report_All
            // 
            this.TSS_Report_All.Name = "TSS_Report_All";
            this.TSS_Report_All.Size = new System.Drawing.Size(208, 26);
            this.TSS_Report_All.Text = "تقرير بالعمليات";
            this.TSS_Report_All.Click += new System.EventHandler(this.TSS_Report_All_Click);
            // 
            // TSS_Report_FlowChar
            // 
            this.TSS_Report_FlowChar.Image = global::clinic.Properties.Resources.chart;
            this.TSS_Report_FlowChar.Name = "TSS_Report_FlowChar";
            this.TSS_Report_FlowChar.Size = new System.Drawing.Size(208, 26);
            this.TSS_Report_FlowChar.Text = "مخطط احصائي بالعمليات";
            this.TSS_Report_FlowChar.Click += new System.EventHandler(this.TSS_Report_FlowChar_Click);
            // 
            // TS_ImportExcel
            // 
            this.TS_ImportExcel.Image = global::clinic.Properties.Resources.tdx_excel2__Custom_;
            this.TS_ImportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_ImportExcel.Name = "TS_ImportExcel";
            this.TS_ImportExcel.Size = new System.Drawing.Size(138, 37);
            this.TS_ImportExcel.Text = "استيراد ملف Excel";
            this.TS_ImportExcel.Click += new System.EventHandler(this.TS_ImportExcel_Click);
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
            this.TS_Back_To_Main.Size = new System.Drawing.Size(64, 37);
            this.TS_Back_To_Main.Text = "اغلاق";
            this.TS_Back_To_Main.Click += new System.EventHandler(this.TS_Back_To_Main_Click);
            // 
            // DGV_OperationType
            // 
            this.DGV_OperationType.AllowUserToAddRows = false;
            this.DGV_OperationType.AllowUserToDeleteRows = false;
            this.DGV_OperationType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_OperationType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OperationTypeID,
            this.OperationType});
            this.DGV_OperationType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_OperationType.Location = new System.Drawing.Point(3, 284);
            this.DGV_OperationType.Name = "DGV_OperationType";
            this.DGV_OperationType.ReadOnly = true;
            this.DGV_OperationType.Size = new System.Drawing.Size(649, 140);
            this.DGV_OperationType.TabIndex = 1;
            this.DGV_OperationType.Click += new System.EventHandler(this.DGV_OperationType_Click);
            // 
            // OperationTypeID
            // 
            this.OperationTypeID.DataPropertyName = "OperationTypeID";
            this.OperationTypeID.HeaderText = "رقم العملية";
            this.OperationTypeID.Name = "OperationTypeID";
            this.OperationTypeID.ReadOnly = true;
            // 
            // OperationType
            // 
            this.OperationType.DataPropertyName = "OperationType";
            this.OperationType.HeaderText = "اسم العمليه";
            this.OperationType.Name = "OperationType";
            this.OperationType.ReadOnly = true;
            this.OperationType.Width = 200;
            // 
            // GB_Operation_INfo
            // 
            this.GB_Operation_INfo.Controls.Add(this.pictureBox1);
            this.GB_Operation_INfo.Controls.Add(this.txt_OperationType);
            this.GB_Operation_INfo.Controls.Add(this.txt_OperationTypeID);
            this.GB_Operation_INfo.Controls.Add(this.lbl_OperationType);
            this.GB_Operation_INfo.Controls.Add(this.lbl_OperationTypeID);
            this.GB_Operation_INfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Operation_INfo.Location = new System.Drawing.Point(3, 46);
            this.GB_Operation_INfo.Name = "GB_Operation_INfo";
            this.GB_Operation_INfo.Size = new System.Drawing.Size(649, 108);
            this.GB_Operation_INfo.TabIndex = 2;
            this.GB_Operation_INfo.TabStop = false;
            this.GB_Operation_INfo.Text = "بيانات العمليات";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::clinic.Properties.Resources.ambulance_128;
            this.pictureBox1.Location = new System.Drawing.Point(537, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txt_OperationType
            // 
            this.txt_OperationType.Location = new System.Drawing.Point(223, 67);
            this.txt_OperationType.Name = "txt_OperationType";
            this.txt_OperationType.Size = new System.Drawing.Size(136, 20);
            this.txt_OperationType.TabIndex = 7;
            // 
            // txt_OperationTypeID
            // 
            this.txt_OperationTypeID.Location = new System.Drawing.Point(222, 41);
            this.txt_OperationTypeID.Name = "txt_OperationTypeID";
            this.txt_OperationTypeID.ReadOnly = true;
            this.txt_OperationTypeID.Size = new System.Drawing.Size(136, 20);
            this.txt_OperationTypeID.TabIndex = 6;
            // 
            // lbl_OperationType
            // 
            this.lbl_OperationType.AutoSize = true;
            this.lbl_OperationType.Location = new System.Drawing.Point(377, 74);
            this.lbl_OperationType.Name = "lbl_OperationType";
            this.lbl_OperationType.Size = new System.Drawing.Size(69, 13);
            this.lbl_OperationType.TabIndex = 5;
            this.lbl_OperationType.Text = "اسم العملية:";
            // 
            // lbl_OperationTypeID
            // 
            this.lbl_OperationTypeID.AutoSize = true;
            this.lbl_OperationTypeID.Location = new System.Drawing.Point(377, 41);
            this.lbl_OperationTypeID.Name = "lbl_OperationTypeID";
            this.lbl_OperationTypeID.Size = new System.Drawing.Size(64, 13);
            this.lbl_OperationTypeID.TabIndex = 4;
            this.lbl_OperationTypeID.Text = "رقم العملية:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.61325F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.386749F));
            this.tableLayoutPanel2.Controls.Add(this.GB_Search, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 160);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(649, 118);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // GB_Search
            // 
            this.GB_Search.Controls.Add(this.pictureBox2);
            this.GB_Search.Controls.Add(this.lbl_TEXT);
            this.GB_Search.Controls.Add(this.txt_Search);
            this.GB_Search.Controls.Add(this.btn_Search);
            this.GB_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Search.Location = new System.Drawing.Point(13, 3);
            this.GB_Search.Name = "GB_Search";
            this.GB_Search.Size = new System.Drawing.Size(633, 112);
            this.GB_Search.TabIndex = 0;
            this.GB_Search.TabStop = false;
            this.GB_Search.Text = "بحث";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::clinic.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(530, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_TEXT
            // 
            this.lbl_TEXT.AutoSize = true;
            this.lbl_TEXT.Location = new System.Drawing.Point(353, 46);
            this.lbl_TEXT.Name = "lbl_TEXT";
            this.lbl_TEXT.Size = new System.Drawing.Size(69, 13);
            this.lbl_TEXT.TabIndex = 3;
            this.lbl_TEXT.Text = "اسم العملية:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(210, 44);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(136, 20);
            this.txt_Search.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(245, 68);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 25);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // FrmOperationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 465);
            this.MinimumSize = new System.Drawing.Size(671, 465);
            this.Name = "FrmOperationType";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التحكم بجدول العمليات";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmOperationType_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TS_Operation.ResumeLayout(false);
            this.TS_Operation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OperationType)).EndInit();
            this.GB_Operation_INfo.ResumeLayout(false);
            this.GB_Operation_INfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.GB_Search.ResumeLayout(false);
            this.GB_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip TS_Operation;
        private System.Windows.Forms.DataGridView DGV_OperationType;
        private System.Windows.Forms.GroupBox GB_Operation_INfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox GB_Search;
        private System.Windows.Forms.Label lbl_TEXT;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_OperationType;
        private System.Windows.Forms.TextBox txt_OperationTypeID;
        private System.Windows.Forms.Label lbl_OperationType;
        private System.Windows.Forms.Label lbl_OperationTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationType;
        private System.Windows.Forms.ToolStripButton TS_Add_OperationType;
        private System.Windows.Forms.ToolStripButton TS_UpData_OperationTpye;
        private System.Windows.Forms.ToolStripButton TS_Delete_OperationType;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TS_Back_To_Main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripSplitButton TSS_Reoprt;
        private System.Windows.Forms.ToolStripMenuItem TSS_Report_All;
        private System.Windows.Forms.ToolStripMenuItem TSS_Report_FlowChar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TS_ImportExcel;
    }
}