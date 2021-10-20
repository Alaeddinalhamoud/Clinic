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

using clinic.Report_Form;
using clinic.Classes;
using BLL;

namespace clinic.Patient
{
    public partial class Frm_Operation_Patient : Form
    {
        public Frm_Operation_Patient()
        {
            InitializeComponent();
        }
        //SP FOR All Operation
        SP_Operation _SP_Operation = new SP_Operation();
        SP_OperationType _SP_OperationType = new SP_OperationType();
        SP_Patient _SP_Patient = new SP_Patient();
        
   //     C_ThreadLoding ThLoading = new C_ThreadLoding();
        // Felid For All Operation
        Felid_Operation _Felid_Operation = new Felid_Operation();
        Felid_Patient _Felid_Patient = new Felid_Patient();
        Felid_OperationType _Felid_OperationType = new Felid_OperationType();
       // Felid_Opreation_details _Felid_Opreation_details = new Felid_Opreation_details();

        private void Frm_Operation_Patient_Load(object sender, EventArgs e)
        {
            TS_Operation.Renderer = new Renderers.WindowsVistaRenderer();
            //SP FOR All Operation

            DGV_OPeration_Patient();
            Fill_Cmb_OperationType();
            Fill_Cmb_FullName();
            Make_Cmb_Text_null();
        }

        private void Make_Cmb_Text_null()
        {
            Cmb_Patient_Full.Text = "";
            Cmb_Operation.Text = "";
        }

