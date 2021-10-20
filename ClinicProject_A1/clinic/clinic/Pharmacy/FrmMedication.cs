using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Lib_Felid;
using clinic.FrmThread;
using System.Threading;
using BLL;
using clinic.Report_Form;
using clinic.Classes;
using System.IO;

namespace clinic.pharmacy
{
    public partial class FrmMedication : Form
    {
        public FrmMedication()
        {
            InitializeComponent();
        }
        // SP_Medications For All
        //Felid for all
        



        private void FrmPharmacy_Load(object sender, EventArgs e)
        {
            TS_Phrmacy.Renderer = new Renderers.WindowsVistaRenderer();

            Fill_DVG_Browes_All_From_Medications();
        }

        private void Fill_DVG_Browes_All_From_Medications()
        {
            //Fill DVG All

            DVG_Medication_All.DataSource = InstantObject._SP_Medications.SP_Browes_Medications_All();
        }

        private void TS_BAck_To_Main_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            if (RD_btn_MedicationID.Checked == true)
            {
                if (txt_Search.Text == "")
                {
                    MessageBox.Show("ادخل رقم الدواء");
                }
                else
                {

                    // Thread ThSearch = new Thread(Do_Search);
                    //  ThSearch.Start();
                    try
                    {
                        DVG_Medication_All.DataSource = InstantObject._SP_Medications.SP_Browes_Medications_By_ID(Convert.ToInt32(txt_Search.Text));
                        //  ThSearch.Abort();
                    }
                    catch (Exception ex)
                    {
                        // ThSearch.Abort();
                        MessageBox.Show(ex.Message);


                    }
                }
            }
            else
            {

                if (txt_Search.Text == "")
                {
                    MessageBox.Show("ادخل اسم الدواء");
                }
                else
                {

                    //     Thread ThSearch = new Thread(Do_Search);
                    //   ThSearch.Start();
                    try
                    {
                        DVG_Medication_All.DataSource = InstantObject._SP_Medications.SP_Browes_Medications_By_Name(txt_Search.Text);
                        //   ThSearch.Abort();
                    }
                    catch (Exception ex)
                    {
                        //  ThSearch.Abort();
                        MessageBox.Show(ex.Message);
                    }
                }
            }


        }

        private void RD_btn_MedicationID_CheckedChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            lbl_TEXT.Text = RD_btn_MedicationID.Text;
            Fill_DVG_Browes_All_From_Medications();
        }

        private void RD_btn_MedicationName_CheckedChanged(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            lbl_TEXT.Text = RD_btn_MedicationName.Text;
            Fill_DVG_Browes_All_From_Medications();
        }

        private void TS_Add_Medication_Click(object sender, EventArgs e)
        {
            if (txt_Medication.Text == "")
                MessageBox.Show("ادخل اسم الدواء");
            else
            {
                Felid_Medications _Felid_Medication = new Felid_Medications();
                _Felid_Medication.MedicationName = txt_Medication.Text;
                try
                {
                    //  InstantObject.ThLoading.Open_Loading();
                   InstantObject._SP_Medications.SP_Insert_Medications(_Felid_Medication);
                    //   InstantObject.ThLoading.Abort_Loading();
                }
                catch (Exception ex)
                {
                    //  InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show(ex.Message);

                }
                //Fill From Medications By Method
                Fill_DVG_Browes_All_From_Medications();
            }

            Clear_Tools();

        }

        private void DVG_Medication_All_Click(object sender, EventArgs e)
        {
            try
            {
                ///InstantObject.ThLoading.Open_Loading();
                if (DVG_Medication_All.Rows.Count > 0)
                {
                    //Method For Fill Tools at Patient
                    int _RowIndex;
                    _RowIndex = DVG_Medication_All.CurrentCell.RowIndex;
                    int _CurrentRow = Convert.ToInt32(DVG_Medication_All[0, _RowIndex].Value);
                    //_Felid_Patient = _SP_Patient_All.SP_Browes_Patient_By_PatientID(_CurrentRow);
                    InstantObject . _Felid_Medications =InstantObject. _SP_Medications.SP_Browes_Medications_By_ID_Felid(_CurrentRow);
                    txt_MedicationID.Text =InstantObject. _Felid_Medications.MedicationID.ToString();
                    txt_Medication.Text =InstantObject. _Felid_Medications.MedicationName;
                    ///  InstantObject.ThLoading.Abort_Loading();
                }
            }
            catch
            { //InstantObject.ThLoading.Abort_Loading(); };
            };
        }
        private void TS_Delete_Medication_Click(object sender, EventArgs e)
        {
            if (txt_MedicationID.Text.Trim() == "")
            {
                MessageBox.Show("اختر رقم الدواء", "تحذير", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);


            }
            else
            {
                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    // InstantObject.ThLoading.Open_Loading();
                   InstantObject. _SP_Medications.SP_Delete_Medications_By_ID(Convert.ToInt32(txt_MedicationID.Text));
                    //Fill DVG All
                    Fill_DVG_Browes_All_From_Medications();

                    Clear_Tools();
                    // InstantObject.ThLoading.Abort_Loading();
                }

            }

        }

        private void Clear_Tools()
        {
            txt_MedicationID.Clear();
            txt_Medication.Clear();

        }

        private void TS_Update_Medication_Click(object sender, EventArgs e)
        {
            if (txt_MedicationID.Text.Trim() == "")
            {
                MessageBox.Show("اختر رقم الدواء", "تحذير", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
            }
            else
            {

               InstantObject. _Felid_Medications.MedicationName = txt_Medication.Text;
                try
                {//
                    //  InstantObject.ThLoading.Open_Loading();
                   InstantObject. _SP_Medications.SP_UpDate_Medications_By_ID(InstantObject. _Felid_Medications);
                    Fill_DVG_Browes_All_From_Medications();
                    //InstantObject.ThLoading.Abort_Loading();
                }
                catch (Exception ex)
                {
                    // InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show(ex.Message);

                }
            }

            Clear_Tools();
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

        private void TS_Rrport_All_Click(object sender, EventArgs e)
        {
            //  InstantObject.ThLoading.Open_Loading();
            FrmReport Frm = new FrmReport();
            Frm.ShowReportMedication();
            // InstantObject.ThLoading.Abort_Loading();
            Frm.Show();
        }

        private void TS_ImportExcel_Click(object sender, EventArgs e)
        {
            String path;
            Stream myStream;
            OpenFileDialog openFileDialogExcel = new OpenFileDialog();
            // openFileDialogPicture.InitialDirectory = "C:\\temp\\image.jpg";
            openFileDialogExcel.Filter = "Excel (*.xls)|*.xls";
            openFileDialogExcel.FilterIndex = 2;
            openFileDialogExcel.RestoreDirectory = true;
            if (openFileDialogExcel.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialogExcel.OpenFile()) != null)
                {
                    path = openFileDialogExcel.FileName;
                    try
                    {
                        InstantObject.ImportExcel.ReadDataFromExcelMedicationIntoSqlServer(path, "Medications", "MedicationID"
                                                                                                    , "MedicationName"
                                                                                                    , "Company"
                                                                                                    , "GroupOfRemedial"
                                                                                                    , "Classification"
                                                                                                    , "Page"
                                                                                                    , "MedicalOfConsultation"
                                                                                                    , "AntiOfMedical_Consultation"
                                                                                                    , "Warning"
                                                                                                    , "OverlapOfMedication"
                                                                                                    , "SideOfEffect");
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                    Fill_DVG_Browes_All_From_Medications();
                }
            }





        }
    }
}

