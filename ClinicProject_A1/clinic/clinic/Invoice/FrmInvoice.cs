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
using clinic.Report_Form;
using clinic.Classes;

namespace clinic.Invoice
{
    public partial class FrmInvoice : Form
    {
        public FrmInvoice()
        {
            InitializeComponent();
        }
        //Sp
        SP_Invoice _SP_Invoice = new SP_Invoice();
        SP_Patient _SP_Patient = new SP_Patient();
        SP_Visit _SP_Visit = new SP_Visit();


        //Felid
        Felid_Invoice _Felid_Invoice = new Felid_Invoice();
        
        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            DPK_DateInvoice.Value = DateTime.Now;
            TS_Invoice.Renderer = new Renderers.WindowsVistaRenderer();
            txt_PtientInher.Text = InstantObject.PatientID.ToString();

            if (Convert.ToInt32(txt_PtientInher.Text)==0)
            {
            this.Cmb_Patient.SelectedIndexChanged -= new System.EventHandler(this.Cmb_Patient_SelectedIndexChanged);
           
             txt_Reminder.Enabled = false;
                txt_Discount.Enabled = false;


                Fill_DGV_Invoice();
           
            Fill_DGV_Patient();
            
            Cmb_Patient.Text = "";
           this.Cmb_Patient.SelectedIndexChanged += new System.EventHandler(this.Cmb_Patient_SelectedIndexChanged);
            }
            else
            {
                DGV_Invoice_All.AutoGenerateColumns = false;
                Cmb_Patient.DisplayMember = "FirstName";
                Cmb_Patient.ValueMember = "PatientID";
                Cmb_Patient.DataSource = _SP_Patient.SP_Browes_Patient_FullName_By_ID(Convert.ToInt32(txt_PtientInher.Text));
                DGV_Invoice_All.DataSource = _SP_Invoice.SP_Browes_Invoice_ReprtByPatientID(Convert.ToInt32(txt_PtientInher.Text));

            }
            }

        private void Fill_DGV_Invoice()
        {
            
         
            DGV_Invoice_All.DataSource = _SP_Invoice.SP_Brows_Invoice_Datials();
        }

        private void Fill_DGV_Patient()
        {
            Cmb_Patient.DisplayMember = "FirstName";
            Cmb_Patient.ValueMember = "PatientID";
            Cmb_Patient.DataSource = _SP_Patient.SP_Browes_Patient_FullName();
        }

        private void TS_Add_Invoice_Click(object sender, EventArgs e)
        {

            try
            {
                int Paid = Convert.ToInt32(txt_PaidMoney.Text);
                int Reminder=Convert.ToInt32(txt_Reminder.Text);
                int Discount =  Convert.ToInt32(txt_Discount.Text);
                _Felid_Invoice.VisitID = Convert.ToInt32(Cmb_VisitID.SelectedValue);
                //_Felid_Invoice.FirstName = _SP_Patient.SP_Browes_Patient_FullName_By_ID_Felid(Convert.ToInt32 (Cmb_Patient.SelectedValue)).ToString();
                _Felid_Invoice.PatientID = Convert.ToInt32(Cmb_Patient.SelectedValue);
                _Felid_Invoice.PaidMoney = Paid;
                _Felid_Invoice.Reminder= Reminder;
                int addpaidrem = Paid+Reminder;
                int DiscountCalc = addpaidrem * Discount / 100;
                _Felid_Invoice.Discount = Discount;
                _Felid_Invoice.Total = addpaidrem - DiscountCalc;
                _Felid_Invoice.DateInvoice = Convert.ToDateTime(DPK_DateInvoice.Value);
                _SP_Invoice.SP_Insert_Invoice(_Felid_Invoice);


                Fill_DGV_Invoice();
                Clear_Tools();
            }
            catch { };
        }

