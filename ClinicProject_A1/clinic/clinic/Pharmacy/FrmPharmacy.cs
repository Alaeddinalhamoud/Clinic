using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clinic.Classes;
using clinic.SyrianMedicationReference;

namespace clinic.Pharmacy
{
    public partial class FrmPharmacy : Form
    {
        public FrmPharmacy()
        {
            InitializeComponent();
        }

        //timer.Start();
        ////////Here Code
        //timer.Stop();

        //    //طباعة ملخص عملية البحث
        //    tssLblResultNumber.Text = "عدد النتائج: " + dgvSearchResults.Rows.Count;
        //    tssLblLeftTime.Text = "الوقت المستغرق: " + (float)timer.Duration + " ثانية";

        private void FrmPharmacy_Load(object sender, EventArgs e)
        {
           DGV_Search_Pharmecy.DataSource= InstantObject._SP_Medications.SP_Browes_Medications_All();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {

                MessageBox.Show("لم تقم بإدخال " + lbl_Search_by.Text, "تحذير", MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);
            }
            else
            {
                if (RB_Name.Checked == true)
                {
                    DGV_Search_Pharmecy.DataSource=InstantObject._SP_Medications.SP_Browes_Pharmacy_By_Medication_Name(txt_Search.Text);

                }
                else if (RB_Company.Checked == true)
                {
                    DGV_Search_Pharmecy.DataSource = InstantObject._SP_Medications.SP_Browes_Pharmacy_By_Company_Name(txt_Search.Text);
                }
                else if (RB_SideOfEffect.Checked == true)
                {
                    DGV_Search_Pharmecy.DataSource = InstantObject._SP_Medications.SP_Browes_Pharmacy_By_SideEffect(txt_Search.Text);
                }
                else if (RB_MedicalOfConsultation.Checked == true)
                {
                    DGV_Search_Pharmecy.DataSource = InstantObject._SP_Medications.SP_Browes_Pharmacy_By_MedicalOfConsultation(txt_Search.Text);
                }
                else
                {
                    DGV_Search_Pharmecy.DataSource = InstantObject._SP_Medications.SP_Browes_Pharmacy_By_OverlapOfMedication(txt_Search.Text);
                }
            }
          



           
        }

        private void RB_Name_CheckedChanged(object sender, EventArgs e)
        {
            txt_Search.Clear();
            lbl_Search_by.Text = RB_Name.Text;
            txt_Search.Focus();
        }

        private void RB_Company_CheckedChanged(object sender, EventArgs e)
        {
            txt_Search.Clear();
            lbl_Search_by.Text = RB_Company.Text;
            txt_Search.Focus();
        }

        private void RB_SideOfEffect_CheckedChanged(object sender, EventArgs e)
        {
            txt_Search.Clear();
            lbl_Search_by.Text = RB_SideOfEffect.Text;
            txt_Search.Focus();
        }

        private void RB_MedicalOfConsultation_CheckedChanged(object sender, EventArgs e)
        {
            txt_Search.Clear();
            lbl_Search_by.Text = RB_MedicalOfConsultation.Text;
            txt_Search.Focus();
        }

        private void RB_OverlapOfMedication_CheckedChanged(object sender, EventArgs e)
        {
            txt_Search.Clear();
            lbl_Search_by.Text = RB_OverlapOfMedication.Text;
            txt_Search.Focus();
        }

        private void DGV_Search_Pharmecy_DoubleClick(object sender, EventArgs e)
        {
            if (DGV_Search_Pharmecy.Rows.Count > 0)
            {
                int _RowIndex;
                _RowIndex = DGV_Search_Pharmecy.CurrentCell.RowIndex;
                object _CurrentRow = DGV_Search_Pharmecy[0, _RowIndex];
                int _Value_Current_Row = Convert.ToInt32(DGV_Search_Pharmecy[0, _RowIndex].Value);
                InstantObject.Medcation_ID = _Value_Current_Row;
                FrmSMR_All frm = new FrmSMR_All();
                frm.ShowDialog();
            }
        }
    }
}
