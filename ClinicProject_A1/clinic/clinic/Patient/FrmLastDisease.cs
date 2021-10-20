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
using BLL;
using clinic.Classes;


namespace clinic.Patient
{
    public partial class FrmLastDisease : Form
    {
        public FrmLastDisease()
        {
            InitializeComponent();
        }

        //SP Last Disease 
        SP_Patient_LastDisease _SP_LastDisease = new SP_Patient_LastDisease();
        SP_Patient _SP_Patient = new SP_Patient();
        SP_Disease _SP_Disease = new SP_Disease();
        SP_Patient_LastDisease __SP_LastDisease_details = new SP_Patient_LastDisease();
     
        //For Felid
        Felid_Patient_LastDisease _Felid_LastDisease = new Felid_Patient_LastDisease();
        Felid_Patient _Felid_Patient = new Felid_Patient();
        Felid_Disease _Felid_Disease = new Felid_Disease();




        private void FrmLastDisease_Load(object sender, EventArgs e)
        {
            TS_LastDisease.Renderer = new Renderers.WindowsVistaRenderer();

            //DGV_LastDisease_All.Rows[0].Selected = true;
            Fill_DGV_All();
            Fill_Cmb_Disa();
            Fill_Pateint_Name_cmb();
           
        }

        private void Fill_Pateint_Name_cmb()
        {
            Cmb_Patient_Full.ValueMember = "PatientID";
            Cmb_Patient_Full.DisplayMember = "FirstName";
            Cmb_Patient_Full.DataSource = _SP_Patient.SP_Browes_Patient_FullName();
        }

        private void Fill_Cmb_Disa()
        {
            Cmb_DiseaseID.DisplayMember = "DiseaseName";
            Cmb_DiseaseID.ValueMember = "DiseaseID";
            Cmb_DiseaseID.DataSource = _SP_Disease.SP_Browes_Disease_All();
        }

        private void Fill_DGV_All()
        {
            DGV_LastDisease_All.DataSource = _SP_LastDisease.SP_Browes_LastDisease_details();
        }

        private void TS_Add_LastDisease_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Patient_Full.Text == "")
                {
                    MessageBox.Show("أختر المريض");
                }
                else
                {
                    _Felid_LastDisease.PatientID = Convert.ToInt32(Cmb_Patient_Full.SelectedValue);
                    _Felid_LastDisease.DiseaseID = Convert.ToInt32(Cmb_DiseaseID.SelectedValue);
                    _Felid_LastDisease.FamilyDisease = CKB_FamilyDisease.Checked;
                    _Felid_LastDisease.DateOfDisease = DPK_DateOfDiesase.Value;

                 //   InstantObject.ThLoading.Open_Loading();
                    _SP_LastDisease.SP_Insert_Patient_LastDisease(_Felid_LastDisease);

                    Fill_DGV_All();
                    Fill_Cmb_Disa();
                    Fill_Pateint_Name_cmb();
                    Clear_Tool();
                  //  InstantObject.ThLoading.Abort_Loading();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void TS_UpData_LastDisease_Click(object sender, EventArgs e)
        {
            try
            {
            if (Cmb_Patient_Full.Text == "")
            {
                MessageBox.Show("أختر المريض");
            }
            else
            {
                _Felid_LastDisease.PatientID = Convert.ToInt32(Cmb_Patient_Full.SelectedValue);
                _Felid_LastDisease.DiseaseID = Convert.ToInt32(Cmb_DiseaseID.SelectedValue);
                _Felid_LastDisease.LastDiseaseID = Convert.ToInt32(txt_LastDiseaseID.Text);
                _Felid_LastDisease.FamilyDisease = CKB_FamilyDisease.Checked;
                _Felid_LastDisease.DateOfDisease = DPK_DateOfDiesase.Value;
               /// InstantObject.ThLoading.Open_Loading();
                _SP_LastDisease.SP_UpData_Patient_LastDisease(_Felid_LastDisease);
                Fill_DGV_All();
                Fill_Cmb_Disa();
                Fill_Pateint_Name_cmb();
                Clear_Tool();
              //  InstantObject.ThLoading.Abort_Loading();

            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }
        private void TS_Delete_LastDisease_Click(object sender, EventArgs e)
        {
            if (txt_LastDiseaseID.Text.Trim() == "")
            {
                MessageBox.Show("لم تقم باختيار المرض السابق",
                                        "تحذير",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
            }



            else
            {
                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                //  /  InstantObject.ThLoading.Open_Loading();
                    _SP_LastDisease.SP_Delete_Patient_LastDisease(Convert.ToInt32(txt_LastDiseaseID.Text));
                    Fill_DGV_All();
                    Fill_Cmb_Disa();
                    Fill_Pateint_Name_cmb();
                    Clear_Tool();
                  //  InstantObject.ThLoading.Abort_Loading();
                }
            }
        }

        private void Clear_Tool()
        {
            txt_LastDiseaseID.Clear();
            Cmb_DiseaseID.Text = "";
            Cmb_Patient_Full.Text = "";
        }

        private void DGV_LastDisease_All_Click(object sender, EventArgs e)
        {
            try
            {
              //  InstantObject.ThLoading.Open_Loading();

                if (DGV_LastDisease_All.Rows.Count > 0)
                {
                    int _RowIndex;
                    _RowIndex = DGV_LastDisease_All.CurrentCell.RowIndex;
                    int _CurrentRow = Convert.ToInt32(DGV_LastDisease_All[0, _RowIndex].Value);
                    _Felid_LastDisease = _SP_LastDisease.SP_Browes_Patient_LastDisease_By_ID_Felid(_CurrentRow);
                    Cmb_Patient_Full.ValueMember = "PatientID";
                    Cmb_Patient_Full.DisplayMember = "FirstName";
                    Cmb_Patient_Full.DataSource = _SP_Patient.SP_Browes_Patient_FullName_By_ID(_Felid_LastDisease.PatientID);
                    //Cmb_Patient_Full.SelectedItem = Cmb_Patient_Full.Items[_Felid_Patient.PatientID];
                    Fill_Cmb_Disa();
                    string NameOfDisease = Convert.ToString(DGV_LastDisease_All[3, _RowIndex].Value);
                    Cmb_DiseaseID.Text = NameOfDisease;
                    //Cmb_DiseaseID.SelectedItem = Cmb_DiseaseID.Items[_Felid_Disease.DiseaseID];
                    txt_LastDiseaseID.Text = _Felid_LastDisease.LastDiseaseID.ToString();
                    bool CheckedFamilyDisease = Convert.ToBoolean(DGV_LastDisease_All[5, _RowIndex].Value);
                    CKB_FamilyDisease.Checked = CheckedFamilyDisease;
                    DPK_DateOfDiesase.Value = Convert.ToDateTime(_Felid_LastDisease.DateOfDisease);
                }

               // InstantObject.ThLoading.Abort_Loading();
            }
           catch{
               //InstantObject.ThLoading.Abort_Loading();
           };

        }

        private void TS_emptyTools_Click(object sender, EventArgs e)
        {
            Fill_DGV_All();
            Fill_Cmb_Disa();
            Fill_Pateint_Name_cmb();
            CKB_FamilyDisease.Checked = false;

        }

        private void TS_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       

    }
}
