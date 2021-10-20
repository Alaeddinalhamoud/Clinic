using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Lib_Felid;
using Lib_Felid.Patient;
using clinic.Visit;
using Microsoft.ApplicationBlocks.Data;
using System.IO;


using clinic.Classes;
using System.Drawing.Imaging;
using clinic.FrmThread;
using System.Threading;
using clinic.Report_Form;
using BLL;
using System.Data.SqlTypes;
using System.Configuration;
using System.Diagnostics;

//Problems want Solution 1-For del...Message BOx
//2- updata
//3-Insert
// 4-Image   
//Key borad 
namespace clinic.Patient
{
    public partial class FrmPatient : Form
    {
        public FrmPatient()
        {
            InitializeComponent();
        }
        //ForNOty
        NotifyWindow _NotifyWindow;

        //C_ThreadLoding ThLoading = new C_ThreadLoding();
        SP_Patient _SP_Patient_All = new SP_Patient();
        SP_Sex _SP_Sex = new SP_Sex();
        SP_Blood _SP_Blood = new SP_Blood();
        SP_SocialState _SP_SocialState = new SP_SocialState();
        SP_Disease _SP_Disease = new SP_Disease();
        SP_Medications _SP_Medications = new SP_Medications();
        
        //-----------------------------
        Felid_Patient _Felid_Patient = new Felid_Patient();
        Felid_Sex _Felid_Sex = new Felid_Sex();
        Felid_Blood _Felid_Blood = new Felid_Blood();
        public string  Va = ConfigurationManager.AppSettings["dbPicture"];
        public Image i;
        public Random R = new Random();
        public string Image_Path;
        public bool IsAnEmail;
        IsEmailValidations vali;
        public int x;
        byte[,] a;
        

        private void FrmPatient_Load(object sender, EventArgs e)
        {
            toolStrip1.Renderer = new Renderers.WindowsVistaRenderer();

            DGV_Patient_All.AutoGenerateColumns = false;

          
            
            Fill_Comb_From_TB();
          
        }

        private void Fill_DGV_All()
        {
            DGV_Patient_All.DataSource = _SP_Patient_All.SP_Browes_Patient_All();
        }

        private void Fill_Comb_From_TB()
        {
            Cmb_Sex.DisplayMember = "Sex";
            Cmb_Sex.ValueMember = "SexID";
            Cmb_Sex.DataSource = _SP_Sex.SP_Browes_Sex();
            Cmb_Blood.DisplayMember = "BloodType";
            Cmb_Blood.ValueMember = "BloodID";
            Cmb_Blood.DataSource = _SP_Blood.SP_Browes_Blood();
            Cmb_SocialState.DisplayMember = "SocialState";
            Cmb_SocialState.ValueMember = "SocialStateID";
            Cmb_SocialState.DataSource = _SP_SocialState.SP_Browes_SocialState();
        }

       

