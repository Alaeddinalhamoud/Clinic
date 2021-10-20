using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clinic.Patient;
using clinic.pharmacy;
using clinic.Operation;
using clinic.Analysis;
using clinic.RadioType;
using clinic.Visit;
using clinic.Appointment;
using clinic.Invoice;
using clinic.Radio;
using clinic.ClinicData;
using clinic.Pharmacy;
using clinic.Classes;
using clinic.Bakeup;
using clinic.FrmAboutUS;
using System.Threading;
using clinic.Security;
using clinic.ControlPanel;
using TumbnailDotnet;
using Webcam_Test;
using clinic.SyrianMedicationReference;

namespace clinic
{
    public partial class FrmMain : Form
    {
        private FormResult _DialogFormResult;

        public FormResult DialogFormResult
        {
            get { return _DialogFormResult; }
            set { _DialogFormResult = value; }
        }

        public enum FormResult : int
        {
            None = 0,
            LogOff = 1,
            Exit = 2
        }
        public FrmMain()
        {
            InitializeComponent();
            
        }
        

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
          
            TS_UserName.Text = InstantObject.UserName;
            
            InstantObject._Felid_Permission = InstantObject._SP_Permission.SP_Browes_Permission_ByUserID_Felid(InstantObject.UserID);
            GetPermissionUser();
           
           

            notify.ShowBalloonTip(3000, "Futuer Clinic Version: Demo", " المستحدم الحالي:" + Convert.ToString(InstantObject.UserName), ToolTipIcon.Info);

            
        }

        private void GetPermissionUser()
        {
            InstantObject._Felid_Permission = InstantObject._SP_Permission.SP_Browes_Permission_ByUserID_Felid(InstantObject.UserID);

            PatientMenu.Enabled = InstantObject._Felid_Permission.PatientMenu;
            filePatientToolStripMenuItem.Enabled = InstantObject._Felid_Permission.CHB_FilePatient;
            //klblpatinet.Enabled = InstantObject._Felid_Permission.CHB_FilePatient;
            operationToolStripMenuItem.Enabled= InstantObject._Felid_Permission.CHB_OperationOfPatient;
            lastDiseaseToolStripMenuItem.Enabled  = InstantObject._Felid_Permission.CHB_lastDisease;
            frmLastMedicationToolStripMenuItem.Enabled  = InstantObject._Felid_Permission.CHB_LastMedication;
            visitToolStripMenuItem .Enabled = InstantObject._Felid_Permission.CHB_Visit;
          //  klblVisit.Enabled = InstantObject._Felid_Permission.CHB_Visit;
            AnalysisMeun.Enabled  = InstantObject._Felid_Permission.AnalysisMeun;
            analysisToolStripMenuItem1 .Enabled = InstantObject._Felid_Permission.CHB_Analysis;
            frmRadioToolStripMenuItem .Enabled = InstantObject._Felid_Permission.CHB_Radio;
            InvoiceMeun .Enabled = InstantObject._Felid_Permission.InvoiceMeun;
            MS_Invoice.Enabled  = InstantObject._Felid_Permission.CHB_Invoice;
            ToolsMeun.Enabled  = InstantObject._Felid_Permission.ToolsMeun;
            ControlMeun .Enabled = InstantObject._Felid_Permission.CHB_ControlPanel;
            TS_Camera.Enabled = InstantObject._Felid_Permission.CHB_CameraWatiching;
            ImageViewer.Enabled = InstantObject._Felid_Permission.CHB_BrowesImage;
            TS_AdminControlPanal.Enabled  = InstantObject._Felid_Permission.CHB_AdminControlPanal;
            TS_UserContolPanel.Enabled  = InstantObject._Felid_Permission.CHB_UserContolPanel;
            TS_Bakup .Enabled= InstantObject._Felid_Permission.CHB_BackUp;
            AppointmentMeun.Enabled = InstantObject._Felid_Permission.AppointmentMeun;
            frmAppointmentToolStripMenuItem.Enabled  = InstantObject._Felid_Permission.CHB_Appointment;
            PrescriptionMeun.Enabled = InstantObject._Felid_Permission.PrescriptionMeun;
           // klblPrescrption.Enabled = InstantObject._Felid_Permission.PrescriptionMeun;
            frmPrescriptionToolStripMenuItem.Enabled = InstantObject._Felid_Permission.CHB_Prescription;
            //ToolBar
            MU_Appoentent.Enabled = InstantObject._Felid_Permission.CHB_Appointment;
            TSS_Patient.Enabled = InstantObject._Felid_Permission.CHB_FilePatient;
            Mu_Visit.Enabled = InstantObject._Felid_Permission.CHB_Visit;
            TS_Analysis_MAin.Enabled = InstantObject._Felid_Permission.CHB_Analysis;
            TS_Radio_Main.Enabled = InstantObject._Felid_Permission.CHB_Radio;
            Mu_Prescrption.Enabled = InstantObject._Felid_Permission.CHB_Prescription;
            Mu_Invoice.Enabled = InstantObject._Felid_Permission.CHB_Invoice;
           // linkLabel1.Enabled = InstantObject._Felid_Permission.CHB_Invoice;
        }

