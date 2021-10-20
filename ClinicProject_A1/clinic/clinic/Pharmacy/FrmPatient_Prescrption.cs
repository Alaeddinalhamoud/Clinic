using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Lib_Felid;
using Microsoft.ApplicationBlocks.Data;
using BLL;
using clinic.Classes;

namespace clinic.Pharmacy
{
    public partial class FrmPatient_Prescrption : Form
    {
        public FrmPatient_Prescrption()
        {
            InitializeComponent();
        }
        SP_Patient _SP_Patient = new SP_Patient();
        SP_Visit _SP_Visit = new SP_Visit();
        SP_Prescription _SP_Prescription = new SP_Prescription();

        Felid_Prescription _Felid_Prescription = new Felid_Prescription();

        private void FrmPatient_Prescrption_Load(object sender, EventArgs e)
        {
            TS_P_P.Renderer = new Renderers.WindowsVistaRenderer();
            txt_PatientInher.Text = InstantObject.PatientID.ToString();

            if (Convert.ToInt32(txt_PatientInher.Text)==0)
            {
            this.Cmb_PatientName.SelectedIndexChanged -= new System.EventHandler(this.Cmb_PatientName_SelectedIndexChanged);
            DTP_Pre.Value = DateTime.Now;
            
            Fill_Cmb_Patient();

            Fill_DGV();
            
            Make_ComboBoxes_text_null();
                //Fill_DGV();
            this.Cmb_PatientName.SelectedIndexChanged += new System.EventHandler(this.Cmb_PatientName_SelectedIndexChanged);
            }
            else
            {

                Cmb_PatientName.DisplayMember = "FirstName";
                Cmb_PatientName.ValueMember = "PatientID";
                Cmb_PatientName.DataSource = _SP_Patient.SP_Browes_Patient_FullName_By_ID(Convert.ToInt32(txt_PatientInher.Text));
                DGV_Patient.DataSource =_SP_Prescription.SP_Browes_Prescription_Datials_PatientID(Convert.ToInt32(txt_PatientInher.Text));

            }
        }

        private void Make_ComboBoxes_text_null()
        {
            Cmb_PatientName.Text = "";
            Cmb_VisitID.DataSource  = null;
            txt_PreScription.Clear();

        }

