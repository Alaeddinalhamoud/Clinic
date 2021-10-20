namespace clinic.ClinicData
{
    partial class FrmClinicData
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
            this.GB_Dr_Info = new System.Windows.Forms.GroupBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GB_Image = new System.Windows.Forms.GroupBox();
            this.PIC_Logo = new System.Windows.Forms.PictureBox();
            this.txt_WebSite = new System.Windows.Forms.TextBox();
            this.lbl_Website = new System.Windows.Forms.Label();
            this.lbl_Moblie = new System.Windows.Forms.Label();
            this.txt_Mobile = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_DrID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_Image = new System.Windows.Forms.TextBox();
            this.txt_Fax = new System.Windows.Forms.TextBox();
            this.lbl_Fax = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Speciaty = new System.Windows.Forms.TextBox();
            this.lbl_Speciaty = new System.Windows.Forms.Label();
            this.txt_DrName = new System.Windows.Forms.TextBox();
            this.lbl_DrNmae = new System.Windows.Forms.Label();
            this.TS_Dr = new System.Windows.Forms.ToolStrip();
            this.TS_Add = new System.Windows.Forms.ToolStripButton();
            this.TS_UpData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_BAck = new System.Windows.Forms.ToolStripButton();
            this.GB_Dr_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GB_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Logo)).BeginInit();
            this.TS_Dr.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Dr_Info
            // 
            this.GB_Dr_Info.Controls.Add(this.lbl_Email);
            this.GB_Dr_Info.Controls.Add(this.pictureBox1);
            this.GB_Dr_Info.Controls.Add(this.GB_Image);
            this.GB_Dr_Info.Controls.Add(this.txt_WebSite);
            this.GB_Dr_Info.Controls.Add(this.lbl_Website);
            this.GB_Dr_Info.Controls.Add(this.lbl_Moblie);
            this.GB_Dr_Info.Controls.Add(this.txt_Mobile);
            this.GB_Dr_Info.Controls.Add(this.txt_Email);
            this.GB_Dr_Info.Controls.Add(this.txt_DrID);
            this.GB_Dr_Info.Controls.Add(this.label2);
            this.GB_Dr_Info.Controls.Add(this.lbl_City);
            this.GB_Dr_Info.Controls.Add(this.txt_Address);
            this.GB_Dr_Info.Controls.Add(this.txt_City);
            this.GB_Dr_Info.Controls.Add(this.txt_Image);
            this.GB_Dr_Info.Controls.Add(this.txt_Fax);
            this.GB_Dr_Info.Controls.Add(this.lbl_Fax);
            this.GB_Dr_Info.Controls.Add(this.txt_Phone);
            this.GB_Dr_Info.Controls.Add(this.lbl_Phone);
            this.GB_Dr_Info.Controls.Add(this.txt_Speciaty);
            this.GB_Dr_Info.Controls.Add(this.lbl_Speciaty);
            this.GB_Dr_Info.Controls.Add(this.txt_DrName);
            this.GB_Dr_Info.Controls.Add(this.lbl_DrNmae);
            this.GB_Dr_Info.Location = new System.Drawing.Point(0, 37);
            this.GB_Dr_Info.Name = "GB_Dr_Info";
            this.GB_Dr_Info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_Dr_Info.Size = new System.Drawing.Size(562, 266);
            this.GB_Dr_Info.TabIndex = 0;
            this.GB_Dr_Info.TabStop = false;
            this.GB_Dr_Info.Text = "بيانات الطبيب:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(365, 157);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(85, 13);
            this.lbl_Email.TabIndex = 9;
            this.lbl_Email.Text = "البريد الالكتروني:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::clinic.Properties.Resources.doctor_256;
            this.pictureBox1.Location = new System.Drawing.Point(435, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // GB_Image
            // 
            this.GB_Image.Controls.Add(this.PIC_Logo);
            this.GB_Image.Location = new System.Drawing.Point(12, 19);
            this.GB_Image.Name = "GB_Image";
            this.GB_Image.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_Image.Size = new System.Drawing.Size(150, 182);
            this.GB_Image.TabIndex = 2;
            this.GB_Image.TabStop = false;
            this.GB_Image.Text = "شعار الطبيب";
            // 
            // PIC_Logo
            // 
            this.PIC_Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PIC_Logo.Location = new System.Drawing.Point(9, 20);
            this.PIC_Logo.Name = "PIC_Logo";
            this.PIC_Logo.Size = new System.Drawing.Size(135, 156);
            this.PIC_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_Logo.TabIndex = 16;
            this.PIC_Logo.TabStop = false;
            // 
            // txt_WebSite
            // 
            this.txt_WebSite.Location = new System.Drawing.Point(177, 179);
            this.txt_WebSite.Name = "txt_WebSite";
            this.txt_WebSite.Size = new System.Drawing.Size(182, 20);
            this.txt_WebSite.TabIndex = 20;
            // 
            // lbl_Website
            // 
            this.lbl_Website.AutoSize = true;
            this.lbl_Website.Location = new System.Drawing.Point(367, 182);
            this.lbl_Website.Name = "lbl_Website";
            this.lbl_Website.Size = new System.Drawing.Size(90, 13);
            this.lbl_Website.TabIndex = 19;
            this.lbl_Website.Text = "الموقع الالكتروني:";
            // 
            // lbl_Moblie
            // 
            this.lbl_Moblie.AutoSize = true;
            this.lbl_Moblie.Location = new System.Drawing.Point(366, 109);
            this.lbl_Moblie.Name = "lbl_Moblie";
            this.lbl_Moblie.Size = new System.Drawing.Size(66, 13);
            this.lbl_Moblie.TabIndex = 18;
            this.lbl_Moblie.Text = "رقم الموبايل:";
            // 
            // txt_Mobile
            // 
            this.txt_Mobile.Location = new System.Drawing.Point(177, 102);
            this.txt_Mobile.Name = "txt_Mobile";
            this.txt_Mobile.Size = new System.Drawing.Size(182, 20);
            this.txt_Mobile.TabIndex = 17;
            this.txt_Mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Fax_KeyPress);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(177, 154);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(182, 20);
            this.txt_Email.TabIndex = 16;
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // txt_DrID
            // 
            this.txt_DrID.Location = new System.Drawing.Point(492, 208);
            this.txt_DrID.Name = "txt_DrID";
            this.txt_DrID.ReadOnly = true;
            this.txt_DrID.Size = new System.Drawing.Size(32, 20);
            this.txt_DrID.TabIndex = 15;
            this.txt_DrID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "العنوان:";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(364, 211);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(43, 13);
            this.lbl_City.TabIndex = 13;
            this.lbl_City.Text = "المدينة:";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(177, 230);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(182, 20);
            this.txt_Address.TabIndex = 12;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(177, 204);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(182, 20);
            this.txt_City.TabIndex = 11;
            // 
            // txt_Image
            // 
            this.txt_Image.Location = new System.Drawing.Point(459, 211);
            this.txt_Image.Name = "txt_Image";
            this.txt_Image.ReadOnly = true;
            this.txt_Image.Size = new System.Drawing.Size(10, 20);
            this.txt_Image.TabIndex = 10;
            this.txt_Image.Visible = false;
            // 
            // txt_Fax
            // 
            this.txt_Fax.Location = new System.Drawing.Point(176, 127);
            this.txt_Fax.Name = "txt_Fax";
            this.txt_Fax.Size = new System.Drawing.Size(182, 20);
            this.txt_Fax.TabIndex = 7;
            this.txt_Fax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Fax_KeyPress);
            // 
            // lbl_Fax
            // 
            this.lbl_Fax.AutoSize = true;
            this.lbl_Fax.Location = new System.Drawing.Point(365, 134);
            this.lbl_Fax.Name = "lbl_Fax";
            this.lbl_Fax.Size = new System.Drawing.Size(38, 13);
            this.lbl_Fax.TabIndex = 6;
            this.lbl_Fax.Text = "فاكس:";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(177, 78);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(182, 20);
            this.txt_Phone.TabIndex = 5;
            this.txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Fax_KeyPress);
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(365, 85);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(39, 13);
            this.lbl_Phone.TabIndex = 4;
            this.lbl_Phone.Text = "الهاتف:";
            // 
            // txt_Speciaty
            // 
            this.txt_Speciaty.Location = new System.Drawing.Point(177, 50);
            this.txt_Speciaty.Name = "txt_Speciaty";
            this.txt_Speciaty.Size = new System.Drawing.Size(182, 20);
            this.txt_Speciaty.TabIndex = 3;
            // 
            // lbl_Speciaty
            // 
            this.lbl_Speciaty.AutoSize = true;
            this.lbl_Speciaty.Location = new System.Drawing.Point(365, 52);
            this.lbl_Speciaty.Name = "lbl_Speciaty";
            this.lbl_Speciaty.Size = new System.Drawing.Size(57, 13);
            this.lbl_Speciaty.TabIndex = 2;
            this.lbl_Speciaty.Text = "الاختصاص:";
            // 
            // txt_DrName
            // 
            this.txt_DrName.Location = new System.Drawing.Point(177, 19);
            this.txt_DrName.Name = "txt_DrName";
            this.txt_DrName.Size = new System.Drawing.Size(182, 20);
            this.txt_DrName.TabIndex = 1;
            // 
            // lbl_DrNmae
            // 
            this.lbl_DrNmae.AutoSize = true;
            this.lbl_DrNmae.Location = new System.Drawing.Point(365, 22);
            this.lbl_DrNmae.Name = "lbl_DrNmae";
            this.lbl_DrNmae.Size = new System.Drawing.Size(64, 13);
            this.lbl_DrNmae.TabIndex = 0;
            this.lbl_DrNmae.Text = "اسم الطيب:";
            // 
            // TS_Dr
            // 
            this.TS_Dr.AutoSize = false;
            this.TS_Dr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Dr.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_Dr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add,
            this.TS_UpData,
            this.toolStripSeparator1,
            this.TS_BAck});
            this.TS_Dr.Location = new System.Drawing.Point(0, 0);
            this.TS_Dr.Name = "TS_Dr";
            this.TS_Dr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TS_Dr.Size = new System.Drawing.Size(567, 40);
            this.TS_Dr.TabIndex = 1;
            this.TS_Dr.Text = "toolStrip1";
            // 
            // TS_Add
            // 
            this.TS_Add.Image = global::clinic.Properties.Resources.add1;
            this.TS_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add.Name = "TS_Add";
            this.TS_Add.Size = new System.Drawing.Size(67, 37);
            this.TS_Add.Text = "اضافة";
            this.TS_Add.Click += new System.EventHandler(this.TS_Add_Click);
            // 
            // TS_UpData
            // 
            this.TS_UpData.Image = global::clinic.Properties.Resources.accept;
            this.TS_UpData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_UpData.Name = "TS_UpData";
            this.TS_UpData.Size = new System.Drawing.Size(61, 37);
            this.TS_UpData.Text = "تعديل";
            this.TS_UpData.Click += new System.EventHandler(this.TS_UpData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // TS_BAck
            // 
            this.TS_BAck.Image = global::clinic.Properties.Resources.computer_remove;
            this.TS_BAck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_BAck.Name = "TS_BAck";
            this.TS_BAck.Size = new System.Drawing.Size(59, 37);
            this.TS_BAck.Text = "خلف";
            this.TS_BAck.Click += new System.EventHandler(this.TS_BAck_Click);
            // 
            // FrmClinicData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 305);
            this.Controls.Add(this.TS_Dr);
            this.Controls.Add(this.GB_Dr_Info);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(583, 343);
            this.MinimumSize = new System.Drawing.Size(583, 343);
            this.Name = "FrmClinicData";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " بيانات الطبيب";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmClinicData_Load);
            this.GB_Dr_Info.ResumeLayout(false);
            this.GB_Dr_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GB_Image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Logo)).EndInit();
            this.TS_Dr.ResumeLayout(false);
            this.TS_Dr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Dr_Info;
        private System.Windows.Forms.ToolStrip TS_Dr;
        private System.Windows.Forms.ToolStripButton TS_Add;
        private System.Windows.Forms.ToolStripButton TS_UpData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TS_BAck;
        private System.Windows.Forms.GroupBox GB_Image;
        private System.Windows.Forms.TextBox txt_Speciaty;
        private System.Windows.Forms.Label lbl_Speciaty;
        private System.Windows.Forms.TextBox txt_DrName;
        private System.Windows.Forms.Label lbl_DrNmae;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Fax;
        private System.Windows.Forms.Label lbl_Fax;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_DrID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_Image;
        private System.Windows.Forms.PictureBox PIC_Logo;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_WebSite;
        private System.Windows.Forms.Label lbl_Website;
        private System.Windows.Forms.Label lbl_Moblie;
        private System.Windows.Forms.TextBox txt_Mobile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}