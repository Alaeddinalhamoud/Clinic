using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Lib_Felid;
using System.IO;
using clinic.Classes;
using BLL;
using System.Configuration;

namespace clinic.ClinicData
{
    public partial class FrmClinicData : Form
    {
        public FrmClinicData()
        {
            InitializeComponent();
        }

        SP_ClincData _SP_Clinic = new SP_ClincData();
        Felid_ClincData _Felid = new Felid_ClincData();

        public Image i;
        public Random R = new Random();
        string Image_Path;

        public bool IsAnEmail;
        IsEmailValidations vali;

        OpenFileDialog openFileDialogPicture = new OpenFileDialog();
         public string  Va = ConfigurationManager.AppSettings["dbPicture"];
        private void TS_Add_Click(object sender, EventArgs e)
        {

            if (txt_DrName.Text == "")
            { MessageBox.Show("ادخل اسم الدكتور", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

          else  if (txt_Speciaty.Text == "")
            { MessageBox.Show("ادخل الاختصاص", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

           else if (txt_Phone.Text == "")
            { MessageBox.Show("ادخل رقم الهاتف", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
           else if (txt_City.Text == "")
            { MessageBox.Show("ادخل اسم المدينة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
           else if (txt_Address.Text == "")
            { MessageBox.Show("ادخل العنوان", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else
            {
                _Felid.DrName = txt_DrName.Text;
                _Felid.Speciaty = txt_Speciaty.Text;
                _Felid.Phone = txt_Phone.Text;
                _Felid.Mobile = txt_Mobile.Text;
                _Felid.Fax = txt_Fax.Text;
                _Felid.Email = txt_Email.Text;
                _Felid.WebSiteAddress = txt_WebSite.Text;
                _Felid.City = txt_City.Text;
                _Felid.Address = txt_Address.Text;


                if (MessageBox.Show("هل تريد اضافة  صورة للدكتور ", "معلومات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OpenFile_Dialog();
                    Image_Path = InstantObject.Image_Logo_Folder + "Image" + R.Next() + ".jpg";
                    i = PIC_Logo.Image;
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
                    _Felid.Image = Image_Path;
                    _Felid.DrID = Convert.ToInt32(txt_DrID.Text);

               //    InstantObject.ThLoading.Open_Loading();
                    _SP_Clinic.SP_Insert_Dr_Info(_Felid);
                 //   InstantObject.ThLoading.Abort_Loading();

                }

                else
                {
                    Image_Path = InstantObject.Image_Logo_Folder + "Logo.JPG";
                    _Felid.Image = Image_Path;

                  //  InstantObject.ThLoading.Open_Loading();
                    _SP_Clinic.SP_Insert_Dr_Info(_Felid);
                  //  InstantObject.ThLoading.Abort_Loading();
                }


                MessageBox.Show("تمت الاضافة");
                PIC_Logo.Image = i;
                TS_Add.Enabled = false;

                Fill_ToolS();
            }
        }

        private void FrmClinicData_Load(object sender, EventArgs e)
        {
            TS_Dr.Renderer = new Renderers.WindowsVistaRenderer();

            Fill_ToolS();
        }

        private void Fill_ToolS()
        {
            _Felid = _SP_Clinic.SP_Browse_Dr_Felid();
            txt_DrID.Text = _Felid.DrID.ToString();
            txt_DrName.Text = _Felid.DrName;
            txt_Speciaty.Text = _Felid.Speciaty;
            txt_Phone.Text = _Felid.Phone;
            txt_Mobile.Text = _Felid.Mobile;
            txt_Fax.Text = _Felid.Fax;
            txt_Email.Text = _Felid.Email;
            txt_WebSite.Text = _Felid.WebSiteAddress;
            txt_Image.Text = _Felid.Image;
            txt_City.Text = _Felid.City;
            txt_Address.Text = _Felid.Address;
            if (txt_DrName.Text != "")
            {
                TS_Add.Enabled = false;
            }
            if (txt_Image.Text != "")
            {
                if (Va == "")
                {
                    // MessageBox.Show(@"\\" + ConfigurationManager.AppSettings["dbServerName"] + @"\" + AppDomain.CurrentDomain.BaseDirectory + Image_Path).ToString();
                    PIC_Logo.Image = Image.FromFile(Va + AppDomain.CurrentDomain.BaseDirectory + txt_Image.Text);

                    //SP
                }
                else
                {
                    string SQ = @"\SQLEXPRESS";
                    string s = Va.Trim(SQ.ToCharArray());

                    PIC_Logo.Image = Image.FromFile(@"\\" + s + @"\" + txt_Image.Text);
                }
                // PIC_Logo.Image = Image.FromFile(@"\\" + s + @"\" + txt_Image.Text);
            }
        }

        private void TS_UpData_Click(object sender, EventArgs e)
        {
            if (txt_DrName.Text == "")
            { MessageBox.Show("ادخل اسم الدكتور", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            else if (txt_Speciaty.Text == "")
            { MessageBox.Show("ادخل الاختصاص", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            else if (txt_Phone.Text == "")
            { MessageBox.Show("ادخل رقم الهاتف", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else if (txt_City.Text == "")
            { MessageBox.Show("ادخل اسم المدينة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else if (txt_Address.Text == "")
            { MessageBox.Show("ادخل العنوان", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else
            {
                _Felid.DrID = Convert.ToInt32(txt_DrID.Text);
                _Felid.DrName = txt_DrName.Text;
                _Felid.Speciaty = txt_Speciaty.Text;
                _Felid.Phone = txt_Phone.Text;
                _Felid.Mobile = txt_Mobile.Text;
                _Felid.Fax = txt_Fax.Text;
                _Felid.Email = txt_Email.Text;
                _Felid.WebSiteAddress = txt_WebSite.Text;
                _Felid.City = txt_City.Text;
                _Felid.Address = txt_Address.Text;

               

                if (MessageBox.Show("هل تريد تعديل الصورة ", "معلومات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    OpenFile_Dialog();

                    if (txt_Image.Text != InstantObject.Image_Logo_Folder + "Logo.jpg")
                    {

                        Image_Path = InstantObject.Image_Logo_Folder + "Image" + R.Next() + ".jpg";
                        i = PIC_Logo.Image;
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

                        
                        _Felid.Image = Image_Path;
                     //   InstantObject.ThLoading.Open_Loading();
                        _SP_Clinic.SP_UpData_Dr_Image(_Felid);
                        _SP_Clinic.SP_UpData_Dr_Info(_Felid);

                    //    InstantObject.ThLoading.Abort_Loading();




                    }

                }
                else
                {

                  //  InstantObject.ThLoading.Open_Loading();
                    _SP_Clinic.SP_UpData_Dr_Info(_Felid);
                  //  InstantObject.ThLoading.Abort_Loading();
                }
                Fill_ToolS();


            }
        }

        

        private void OpenFile_Dialog()
        {
            String path;

            Stream myStream;

            //openFileDialogPicture.InitialDirectory = "C:\\temp\\image.jpg";
            openFileDialogPicture.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialogPicture.FilterIndex = 2;
            openFileDialogPicture.RestoreDirectory = true;
            if (openFileDialogPicture.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialogPicture.OpenFile()) != null)
                {
                    path = openFileDialogPicture.FileName;

                    i = Image.FromFile(path);

                    PIC_Logo.Image = i;
                    txt_Image.Text = path;


                }
            }
            else
            {
                MessageBox.Show("يجب عليك اختيار الصورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenFile_Dialog();

            }
        }

        

        private void TS_BAck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Fax_KeyPress(object sender, KeyPressEventArgs e)
        {
            InstantObject.KeyPress(e);

        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (txt_Email.Text == "")
            {
                return;
            }
            else
            {
                vali = new IsEmailValidations(txt_Email.Text);
                IsAnEmail = vali.IsValidEmail();

                if (IsAnEmail != true)
                {
                    MessageBox.Show("هذا الصيغة ليست مقبولة كإيميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
