using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;

using Lib_Felid;


using BLL;
using clinic.Report_Form;
using clinic.Classes;
using System.IO;

namespace clinic.Pharmacy
{
    public partial class FrmPrescription :Form  
    {
        public FrmPrescription()
        {
            InitializeComponent();
        }
        //SP_Prescription _SP_Prescription = new SP_Prescription();
        //SP_Medications _SP_Medications = new SP_Medications();
        //SP_Prescription_Medications _SP_Prescription_Medications = new SP_Prescription_Medications();
        //SP_Precription_Mediction_detalis _SP_Precription_Mediction_detalis = new SP_Precription_Mediction_detalis();
        Felid_Prescription_Medications _Felid_Prescription_Medications = new Felid_Prescription_Medications();
        SP_Prescription_Medications _SP_Prescription_Medications = new SP_Prescription_Medications();
        SP_Prescription _SP_Prescription = new SP_Prescription();
        SP_Medications _SP_Medications = new SP_Medications();

        //Felid_Prescription_Medications _Felid_Prescription_Medications = new Felid_Prescription_Medications();
        //Felid_Prescription_Medications_details _Felid_Prescription_Medications_details = new Felid_Prescription_Medications_details();


     
        private void FrmPrescription_Load(object sender, EventArgs e)
        {
            TS_Presciption.Renderer = new Renderers.WindowsVistaRenderer();
           Fill_DGV_Prescription();
            Fill_Cmb_Medications();

        }

        private void Fill_DGV_Prescription()

        {
            DGV_Prescription_All.DataSource = _SP_Prescription_Medications.SP_Browes_Prescription_Medication_By_PrescriptionID_List(Convert.ToInt32(txt_PrescrptionID.Text));
            
        }

        private void Fill_Cmb_Medications()
        {
            Cmb_Medication.DisplayMember = "MedicationName";
            Cmb_Medication.ValueMember = "MedicationID";
            Cmb_Medication.DataSource = _SP_Medications.SP_Browes_Medications_All();
        }
        public void SetPrescriptionID(string text)
        {
            txt_PrescrptionID.Text = text;
        }


        public void SetPatientFullName(string text)
        {
           lbl_TSS_PatientName.Text = text;
        }



        private void TS_Add_Pre_P_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Medication.Text == "")
                { MessageBox.Show("اختر الدواء"); }
                else if (ImCmb_Cleander_Dose.Text == "")
                { MessageBox.Show("اختر مواعيد الجرعات"); }
                else if (ImCmb_Time.Text == "")
                { MessageBox.Show("اختر وقت الجرعات"); }
                else if (ImCmb_Type.Text == "")
                { MessageBox.Show("اختر شكل العلبة"); }
                else
                {
                    try
                    {

                        _Felid_Prescription_Medications.PrescriptionID = Convert.ToInt32(txt_PrescrptionID.Text);
                        _Felid_Prescription_Medications.MedicationID = Convert.ToInt32(Cmb_Medication.SelectedValue);
                        _Felid_Prescription_Medications.Dose = Convert.ToInt32(Num_Dose.Value);
                        _Felid_Prescription_Medications.MedicalCount = Convert.ToInt32(Num_MedicalCount.Value);
                        _Felid_Prescription_Medications.Cleander_Of_Dose = ImCmb_Cleander_Dose.Text;
                        _Felid_Prescription_Medications.Type_Of_Medication = ImCmb_Type.Text;
                        _Felid_Prescription_Medications.Time_Of_Dose = ImCmb_Time.Text;
                        _Felid_Prescription_Medications.Note = txt_Note.Text;
                    //    InstantObject.ThLoading.Open_Loading();
                        _SP_Prescription_Medications.SP_Insert_Prescription_Medication(_Felid_Prescription_Medications);
                        Fill_DGV_Prescription();

                        Clear_Tools();
                      //  InstantObject.ThLoading.Abort_Loading();
                    }
                    catch (Exception ex)
                    {
                      //  InstantObject.ThLoading.Abort_Loading();
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            catch { //InstantObject.ThLoading.Abort_Loading();
            };
        }

        private void Clear_Tools()
        {
           txt_Note.Clear();
            Num_MedicalCount.Value = 1;
            Num_Dose.Value = 1;
            ImCmb_Time.Text = "";
            ImCmb_Cleander_Dose.Text = "";
            ImCmb_Type.Text = "";

        }

        private void TS_UpDate_Pre_Click(object sender, EventArgs e)
        {
            try
            {
            if (Cmb_Medication.Text == "")
            { MessageBox.Show("اختر الدواء"); }
            else if (ImCmb_Cleander_Dose.Text == "")
            { MessageBox.Show("اختر مواعيد الجرعات"); }
            else if (ImCmb_Time.Text == "")
            { MessageBox.Show("اختر وقت الجرعات"); }
            else if (ImCmb_Type.Text == "")
            { MessageBox.Show("اختر شكل العلبة"); }
            else
            {
                try
                {

            _Felid_Prescription_Medications.PrescriptionID = Convert.ToInt32(txt_PrescrptionID.Text);
            _Felid_Prescription_Medications.MedicationID = Convert.ToInt32(Cmb_Medication.SelectedValue);
            _Felid_Prescription_Medications.Dose = Convert.ToInt32(Num_Dose.Value);
            _Felid_Prescription_Medications.MedicalCount = Convert.ToInt32(Num_MedicalCount.Value);
            _Felid_Prescription_Medications.Cleander_Of_Dose = ImCmb_Cleander_Dose.Text;
            _Felid_Prescription_Medications.Type_Of_Medication = ImCmb_Type.Text;
            _Felid_Prescription_Medications.Time_Of_Dose = ImCmb_Time.Text;
            _Felid_Prescription_Medications.Note = txt_Note.Text;
         //   InstantObject.ThLoading.Open_Loading();
            _SP_Prescription_Medications.SP_UpDate_Prescription_Medication (_Felid_Prescription_Medications);
            Fill_DGV_Prescription();
            Clear_Tools();
         //   InstantObject.ThLoading.Abort_Loading();
                }
                catch (Exception ex) 
                {
                   // InstantObject.ThLoading.Abort_Loading(); 
                    MessageBox.Show(ex.Message); 
                }

            }
              }
            catch { //InstantObject.ThLoading.Abort_Loading();
            };
                }

        private void TS_Back_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void TS_Delete_Pre_Click(object sender, EventArgs e)
        {
            if (txt_PrescrptionID.Text.Trim()=="")
            {
                MessageBox.Show("لم تقم بتحديد الوصفة التي ترغب بحذفها", "تحذير", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);


            }
            else
            {
                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                   // InstantObject.ThLoading.Open_Loading();
                    _SP_Prescription_Medications.SP_Delete_Prescription_Medication(Convert.ToInt32(Cmb_Medication.SelectedValue));
                    Fill_DGV_Prescription();
                    Clear_Tools();
                   // InstantObject.ThLoading.Abort_Loading();
                }
            }
        }