        private void TS_btn_Add_Click(object sender, EventArgs e)
        {
            //if (DGV_Patient_All.RowCount == 25)
            //{
            //    MessageBox.Show("هذه النسخة مجانية ",
            //                                "معلومات",
            //                                MessageBoxButtons.OK,
            //                                MessageBoxIcon.Information);
            //}
            //else
            //{

                try
                {
                    _NotifyWindow = new NotifyWindow("تم اضافة مريض", txt_FirstName.Text + " " + txt_LastName.Text);

                    if (txt_FirstName.Text == "")
                    {
                        errorProvider1.SetError(txt_FirstName, "ادخل الاسم الاول");
                        return;

                    }
                    else if (txt_LastName.Text == "")
                    {
                        errorProvider1.SetError(txt_LastName, "ادخل الاسم الاخير");
                        return;

                    }


                    ///
                    else
                    {
                        _Felid_Patient.FirstName = txt_FirstName.Text;
                        _Felid_Patient.LastName = txt_LastName.Text;
                        _Felid_Patient.DataOfRegister = Convert.ToDateTime(DPK_DataOfRegister.Value.Date);
                        _Felid_Patient.DataOFBirth = Convert.ToDateTime(DPK_DataOFBirth.Value.Date);
                        _Felid_Patient.SexID = Convert.ToInt32(Cmb_Sex.SelectedValue);
                        _Felid_Patient.BloodID = Convert.ToInt32(Cmb_Blood.SelectedValue);
                        _Felid_Patient.SocialStateID = Convert.ToInt32(Cmb_SocialState.SelectedValue);
                        _Felid_Patient.ChidNo = Convert.ToInt32(Cmb_ChidNo.Value);
                        _Felid_Patient.Job = txt_Job.Text;
                        _Felid_Patient.AddressHome = txt_AddressHome.Text;
                        _Felid_Patient.AddressWork = txt_AddressWork.Text;
                        _Felid_Patient.Email = Mtxt_Email.Text;
                        _Felid_Patient.Tel = Convert.ToString(Mtxt_Tel.Text);
                        _Felid_Patient.Mobile = Convert.ToString(MtxtMob.Text);
                        _Felid_Patient.TelWork = Convert.ToString(MtxtTelWork.Text);
                        _Felid_Patient.Smoke = Chb_Smoke.Checked;
                        _Felid_Patient.Win = Chb_Win.Checked;
                        _Felid_Patient.Sensitive = txt_Sensitive.Text;
                        _Felid_Patient.Note = txt_Note.Text;
                        if (MessageBox.Show("هل تريد اضافة  صورة للمريض ", "معلومات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            OpenFile_Dialog();

                            Image_Path = InstantObject.ImageFolder + "Image" + R.Next() + ".jpg";
                            i = PB_Patient.Image;
                            Graphics Graph_Image = Graphics.FromImage(i);
                            Graph_Image.DrawString(txt_FirstName.Text + " " + txt_LastName.Text, new Font("Tahoma", 40), Brushes.White, new PointF(0, 0));
                          
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
                            _Felid_Patient.ImagePath = Image_Path;
                            //  InstantObject.ThLoading.Open_Loading();
                            _SP_Patient_All.SP_Insert_Patient(_Felid_Patient);
                            //     InstantObject.ThLoading.Abort_Loading();

                            // _NotifyWind
                            _NotifyWindow.Notify();
                            _NotifyWindow.WaitTime = 9000;

                        }

                        else
                        {
                            Image_Path = InstantObject.ImageFolder + "delete-user.ico";
                            //i.Save(Application.StartupPath + Image_Path);
                            _Felid_Patient.ImagePath = Image_Path;

                            //   InstantObject.ThLoading.Open_Loading();
                            _SP_Patient_All.SP_Insert_Patient(_Felid_Patient);
                            //  InstantObject.ThLoading.Abort_Loading();

                            // _NotifyWind
                            _NotifyWindow.Notify();
                            _NotifyWindow.WaitTime = 9000;

                        }

                    }




                    ///////////


                    //  InstantObject.ThLoading.Abort_Loading();  

                }
                catch (Exception ex)
                {
                    // InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show(ex.Message);
                }
                Fill_DGV_All();
                Fill_Comb_From_TB();
                Clear_Tools();

                PB_Patient.Image = null;
           // }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
          //  Thread ThSearch = new Thread(Do_Search);

            if (RB_PatientID.Checked == true)
            {
                if (txt_Search.Text == "")
                {
                    MessageBox.Show("ادخل رقم المريض");
                }
                else
                {



                    try
                    {

                        try
                        {

                            x = Convert.ToInt32(txt_Search.Text);
                        }
                        catch
                        {
                            MessageBox.Show("ادخل قيمة عددية");
                            return;
                        }

                      //  ThSearch.Start();

                        _Felid_Patient = _SP_Patient_All.SP_Browes_Patient_By_PatientID(x);

                        Fill_Tools_forCeratinPatient();
                       // ThSearch.Abort();
                    }
                    catch (Exception ex)
                    {

                       // ThSearch.Abort();
                        MessageBox.Show(ex.Message);
                    }


                }
            }
            else if (RB_FirstName.Checked == true)
            {
                if (txt_Search.Text == "")
                {
                    MessageBox.Show("ادخل الاسم الاول");
                }
                else
                {


                    try
                    {
                       // ThSearch.Start();
                        DGV_Patient_All.DataSource = _SP_Patient_All.SP_Browes_Patient_List_By_FirstName(txt_Search.Text);
                       // ThSearch.Abort();
                    }
                    catch (Exception ex)
                    {
                      //  ThSearch.Abort();
                        MessageBox.Show(ex.Message);
                    }


                }
            }
            else
            {
                if (txt_Search.Text == "")
                {
                    MessageBox.Show("ادخل الاسم الاخير");
                }
                else
                {


                    try
                    {
                      //  ThSearch.Start();
                        DGV_Patient_All.DataSource = _SP_Patient_All.SP_Browes_Patient_List_By_LastName(txt_Search.Text);
                        //ThSearch.Abort();
                    }
                    catch (Exception ex)
                    {
                       // ThSearch.Abort();
                        MessageBox.Show(ex.Message);
                    }


                }
            }


        }

        private void Fill_Tools_forCeratinPatient()
        {

          


            txt_PatientID.Text = _Felid_Patient.PatientID.ToString();
            txt_FirstName.Text = _Felid_Patient.FirstName;
            txt_LastName.Text = _Felid_Patient.LastName;
            //   _Felid.ImageID = (int)_Reader["ImageID"];
            DPK_DataOfRegister.Text = _Felid_Patient.DataOfRegister.ToString();
            DPK_DataOFBirth.Text = _Felid_Patient.DataOFBirth.ToString();
            Cmb_Sex.DisplayMember = "Sex";
            Cmb_Sex.ValueMember = "SexID";
            Cmb_Sex.DataSource = _SP_Sex.SP_Browes_Sex();
            //Cmb_Sex.SelectedIndex = _SP_Sex.SP_Browes_Sex_By_ID(_Felid_Patient.SexID);
            Cmb_Sex.SelectedItem = Cmb_Sex.Items[_Felid_Patient.SexID - 1];
            Cmb_Blood.DisplayMember = "BloodType";
            Cmb_Blood.ValueMember = "BloodID";
            Cmb_Blood.DataSource = _SP_Blood.SP_Browes_Blood();
            Cmb_Blood.SelectedItem = Cmb_Blood.Items[_Felid_Patient.BloodID - 1];

            Cmb_SocialState.DisplayMember = "SocialState";
            Cmb_SocialState.ValueMember = "SocialStateID";
            Cmb_SocialState.DataSource = _SP_SocialState.SP_Browes_SocialState();
            Cmb_SocialState.SelectedItem = Cmb_SocialState.Items[_Felid_Patient.SocialStateID - 1];

            Cmb_ChidNo.Value = _Felid_Patient.ChidNo;
            txt_Job.Text = _Felid_Patient.Job;
            txt_AddressHome.Text = _Felid_Patient.AddressHome;
            txt_AddressWork.Text = _Felid_Patient.AddressWork;
            Mtxt_Email.Text = _Felid_Patient.Email;
            Mtxt_Tel.Text = _Felid_Patient.Tel.ToString();
            MtxtMob.Text = _Felid_Patient.Mobile.ToString();
            MtxtTelWork.Text = _Felid_Patient.TelWork.ToString();
            Chb_Win.Checked = _Felid_Patient.Win;
            Chb_Smoke.Checked = _Felid_Patient.Smoke;
            txt_Sensitive.Text = _Felid_Patient.Sensitive;
            txt_Note.Text = _Felid_Patient.Note;
            txt_Image.Text = _Felid_Patient.ImagePath;
            if (txt_Image.Text != "")
            {
                if (Va == "")
                {
                    // MessageBox.Show(@"\\" + ConfigurationManager.AppSettings["dbServerName"] + @"\" + AppDomain.CurrentDomain.BaseDirectory + Image_Path).ToString();
                    //i.Save(Va + AppDomain.CurrentDomain.BaseDirectory + Image_Path);
                    PB_Patient.Image = Image.FromFile(Va + AppDomain.CurrentDomain.BaseDirectory + txt_Image.Text);
                    
                    //SP
                }
                else
                {
                    string SQ = @"\SQLEXPRESS";
                    string s = Va.Trim(SQ.ToCharArray());
                    PB_Patient.Image = Image.FromFile(@"\\" + s + @"\" + txt_Image.Text);
                }
               
                
            }
            else
            {
                PB_Patient.Image = null;
            }
        }

        private void RB_PatientID_CheckedChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            lbl_TEXT.Text = RB_PatientID.Text;
        }

        private void RB_FirstName_CheckedChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            lbl_TEXT.Text = RB_FirstName.Text;
        }