        private void Fill_Cmb_FullName()
        {
            Cmb_Patient_Full.ValueMember = "PatientID";
            Cmb_Patient_Full.DisplayMember = "FirstName";
            Cmb_Patient_Full.DataSource = _SP_Patient.SP_Browes_Patient_FullName();
        }
        private void DGV_OPeration_Patient()
        {
            //Fill DGV Operation_Patient
            DGV_OPeration_Patient_All.DataSource = _SP_Operation.SP_Browes_All_Dtailse_Opreation();
          
        }
        private void TS_Add_Operation_Patient_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_Patient_Full.Text == "")
                {
                    MessageBox.Show("لم تقم بتحديد المريض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Cmb_Operation.Text == "")
                {
                    MessageBox.Show("لم تقم بتحديد العملية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _Felid_Operation.PatientID = Convert.ToInt32(Cmb_Patient_Full.SelectedValue);
                    _Felid_Operation.DateOfOperation = Convert.ToDateTime(DTP_opration.Value);
                    _Felid_Operation.OperationTypeID = Convert.ToInt32(Cmb_Operation.SelectedValue);
                    _Felid_Operation.Note = Convert.ToString(txt_Note.Text);
                  //  ThLoading.Open_Loading();
                    _SP_Operation.SP_Insert_Operation(_Felid_Operation);
                  //  ThLoading.Abort_Loading();
                    Fill_Cmb_OperationType();
                    Fill_Cmb_FullName();
                    Make_Cmb_Text_null();
                    DGV_OPeration_Patient();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void DGV_OPeration_Patient_All_Click(object sender, EventArgs e)
        {
            //Method For Fill Tools at Patient

        }

        private void TS_Delete_Operation_Patient_Click(object sender, EventArgs e)
        {
            if (txt_OperationID.Text.Trim() == "")
            {
                MessageBox.Show("لم تقم باختيار المريض",
                                        "تحذير",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                   // ThLoading.Open_Loading();
                    _SP_Operation.SP_Delete_Operation_By_ID(Convert.ToInt32(txt_OperationID.Text));
                  //  ThLoading.Abort_Loading();
                    //For Fill New Result
                    DGV_OPeration_Patient();
                    Fill_Cmb_OperationType();
                    Fill_Cmb_FullName();
                    Make_Cmb_Text_null();
                    Clear_Tools();
                }
           }
        }


        private void Clear_Tools()
        {
            txt_OperationID.Clear();
            txt_Note.Clear();
        }
        private void TS_UpData_Operation_Patient_Click(object sender, EventArgs e)
        {
            try
            {

                if (Cmb_Patient_Full.Text == "")
                {
                    MessageBox.Show("لم تقم باختيار المريض",
                                            "تحذير",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                }
                else
                {
                    _Felid_Operation.OperationID = Convert.ToInt32(txt_OperationID.Text);
                    _Felid_Operation.PatientID = Convert.ToInt32(Cmb_Patient_Full.SelectedValue);
                    _Felid_Operation.DateOfOperation = DTP_opration.Value;
                    _Felid_Operation.OperationTypeID = Convert.ToInt32(Cmb_Operation.SelectedValue);
                    _Felid_Operation.Note = Convert.ToString(txt_Note.Text);
                    //  ThLoading.Open_Loading();
                    _SP_Operation.SP_UpData_Operation_By_ID(_Felid_Operation);
                    //  ThLoading.Abort_Loading();
                    DGV_OPeration_Patient();
                    Fill_Cmb_OperationType();
                    Fill_Cmb_FullName();
                    Make_Cmb_Text_null();
                    Clear_Tools();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }
        private void TS_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        
        private void Fill_Cmb_OperationType()
        {
            Cmb_Operation.DisplayMember = "OperationType";
            Cmb_Operation.ValueMember = "OperationTypeID";
            Cmb_Operation.DataSource = _SP_OperationType.SP_Browes_OperationType_All();
        }

        private void DGV_OPeration_Patient_All_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (DGV_OPeration_Patient_All.Rows.Count > 0)
                {
                    int _RowIndex;
                    _RowIndex = DGV_OPeration_Patient_All.CurrentCell.RowIndex;
                    int _CurrentRow = Convert.ToInt32(DGV_OPeration_Patient_All[0, _RowIndex].Value);

                 //   ThLoading.Open_Loading();
                    //_Felid_Operation = _SP_Operation.SP_Browes_Operation_All_By_PatientID_Felid(_CurrentRow);
                    _Felid_Operation = _SP_Operation.SP_Browes_Operation_All_By_ID_Felid(_CurrentRow);
                  //  ThLoading.Abort_Loading();
                    txt_OperationID.Text = _Felid_Operation.OperationID.ToString();
                    txt_Note.Text = _Felid_Operation.Note.ToString();
                    DTP_opration.Value = Convert.ToDateTime(_Felid_Operation.DateOfOperation);
                    Cmb_Patient_Full.ValueMember = "PatientID";
                    Cmb_Patient_Full.DisplayMember = "FirstName";
                    Cmb_Patient_Full.DataSource = _SP_Patient.SP_Browes_Patient_FullName_By_ID(_Felid_Operation.PatientID);
                    //Cmb_Patient_Full.SelectedItem = Cmb_Patient_Full.Items[_Felid_Patient.PatientID];
                    Fill_Cmb_OperationType();
                    string NameOfOperationType = Convert.ToString(DGV_OPeration_Patient_All[3, _RowIndex].Value);
                    Cmb_Operation.Text = NameOfOperationType;

                    //Cmb_Operation.SelectedItem = Cmb_Operation.Items[_Felid_OperationType.OperationTypeID]
                    //
                }
            }
            catch { };
            


        }

        private void btn_Report_Patient_Click(object sender, EventArgs e)
        {
           
        }

        private void TS_S_By_PatientID_Click(object sender, EventArgs e)
        {
            if (Cmb_Patient_Full.Text == "")
            {
                MessageBox.Show("من فضلك اختر المريض ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
              //  ThLoading.Open_Loading();
                FrmReport nfrm = new FrmReport();
                nfrm.ShowReportForPateintOperation(Convert.ToInt32(Cmb_Patient_Full.SelectedValue));
                nfrm.Show();
              //  ThLoading.Abort_Loading();
            }
        }

        private void TS_S_By_Name_All_PAtient_Click(object sender, EventArgs e)
        {

              //  ThLoading.Open_Loading();
                FrmReport nfrm = new FrmReport();
                nfrm.ShowOperationForAllPatient();
               
                nfrm.Show();
               // ThLoading.Abort_Loading();
            
        }

        private void Ts_EmptyRecord_Click(object sender, EventArgs e)
        {
            txt_Note.Clear();
            DGV_OPeration_Patient();
            Fill_Cmb_OperationType();
            Fill_Cmb_FullName();
        }

      

        
       
        
    }
}