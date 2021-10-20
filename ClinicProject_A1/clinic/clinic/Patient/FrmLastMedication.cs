using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Lib_Felid.Patient;
using Lib_Felid;
using BLL;
using clinic.Classes;


namespace clinic.Patient
{
    public partial class FrmLastMedication : Form
    {
        public FrmLastMedication()
        {
            InitializeComponent();
        }
        //SP LastMedication 
        SP_Patient_LastMedication _SP_LastMedication = new SP_Patient_LastMedication();
        SP_Patient _SP_Patient = new SP_Patient();
        SP_Medications _SP_Medication = new SP_Medications();
       //SP_LastMedication_details _SP_LastMedication_details = new SP_LastMedication_details();
        //Felid
        Felid_Patient _Felid_Patient = new Felid_Patient();
        Felid_Patient_LastMedication _Felid_LastMedication = new Felid_Patient_LastMedication();
        Felid_Medications _Felid_Medications = new Felid_Medications();
        private void FrmLastMedication_Load(object sender, EventArgs e)
        {
            TS_LastMedication.Renderer = new Renderers.WindowsVistaRenderer();

            Fill_LastMedication_cmb();
            Fill_Patient_cmb();
           // DGV_LastMedication.AutoGenerateColumns = false;
            Fill_DGV_All();
            Clear_Tools();
        }

        private void Fill_Patient_cmb()
        {
            Cmb_Patient_All.ValueMember = "PatientID";
            Cmb_Patient_All.DisplayMember = "FirstName";
            Cmb_Patient_All.DataSource = _SP_Patient.SP_Browes_Patient_FullName();
        }

        private void Fill_LastMedication_cmb()
        {
            Cmb_MedcationID.DisplayMember = "MedicationName";
            Cmb_MedcationID.ValueMember = "MedicationID";
            Cmb_MedcationID.DataSource = _SP_Medication.SP_Browes_Medications_All();
        }

        private void Fill_DGV_All()
        {
            DGV_LastMedication.DataSource = _SP_LastMedication.SP_Browes_LastMedication_details();
        }
       
       

        private void Clear_Tools()
        {
            txt_LastMedicationID.Clear();

            Cmb_MedcationID.Text = "";
            Cmb_Patient_All.Text = "";
        }

        private void DGV_LastMedication_Click(object sender, EventArgs e)
        {
            try
            {

                if (DGV_LastMedication.Rows.Count > 0)
                {
                    int _RowIndex;
                    _RowIndex = DGV_LastMedication.CurrentCell.RowIndex;

                    int _CurrentRow = Convert.ToInt32(DGV_LastMedication[0, _RowIndex].Value);

                    _Felid_LastMedication = _SP_LastMedication.SP_Browes_Patient_LastMedication_By_ID_Felid(_CurrentRow);



                    Cmb_Patient_All.ValueMember = "PatientID";
                    Cmb_Patient_All.DisplayMember = "FirstName";
                    Cmb_Patient_All.DataSource = _SP_Patient.SP_Browes_Patient_FullName_By_ID(_Felid_LastMedication.PatientID);
                    //Cmb_Patient_All.SelectedItem = Cmb_Patient_All.Items[_Felid_Patient.PatientID];
                    Fill_LastMedication_cmb();
                    string NameOfLastMedication = Convert.ToString(DGV_LastMedication[3, _RowIndex].Value);
                    Cmb_MedcationID.Text = NameOfLastMedication;
                    //Cmb_MedcationID.SelectedItem = Cmb_MedcationID.Items[_Felid_Medications.MedicationID];
                    txt_LastMedicationID.Text = _Felid_LastMedication.LastMedicationID.ToString();
                    DPR_DateOfMedication.Value = Convert.ToDateTime(_Felid_LastMedication.DateOfMedication);

                }

            }
            catch { };
          
        }

        private void TS_Add_LastMedication_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Patient_All.Text == "")
                { MessageBox.Show("اختر المريض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else if (Cmb_MedcationID.Text == "")
                { MessageBox.Show("اختر الدواء", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    _Felid_LastMedication.PatientID = Convert.ToInt32(Cmb_Patient_All.SelectedValue);
                    _Felid_LastMedication.MedicationID = Convert.ToInt32(Cmb_MedcationID.SelectedValue);
                    _Felid_LastMedication.DateOfMedication = Convert.ToDateTime(DPR_DateOfMedication.Value);
                    //    InstantObject.ThLoading.Open_Loading();
                    _SP_LastMedication.SP_Insert_Patient_LastMedication(_Felid_LastMedication);

                    Fill_DGV_All();
                    Fill_LastMedication_cmb();
                    Fill_Patient_cmb();
                    //   InstantObject.ThLoading.Abort_Loading();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };

        }

        private void TS_UpData_LastMedication_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_LastMedicationID.Text == "")
                { MessageBox.Show("اختر المريض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    _Felid_LastMedication.PatientID = Convert.ToInt32(Cmb_Patient_All.SelectedValue);
                    _Felid_LastMedication.MedicationID = Convert.ToInt32(Cmb_MedcationID.SelectedValue);
                    _Felid_LastMedication.LastMedicationID = Convert.ToInt32(txt_LastMedicationID.Text);
                    _Felid_LastMedication.DateOfMedication = DPR_DateOfMedication.Value;
                    // InstantObject.ThLoading.Open_Loading();
                    _SP_LastMedication.SP_UpData_Patient_LastMedication_By_ID(_Felid_LastMedication);

                    Fill_DGV_All();
                    Fill_LastMedication_cmb();
                    Fill_Patient_cmb();
                    //  InstantObject.ThLoading.Abort_Loading();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }
        private void TS_Delete_LastMedication_Click_1(object sender, EventArgs e)
        {
            if (txt_LastMedicationID.Text.Trim() == "")
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
                   // InstantObject.ThLoading.Open_Loading();
                    _SP_LastMedication.SP_Delete_Patient_LastMedication_By_ID(Convert.ToInt32(txt_LastMedicationID.Text));
                    //For Fill New Result
                    Fill_DGV_All();
                    Fill_LastMedication_cmb();
                    Fill_Patient_cmb();
                    Clear_Tools();
                  //  InstantObject.ThLoading.Abort_Loading();

                }
            }

        }

        private void TS_Emaptytools_Click(object sender, EventArgs e)
        {
            Fill_LastMedication_cmb();
            Fill_Patient_cmb();
            Clear_Tools();
        }

        private void TS_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       

      

       

        


    }
}