        private void RB_LastName_CheckedChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            lbl_TEXT.Text = RB_LastName.Text;
        }

       
        private void Fill_Tools()
        {
            try
            {
                if (DGV_Patient_All.Rows.Count > 0)
                {
                    int _RowIndex;
                    _RowIndex = DGV_Patient_All.CurrentCell.RowIndex;
                    object _CurrentRow = DGV_Patient_All[0, _RowIndex];
                    int _Value_Current_Row = Convert.ToInt32(DGV_Patient_All[0, _RowIndex].Value);
                    _Felid_Patient = _SP_Patient_All.SP_Browes_Patient_By_PatientID(_Value_Current_Row);

                    Fill_Tools_forCeratinPatient();
                    Fill_DGV_All();

                }
            }
            catch { };
        }

        private void Clear_Tools()
        {
            txt_PatientID.Text="0";
            txt_FirstName.Clear();
            txt_LastName.Clear();
            txt_Image.Clear();
            DPK_DataOfRegister.Text = "";
            DPK_DataOFBirth.Text = "";
            Cmb_ChidNo.Value = 0;
            txt_Job.Clear();
            txt_AddressHome.Clear();
            txt_AddressWork.Clear();
            Mtxt_Email.Clear();
            Mtxt_Tel.Text = "";
            MtxtMob.Clear();
            MtxtTelWork.Clear();
            Chb_Win.Checked = false;
            Chb_Smoke.Checked = false;
            PB_Patient.Image = null;
            txt_Sensitive.Clear();
            txt_Note.Clear();

        }


