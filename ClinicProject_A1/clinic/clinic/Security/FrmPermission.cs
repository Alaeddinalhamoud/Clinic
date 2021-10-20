using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clinic.Classes;

namespace clinic.Security
{
    public partial class FrmPermission : Form
    {
        public FrmPermission()
        {
            InitializeComponent();
        }

        private void FrmPermission_Load(object sender, EventArgs e)
        {
            TS_Permission.Renderer = new Renderers.WindowsVistaRenderer();
            EnabledCheckPatient();
            analysisCheckedEnable();
            CHB_Invoice.Enabled  = false;
            TOllEnable();
             CHB_Appointment.Enabled  = false ;
             CHB_Prescription.Enabled = false;
            //  InstantObject.ThLoading.Open_Loading();

            InstantObject._Felid_Permission = InstantObject._SP_Permission.SP_Browes_Permission_ByUserID_Felid(Convert.ToInt32(txt_UserID.Text));

            PatientMenu.Checked = InstantObject._Felid_Permission.PatientMenu;
            CHB_FilePatient.Checked = InstantObject._Felid_Permission.CHB_FilePatient;
            CHB_OperationOfPatient.Checked = InstantObject._Felid_Permission.CHB_OperationOfPatient;
            CHB_lastDisease.Checked = InstantObject._Felid_Permission.CHB_lastDisease;
            CHB_LastMedication.Checked = InstantObject._Felid_Permission.CHB_LastMedication;
            CHB_Visit.Checked = InstantObject._Felid_Permission.CHB_Visit;
            AnalysisMenu.Checked = InstantObject._Felid_Permission.AnalysisMeun;
            CHB_Analysis.Checked = InstantObject._Felid_Permission.CHB_Analysis;
            CHB_Radio.Checked = InstantObject._Felid_Permission.CHB_Radio;
            InvoiceMeun.Checked = InstantObject._Felid_Permission.InvoiceMeun;
            CHB_Invoice.Checked = InstantObject._Felid_Permission.CHB_Invoice;
            ToolsMeun.Checked = InstantObject._Felid_Permission.ToolsMeun;
            CHB_CameraWatiching.Checked = InstantObject._Felid_Permission.CHB_CameraWatiching;
            CHB_BrowesImage.Checked = InstantObject._Felid_Permission.CHB_BrowesImage;
            CHB_ControlPanel.Checked = InstantObject._Felid_Permission.CHB_ControlPanel;
            CHB_AdminControlPanal.Checked = InstantObject._Felid_Permission.CHB_AdminControlPanal;
            CHB_UserContolPanel.Checked = InstantObject._Felid_Permission.CHB_UserContolPanel;
            CHB_BackUp.Checked = InstantObject._Felid_Permission.CHB_BackUp;
            AppointmentMeun.Checked = InstantObject._Felid_Permission.AppointmentMeun;
            CHB_Appointment.Checked = InstantObject._Felid_Permission.CHB_Appointment;
            PrescriptionMeun.Checked = InstantObject._Felid_Permission.PrescriptionMeun;
            CHB_Prescription.Checked = InstantObject._Felid_Permission.CHB_Prescription;


            //      InstantObject.ThLoading.Abort_Loading();
            ///



        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            InstantObject._Felid_Permission.UserID = Convert.ToInt32(txt_UserID.Text);
            InstantObject._Felid_Permission.PatientMenu = PatientMenu.Checked;
            InstantObject._Felid_Permission.CHB_FilePatient = CHB_FilePatient.Checked;
            InstantObject._Felid_Permission.CHB_OperationOfPatient = CHB_OperationOfPatient.Checked;
            InstantObject._Felid_Permission.CHB_lastDisease = CHB_lastDisease.Checked;
            InstantObject._Felid_Permission.CHB_LastMedication = CHB_LastMedication.Checked;
            InstantObject._Felid_Permission.CHB_Visit = CHB_Visit.Checked;
            InstantObject._Felid_Permission.AnalysisMeun = AnalysisMenu.Checked;
            InstantObject._Felid_Permission.CHB_Analysis = CHB_Analysis.Checked;
            InstantObject._Felid_Permission.CHB_Radio = CHB_Radio.Checked;
            InstantObject._Felid_Permission.InvoiceMeun = InvoiceMeun.Checked;
            InstantObject._Felid_Permission.CHB_Invoice = CHB_Invoice.Checked;
            InstantObject._Felid_Permission.ToolsMeun = ToolsMeun.Checked;
            InstantObject._Felid_Permission.CHB_CameraWatiching = CHB_CameraWatiching.Checked;
            InstantObject._Felid_Permission.CHB_BrowesImage = CHB_BrowesImage.Checked;
            InstantObject._Felid_Permission.CHB_ControlPanel = CHB_ControlPanel.Checked;
            InstantObject._Felid_Permission.CHB_AdminControlPanal = CHB_AdminControlPanal.Checked;
            InstantObject._Felid_Permission.CHB_UserContolPanel = CHB_UserContolPanel.Checked;
            InstantObject._Felid_Permission.CHB_BackUp = CHB_BackUp.Checked;
            InstantObject._Felid_Permission.AppointmentMeun = AppointmentMeun.Checked;
            InstantObject._Felid_Permission.CHB_Appointment = CHB_Appointment.Checked;
            InstantObject._Felid_Permission.PrescriptionMeun = PrescriptionMeun.Checked;
            InstantObject._Felid_Permission.CHB_Prescription = CHB_Prescription.Checked;

            try
            {
                // InstantObject.ThLoading.Open_Loading();
                InstantObject._SP_Permission.SP_Insert_Permission(InstantObject._Felid_Permission);

                //  InstantObject.ThLoading.Abort_Loading();
                MessageBox.Show("عملية الاضافة تمت بنجاج");
            }
            catch (Exception ex)
            {
                // InstantObject.ThLoading.Abort_Loading();
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
        public void GetUserID(int UserID, string UserFullName)
        {
            txt_UserID.Text = UserID.ToString();
            STB_UserName.Text = UserFullName;
        }

        private void btn_Updata_Click(object sender, EventArgs e)
        {
            InstantObject._Felid_Permission.UserID = Convert.ToInt32(txt_UserID.Text);
            InstantObject._Felid_Permission.PatientMenu = PatientMenu.Checked;
            InstantObject._Felid_Permission.CHB_FilePatient = CHB_FilePatient.Checked;
            InstantObject._Felid_Permission.CHB_OperationOfPatient = CHB_OperationOfPatient.Checked;
            InstantObject._Felid_Permission.CHB_lastDisease = CHB_lastDisease.Checked;
            InstantObject._Felid_Permission.CHB_LastMedication = CHB_LastMedication.Checked;
            InstantObject._Felid_Permission.CHB_Visit = CHB_Visit.Checked;
            InstantObject._Felid_Permission.AnalysisMeun = AnalysisMenu.Checked;
            InstantObject._Felid_Permission.CHB_Analysis = CHB_Analysis.Checked;
            InstantObject._Felid_Permission.CHB_Radio = CHB_Radio.Checked;
            InstantObject._Felid_Permission.InvoiceMeun = InvoiceMeun.Checked;
            InstantObject._Felid_Permission.CHB_Invoice = CHB_Invoice.Checked;
            InstantObject._Felid_Permission.ToolsMeun = ToolsMeun.Checked;
            InstantObject._Felid_Permission.CHB_CameraWatiching = CHB_CameraWatiching.Checked;
            InstantObject._Felid_Permission.CHB_BrowesImage = CHB_BrowesImage.Checked;
            InstantObject._Felid_Permission.CHB_ControlPanel = CHB_ControlPanel.Checked;
            InstantObject._Felid_Permission.CHB_AdminControlPanal = CHB_AdminControlPanal.Checked;
            InstantObject._Felid_Permission.CHB_UserContolPanel = CHB_UserContolPanel.Checked;
            InstantObject._Felid_Permission.CHB_BackUp = CHB_BackUp.Checked;
            InstantObject._Felid_Permission.AppointmentMeun = AppointmentMeun.Checked;
            InstantObject._Felid_Permission.CHB_Appointment = CHB_Appointment.Checked;
            InstantObject._Felid_Permission.PrescriptionMeun = PrescriptionMeun.Checked;
            InstantObject._Felid_Permission.CHB_Prescription = CHB_Prescription.Checked;
            //InstantObject.ThLoading.Open_Loading();
            InstantObject._SP_Permission.SP_Update_Permission(InstantObject._Felid_Permission);

            // InstantObject.ThLoading.Abort_Loading();
            MessageBox.Show("عملية التعديل تمت بنجاج");
        }

        private void btn_Delelte_Click(object sender, EventArgs e)
        {
            if (txt_UserID.Text == InstantObject.UserID.ToString())
            {
                MessageBox.Show("انتبه لايمكن حذف سماحيات الحساب الخاص بك", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //  InstantObject.ThLoading.Open_Loading();
                InstantObject._SP_Permission.SP_Delete_Permission(Convert.ToInt32(txt_UserID.Text));
                //  InstantObject.ThLoading.Abort_Loading();
                this.Close();
            }
        }

        private void TS_FillAlCheck_Click(object sender, EventArgs e)
        {
            foreach (Control control in GB_ToolsBox.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = control as CheckBox;
                    checkBox.Checked = true;
                }

            }
        }

        private void GB_ToolsBox_Enter(object sender, EventArgs e)
        {

        }

        private void PatientMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (PatientMenu.Checked == true)
            {
                CHB_FilePatient.Enabled = true;
                CHB_OperationOfPatient.Enabled = true;
                CHB_lastDisease.Enabled = true;
                CHB_LastMedication.Enabled  = true;
                CHB_Visit.Enabled  = true;
            }
            else
            {
                EnabledCheckPatient();
            }
        }

        private void EnabledCheckPatient()
        {
            CHB_FilePatient.Checked = false;
            CHB_OperationOfPatient.Checked = false;
            CHB_lastDisease.Checked = false;
            CHB_LastMedication.Checked = false;
            CHB_Visit.Checked = false;

            CHB_FilePatient.Enabled = false;
            CHB_OperationOfPatient.Enabled = false;
            CHB_lastDisease.Enabled = false;
            CHB_LastMedication.Enabled  = false;
            CHB_Visit.Enabled  = false;
        }

        private void AnalysisMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (AnalysisMenu.Checked == true)
            {
                CHB_Analysis.Enabled  = true;
                CHB_Radio.Enabled  = true;
            }
            else
            {
                analysisCheckedEnable();
            }
        }

