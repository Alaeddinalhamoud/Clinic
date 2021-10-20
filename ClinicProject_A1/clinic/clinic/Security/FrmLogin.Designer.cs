namespace clinic.Security
{
    partial class FrmLogin
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
                components.Dispose ();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.GB_Info_Login = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_PassWord = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.GB_Info_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_Info_Login
            // 
            this.GB_Info_Login.Controls.Add(this.pictureBox1);
            this.GB_Info_Login.Controls.Add(this.btn_Cancel);
            this.GB_Info_Login.Controls.Add(this.btn_Login);
            this.GB_Info_Login.Controls.Add(this.txt_PassWord);
            this.GB_Info_Login.Controls.Add(this.txt_UserName);
            this.GB_Info_Login.Controls.Add(this.lbl_PassWord);
            this.GB_Info_Login.Controls.Add(this.lbl_UserName);
            this.GB_Info_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Info_Login.Location = new System.Drawing.Point(0, 0);
            this.GB_Info_Login.Name = "GB_Info_Login";
            this.GB_Info_Login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GB_Info_Login.Size = new System.Drawing.Size(372, 153);
            this.GB_Info_Login.TabIndex = 0;
            this.GB_Info_Login.TabStop = false;
            this.GB_Info_Login.Text = "بيانات الدخول:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::clinic.Properties.Resources.Keys;
            this.pictureBox1.Location = new System.Drawing.Point(262, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(12, 106);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(87, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "الغاء الامر";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(105, 106);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(87, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "دخول";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Location = new System.Drawing.Point(13, 65);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(177, 20);
            this.txt_PassWord.TabIndex = 3;
            this.txt_PassWord.Text = "1";
            this.txt_PassWord.UseSystemPasswordChar = true;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(13, 32);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(177, 20);
            this.txt_UserName.TabIndex = 2;
            this.txt_UserName.Text = "Admin";
            // 
            // lbl_PassWord
            // 
            this.lbl_PassWord.AutoSize = true;
            this.lbl_PassWord.Location = new System.Drawing.Point(196, 67);
            this.lbl_PassWord.Name = "lbl_PassWord";
            this.lbl_PassWord.Size = new System.Drawing.Size(63, 13);
            this.lbl_PassWord.TabIndex = 1;
            this.lbl_PassWord.Text = "كلمة المرور:";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(196, 36);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(67, 13);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "اسم الدخول:";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 153);
            this.ControlBox = false;
            this.Controls.Add(this.GB_Info_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(388, 189);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(388, 189);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.GB_Info_Login.ResumeLayout(false);
            this.GB_Info_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Info_Login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_PassWord;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}