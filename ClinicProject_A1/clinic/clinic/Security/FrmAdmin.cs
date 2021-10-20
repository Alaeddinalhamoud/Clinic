using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clinic.Classes;
using System.IO;
using System.Configuration;

namespace clinic.Security
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        public Image i;
        public Random R = new Random();
        string Image_Path;
        OpenFileDialog openFileDialogPicture = new OpenFileDialog();
        public string Va = ConfigurationManager.AppSettings["dbPicture"];
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            TS_User.Renderer = new Renderers.WindowsVistaRenderer();
            Fill_DGV_User();
            Fill_CmboSex();
        }

        private void Fill_CmboSex()
        {
            Cmb_Sex.ValueMember = "SexID";
            Cmb_Sex.DisplayMember = "Sex";
            Cmb_Sex.DataSource = InstantObject._SP_Sex.SP_Browes_Sex();
        }

        private void Fill_DGV_User()
        {
            DGV_User.DataSource = InstantObject._SP_User.SP_Browes_User_Detalis();
        }

        private void TS_Add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("ادخل الاسم الكامل");
                return;
            }
            else if (Cmb_Sex.Text == "")
            {
                MessageBox.Show("حدد الجنسية");
                return;
            }
            else if (txt_UserName.Text == "")
            {
                MessageBox.Show("ادخل اسم الدخول");
                return;
            }
            else if (txt_PassWord1.Text == "")
            {
                MessageBox.Show("ادخل كلمة المرور");
                return;
            }
            else if (txt_confirmation.Text == "")
            {
                MessageBox.Show("ادخل تأكيد كلمة المرور");
                return;
            }
            else
            {
                if (txt_PassWord1.Text != txt_confirmation.Text)
                {
                    MessageBox.Show("لم تتطابق كلمة المرور مع تاكيد كلمة المرور");
                    return;
                }
                else
                {

                    InstantObject._Felid_User.FullName = txt_Name.Text;
                    InstantObject._Felid_User.SexID = Convert.ToInt32(Cmb_Sex.SelectedValue);
                    InstantObject._Felid_User.UserName = txt_UserName.Text;
                    InstantObject._Felid_User.PassWord = txt_PassWord1.Text;
                    InstantObject._Felid_User.TelHome = txt_TElHome.Text;
                    InstantObject._Felid_User.TelMobil = txt_Mobile.Text;
                    InstantObject._Felid_User.Address = txt_Address.Text;
                    InstantObject._Felid_User.IsAdmin = Convert.ToBoolean(Ch_ISAdmin.Checked);
                   


                    if (MessageBox.Show("هل تريد اضافة  صورةللمستخدم  ", "معلومات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        OpenFile_Dialog();
                        Image_Path = InstantObject.ImageUserFolder + "ImageUser" + R.Next() + ".jpg";
                        i = PIC_Employess.Image;
                        if (Va == "")
                        {
                            // MessageBox.Show(@"\\" + ConfigurationManager.AppSettings["dbServerName"] + @"\" + AppDomain.CurrentDomain.BaseDirectory + Image_Path).ToString();
                            i.Save(Va + AppDomain.CurrentDomain.BaseDirectory + Image_Path);

                            //SP
                        }
                        else
                        {
                            string SQ = @"\SQLEXPRESS";
                            string s = Va.Trim(SQ.ToCharArray());

                            i.Save(@"\\" + s + @"\" + Image_Path);
                        }
                        //i.Save(AppDomain.CurrentDomain.BaseDirectory + Image_Path);
                        //SP
                        try
                        {
                         //   InstantObject.ThLoading.Open_Loading();
                            InstantObject._Felid_User.ImagePath = Image_Path;
                           InstantObject._SP_User.SP_Insert_User(InstantObject._Felid_User);

                           // InstantObject.ThLoading.Abort_Loading();
                            MessageBox.Show("عملية الاضافة تمت بنجاج");
                        }
                        catch (Exception ex)
                        {
                           // InstantObject.ThLoading.Abort_Loading();
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {

                        try
                            {
                        Image_Path = InstantObject.ImageUserFolder + "delete-user.png";
                       // InstantObject.ThLoading.Open_Loading();
                        InstantObject._Felid_User.ImagePath = Image_Path;
                        InstantObject._SP_User.SP_Insert_User(InstantObject._Felid_User);
                      //  InstantObject.ThLoading.Abort_Loading();

                    
                         }
                        catch (Exception ex)
                        {
                          //  InstantObject.ThLoading.Abort_Loading();
                            MessageBox.Show(ex.Message);
                        }

                    }
                        Fill_DGV_User();
                        ClearTools();
                }
            }

        }

        private void Ts_Empty_Click(object sender, EventArgs e)
        {
            ClearTools();

        }

        private void ClearTools()
        {
            txt_UserID.Clear();
            txt_Name.Clear();
            txt_UserName.Clear();
            txt_PassWord1.Clear();
            txt_confirmation.Clear();
            txt_TElHome.Clear();
            txt_Mobile.Clear();
            txt_Address.Clear();
            Ch_ISAdmin.Checked = false;
            PIC_Employess.Image = null;
        }

        private void TS_Updata_Click(object sender, EventArgs e)
        {
            if (txt_UserID.Text == "")
            {
                MessageBox.Show("لم تقم باختيار المستخدم");
                return;
            }

            else if (txt_Name.Text == "")
            {
                MessageBox.Show("ادخل الاسم الكامل");
                return;
            }
            else if (Cmb_Sex.Text == "")
            {
                MessageBox.Show("حدد الجنسية");
                return;
            }
           
            else if (txt_PassWord1.Text == "")
            {
                MessageBox.Show("ادخل كلمة المرور");
                return;
            }
            else if (txt_confirmation.Text == "")
            {
                MessageBox.Show("ادخل تأكيد كلمة المرور");
                return;
            }
            else
            {
                if (txt_PassWord1.Text != txt_confirmation.Text)
                {
                    MessageBox.Show("لم تتطابق كلمة المرور مع تاكيد كلمة المرور");
                    return;
                }
                else
                {


                    InstantObject._Felid_User.UserID = Convert.ToInt32(txt_UserID.Text);
                    InstantObject._Felid_User.FullName = txt_Name.Text;
                    InstantObject._Felid_User.SexID = Convert.ToInt32(Cmb_Sex.SelectedValue);
                  //  InstantObject._Felid_User.UserName = txt_UserName.Text;
                    InstantObject._Felid_User.PassWord = txt_PassWord1.Text;
                    InstantObject._Felid_User.TelHome = txt_TElHome.Text;
                    InstantObject._Felid_User.TelMobil = txt_Mobile.Text;
                    InstantObject._Felid_User.Address = txt_Address.Text;
                    InstantObject._Felid_User.IsAdmin = Convert.ToBoolean(Ch_ISAdmin.Checked);


                    if (MessageBox.Show("هل تريد تعديل الصورة ", "معلومات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        OpenFile_Dialog();

                        if (txt_ImagePath.Text != InstantObject.ImageUserFolder + "delete-user.png")
                        {

                            Image_Path = InstantObject.ImageUserFolder + "ImageUser" + R.Next() + ".jpg";
                            i = PIC_Employess.Image;
                            if (Va == "")
                            {
                                // MessageBox.Show(@"\\" + ConfigurationManager.AppSettings["dbServerName"] + @"\" + AppDomain.CurrentDomain.BaseDirectory + Image_Path).ToString();
                                i.Save(Va + AppDomain.CurrentDomain.BaseDirectory + Image_Path);

                                //SP
                            }
                            else
                            {
                                string SQ = @"\SQLEXPRESS";
                                string s = Va.Trim(SQ.ToCharArray());

                                i.Save(@"\\" + s + @"\" + Image_Path);
                            }
                            //i.Save(AppDomain.CurrentDomain.BaseDirectory + Image_Path);
                            //SP
                            try
                            {
                          
                            InstantObject._Felid_User.ImagePath = Image_Path;
                           // InstantObject.ThLoading.Open_Loading();
                            InstantObject._SP_User.SP_UpDate_User(InstantObject._Felid_User);
                            InstantObject._SP_User.SP_UpDate_User_Image(InstantObject._Felid_User);
                          //  InstantObject.ThLoading.Abort_Loading();
                            MessageBox.Show("عملية التعديل تمت بنجاج");
                        }
                            catch (Exception ex)
                        {
                           // InstantObject.ThLoading.Abort_Loading();
                            MessageBox.Show(ex.Message);
                        }


                               }
                         
                    }
                   
                                 else
                               {
                                   try{
                                 //    InstantObject.ThLoading.Open_Loading();
                                     InstantObject._SP_User.SP_UpDate_User(InstantObject._Felid_User);
                                 //    InstantObject.ThLoading.Abort_Loading();
                                     MessageBox.Show("عملية التعديل تمت بنجاج");
                    }
                                   catch (Exception ex)
                                   {
                                 //  InstantObject.ThLoading.Abort_Loading();
                                   MessageBox.Show(ex.Message);
                                   }

                               }



                   




                    Fill_DGV_User();
                    ClearTools();

                }
            }

        }

        private void DGV_User_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGV_User.Rows.Count > 0)
                {
                    //Method For Fill Tools at Patient
                    int _RowIndex = DGV_User.CurrentCell.RowIndex;
                    int _CurrentRow = Convert.ToInt32(DGV_User[0, _RowIndex].Value);

                    InstantObject._Felid_User = InstantObject._SP_User.SP_Browes_User_All_Felid(_CurrentRow);

                    txt_UserID.Text = InstantObject._Felid_User.UserID.ToString();
                    txt_Name.Text = InstantObject._Felid_User.FullName;
                    txt_UserName.Text = InstantObject._Felid_User.UserName;

                    Fill_CmboSex();
                    string NameOfSex = Convert.ToString(DGV_User[3, _RowIndex].Value);
                    Cmb_Sex.Text = NameOfSex;

                    txt_UserName.Text = InstantObject._Felid_User.UserName;
                    txt_PassWord1.Text = InstantObject._Felid_User.PassWord.ToString();
                    txt_confirmation.Text = InstantObject._Felid_User.PassWord.ToString();
                    txt_TElHome.Text = InstantObject._Felid_User.TelHome;
                    txt_Mobile.Text = InstantObject._Felid_User.TelMobil;
                    txt_Address.Text = InstantObject._Felid_User.Address;
                    Ch_ISAdmin.Checked = InstantObject._Felid_User.IsAdmin;

                    txt_ImagePath.Text = InstantObject._Felid_User.ImagePath;
                    if (Va == "")
                    {
                        // MessageBox.Show(@"\\" + ConfigurationManager.AppSettings["dbServerName"] + @"\" + AppDomain.CurrentDomain.BaseDirectory + Image_Path).ToString();
                        //i.Save(Va + AppDomain.CurrentDomain.BaseDirectory + Image_Path);
                        PIC_Employess.Image = Image.FromFile(Va + AppDomain.CurrentDomain.BaseDirectory + txt_ImagePath.Text);

                        //SP
                    }
                    else
                    {
                        string SQ = @"\SQLEXPRESS";
                        string s = Va.Trim(SQ.ToCharArray());
                        PIC_Employess.Image = Image.FromFile(@"\\" + s + @"\" + txt_ImagePath.Text);
                    }

                   // PIC_Employess.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + txt_ImagePath.Text);


                }
            } catch {};
        }

        private void TS_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void OpenFile_Dialog()
        {
            String path;
            Stream myStream;


            openFileDialogPicture.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            ;
            openFileDialogPicture.FilterIndex = 2;
            openFileDialogPicture.RestoreDirectory = true;
            if (openFileDialogPicture.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialogPicture.OpenFile()) != null)
                {
                    path = openFileDialogPicture.FileName;

                    i = Image.FromFile(path);

                  

                    PIC_Employess.Image = i;
                    txt_ImagePath.Text = path;
                    

                }
            }
            else
            {
                MessageBox.Show("يجب عليك اختيار الصورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenFile_Dialog();

            }
        }

        private void TS_Del_Click(object sender, EventArgs e)
        {
            try
            {


                if (txt_UserID.Text.Trim() == "")
                {
                    MessageBox.Show("اختر المستخدم ",
                                            "تحذير",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                }
                    else if (txt_UserID.Text==InstantObject.UserID.ToString())
                {
                    MessageBox.Show("لا يمكنك حذف المستحدم الحالي","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                     //  InstantObject.ThLoading.Open_Loading();
                       InstantObject._SP_User.SP_Delete_User(Convert.ToInt32(txt_UserID.Text));

                       Fill_DGV_User();
                       ClearTools();
                      // InstantObject.ThLoading.Abort_Loading();
                    }
                }
              
            }
            catch { };
        }

        private void TS_Permission_Click(object sender, EventArgs e)
        {
            if (txt_UserID.Text == "")
            {
                MessageBox.Show("اختر المستخدم", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                FrmPermission Frm = new FrmPermission();
                Frm.GetUserID(Convert.ToInt32(txt_UserID.Text),txt_Name.Text);
                Frm.Show();
            }
        }

    }
}