        private void analysisCheckedEnable()
        {
            CHB_Analysis.Checked = false;
            CHB_Radio.Checked = false;
            CHB_Analysis.Enabled  = false ;
            CHB_Radio.Enabled  = false ;
        }

        private void InvoiceMeun_CheckedChanged(object sender, EventArgs e)
        {
            if (InvoiceMeun.Checked == true)
            {
                CHB_Invoice.Enabled  = true;
            }
            else
            {
                CHB_Invoice.Checked = false;
                CHB_Invoice.Enabled  = false;
            }
        }

        private void ToolsMeun_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolsMeun.Checked == true)
            {
                CHB_CameraWatiching.Enabled  = true;
                CHB_BrowesImage.Enabled  = true;
                CHB_ControlPanel.Enabled  = true;
                CHB_AdminControlPanal.Enabled  = true;
                CHB_UserContolPanel.Enabled  = true;
                CHB_BackUp.Enabled  = true;
            }
            else
            {
                TOllEnable();
            }
        }

        private void TOllEnable()
        {
            CHB_CameraWatiching.Checked = false;
            CHB_BrowesImage.Checked = false;
            CHB_ControlPanel.Checked = false;
            CHB_AdminControlPanal.Checked = false;
            CHB_UserContolPanel.Checked = false;
            CHB_BackUp.Checked = false;

            CHB_CameraWatiching.Enabled  = false;
            CHB_BrowesImage.Enabled  = false;
            CHB_ControlPanel.Enabled  = false;
            CHB_AdminControlPanal.Enabled  = false;
            CHB_UserContolPanel.Enabled  = false;
            CHB_BackUp.Enabled  = false;
        }

        private void AppointmentMeun_CheckedChanged(object sender, EventArgs e)
        {
            if (AppointmentMeun.Checked == true)
            {
                CHB_Appointment.Enabled  = true;
            }
            else
            {
                CHB_Appointment.Checked = false;
                CHB_Appointment.Enabled  = false ;
            }

        }

        private void PrescriptionMeun_CheckedChanged(object sender, EventArgs e)
        {
            if (PrescriptionMeun.Checked == true)
            {
                CHB_Prescription.Enabled  = true;
            }
            else
            {
                CHB_Prescription.Checked = false;
                CHB_Prescription.Enabled  = false;
            }
        }


    }
}
