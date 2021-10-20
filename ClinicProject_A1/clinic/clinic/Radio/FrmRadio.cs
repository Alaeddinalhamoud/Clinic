using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using Lib_Felid;
using clinic.Classes;
using BLL;
using clinic.Report_Form;
using System.Configuration;

namespace clinic.Radio
{
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }
        SP_Patient _SP_Patient = new SP_Patient();
        SP_RadioType _SP_RadioType = new SP_RadioType();
        SP_Visit _SP_Visit = new SP_Visit();
        SP_Radio _Sp_Radio = new SP_Radio();


        Felid_Radio _Felid_Radio = new Felid_Radio();

        public Image i;
        public Random R = new Random();
        string Image_Path;
        OpenFileDialog openFileDialogPicture = new OpenFileDialog();
        public string Va = ConfigurationManager.AppSettings["dbPicture"];
        private void FrmRadio_Load(object sender, EventArgs e)
        {
            TS_Radio.Renderer = new Renderers.WindowsVistaRenderer();

            txt_PateintInher.Text = InstantObject.PatientID.ToString();

            if (Convert.ToInt32(txt_PateintInher.Text) == 0)
            {
                Fill_DvG_Radio();
                Fill_cmb_AnalysisType();

                this.Cmb_PatientName.SelectedIndexChanged -= new System.EventHandler(this.Cmb_PatientName_SelectedIndexChanged);
                Cmb_Fill_PatientName();
                Cmb_PatientName.Text = "";
                this.Cmb_PatientName.SelectedIndexChanged += new System.EventHandler(this.Cmb_PatientName_SelectedIndexChanged);
            }
            else
            {
                Cmb_PatientName.DisplayMember = "FirstName";
                Cmb_PatientName.ValueMember = "PatientID";
                Cmb_PatientName.DataSource = _SP_Patient.SP_Browes_Patient_FullName_By_ID(Convert.ToInt32(txt_PateintInher.Text));

                Fill_cmb_AnalysisType();
                DGV_RAdio_All.AutoGenerateColumns = false;
                DGV_RAdio_All.DataSource = _Sp_Radio.SP_Browes_Radio_Report_PatientID(Convert.ToInt32(txt_PateintInher.Text));

            }

            }

        private void Fill_DvG_Radio()
        {
            DGV_RAdio_All.DataSource = _Sp_Radio.SP_Browes_Radio_Dateils();
        }

        private void Fill_cmb_AnalysisType()
        {
            Cmb_RadioType.DisplayMember = "RadioType";
            Cmb_RadioType.ValueMember = "RadioTypeID";
            Cmb_RadioType.DataSource = _SP_RadioType.SP_Browes_RadioType_All();
        }
        private void Cmb_Fill_Visit()
        {try{

            Cmb_VisitID.DisplayMember = "DataOfVisit";
            Cmb_VisitID.ValueMember = "VisitID";
            Cmb_VisitID.DataSource = _SP_Visit.SP_Browes_Visit_Date_By_PatientID(Convert.ToInt32(Cmb_PatientName.SelectedValue));
        }catch(Exception ex)
        { MessageBox.Show(ex.Message); }
        }
        private void Cmb_Fill_PatientName()
        {
            Cmb_PatientName.DisplayMember = "FirstName";
            Cmb_PatientName.ValueMember = "PatientID";
            Cmb_PatientName.DataSource = _SP_Patient.SP_Browes_Patient_FullName();
        }

       

        private void OpenFile_Dialog()
        {
            String path;
            Stream myStream;

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


                    PIC_X_RAY.Image = i;
                    txt_ImagePath.Text = path;
                   

                }
            }
            else
            {
                MessageBox.Show("يجب عليك اختيار الصورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenFile_Dialog();

            }
        }

        private void TS_Add_RAdio_Click(object sender, EventArgs e)
        {
            if (Cmb_PatientName.Text == "")
            { MessageBox.Show("اختر المريض"); }
            else if (Cmb_VisitID.Text == "")
            { MessageBox.Show("اختر الزياره"); }
            else if (Cmb_RadioType.Text == "")
            { MessageBox.Show("اختر التصوير الشعاعي"); }
            else
            {

                //   Image_Path = InstantObject.Image_X_Folder + "delete-user.ico";

                _Felid_Radio.RadioTypeID = Convert.ToInt32(Cmb_RadioType.SelectedValue);
                _Felid_Radio.RadioSubject = txt_Subject.Text;
                _Felid_Radio.RadioResult = txt_RadioResult.Text;
                _Felid_Radio.VisitID = Convert.ToInt32(Cmb_VisitID.SelectedValue);
                _Felid_Radio.PatientID = Convert.ToInt32(Cmb_PatientName.SelectedValue);







                if (MessageBox.Show("هل تريد اضافة  صورة اشعاعية  ", "معلومات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    OpenFile_Dialog();

                    InstantObject._Felid_Patient=InstantObject._SP_Patient.SP_Browes_Patient_FullName_By_ID_Felid(InstantObject.PatientID);


                    Image_Path = InstantObject.Image_X_Folder + "Image" + R.Next() + ".jpg";
                    i = PIC_X_RAY.Image;
                    Graphics Graph_Image = Graphics.FromImage(i);
                    Graph_Image.DrawString(InstantObject.PatientID.ToString() + ":"+InstantObject._Felid_Patient.FirstName+InstantObject._Felid_Patient.LastName , new Font("Tahoma", 40), Brushes.White, new PointF(0, 0));
                          
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
                 ///   InstantObject.ThLoading.Open_Loading();
                    _Felid_Radio.ImagePath = Image_Path;

                    _Sp_Radio.SP_Insert_RadioTB(_Felid_Radio);
                 //   InstantObject.ThLoading.Abort_Loading();

                }

                else
                {
                    Image_Path = InstantObject.Image_X_Folder + "delete-user.ico";
                    //i.Save(Application.StartupPath + Image_Path);
                 //   InstantObject.ThLoading.Open_Loading();
                    _Felid_Radio.ImagePath = Image_Path;

                    _Sp_Radio.SP_Insert_RadioTB(_Felid_Radio);
                //    InstantObject.ThLoading.Abort_Loading();
                }





                Fill_DvG_Radio();
                Clear_Tools();
            }
        }

        

        private void Cmb_PatientName_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Cmb_VisitID.DisplayMember = "DataOfVisit";
                Cmb_VisitID.ValueMember = "VisitID";
                Cmb_VisitID.DataSource = _SP_Visit.SP_Browes_Visit_Date_By_PatientID(Convert.ToInt32(Cmb_PatientName.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TS_UpDate_Click(object sender, EventArgs e)
        {
            if (txt_Radio.Text == "")
            { MessageBox.Show("اختر المريض"); }
            else if (Cmb_PatientName.Text == "")
            { MessageBox.Show("اختر المريض"); }
            else if (Cmb_VisitID.Text == "")
            { MessageBox.Show("اختر الزياره"); }
            else if (Cmb_RadioType.Text == "")
            { MessageBox.Show("اختر التصوير الشعاعي"); }
            else
            {
                _Felid_Radio.RadioID = Convert.ToInt32(txt_Radio.Text);
                _Felid_Radio.RadioTypeID = Convert.ToInt32(Cmb_RadioType.SelectedValue);
                _Felid_Radio.RadioSubject = txt_Subject.Text;
                _Felid_Radio.RadioResult = txt_RadioResult.Text;
                _Felid_Radio.VisitID = Convert.ToInt32(Cmb_VisitID.SelectedValue);
                _Felid_Radio.PatientID = Convert.ToInt32(Cmb_PatientName.SelectedValue);



                if (MessageBox.Show("هل تريد تعديل الصورة ", "معلومات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    OpenFile_Dialog();

                    if (txt_ImagePath.Text != InstantObject.Image_X_Folder + "delete-user.ico")
                    {

                        Image_Path = InstantObject.Image_X_Folder + "Image" + R.Next() + ".jpg";
                        i = PIC_X_RAY.Image;
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
                        //SP
                      //  InstantObject.ThLoading.Open_Loading();
                        _Felid_Radio.RadioID = Convert.ToInt32(txt_Radio.Text);
                        _Felid_Radio.ImagePath = Image_Path;
                        _Sp_Radio.SP_UpDate_RadioTB_Image_By_ID(_Felid_Radio);
                        _Sp_Radio.SP_UpData_RadioTB(_Felid_Radio);
                      //  InstantObject.ThLoading.Abort_Loading();

                    }

                }
                else
                {
                    //Image_Path = InstantObject.ImageFolder + "delete-user.ico";
                   // InstantObject.ThLoading.Open_Loading();
                    _Sp_Radio.SP_UpData_RadioTB(_Felid_Radio);
                    //InstantObject.ThLoading.Abort_Loading();
                }
                Fill_DvG_Radio();
                Clear_Tools();
            }

        }

        private void Clear_Tools()
        {
            Cmb_PatientName.Text = "";
            Cmb_VisitID.DataSource = null;
            txt_Radio.Clear();
            txt_Subject.Clear();
            txt_RadioResult.Clear();
            txt_Subject.Clear();
            txt_ImagePath.Clear();
            PIC_X_RAY.Image = null;
        }



        private void TS_Delete_Click(object sender, EventArgs e)
        {
            if (txt_Radio.Text == "")
            {
                MessageBox.Show("اختر الصورة الاشعاعية التي ترغب بحذفها", "تحذير", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);


            }
            else
            {
                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                 //   InstantObject.ThLoading.Open_Loading();
                    _Sp_Radio.SP_Delete_RadioTB(Convert.ToInt32(txt_Radio.Text));
                  //  InstantObject.ThLoading.Abort_Loading();


                    Fill_DvG_Radio();
                    Clear_Tools();
                }

            }

            
        }

        private void TS_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ts_Report_PatientID_Click(object sender, EventArgs e)
        {
            if (Cmb_PatientName.Text == "")
            { MessageBox.Show("اختر المريض"); }
            else
            {
               // InstantObject.ThLoading.Open_Loading();
                FrmReport Frm = new FrmReport();
                Frm.ReportRptRadioReportPatientID(Convert.ToInt32(Cmb_PatientName.SelectedValue));
              //  InstantObject.ThLoading.Abort_Loading();
                Frm.Show();
            }
        }

        private void Ts_PaientIDS_Click(object sender, EventArgs e)
        {
           // InstantObject.ThLoading.Open_Loading();
            FrmReport Frm = new FrmReport();
            Frm.ReportRptRptRadioAll();
           // InstantObject.ThLoading.Abort_Loading();
            Frm.Show();
        }

        private void TS_EmaptyTools_Click(object sender, EventArgs e)
        {
           
            Cmb_Fill_PatientName();
            Fill_cmb_AnalysisType();
            Clear_Tools();
        }

        private void DGV_RAdio_All_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGV_RAdio_All.Rows.Count > 0)
                {
                   // InstantObject.ThLoading.Open_Loading();
                    //Method For Fill Tools at Patient
                    int _RowIndex;
                    _RowIndex = DGV_RAdio_All.CurrentCell.RowIndex;
                    int _CurrentRow = Convert.ToInt32(DGV_RAdio_All[0, _RowIndex].Value);
                    _Felid_Radio = _Sp_Radio.SP_Browes_RadioTB_By_RadioID_Felid(_CurrentRow);
                    txt_Radio.Text = _Felid_Radio.RadioID.ToString();
                    // txt_RadioID.Text = _Felid_Radio.RadioID.ToString();
                    Fill_cmb_AnalysisType();
                    string NameOfRadioType = Convert.ToString(DGV_RAdio_All[2, _RowIndex].Value);
                    Cmb_RadioType.Text = NameOfRadioType;


                    txt_Subject.Text = _Felid_Radio.RadioSubject;
                    txt_RadioResult.Text = _Felid_Radio.RadioSubject;

                    Cmb_PatientName.DisplayMember = "FirstName";
                    Cmb_PatientName.ValueMember = "PatientID";
                    Cmb_PatientName.DataSource = _SP_Patient.SP_Browes_Patient_FullName_By_ID(Convert.ToInt32(_Felid_Radio.PatientID));
                    string DataOfVisit = Convert.ToString(DGV_RAdio_All[6, _RowIndex].Value);
                    Cmb_VisitID.Text = DataOfVisit;

                    txt_ImagePath.Text = _Felid_Radio.ImagePath;
                    if (Va == "")
                    {
                        // MessageBox.Show(@"\\" + ConfigurationManager.AppSettings["dbServerName"] + @"\" + AppDomain.CurrentDomain.BaseDirectory + Image_Path).ToString();
                        PIC_X_RAY.Image = Image.FromFile(Va + AppDomain.CurrentDomain.BaseDirectory + txt_ImagePath.Text);

                        //SP
                    }
                    else
                    {
                        string SQ = @"\SQLEXPRESS";
                        string s = Va.Trim(SQ.ToCharArray());

                        PIC_X_RAY.Image = Image.FromFile(@"\\" + s + @"\" + txt_ImagePath.Text);
                    }
                    
                  //  InstantObject.ThLoading.Abort_Loading();
                }
            }catch{};
        }

        

    }
}
