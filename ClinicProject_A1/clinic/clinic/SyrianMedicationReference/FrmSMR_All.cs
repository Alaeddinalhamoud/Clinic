using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clinic.Classes;

namespace clinic.SyrianMedicationReference
{
    public partial class FrmSMR_All : Form
    {
        public FrmSMR_All()
        {
            InitializeComponent();
        }


       

        private void FrmSMR_All_Load(object sender, EventArgs e)
        {
            InstantObject._Felid_Medications = InstantObject._SP_Medications.SP_Browes_Medications_By_ID_Felid(InstantObject.Medcation_ID);
            lbl_MedicationName.Text = InstantObject._Felid_Medications.MedicationName;
            lbl_CompanyName.Text = InstantObject._Felid_Medications.Company;
            txt_AntiOfMedical_Consultation.Text = InstantObject._Felid_Medications.AntiOfMedical_Consultation;
            txt_MedicalOfConsultation.Text = InstantObject._Felid_Medications.MedicalOfConsultation;
            txt_OverlapOfMedication.Text = InstantObject._Felid_Medications.OverlapOfMedication;
            txt_SideOfEffect.Text = InstantObject._Felid_Medications.SideOfEffect;
            txt_Warning.Text = InstantObject._Felid_Medications.Warning;
        }



    }
}