        private void Fill_Cmb_Visit()
        {
            Cmb_VisitID.DisplayMember = "DataOfVisit";
            Cmb_VisitID.ValueMember = "VisitID";
            try
            {
                Cmb_VisitID.DataSource = _SP_Visit.SP_Browes_Visit_Date_By_PatientID(Convert.ToInt32(Cmb_PatientName.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fill_Cmb_Patient()
        {
            Cmb_PatientName.DisplayMember = "FirstName";
            Cmb_PatientName.ValueMember = "PatientID";
            Cmb_PatientName.DataSource = _SP_Patient.SP_Browes_Patient_FullName();
        }

        private void TS_Add_Pre_Click(object sender, EventArgs e)
        {
            if (Cmb_PatientName.Text == "")
            {
                MessageBox.Show("لم تقم باختيار المريض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Cmb_VisitID.Text == "")
            {
                MessageBox.Show("لم تقم باختيار الزيارة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _Felid_Prescription.DateOfPrescription = DTP_Pre.Value;
                _Felid_Prescription.PatientID = Convert.ToInt32(Cmb_PatientName.SelectedValue);
                _Felid_Prescription.VisitID = Convert.ToInt32(Cmb_VisitID.SelectedValue);
                try
                {
               //     InstantObject.ThLoading.Open_Loading();
                    int ID = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.ConnStr, "SP_Insert_Prescription", _Felid_Prescription.DateOfPrescription
                         , _Felid_Prescription.PatientID, _Felid_Prescription.VisitID));
                  
                    Fill_DGV();
                  //  InstantObject.ThLoading.Abort_Loading();

                    FrmPrescription frm = new FrmPrescription();
                    frm.SetPrescriptionID(ID.ToString());
                    frm.SetPatientFullName(Cmb_PatientName.Text);
                                     
                    frm.ShowDialog();

                    MakeToolsEmapty();
               

                }
                catch (Exception ex)
                {
                  //  InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show(ex.Message);
                    Cmb_VisitID.DataSource = null;
                }
            }


        }

        private void TS_UpData_Pre_Click(object sender, EventArgs e)
        {
            if (txt_PreScription.Text == "")
            {
                MessageBox.Show("اختر المريض","تحذير",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (Cmb_PatientName.Text == "")
            {
                MessageBox.Show("اختر المريض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Cmb_VisitID.Text == "")
            {
                MessageBox.Show("لم تقم باختيار الزيارة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
              //  InstantObject.ThLoading.Open_Loading();
                _Felid_Prescription.PrescriptionID = Convert.ToInt32(txt_PreScription.Text);
                _Felid_Prescription.DateOfPrescription = DTP_Pre.Value;
                _Felid_Prescription.PatientID = Convert.ToInt32(Cmb_PatientName.SelectedValue);
                _Felid_Prescription.VisitID = Convert.ToInt32(Cmb_VisitID.SelectedValue);
                _SP_Prescription.SP_UpData_Prescription(_Felid_Prescription);
                Fill_DGV();
                MakeToolsEmapty();
             //   InstantObject.ThLoading.Abort_Loading();
                
            }
        }

        private void TS_Delete_Pre_Click(object sender, EventArgs e)
        {
            if (txt_PreScription.Text.Trim() == "")
            {
                MessageBox.Show("لم تقم بتحديد الوصفة التي ترغب بحذفها", "تحذير", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);


            }
            else
            {
                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    _SP_Prescription.SP_Delete_Prescription(Convert.ToInt32(txt_PreScription.Text));
                    Fill_DGV();
                    MakeToolsEmapty();
                    MessageBox.Show("تمت عملية الحذف");
                }
            }



        }

       

       
        private void Fill_DGV()
        {
            DGV_Patient.DataSource = _SP_Prescription.SP_Browes_Prescription_Datials();
        }

      

       

        private void Cmb_PatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                Fill_Cmb_Visit();
            
        }

        private void TS_Browes_ID_Click(object sender, EventArgs e)
        {
            if (txt_PreScription.Text.Trim() == "")
            {
                MessageBox.Show("لم تقم بتحديد الوصفة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
      
                FrmPrescription frm = new FrmPrescription();
                frm.SetPrescriptionID(txt_PreScription.Text);
                frm.SetPatientFullName(Cmb_PatientName.Text);
                frm.Show();
               
            }
        }

        private void TS_PatientPrecriptions_Click(object sender, EventArgs e)
        {
            DGV_Patient.DataSource = _SP_Prescription.SP_Browes_Prescription_Datials_PatientID(Convert.ToInt32(Cmb_PatientName.SelectedValue));
        }

        private void TS_Back_To_Main_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TS_EmaptyTools_Click(object sender, EventArgs e)
        {
            MakeToolsEmapty();
           
        }

        private void MakeToolsEmapty()
        {
            Fill_Cmb_Patient();
            Fill_DGV();
            Make_ComboBoxes_text_null();
        }

        private void DGV_Patient_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Patient.Rows.Count > 0)
                {
                    int _RowIndex;
                    _RowIndex = DGV_Patient.CurrentCell.RowIndex;
                    int _CurrentRow = Convert.ToInt32(DGV_Patient[0, _RowIndex].Value);
                    _Felid_Prescription = _SP_Prescription.SP_Browes_Prescription_By_ID_Felid(_CurrentRow);
                    txt_PreScription.Text = _Felid_Prescription.PrescriptionID.ToString();
                    DTP_Pre.Value = Convert.ToDateTime(_Felid_Prescription.DateOfPrescription);

                    Cmb_PatientName.DisplayMember = "FirstName";
                    Cmb_PatientName.ValueMember = "PatientID";
                    Cmb_PatientName.DataSource = _SP_Patient.SP_Browes_Patient_FullName_By_ID(_Felid_Prescription.PatientID);

                    Fill_Cmb_Visit();
                    string NameOFVisit = Convert.ToString(DGV_Patient[5, _RowIndex].Value);
                    Cmb_VisitID.Text = NameOFVisit;

                }
            }
            catch { };
        }

       
     

    }
}
