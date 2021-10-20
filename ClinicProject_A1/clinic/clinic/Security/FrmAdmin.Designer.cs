namespace clinic.Security
{
    partial class FrmAdmin
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
            this.TS_User = new System.Windows.Forms.ToolStrip();
            this.TS_Add = new System.Windows.Forms.ToolStripButton();
            this.TS_Updata = new System.Windows.Forms.ToolStripButton();
            this.TS_Del = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Permission = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Ts_Empty = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TS_Back = new System.Windows.Forms.ToolStripButton();
            this.TL_User = new System.Windows.Forms.TableLayoutPanel();
            this.GB_User_Info = new System.Windows.Forms.GroupBox();
            this.txt_ImagePath = new System.Windows.Forms.TextBox();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.Ch_ISAdmin = new System.Windows.Forms.CheckBox();
            this.Cmb_Sex = new System.Windows.Forms.ComboBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Mobile = new System.Windows.Forms.TextBox();
            this.txt_TElHome = new System.Windows.Forms.TextBox();
            this.txt_confirmation = new System.Windows.Forms.TextBox();
            this.txt_PassWord1 = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Sex = new System.Windows.Forms.Label();
            this.GB_Info_Employess = new System.Windows.Forms.GroupBox();
            this.PIC_Employess = new System.Windows.Forms.PictureBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.TelMobile = new System.Windows.Forms.Label();
            this.lbl_TelHome = new System.Windows.Forms.Label();
            this.lbl_confirmation = new System.Windows.Forms.Label();
            this.lbl_PassWord1 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_NameUser = new System.Windows.Forms.Label();
            this.DGV_User = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelMobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TS_User.SuspendLayout();
            this.TL_User.SuspendLayout();
            this.GB_User_Info.SuspendLayout();
            this.GB_Info_Employess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Employess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_User)).BeginInit();
            this.SuspendLayout();
            // 
            // TS_User
            // 
            this.TS_User.AutoSize = false;
            this.TS_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_User.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_User.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Add,
            this.TS_Updata,
            this.TS_Del,
            this.toolStripSeparator2,
            this.TS_Permission,
            this.toolStripSeparator3,
            this.Ts_Empty,
            this.toolStripSeparator1,
            this.TS_Back});
            this.TS_User.Location = new System.Drawing.Point(0, 0);
            this.TS_User.Name = "TS_User";
            this.TS_User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TS_User.Size = new System.Drawing.Size(570, 40);
            this.TS_User.TabIndex = 0;
            // 
            // TS_Add
            // 
            this.TS_Add.Image = global::clinic.Properties.Resources.add;
            this.TS_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Add.Name = "TS_Add";
            this.TS_Add.Size = new System.Drawing.Size(66, 37);
            this.TS_Add.Text = "اضافة";
            this.TS_Add.Click += new System.EventHandler(this.TS_Add_Click);
            // 
            // TS_Updata
            // 
            this.TS_Updata.Image = global::clinic.Properties.Resources.accept;
            this.TS_Updata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Updata.Name = "TS_Updata";
            this.TS_Updata.Size = new System.Drawing.Size(60, 37);
            this.TS_Updata.Text = "تعديل";
            this.TS_Updata.Click += new System.EventHandler(this.TS_Updata_Click);
            // 
            // TS_Del
            // 
            this.TS_Del.Image = global::clinic.Properties.Resources.remove;
            this.TS_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Del.Name = "TS_Del";
            this.TS_Del.Size = new System.Drawing.Size(59, 37);
            this.TS_Del.Text = "حذف";
            this.TS_Del.Click += new System.EventHandler(this.TS_Del_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // TS_Permission
            // 
            this.TS_Permission.Image = global::clinic.Properties.Resources.Locker;
            this.TS_Permission.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Permission.Name = "TS_Permission";
            this.TS_Permission.Size = new System.Drawing.Size(115, 37);
            this.TS_Permission.Text = "تحديد السماحيات";
            this.TS_Permission.Click += new System.EventHandler(this.TS_Permission_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // Ts_Empty
            // 
            this.Ts_Empty.Image = global::clinic.Properties.Resources.Empty_Recycle_Bin;
            this.Ts_Empty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ts_Empty.Name = "Ts_Empty";
            this.Ts_Empty.Size = new System.Drawing.Size(100, 37);
            this.Ts_Empty.Text = "تفريغ الحقول";
            this.Ts_Empty.Click += new System.EventHandler(this.Ts_Empty_Click);
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
            this.TS_Back.Size = new System.Drawing.Size(64, 37);
            this.TS_Back.Text = "اغلاق";
            this.TS_Back.Click += new System.EventHandler(this.TS_Back_Click);
            // 
            // TL_User
            // 
            this.TL_User.ColumnCount = 1;
            this.TL_User.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TL_User.Controls.Add(this.GB_User_Info, 0, 0);
            this.TL_User.Controls.Add(this.DGV_User, 0, 1);
            this.TL_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TL_User.Location = new System.Drawing.Point(0, 40);
            this.TL_User.Name = "TL_User";
            this.TL_User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TL_User.RowCount = 2;
            this.TL_User.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.3212F));
            this.TL_User.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.6788F));
            this.TL_User.Size = new System.Drawing.Size(570, 465);
            this.TL_User.TabIndex = 1;
            // 
            // GB_User_Info
            // 
            this.GB_User_Info.Controls.Add(this.txt_ImagePath);
            this.GB_User_Info.Controls.Add(this.txt_UserID);
            this.GB_User_Info.Controls.Add(this.Ch_ISAdmin);
            this.GB_User_Info.Controls.Add(this.Cmb_Sex);
            this.GB_User_Info.Controls.Add(this.txt_Address);
            this.GB_User_Info.Controls.Add(this.txt_Mobile);
            this.GB_User_Info.Controls.Add(this.txt_TElHome);
            this.GB_User_Info.Controls.Add(this.txt_confirmation);
            this.GB_User_Info.Controls.Add(this.txt_PassWord1);
            this.GB_User_Info.Controls.Add(this.txt_UserName);
            this.GB_User_Info.Controls.Add(this.txt_Name);
            this.GB_User_Info.Controls.Add(this.lbl_Sex);
            this.GB_User_Info.Controls.Add(this.GB_Info_Employess);
            this.GB_User_Info.Controls.Add(this.lbl_Address);
            this.GB_User_Info.Controls.Add(this.TelMobile);
            this.GB_User_Info.Controls.Add(this.lbl_TelHome);
            this.GB_User_Info.Controls.Add(this.lbl_confirmation);
            this.GB_User_Info.Controls.Add(this.lbl_PassWord1);
            this.GB_User_Info.Controls.Add(this.lbl_Name);
            this.GB_User_Info.Controls.Add(this.lbl_NameUser);
            this.GB_User_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_User_Info.Location = new System.Drawing.Point(3, 3);
            this.GB_User_Info.Name = "GB_User_Info";
            this.GB_User_Info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_User_Info.Size = new System.Drawing.Size(564, 227);
            this.GB_User_Info.TabIndex = 0;
            this.GB_User_Info.TabStop = false;
            this.GB_User_Info.Text = "بيانات المستخدم:";
            // 
            // txt_ImagePath
            // 
            this.txt_ImagePath.Location = new System.Drawing.Point(201, 179);
            this.txt_ImagePath.Name = "txt_ImagePath";
            this.txt_ImagePath.Size = new System.Drawing.Size(100, 20);
            this.txt_ImagePath.TabIndex = 19;
            this.txt_ImagePath.Visible = false;
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(201, 74);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.ReadOnly = true;
            this.txt_UserID.Size = new System.Drawing.Size(37, 20);
            this.txt_UserID.TabIndex = 18;
            this.txt_UserID.Visible = false;
            // 
            // Ch_ISAdmin
            // 
            this.Ch_ISAdmin.AutoSize = true;
            this.Ch_ISAdmin.Location = new System.Drawing.Point(232, 29);
            this.Ch_ISAdmin.Name = "Ch_ISAdmin";
            this.Ch_ISAdmin.Size = new System.Drawing.Size(65, 17);
            this.Ch_ISAdmin.TabIndex = 17;
            this.Ch_ISAdmin.Text = "ISAdmin";
            this.Ch_ISAdmin.UseVisualStyleBackColor = true;
            // 
            // Cmb_Sex
            // 
            this.Cmb_Sex.FormattingEnabled = true;
            this.Cmb_Sex.Location = new System.Drawing.Point(314, 52);
            this.Cmb_Sex.Name = "Cmb_Sex";
            this.Cmb_Sex.Size = new System.Drawing.Size(152, 21);
            this.Cmb_Sex.TabIndex = 16;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(314, 199);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(152, 20);
            this.txt_Address.TabIndex = 15;
            // 
            // txt_Mobile
            // 
            this.txt_Mobile.Location = new System.Drawing.Point(314, 175);
            this.txt_Mobile.Name = "txt_Mobile";
            this.txt_Mobile.Size = new System.Drawing.Size(152, 20);
            this.txt_Mobile.TabIndex = 14;
            // 
            // txt_TElHome
            // 
            this.txt_TElHome.Location = new System.Drawing.Point(314, 151);
            this.txt_TElHome.Name = "txt_TElHome";
            this.txt_TElHome.Size = new System.Drawing.Size(152, 20);
            this.txt_TElHome.TabIndex = 13;
            // 
            // txt_confirmation
            // 
            this.txt_confirmation.Location = new System.Drawing.Point(314, 126);
            this.txt_confirmation.Name = "txt_confirmation";
            this.txt_confirmation.Size = new System.Drawing.Size(152, 20);
            this.txt_confirmation.TabIndex = 12;
            this.txt_confirmation.UseSystemPasswordChar = true;
            // 
            // txt_PassWord1
            // 
            this.txt_PassWord1.Location = new System.Drawing.Point(314, 102);
            this.txt_PassWord1.Name = "txt_PassWord1";
            this.txt_PassWord1.Size = new System.Drawing.Size(152, 20);
            this.txt_PassWord1.TabIndex = 11;
            this.txt_PassWord1.UseSystemPasswordChar = true;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(314, 78);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(152, 20);
            this.txt_UserName.TabIndex = 10;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(314, 26);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(152, 20);
            this.txt_Name.TabIndex = 9;
            // 
            // lbl_Sex
            // 
            this.lbl_Sex.AutoSize = true;
            this.lbl_Sex.Location = new System.Drawing.Point(472, 57);
            this.lbl_Sex.Name = "lbl_Sex";
            this.lbl_Sex.Size = new System.Drawing.Size(42, 13);
            this.lbl_Sex.TabIndex = 8;
            this.lbl_Sex.Text = "الجنس:";
            // 
            // GB_Info_Employess
            // 
            this.GB_Info_Employess.Controls.Add(this.PIC_Employess);
            this.GB_Info_Employess.Dock = System.Windows.Forms.DockStyle.Left;
            this.GB_Info_Employess.Location = new System.Drawing.Point(3, 16);
            this.GB_Info_Employess.Name = "GB_Info_Employess";
            this.GB_Info_Employess.Size = new System.Drawing.Size(166, 208);
            this.GB_Info_Employess.TabIndex = 7;
            this.GB_Info_Employess.TabStop = false;
            this.GB_Info_Employess.Text = "الصوره الشخصية:";
            // 
            // PIC_Employess
            // 
            this.PIC_Employess.Location = new System.Drawing.Point(11, 41);
            this.PIC_Employess.Name = "PIC_Employess";
            this.PIC_Employess.Size = new System.Drawing.Size(140, 138);
            this.PIC_Employess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_Employess.TabIndex = 16;
            this.PIC_Employess.TabStop = false;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(470, 202);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(42, 13);
            this.lbl_Address.TabIndex = 6;
            this.lbl_Address.Text = "العنوان:";
            // 
            // TelMobile
            // 
            this.TelMobile.AutoSize = true;
            this.TelMobile.Location = new System.Drawing.Point(472, 179);
            this.TelMobile.Name = "TelMobile";
            this.TelMobile.Size = new System.Drawing.Size(39, 13);
            this.TelMobile.TabIndex = 5;
            this.TelMobile.Text = "موبايل:";
            // 
            // lbl_TelHome
            // 
            this.lbl_TelHome.AutoSize = true;
            this.lbl_TelHome.Location = new System.Drawing.Point(472, 154);
            this.lbl_TelHome.Name = "lbl_TelHome";
            this.lbl_TelHome.Size = new System.Drawing.Size(67, 13);
            this.lbl_TelHome.TabIndex = 4;
            this.lbl_TelHome.Text = "هاتف المنزل:";
            // 
            // lbl_confirmation
            // 
            this.lbl_confirmation.AutoSize = true;
            this.lbl_confirmation.Location = new System.Drawing.Point(472, 129);
            this.lbl_confirmation.Name = "lbl_confirmation";
            this.lbl_confirmation.Size = new System.Drawing.Size(87, 13);
            this.lbl_confirmation.TabIndex = 3;
            this.lbl_confirmation.Text = "تاكيد كلمة المرور:";
            // 
            // lbl_PassWord1
            // 
            this.lbl_PassWord1.AutoSize = true;
            this.lbl_PassWord1.Location = new System.Drawing.Point(472, 106);
            this.lbl_PassWord1.Name = "lbl_PassWord1";
            this.lbl_PassWord1.Size = new System.Drawing.Size(63, 13);
            this.lbl_PassWord1.TabIndex = 2;
            this.lbl_PassWord1.Text = "كلمة المرور:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(472, 29);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(72, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "الاسم الكامل:";
            // 
            // lbl_NameUser
            // 
            this.lbl_NameUser.AutoSize = true;
            this.lbl_NameUser.Location = new System.Drawing.Point(472, 81);
            this.lbl_NameUser.Name = "lbl_NameUser";
            this.lbl_NameUser.Size = new System.Drawing.Size(67, 13);
            this.lbl_NameUser.TabIndex = 0;
            this.lbl_NameUser.Text = "اسم الدخول:";
            // 
            // DGV_User
            // 
            this.DGV_User.AllowUserToAddRows = false;
            this.DGV_User.AllowUserToDeleteRows = false;
            this.DGV_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_User.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.FullName,
            this.SexID,
            this.Sex,
            this.UserName,
            this.PassWord,
            this.TelHome,
            this.TelMobil,
            this.Address,
            this.IsAdmin,
            this.ImagePath});
            this.DGV_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_User.Location = new System.Drawing.Point(3, 236);
            this.DGV_User.Name = "DGV_User";
            this.DGV_User.ReadOnly = true;
            this.DGV_User.Size = new System.Drawing.Size(564, 226);
            this.DGV_User.TabIndex = 1;
            this.DGV_User.DoubleClick += new System.EventHandler(this.DGV_User_DoubleClick);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "رقم المستخدم";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "الاسم الكامل";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 110;
            // 
            // SexID
            // 
            this.SexID.DataPropertyName = "SexID";
            this.SexID.HeaderText = "SexID";
            this.SexID.Name = "SexID";
            this.SexID.ReadOnly = true;
            this.SexID.Visible = false;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "الجنس";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Visible = false;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "اسم الدخول";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // PassWord
            // 
            this.PassWord.DataPropertyName = "PassWord";
            this.PassWord.HeaderText = "كلمة المرور";
            this.PassWord.Name = "PassWord";
            this.PassWord.ReadOnly = true;
            this.PassWord.Visible = false;
            // 
            // TelHome
            // 
            this.TelHome.DataPropertyName = "TelHome";
            this.TelHome.HeaderText = "هاتف المنزل";
            this.TelHome.Name = "TelHome";
            this.TelHome.ReadOnly = true;
            // 
            // TelMobil
            // 
            this.TelMobil.DataPropertyName = "TelMobil";
            this.TelMobil.HeaderText = "الموبايل";
            this.TelMobil.Name = "TelMobil";
            this.TelMobil.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "العنوان";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Visible = false;
            // 
            // IsAdmin
            // 
            this.IsAdmin.DataPropertyName = "IsAdmin";
            this.IsAdmin.HeaderText = "IsAdmin";
            this.IsAdmin.Name = "IsAdmin";
            this.IsAdmin.ReadOnly = true;
            this.IsAdmin.Width = 75;
            // 
            // ImagePath
            // 
            this.ImagePath.DataPropertyName = "ImagePath";
            this.ImagePath.HeaderText = "مسار الصوره";
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.ReadOnly = true;
            this.ImagePath.Visible = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 505);
            this.Controls.Add(this.TL_User);
            this.Controls.Add(this.TS_User);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(586, 543);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(586, 543);
            this.Name = "FrmAdmin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة تحكم المدير";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.TS_User.ResumeLayout(false);
            this.TS_User.PerformLayout();
            this.TL_User.ResumeLayout(false);
            this.GB_User_Info.ResumeLayout(false);
            this.GB_User_Info.PerformLayout();
            this.GB_Info_Employess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Employess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS_User;
        private System.Windows.Forms.TableLayoutPanel TL_User;
        private System.Windows.Forms.GroupBox GB_User_Info;
        private System.Windows.Forms.Label lbl_PassWord1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_NameUser;
        private System.Windows.Forms.GroupBox GB_Info_Employess;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label TelMobile;
        private System.Windows.Forms.Label lbl_TelHome;
        private System.Windows.Forms.Label lbl_confirmation;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Mobile;
        private System.Windows.Forms.TextBox txt_TElHome;
        private System.Windows.Forms.TextBox txt_confirmation;
        private System.Windows.Forms.TextBox txt_PassWord1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Sex;
        private System.Windows.Forms.ComboBox Cmb_Sex;
        private System.Windows.Forms.PictureBox PIC_Employess;
        private System.Windows.Forms.ToolStripButton TS_Add;
        private System.Windows.Forms.ToolStripButton TS_Updata;
        private System.Windows.Forms.ToolStripButton TS_Del;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TS_Back;
        private System.Windows.Forms.DataGridView DGV_User;
        private System.Windows.Forms.CheckBox Ch_ISAdmin;
        private System.Windows.Forms.ToolStripButton TS_Permission;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Ts_Empty;
        private System.Windows.Forms.TextBox txt_ImagePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelMobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagePath;
    }
}