        private void DGV_Prescription_All_Click(object sender, EventArgs e)
        {
           
        }

        private void TS_Repo_Pre_Click(object sender, EventArgs e)
        {

            byte[] ImageP = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + @"\\Image_Path\\Logo\\LogoWhite.JPG");
         //   InstantObject.ThLoading.Open_Loading();
            FrmReport Frm = new FrmReport();
            Frm.ReportPrscriptionPatient(Convert.ToInt32(txt_PrescrptionID.Text), ImageP);
            //InstantObject.ThLoading.Abort_Loading();
            Frm.Show();
        }

        private void DGV_Prescription_All_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Prescription_All.Rows.Count > 0)
                {
                    //  InstantObject.ThLoading.Open_Loading();
                    //Method For Fill Tools at Patient
                    int _RowIndex;
                    _RowIndex = DGV_Prescription_All.CurrentCell.RowIndex;
                    int _CurrentRow = Convert.ToInt32(DGV_Prescription_All[1, _RowIndex].Value);
                    _Felid_Prescription_Medications = _SP_Prescription_Medications.SP_Browes_Prescription_Medication_By_PrescriptionID_Felid(_CurrentRow);

                    //Cmb_Medication.DisplayMember = "MedicationName";
                    //Cmb_Medication.ValueMember = "MedicationID";
                    //Cmb_Medication.DataSource = _SP_Medications.SP_Browes_Medications_By_ID(_Felid_Prescription_Medications.MedicationID);
                    Fill_Cmb_Medications();
                    string NameOfMedication = Convert.ToString(DGV_Prescription_All[2, _RowIndex].Value);
                    Cmb_Medication.Text = NameOfMedication;

                    Num_Dose.Value = _Felid_Prescription_Medications.Dose;
                    Num_MedicalCount.Value = _Felid_Prescription_Medications.MedicalCount;
                    ImCmb_Cleander_Dose.Text = _Felid_Prescription_Medications.Cleander_Of_Dose;
                    ImCmb_Type.Text = _Felid_Prescription_Medications.Type_Of_Medication;
                    ImCmb_Time.Text = _Felid_Prescription_Medications.Time_Of_Dose;
                    txt_Note.Text = _Felid_Prescription_Medications.Note;

                    // InstantObject.ThLoading.Abort_Loading();
                }
            }
            catch
            { //InstantObject.ThLoading.Abort_Loading(); };
            };
        }

    
    }
}
