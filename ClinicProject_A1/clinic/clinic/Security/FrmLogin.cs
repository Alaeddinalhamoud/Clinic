using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using clinic.FrmAboutUS;
using clinic.Classes;

namespace clinic.Security
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
            Thread ThSplesh = new Thread(new ThreadStart(DoSplesh));

            ThSplesh.Start();
            Thread.Sleep(3000);
            ThSplesh.Abort();
            Thread.Sleep(1000);
           
           
        }
        public FrmLogin(int a)
        {

            InitializeComponent();

           

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        public void DoSplesh()
        {
            FrmSplashScreen FrmS = new FrmSplashScreen();
            FrmS.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string UserLoginName = txt_UserName.Text;
            string UserLoginPassWord = txt_PassWord.Text;
            try
            {
             //   InstantObject.ThLoading.Open_Loading();
                InstantObject._Felid_User = InstantObject._SP_User.SP_Browse_UserInfo_For_Login(UserLoginName, txt_PassWord.Text);
              //  InstantObject.ThLoading.Abort_Loading();
          

            if (InstantObject._Felid_User.UserName == UserLoginName && InstantObject._Felid_User.PassWord == txt_PassWord.Text)
            {

                InstantObject.UserID = InstantObject._Felid_User.UserID;
                InstantObject.UserName = InstantObject._Felid_User.FullName;
                    
                this.Close();
             
            }
            else
            {
                MessageBox.Show("اسم الدخول او كلمة المرور غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            }
            catch
            {
               // InstantObject.ThLoading.Abort_Loading();
                MessageBox.Show("تاكد من الاتصال مع قاعدة البيانات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

    }

}
