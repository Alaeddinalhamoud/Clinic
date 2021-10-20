namespace clinic.Invoice
{
    partial class FrmMonthInvoice
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
            this.GB_InvoiceMonth = new System.Windows.Forms.GroupBox();
            this.btn_Agree = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DPK_TODate = new System.Windows.Forms.DateTimePicker();
            this.DPK_FormDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_TO = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.GB_InvoiceMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_InvoiceMonth
            // 
            this.GB_InvoiceMonth.Controls.Add(this.btn_Agree);
            this.GB_InvoiceMonth.Controls.Add(this.pictureBox1);
            this.GB_InvoiceMonth.Controls.Add(this.DPK_TODate);
            this.GB_InvoiceMonth.Controls.Add(this.DPK_FormDate);
            this.GB_InvoiceMonth.Controls.Add(this.lbl_TO);
            this.GB_InvoiceMonth.Controls.Add(this.lbl_From);
            this.GB_InvoiceMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_InvoiceMonth.Location = new System.Drawing.Point(0, 0);
            this.GB_InvoiceMonth.Name = "GB_InvoiceMonth";
            this.GB_InvoiceMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_InvoiceMonth.Size = new System.Drawing.Size(328, 134);
            this.GB_InvoiceMonth.TabIndex = 0;
            this.GB_InvoiceMonth.TabStop = false;
            this.GB_InvoiceMonth.Text = "حدد المدة";
            // 
            // btn_Agree
            // 
            this.btn_Agree.Location = new System.Drawing.Point(32, 99);
            this.btn_Agree.Name = "btn_Agree";
            this.btn_Agree.Size = new System.Drawing.Size(75, 23);
            this.btn_Agree.TabIndex = 5;
            this.btn_Agree.Text = "موافق";
            this.btn_Agree.UseVisualStyleBackColor = true;
            this.btn_Agree.Click += new System.EventHandler(this.btn_Agree_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::clinic.Properties.Resources.SimpleTextEdit;
            this.pictureBox1.Location = new System.Drawing.Point(214, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DPK_TODate
            // 
            this.DPK_TODate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPK_TODate.Location = new System.Drawing.Point(12, 69);
            this.DPK_TODate.Name = "DPK_TODate";
            this.DPK_TODate.Size = new System.Drawing.Size(134, 20);
            this.DPK_TODate.TabIndex = 3;
            // 
            // DPK_FormDate
            // 
            this.DPK_FormDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPK_FormDate.Location = new System.Drawing.Point(12, 37);
            this.DPK_FormDate.Name = "DPK_FormDate";
            this.DPK_FormDate.Size = new System.Drawing.Size(134, 20);
            this.DPK_FormDate.TabIndex = 2;
            // 
            // lbl_TO
            // 
            this.lbl_TO.AutoSize = true;
            this.lbl_TO.Location = new System.Drawing.Point(152, 72);
            this.lbl_TO.Name = "lbl_TO";
            this.lbl_TO.Size = new System.Drawing.Size(59, 13);
            this.lbl_TO.TabIndex = 1;
            this.lbl_TO.Text = "الى التاريخ:";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(152, 41);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(56, 13);
            this.lbl_From.TabIndex = 0;
            this.lbl_From.Text = "من التاريخ:";
            // 
            // FrmMonthInvoice
            // 
            this.AcceptButton = this.btn_Agree;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 134);
            this.Controls.Add(this.GB_InvoiceMonth);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(344, 170);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(344, 170);
            this.Name = "FrmMonthInvoice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فواتير ";
            this.TopMost = true;
            this.GB_InvoiceMonth.ResumeLayout(false);
            this.GB_InvoiceMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_InvoiceMonth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker DPK_TODate;
        private System.Windows.Forms.DateTimePicker DPK_FormDate;
        private System.Windows.Forms.Label lbl_TO;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Button btn_Agree;
    }
}