        private void lblClock()
        {
            TS_Clock.Text = DateTime.Now.ToString();
        }

        

        private void frmPatientToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
            FrmPatient Frm = new FrmPatient();
            Frm.MdiParent = this;
            Frm.Show();
          
        }

        private void frmDiseaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedication Frm = new FrmMedication();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void frmDiseaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDisease Frm = new FrmDisease();
            Frm.MdiParent = this;
            Frm .Show();
        }

        private void frmOperationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperationType Frm = new FrmOperationType();
            Frm.MdiParent = this;
            Frm.Show();
        }

       

        private void frmAnalysisTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmAnalysisType Frm = new FrmAnalysisType();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void frmRadioTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRadioType Frm = new FrmRadioType();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void frmLastDiseaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLastDisease Frm = new FrmLastDisease();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void filePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FrmPatient Frm = new FrmPatient();
            Frm.MdiParent = this;
            Frm.GetSecurityForLastInfo(InstantObject._Felid_Permission.CHB_LastMedication, InstantObject._Felid_Permission.CHB_lastDisease, InstantObject._Felid_Permission.CHB_OperationOfPatient);

            Frm.Show();
          
        }

        private void operationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Operation_Patient Frm = new Frm_Operation_Patient();
            Frm.MdiParent = this;
            Frm.Show();
        }

      
        private void lastDiseaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLastDisease Frm = new FrmLastDisease();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void frmLastMedicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLastMedication Frm = new FrmLastMedication();

            Frm.MdiParent = this;
            Frm.Show();
        }

        private void visitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisit Frm = new FrmVisit();

            Frm.MdiParent = this;
            Frm.Show();
        }

       
        
       

        private void frmAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAppointment Frm = new FrmAppointment();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void frmInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInvoice Frm = new FrmInvoice();
            Frm.MdiParent = this;
            Frm.Show();

        }

        private void analysisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAnalysis Frm = new FrmAnalysis();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void frmRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRadio Frm = new FrmRadio();
            Frm.MdiParent = this;
            Frm.Show();
        }

        

        private void frmPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPatient_Prescrption Frm = new FrmPatient_Prescrption();
            Frm.MdiParent = this;
            Frm.Show();
        }

       

       

        private void MS_Exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل انت متاكد من الخروج","خروج",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
            System.Environment.Exit(0);
            }

            else
            {
                return;
            }
        }

        private void TS_MakeBakup_Click(object sender, EventArgs e)
        {
            frmTakeBackup Frm = new frmTakeBackup();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void TS_RestporBAckup_Click(object sender, EventArgs e)
        {
            FrmRestoreDatabase Frm = new FrmRestoreDatabase();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void TSS_Patient_Click(object sender, EventArgs e)
        {
            FrmPatient Frm = new FrmPatient();
            Frm.MdiParent = this;
            Frm.GetSecurityForLastInfo(InstantObject._Felid_Permission.CHB_LastMedication, InstantObject._Felid_Permission.CHB_lastDisease, InstantObject._Felid_Permission.CHB_OperationOfPatient);
            Frm.Show();
            
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock();
        }

        private void Mu_Visit_Click(object sender, EventArgs e)
        {
            FrmVisit Frm = new FrmVisit();

            Frm.MdiParent = this;
            Frm.Show();
        }

        private void Mu_Invoice_Click(object sender, EventArgs e)
        {
            FrmInvoice Frm = new FrmInvoice();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void Mu_Prescrption_Click(object sender, EventArgs e)
        {
            FrmPatient_Prescrption Frm = new FrmPatient_Prescrption();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void MU_Appoentent_Click(object sender, EventArgs e)
        {
            FrmAppointment Frm = new FrmAppointment();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void TS_Analysis_MAin_Click(object sender, EventArgs e)
        {
            FrmAnalysis Frm = new FrmAnalysis();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void TS_Radio_Main_Click(object sender, EventArgs e)
        {
            FrmRadio Frm = new FrmRadio();
            Frm.MdiParent = this;
            Frm.Show();
        }

       

        private void EXit_Main_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من الخروج", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }

            else
            {
                return;
            }
        }

        private void TS_AboutOus_Click(object sender, EventArgs e)
        {
            Aboutus frm = new Aboutus();
            frm.MdiParent = this;
            frm.Show();
        }

      




     
        private void TS_AdminControlPanal_Click(object sender, EventArgs e)
        {
            FrmAdmin Frm = new FrmAdmin();
           Frm.MdiParent = this;
            Frm.Show();
        }

        private void TS_UserContolPanel_Click(object sender, EventArgs e)
        {
            FrmUser Frm = new FrmUser();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void TS_ChangeUser_Click(object sender, EventArgs e)
        {

            this.DialogFormResult = FormResult.LogOff;
            this.Close();
            
            
            
           
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (MessageBox.Show("هل انت متاكد من الخروج", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{
            //    System.Environment.Exit(0);
            //}

            //else
            //{
            //    return;
            //}
        }

      
        
        
        

        private void ControlMeun_Click(object sender, EventArgs e)
        {
            FrmControlPanel Frm = new FrmControlPanel();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void TS_Help_Click(object sender, EventArgs e)
        {
            OpenFormHelp();
        }

        private void OpenFormHelp()
        {
            FrmHelp Frm = new FrmHelp();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void TS_HelpsOUS_Click(object sender, EventArgs e)
        {
            OpenFormHelp();
        }

       

        private void ImageViewer_Click(object sender, EventArgs e)
        {
            MainForm Frm = new MainForm();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void TS_Camera_Click(object sender, EventArgs e)
        {
            Form1 Frm = new Form1();
            Frm.MdiParent = this;
           
            Frm.Show();
        }

        private void TS_Show_Programs_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void TS_Hide_Prgoram_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TS_Exit_P_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من الخروج", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }

            else
            {
                return;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("هل انت متاكد من الخروج", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{
            //    System.Environment.Exit(0);
            //}

            //else
            //{
            //    return;
            //}
        }

        private void klblpatinet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatient Frm = new FrmPatient();
            Frm.MdiParent = this;
            Frm.GetSecurityForLastInfo(InstantObject._Felid_Permission.CHB_LastMedication, InstantObject._Felid_Permission.CHB_lastDisease, InstantObject._Felid_Permission.CHB_OperationOfPatient);
            Frm.Show();
        }

        private void klblVisit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmVisit Frm = new FrmVisit();

            Frm.MdiParent = this;
            Frm.Show();
        }

        private void klblPrescrption_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatient_Prescrption Frm = new FrmPatient_Prescrption();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmInvoice Frm = new FrmInvoice();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void TSM_Pharmacy_Click(object sender, EventArgs e)
        {
            FrmPharmacy Frm = new FrmPharmacy();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void TSM_SMR_Click(object sender, EventArgs e)
        {
            FrmSyriaMedicaton Frm = new FrmSyriaMedicaton();
            Frm.MdiParent = this;
            Frm.Show();
           
        }

       
        

       

       

        

       

      
        
       
       

       
    }
}