        private void DGV_Invoice_All_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Invoice_All.Rows.Count > 0)
                {
                    //Method For Fill Tools at Patient
                    int _RowIndex;
                    _RowIndex = DGV_Invoice_All.CurrentCell.RowIndex;
                    int _CurrentRow = Convert.ToInt32(DGV_Invoice_All[0, _RowIndex].Value);

                    _Felid_Invoice = _SP_Invoice.SP_Browes_Invoic_By_ID_Felid(_CurrentRow);
                    txt_InvoiceID.Text = _Felid_Invoice.InVoiceID.ToString();
                    Fill_VisitID_Date();


                    Cmb_Patient.DisplayMember = "FirstName";
                    Cmb_Patient.ValueMember = "PatientID";
                    Cmb_Patient.DataSource = _SP_Patient.SP_Browes_Patient_FullName_By_ID(_Felid_Invoice.PatientID);

                    txt_PaidMoney.Text = _Felid_Invoice.PaidMoney.ToString();
                    txt_Reminder.Text = _Felid_Invoice.Reminder.ToString();
                    txt_Discount.Text = _Felid_Invoice.Discount.ToString();
                    txt_Total.Text = _Felid_Invoice.Total.ToString();
                    DPK_DateInvoice.Value = _Felid_Invoice.DateInvoice;

                }
            }
            catch { };
        }

        private void Fill_VisitID_Date()
        {
            Cmb_VisitID.DisplayMember = "DataOfVisit";
            Cmb_VisitID.ValueMember = "VisitID";
            try
            {
                Cmb_VisitID.DataSource = _SP_Visit.SP_Browes_Visit_Date_By_PatientID(Convert.ToInt32(Cmb_Patient.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Cmb_VisitID.DataSource = null;
            }
        }

        private void TS_UpDate_Click(object sender, EventArgs e)
        {

            if (txt_InvoiceID.Text.Trim() == "")
            {
                MessageBox.Show("لم تقم باختيار الفاتورة  ", "تحذير", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);


            }
            else
            {

                int Paid = Convert.ToInt32(txt_PaidMoney.Text);
                int Reminder = Convert.ToInt32(txt_Reminder.Text);
                int Discount = Convert.ToInt32(txt_Discount.Text);

                _Felid_Invoice.InVoiceID = Convert.ToInt32(txt_InvoiceID.Text);
                _Felid_Invoice.VisitID = Convert.ToInt32(Cmb_VisitID.SelectedValue);
                _Felid_Invoice.PatientID = Convert.ToInt32(Cmb_Patient.SelectedValue);
                _Felid_Invoice.PaidMoney = Paid;
                _Felid_Invoice.Reminder = Reminder;
                int addpaidrem = Paid + Reminder;
                int DiscountCalc = addpaidrem * Discount / 100;
                _Felid_Invoice.Discount = Discount;
                _Felid_Invoice.Total = addpaidrem - DiscountCalc;
                _Felid_Invoice.DateInvoice = Convert.ToDateTime(DPK_DateInvoice.Value);
                _SP_Invoice.SP_UpDate_Invoice(_Felid_Invoice);
                Fill_DGV_Invoice();
                Clear_Tools();
                Fill_DGV_Patient();
            }

        }

        private void TS_Delete_Invoice_Click(object sender, EventArgs e)
        {
            if (txt_InvoiceID.Text.Trim()=="")
            {
                MessageBox.Show("لم تقم باختيار الفاتورة  ", "تحذير", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);


            }
            else
            {
                if (MessageBox.Show(":هل انت متأكد", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    _SP_Invoice.SP_Delete_Invoice(Convert.ToInt32(txt_InvoiceID.Text));
                    
                    //Fill All Disase
                    Fill_DGV_Invoice();
                    
                    Clear_Tools();
                    Fill_DGV_Patient();

                }

            }  
        }

        private void Clear_Tools()
        {
            txt_InvoiceID.Clear();

            txt_PaidMoney.Text = "0";

            txt_Reminder.Text = "0";
            txt_Discount.Text = "0";
            txt_Total.Text = "0";
        }

        private void Cmb_Patient_SelectedValueChanged(object sender, EventArgs e)
        {
          //  DGV_Invoice_All.DataSource = _SP_Invoice.SP_Browes_InVoiceID_By_PatientID(Convert.ToInt32(Cmb_Patient.SelectedValue));
        }

        private void txt_PaidMoney_TextChanged(object sender, EventArgs e)
        {
            
                txt_Reminder.Enabled = true;
                txt_Discount.Enabled = true;

              
        }

        private void Cmb_Patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill_VisitID_Date();

                DGV_Invoice_All.DataSource = _SP_Invoice.SP_Brows_Invoice_Detials_By_PatientID(Convert.ToInt32(Cmb_Patient.SelectedValue));
           
        }
        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Reminder_TextChanged(object sender, EventArgs e)
        {
           
        }
       
        private void Tss_PatientReportInvfoice_Click(object sender, EventArgs e)
        {
            if (txt_InvoiceID.Text == "")
            {
                MessageBox.Show("لم تقم بتحديد الفاتورة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmReport frm = new FrmReport();
                frm.ShowReportInvoiceID(Convert.ToInt32(txt_InvoiceID.Text));
                frm.Show();
            }
        }

        private void TSS_Report_PatirntInvoiS_Click(object sender, EventArgs e)
        {
            if (Cmb_Patient.Text == "")
            {
                MessageBox.Show("اختر اسم المريض");
            }
            else
            {
                FrmReport Frm = new FrmReport();
                Frm.ReportRptPatientInvoice(Convert.ToInt32(Cmb_Patient.SelectedValue));
                Frm.Show();
            }
        }

        private void TS_BAck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tss_MonthReport_Click(object sender, EventArgs e)
        {
            FrmMonthInvoice Frm = new FrmMonthInvoice();
            Frm.ShowDialog();
        }

        private void txt_PaidMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            InstantObject.KeyPress(e);

        }

        private void txt_Total_TextChanged(object sender, EventArgs e)
        {

        }

       

      
       
        
    }
}
