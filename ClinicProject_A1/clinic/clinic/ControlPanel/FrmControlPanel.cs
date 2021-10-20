using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clinic.Analysis;
using clinic.RadioType;
using clinic.Operation;
using clinic.pharmacy;
using clinic.ClinicData;
using clinic.FrmStamp;
using clinic.FrmAccident;

namespace clinic.ControlPanel
{
    public partial class FrmControlPanel : Form
    {
        public FrmControlPanel()
        {
            InitializeComponent();
        }

        private void PIC_AnalysisType_Click(object sender, EventArgs e)
        {
            OpenFormAnalysisType();
        }

        private static void OpenFormAnalysisType()
        {
            FrmAnalysisType Frm = new FrmAnalysisType();

            Frm.Show();
        }

        private void PIC_RadioType_Click(object sender, EventArgs e)
        {
            OpenFromRadioType();
        }

        private static void OpenFromRadioType()
        {
            FrmRadioType Frm = new FrmRadioType();

            Frm.Show();
        }

        private void PIC_DiseaseType_Click(object sender, EventArgs e)
        {
            OpenFormDiseaseType();
        }

        private static void OpenFormDiseaseType()
        {
            FrmDisease Frm = new FrmDisease();


            Frm.Show();
        }

        private void lbl_OperationType_Click(object sender, EventArgs e)
        {
            OpenFormOperationType();
        }

        private static void OpenFormOperationType()
        {
            FrmOperationType Frm = new FrmOperationType();


            Frm.Show();
        }

        private void lbl_Pharmacy_Click(object sender, EventArgs e)
        {
            OpenFormPharmacy();
        }

        private static void OpenFormPharmacy()
        {
            FrmMedication Frm = new FrmMedication();


            Frm.Show();
        }

        private void PIC_ClinicData_Click(object sender, EventArgs e)
        {
            OpenFromClinicData();
        }

        private static void OpenFromClinicData()
        {
            FrmClinicData Frm = new FrmClinicData();

            Frm.Show();
        }

        private void PIC_OperationType_Click(object sender, EventArgs e)
        {
            OpenFormOperationType();
        }

        private void lbl_ClinicData_Click(object sender, EventArgs e)
        {
            OpenFromClinicData();
        }

        private void PIC_Pharmacy_Click(object sender, EventArgs e)
        {
            OpenFormPharmacy();
        }

        private void lbl_DiseaseType_Click(object sender, EventArgs e)
        {
            OpenFormDiseaseType();
        }

        private void lbl_RdaioType_Click(object sender, EventArgs e)
        {
            OpenFromRadioType();
        }

        private void lbl_AnalysisType_Click(object sender, EventArgs e)
        {
            OpenFormAnalysisType();
        }

        private void PIC_StampType_Click(object sender, EventArgs e)
        {
            OpenFormStampType();
        }

        private static void OpenFormStampType()
        {
            FrmStamptype Frm = new FrmStamptype();
            Frm.Show();
        }

        private void Lbl_FrmStamp_Click(object sender, EventArgs e)
        {
            OpenFormStampType();
        }

        private void Lbl_AccidentType_Click(object sender, EventArgs e)
        {
            OpenFormAccidentType();
        }

        private static void OpenFormAccidentType()
        {
            FrmAccidentType Frm = new FrmAccidentType();
            Frm.Show();
        }

        private void PIC_AccidentType_Click(object sender, EventArgs e)
        {
            OpenFormAccidentType();
        }
    }
}