        private void TS_btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                _NotifyWindow = new NotifyWindow("تم حذف المريض", txt_FirstName.Text + " " + txt_LastName.Text);

                if (txt_PatientID.Text.Trim() == "0")
                {
                    MessageBox.Show("اختر المريض ",
                                            "تحذير",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //
                       // InstantObject.ThLoading.Open_Loading();
                        _SP_Patient_All.SP_Delete_Patient_By_PatientID(Convert.ToInt32(txt_PatientID.Text));

                        Fill_DGV_All();
                        Fill_Comb_From_TB();
                        Clear_Tools();
                       // InstantObject.ThLoading.Abort_Loading();
                // _NotifyWind
                _NotifyWindow.Notify();
                _NotifyWindow.WaitTime = 9000;
                    }
                }
                ///////////

              
            }
            catch {
               // InstantObject.ThLoading.Abort_Loading();
                return;
            
            }
        }

        

        private void TS_Visit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TS_btn_Update_Click(object sender, EventArgs e)
        {
            try
            {

                _NotifyWindow = new NotifyWindow("تم تعديل المريض", txt_FirstName.Text + " " + txt_LastName.Text);

                if (txt_PatientID.Text == "0")
                {
                    
                        MessageBox.Show("اختر المريض ",
                                                "تحذير",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                   

                }
                else
                {

                    _Felid_Patient.FirstName = txt_FirstName.Text;
                    _Felid_Patient.LastName = txt_LastName.Text;
                    _Felid_Patient.DataOfRegister = Convert.ToDateTime(DPK_DataOfRegister.Value);
                    _Felid_Patient.DataOFBirth = Convert.ToDateTime(DPK_DataOFBirth.Value);
                    _Felid_Patient.SexID = Convert.ToInt32(Cmb_Sex.SelectedValue);
                    _Felid_Patient.BloodID = Convert.ToInt32(Cmb_Blood.SelectedValue);
                    _Felid_Patient.SocialStateID = Convert.ToInt32(Cmb_SocialState.SelectedValue);
                    _Felid_Patient.ChidNo = Convert.ToInt32(Cmb_ChidNo.Value);
                    _Felid_Patient.Job = txt_Job.Text;
                    _Felid_Patient.AddressHome = txt_AddressHome.Text;
                    _Felid_Patient.AddressWork = txt_AddressWork.Text;
                    _Felid_Patient.Email = Mtxt_Email.Text;
                    _Felid_Patient.Tel = Convert.ToString(Mtxt_Tel.Text);
                    _Felid_Patient.Mobile = Convert.ToString(MtxtMob.Text);
                    _Felid_Patient.TelWork = Convert.ToString(MtxtTelWork.Text);
                    _Felid_Patient.Smoke = Chb_Smoke.Checked;
                    _Felid_Patient.Win = Chb_Win.Checked;
                    _Felid_Patient.Sensitive = txt_Sensitive.Text;
                    _Felid_Patient.Note = txt_Note.Text;
                    if (MessageBox.Show("هل تريد تعديل الصورة ", "معلومات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        OpenFile_Dialog();

                        if (txt_Image.Text != InstantObject.ImageFolder + "delete-user.ico")
                        {

                            Image_Path = InstantObject.ImageFolder + "Image" + R.Next() + ".jpg";
                            Graphics Graph_Image = Graphics.FromImage(i);
                            Graph_Image.DrawString(txt_FirstName.Text + " " + txt_LastName.Text, new Font("Tahoma", 40), Brushes.White, new PointF(0, 0));
                          
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
                            //i.Save(@"\\" + ConfigurationManager.AppSettings["dbServerName"] + @"\" + AppDomain.CurrentDomain.BaseDirectory + Image_Path);
                            
                            
                            
                            
                            _Felid_Patient.PatientID = Convert.ToInt32(txt_PatientID.Text);
                            _Felid_Patient.ImagePath = Image_Path;

                        //    InstantObject.ThLoading.Open_Loading();

                            _SP_Patient_All.SP_Update_Patient_By_PatientID(_Felid_Patient);
                            _SP_Patient_All.SP_UpData_Patient_Image_Path_By_ID(_Felid_Patient);

                          //  InstantObject.ThLoading.Abort_Loading();
                            ///////////

                            // _NotifyWind
                            _NotifyWindow.Notify();
                            _NotifyWindow.WaitTime = 9000;

                        }
 
                    }
                    else
                    {
                    // InstantObject.ThLoading.Open_Loading();
                        _SP_Patient_All.SP_Update_Patient_By_PatientID(_Felid_Patient);
                     //   InstantObject.ThLoading.Abort_Loading();
                        ///////////

                      

                    }


                    Fill_DGV_All();
                    Fill_Comb_From_TB();
                    Clear_Tools();
                }

               
            }
            catch
            {
               // InstantObject.ThLoading.Abort_Loading();
                return;
            }

        }

        
        private void TS_FamilyDisease_Click(object sender, EventArgs e)
        {
            FrmLastDisease Frm = new FrmLastDisease();

            Frm.Show();
        }

       

        private void DGV_Patient_All_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    ThLoading.Open_Loading();
            //    Fill_Tools();
            //    ThLoading.Abort_Loading();
            //}
            //catch { };
        }



        private void OpenFile_Dialog()
        {
            String path;

            Stream myStream;
            OpenFileDialog openFileDialogPicture = new OpenFileDialog();
           // openFileDialogPicture.InitialDirectory = "C:\\temp\\image.jpg";
            openFileDialogPicture.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialogPicture.FilterIndex = 2;
            openFileDialogPicture.RestoreDirectory = true;
            if (openFileDialogPicture.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialogPicture.OpenFile()) != null)
                {
                    path = openFileDialogPicture.FileName;
                    i = Image.FromFile(path);
                    PB_Patient.Image = i;
                    txt_Image.Text = path;
                }
            }
            else
            {
                MessageBox.Show("يجب عليك اختيار الصورة","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                OpenFile_Dialog();

            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           // InstantObject.ThLoading.Open_Loading();
            FrmReport nfrm = new FrmReport();
           
            nfrm.ShowPatientFromToDate(Convert.ToDateTime(DPK_From_Date.Value), Convert.ToDateTime(DPK_To_Date.Value));
           // InstantObject.ThLoading.Abort_Loading();
            nfrm.Show();
           
        }
        private Form GetOpenForm(string FormName)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (FormName == form.Name)
                {
                    return form;
                }
            }

            return null;
        }

        private void TS_S_Med_Patent_Click(object sender, EventArgs e)
        {
          //  InstantObject.ThLoading.Open_Loading();
            FrmLastMedication Frm = new FrmLastMedication();
          //  InstantObject.ThLoading.Abort_Loading();
            Frm.Show();
            
        }

        private void TS_S_Dis_Pateint_Click(object sender, EventArgs e)
        {
          //  InstantObject.ThLoading.Open_Loading();
            FrmLastDisease Frm = new FrmLastDisease();

          //  InstantObject.ThLoading.Abort_Loading();
            Frm.ShowDialog();
            
        }

        private void TS_S_Opr_Patient_Click(object sender, EventArgs e)
        {
           // InstantObject.ThLoading.Open_Loading();
            Frm_Operation_Patient Frm = new Frm_Operation_Patient();
          //  InstantObject.ThLoading.Abort_Loading();
            Frm.ShowDialog();
        }

       
        private void Cmb_SocialState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_SocialState.SelectedItem == Cmb_SocialState.Items[0])
            {
                Cmb_ChidNo.Enabled = false;
            }
            else
            {
                Cmb_ChidNo.Enabled = true;
            }


        }

        //void Do_Search()
        //{
        //    try
        //    {
        //        FrmSearch FrmS = new FrmSearch();
        //        FrmS.ShowDialog();
        //    }
        //    catch { };
        //}

      

        private void Mtxt_Email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TS_ClearTools_Click(object sender, EventArgs e)
        {
            Clear_Tools();
        }

        private void TS_BrowesAllPatient_Click(object sender, EventArgs e)
        {
           
        }
        
        private void TS_btn_Patient_Info_Click_1(object sender, EventArgs e)
        {
            byte[] a;
            try
            {
                if (txt_PatientID.Text == "0")
                {
                    MessageBox.Show("لم تقم باختيار اسم المريض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Va == "")
                    {
                        // MessageBox.Show(@"\\" + ConfigurationManager.AppSettings["dbServerName"] + @"\" + AppDomain.CurrentDomain.BaseDirectory + Image_Path).ToString();
                        //i.Save(Va + AppDomain.CurrentDomain.BaseDirectory + Image_Path);
                       // PB_Patient.Image = Image.FromFile(Va + AppDomain.CurrentDomain.BaseDirectory + txt_Image.Text);
                         a = File.ReadAllBytes(Va+ AppDomain.CurrentDomain.BaseDirectory + txt_Image.Text);

                        //SP
                    }
                    else
                    {
                        string SQ = @"\SQLEXPRESS";
                        string s = Va.Trim(SQ.ToCharArray());
                       // MessageBox.Show(@"\\" + s + @"\" + AppDomain.CurrentDomain.BaseDirectory + txt_Image.Text);
                        a = File.ReadAllBytes(@"\\" + s + @"\" + txt_Image.Text);
                        //PB_Patient.Image = Image.FromFile(@"\\" + s + @"\" + AppDomain.CurrentDomain.BaseDirectory + Image_Path);
                    }
                    
                   
                    
                  
                
                    FrmReport nfrm = new FrmReport();
                    nfrm.ShowPatientDatils(Convert.ToInt32(txt_PatientID.Text), a);
                    nfrm.Show();
                 
                   
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

    
        private void TS_ShowFullScreen_Click(object sender, EventArgs e)
        {
            Show_DGV_Full_Screen();
        }

        private void Show_DGV_Full_Screen()
        {
            try
            {
                DGV_Patient_All.Dock = DockStyle.Fill;
              ///  InstantObject.ThLoading.Open_Loading();
                Fill_DGV_All();
                ////InstantObject.ThLoading.Abort_Loading();
            }
            catch 
            {
               //// InstantObject.ThLoading.Abort_Loading();
               // return;
            };
        }

        private void Ts_ShowNormal_Click(object sender, EventArgs e)
        {
            Show_DGV_Normal_Screen();
        }

        private void Show_DGV_Normal_Screen()
        {
            try
            {
                DGV_Patient_All.Dock = DockStyle.None;
                //   InstantObject.ThLoading.Open_Loading();
                Fill_DGV_All();
                //InstantObject.ThLoading.Abort_Loading();
            }
            catch
            {
                ///   InstantObject.ThLoading.Abort_Loading();
                //   return;
            };
        }

        private void TS_FullSceen_Click(object sender, EventArgs e)
        {
            Show_DGV_Full_Screen();
        }

        private void TS_NormalScreen_Click(object sender, EventArgs e)
        {
            Show_DGV_Normal_Screen();
        }

        private void DGV_Patient_All_DoubleClick(object sender, EventArgs e)
        {
            try
            {
              //  InstantObject.ThLoading.Open_Loading();
                Fill_Tools();

              //  InstantObject.ThLoading.Abort_Loading();
                Show_DGV_Normal_Screen();
            }
            catch
            {
                //InstantObject.ThLoading.Abort_Loading();
                //return;
            };
        }

        private void txt_PatientID_TextChanged(object sender, EventArgs e)
        {
            InstantObject.PatientID = Convert.ToInt32(txt_PatientID.Text);
        }
        public void GetSecurityForLastInfo(bool TS_S_Med_Patent, bool TS_S_Dis_Pateint, bool TS_S_Opr_Patient)
        {
            this.TS_S_Med_Patent.Enabled = TS_S_Med_Patent;
            this.TS_S_Dis_Pateint.Enabled = TS_S_Dis_Pateint;
            this.TS_S_Opr_Patient.Enabled = TS_S_Opr_Patient;

        }

        private void Mtxt_Email_Leave(object sender, EventArgs e)
        {
            if (Mtxt_Email.Text == "")
            {
                return;
            }
            else
            {
                vali = new IsEmailValidations(Mtxt_Email.Text);
                IsAnEmail = vali.IsValidEmail();

                if (IsAnEmail != true)
                {
                    MessageBox.Show("هذا الصيغة ليست مقبولة كإيميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Mtxt_Email.Clear();
                    return;
                }
            }

        }

        private void DGV_Patient_All_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TS_SendEmail_Click(object sender, EventArgs e)
        {
            if(Mtxt_Email.Text=="")
            {
                MessageBox.Show("المريض لا يملك بريد الكتروني ",
                                           "تحذير",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);

            }
            else{
                try
                {
                    Process.Start("mailto://" + Mtxt_Email.Text);
                }
                catch { }
            }
        }
       



    }
}
