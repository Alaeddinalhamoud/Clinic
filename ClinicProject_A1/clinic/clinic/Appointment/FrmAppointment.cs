using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Lib_Felid;
using BLL;
using clinic.Classes;

namespace clinic.Appointment
{
    public partial class FrmAppointment : Form
    {
        public FrmAppointment()
        {
            InitializeComponent();
        }

        private void GB_Date_Now_Enter(object sender, EventArgs e)
        {

        }
        SP_Appointment _SP_Appointment = new SP_Appointment();
        SP_VisitType _SP_VisitType = new SP_VisitType();

        Felid_Appointment _Felid = new Felid_Appointment();


        private void FrmAppointment_Load(object sender, EventArgs e)
        {

            TS_Appointment.Renderer = new Renderers.WindowsVistaRenderer();

            Fill_ComboBox();
           // DGV_Appointment_All.AutoGenerateColumns = false;
            Fill_DGV_By_Data();
            DPK_Info.Value = DateTime.Today;
            DPK_Appo.Value = DateTime.Today;

        }

        private void Fill_ComboBox()
        {
            Cmb_VisitType.DisplayMember = "VisitType";
            Cmb_VisitType.ValueMember = "VisitTypeID";
            Cmb_VisitType.DataSource = _SP_VisitType.VisitTypeTB_Browes_All();
        }

        private void Fill_DGV_By_Data()
        {
            DGV_Appointment_All.DataSource = InstantObject._SP_Appointment.SP_Brows_Datials_Appointement(DPK_Appo.Value);
        }

        private void TS_Add_Appointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Name.Text == "")
                { MessageBox.Show("ادخل اسم المريض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                else if (Mtxt_Time.Text == "  : ")
                { MessageBox.Show("ادخل الوقت", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                else
                {
                    _Felid.PatientName = txt_Name.Text;
                    _Felid.Date = DPK_Info.Value;
                    _Felid.Time = Mtxt_Time.Text;
                    _Felid.VisitTypeID = Convert.ToInt32(Cmb_VisitType.SelectedValue);
                    _Felid.Note = txt_Note.Text;

                   // InstantObject.ThLoading.Open_Loading();

                    _SP_Appointment.SP_Insert_Appointment(_Felid);

                    
                  //  InstantObject.ThLoading.Abort_Loading();
                      Fill_DGV_By_Data();
                      Clear_Tools();
                    MessageBox.Show("تمت  الاضافة");

                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void TS_Updata_Appointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Name.Text == "")
                { MessageBox.Show("ادخل اسم المريض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                else if (Mtxt_Time.Text == "")
                { MessageBox.Show("ادخل الوقت", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                else
                {
                    _Felid.AppointmentID = Convert.ToInt32(txt_AppointmentID.Text);
                    _Felid.PatientName = txt_Name.Text;
                    _Felid.Date = DPK_Info.Value;
                    _Felid.Time = Mtxt_Time.Text;
                    _Felid.VisitTypeID = Convert.ToInt32(Cmb_VisitType.SelectedValue);
                    _Felid.Note = txt_Note.Text;
                    // InstantObject.ThLoading.Open_Loading();
                    _SP_Appointment.SP_Updata_Appointment_By_ID(_Felid);
                    Fill_DGV_By_Data();
                    Clear_Tools();
                    // InstantObject.ThLoading.Abort_Loading();

                    MessageBox.Show("تم التعديل");
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void TS_Delete_Appointment_Click(object sender, EventArgs e)
        {
            if (txt_AppointmentID.Text.Trim() == "")
            {
                MessageBox.Show("اختر  الموعد", "تحذير", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);


            }
            else
            {
                if (MessageBox.Show("هل انت متأكد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                   // InstantObject.ThLoading.Open_Loading();
                    _SP_Appointment.SP_Delete_Appointment_By_ID(Convert.ToInt32(txt_AppointmentID.Text));
                    //Fill All Disase
                    Fill_DGV_By_Data();
                    Clear_Tools();
                   // InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show("تمت عملية الحذف");
                }

            }
        }

        private void DPK_Appo_ValueChanged(object sender, EventArgs e)
        {
            Fill_DGV_By_Data();
        }

       
        

        private void Clear_Tools()
        {
            txt_AppointmentID.Clear();
            txt_Name.Clear();
            Mtxt_Time.Clear();
            txt_Note.Clear();
        }

        

        private void TS_BAckTOMAin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_Appointment_All_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Appointment_All.Rows.Count > 0)
                {
         //           InstantObject.ThLoading.Open_Loading();
                    //Method For Fill Tools at Patient
                    int _RowIndex;
                    _RowIndex = DGV_Appointment_All.CurrentCell.RowIndex;
                    int _CurrentRow = Convert.ToInt32(DGV_Appointment_All[0, _RowIndex].Value);
                    _Felid = _SP_Appointment.SP_Browes_Appointment_By_ID_Felid(_CurrentRow);
                    txt_AppointmentID.Text = _Felid.AppointmentID.ToString();
                    txt_Name.Text = _Felid.PatientName.ToString();
                    DPK_Info.Value = Convert.ToDateTime(_Felid.Date);
                    Mtxt_Time.Text = _Felid.Time.ToString();
                    //Cmb_VisitType.DisplayMember = "VisitType";
                    //Cmb_VisitType.ValueMember = "VisitTypeID";
                    //Cmb_VisitType.DataSource = _SP_VisitType.VisitTypeTB_Browes_By_ID(_Felid.VisitTypeID);
                    Fill_ComboBox();
                    string NameOfVisitType = Convert.ToString(DGV_Appointment_All[5, _RowIndex].Value);
                    Cmb_VisitType.Text = NameOfVisitType;
                    txt_Note.Text = _Felid.Note.ToString();
           //         InstantObject.ThLoading.Abort_Loading();
                }
            }
            catch { };
        }

        private void TSB_Empty_Click(object sender, EventArgs e)
        {
            Clear_Tools();
        }

       

      
    }
}
