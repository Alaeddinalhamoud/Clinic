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
using Microsoft.ApplicationBlocks.Data;
using clinic.Classes;


namespace clinic.Analysis
{
    public partial class FrmAnalysis : Form
    {
        public FrmAnalysis()
        {
            InitializeComponent();
        }


        SP_Anlaysis _SP_Anlaysis = new SP_Anlaysis();
        SP_Patient _SP_Patient = new SP_Patient();
        SP_AnalysisType _SP_AnalysisType = new SP_AnalysisType();
        SP_Visit _SP_Visit = new SP_Visit();
        //SP_Analysis_details _SP_Analysis_details = new SP_Analysis_details();
        Felid_Anlaysis _Felid_Anlaysis = new Felid_Anlaysis();
        Filed_AnalysisType _Felid = new Filed_AnalysisType();

        
      
        private void FrmAnalysis_Load(object sender, EventArgs e)
        {
            TS_Analysis.Renderer = new Renderers.WindowsVistaRenderer();

            txt_PatientInher.Text = InstantObject.PatientID.ToString();
             if (Convert.ToInt32(txt_PatientInher.Text)==0)
                 {
            

                this.Cmb_PatientName_1.SelectedIndexChanged -= new System.EventHandler(this.Cmb_PatientName_1_SelectedIndexChanged);
                DGV_Fill_All();
                Fill_Cmbo();

                Make_All_Cmb_Null();

                this.Cmb_PatientName_1.SelectedIndexChanged += new System.EventHandler(this.Cmb_PatientName_1_SelectedIndexChanged);
                 }
                 else
                {
                    DGV_Analysis_All.AutoGenerateColumns = false;
                    Cmb_Fill_AnalysisType();
                    Cmb_PatientName_1.DisplayMember = "FirstName";
                    Cmb_PatientName_1.ValueMember = "PatientID";
                    Cmb_PatientName_1.DataSource = _SP_Patient.SP_Browes_Patient_FullName_By_ID(Convert.ToInt32(txt_PatientInher.Text));
                    DGV_Analysis_All.DataSource = _SP_Anlaysis.SP_Browes_AnalysisTB_Report_By_PatientID(Convert.ToInt32(txt_PatientInher.Text));


                }
        }

        private void Fill_Cmbo()
        {
           
            Cmb_Fill_PatientName();



            Cmb_Fill_AnalysisType();
            
        }

        private void Make_All_Cmb_Null()
        {
            Cmb_PatientName_1.Text = "";
            //Cmb_AnalysisTypeID.Text = "";
           // Cmb_VisitID.Text = "";
        }

        private void Cmb_Fill_AnalysisType()
        {
           
            Cmb_AnalysisTypeID.DisplayMember = "Analysis";
            Cmb_AnalysisTypeID.ValueMember = "AnalysisTypeID";
            Cmb_AnalysisTypeID.DataSource = _SP_AnalysisType.SP_Browes_AnalysisTypeTB_All();
           
        }

        private void Cmb_Fill_Visit()
        {
           

                Cmb_VisitID.DisplayMember = "DataOfVisit";
                Cmb_VisitID.ValueMember = "VisitID";

                Cmb_VisitID.DataSource = _SP_Visit.SP_Browes_Visit_Date_By_PatientID(Convert.ToInt32(Cmb_PatientName_1.SelectedValue));
           
           
        }

        private void Cmb_Fill_PatientName()
        {
           //this.Cmb_PatientName.SelectedIndexChanged -= new System.EventHandler(this.Cmb_PatientName_SelectedIndexChanged);
            Cmb_PatientName_1.DisplayMember = "FirstName";
            Cmb_PatientName_1.ValueMember = "PatientID";
            Cmb_PatientName_1.DataSource = _SP_Patient.SP_Browes_Patient_FullName();
           //     this.Cmb_PatientName.SelectedIndexChanged += new System.EventHandler(this.Cmb_PatientName_SelectedIndexChanged);

            
        }

        private void DGV_Fill_All()
        {

            DGV_Analysis_All.DataSource = _SP_Anlaysis.SP_Browes_AnalysisTB_details();
            
        }


        private void TS_Add_Anlysis_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmb_PatientName_1.Text == "" && Cmb_VisitID.Text == "")
                {
                    MessageBox.Show("اختر المريض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                else if (Cmb_AnalysisTypeID.Text == "")
                {
                    MessageBox.Show("اختر التحليل", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txt_Subject.Text == "")
                {
                    MessageBox.Show("تاكد من صندوق الموضوع", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {


                    _Felid_Anlaysis.AnalysisTypeID = Convert.ToInt32(Cmb_AnalysisTypeID.SelectedValue);
                    _Felid_Anlaysis.AnalysisSubject = txt_Subject.Text;
                    _Felid_Anlaysis.AnalysisResult = txt_Result.Text;
                    _Felid_Anlaysis.VisitID = Convert.ToInt32(Cmb_VisitID.SelectedValue);
                    _Felid_Anlaysis.PatientID = Convert.ToInt32(Cmb_PatientName_1.SelectedValue);

                    // InstantObject.ThLoading.Open_Loading();
                    _SP_Anlaysis.SP_Insert_Analysis(_Felid_Anlaysis);

                    DGV_Fill_All();
                    Fill_Cmbo();
                    Clear_Tools();
                    //  InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show("تمت الاضافة");
                }
            }
            catch { };
        }

     

        private void DGV_Analysis_All_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Analysis_All.Rows.Count > 0)
                {
              //      InstantObject.ThLoading.Open_Loading();
                    //Method For Fill Tools at Patient
                    int _RowIndex;
                    _RowIndex = DGV_Analysis_All.CurrentCell.RowIndex;
                    int _CurrentRow = Convert.ToInt32(DGV_Analysis_All[0, _RowIndex].Value);
                    _Felid_Anlaysis = _SP_Anlaysis.SP_Browes_Analysis_By_AnalysisID_Felid(_CurrentRow);
                    txt_AnalysisID.Text = _Felid_Anlaysis.AnalysisID.ToString();
                    Cmb_Fill_AnalysisType();
                    string analysisname = Convert.ToString(DGV_Analysis_All[2, _RowIndex].Value);
                    Cmb_AnalysisTypeID.Text = analysisname;
                    txt_Subject.Text = _Felid_Anlaysis.AnalysisSubject;
                    txt_Result.Text = _Felid_Anlaysis.AnalysisResult;
                    Cmb_PatientName_1.DisplayMember = "FirstName";
                    Cmb_PatientName_1.ValueMember = "PatientID";

                    Cmb_PatientName_1.DataSource = _SP_Patient.SP_Browes_Patient_FullName_By_ID(_Felid_Anlaysis.PatientID);
                    string DateText = Convert.ToString(DGV_Analysis_All[6, _RowIndex].Value);
                    Cmb_VisitID.Text = DateText;
            //        InstantObject.ThLoading.Abort_Loading();
                    // Fill_Cmbo();
                }
            }
            catch { };
        }

        private void TS_Delete_Analysis_Click(object sender, EventArgs e)
        {

            if (txt_AnalysisID.Text == "")
            {
                MessageBox.Show("لم تقم باختيار التحليل الذي تريد حذفه", "تحذير", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);


            }
            else
            {
                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                   // InstantObject.ThLoading.Open_Loading();
                    _SP_Anlaysis.SP_Delete_Analysis(Convert.ToInt32(txt_AnalysisID.Text));


                    DGV_Fill_All();
                    Fill_Cmbo();
                    Clear_Tools();
                   // InstantObject.ThLoading.Abort_Loading();
                    MessageBox.Show("تمت عملية الحذف");
                }

            }

        }

        private void Clear_Tools()
        {
            txt_AnalysisID.Clear();
            txt_Result.Clear();
            txt_Subject.Clear();
            Cmb_VisitID.DataSource = null;
            Cmb_PatientName_1.Text = "";
        }

        private void TS_UpDate_Analysis_Click(object sender, EventArgs e)
        {
             if (Cmb_PatientName_1.Text == "" && Cmb_VisitID.Text == "")
            {
                MessageBox.Show("اختر المريض", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else if (Cmb_AnalysisTypeID.Text == "")
            {
                MessageBox.Show("اختر التحليل", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             else if (txt_Subject.Text == "")
             {
                 MessageBox.Show("تاكد من  الموضوع", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }
             else
             {

                 _Felid_Anlaysis.AnalysisID = Convert.ToInt32(txt_AnalysisID.Text);
                 _Felid_Anlaysis.AnalysisTypeID = Convert.ToInt32(Cmb_AnalysisTypeID.SelectedValue);
                 _Felid_Anlaysis.AnalysisSubject = txt_Subject.Text;
                 _Felid_Anlaysis.AnalysisResult = txt_Result.Text;
                 _Felid_Anlaysis.VisitID = Convert.ToInt32(Cmb_VisitID.SelectedValue);
                 _Felid_Anlaysis.PatientID = Convert.ToInt32(Cmb_PatientName_1.SelectedValue);
                 
               //  InstantObject.ThLoading.Open_Loading();
                 _SP_Anlaysis.SP_UpData_Analysis(_Felid_Anlaysis);
                 DGV_Fill_All();
                 Fill_Cmbo();
                 Clear_Tools();
               //  InstantObject.ThLoading.Abort_Loading();
                 MessageBox.Show("تمت عملية التعديل");
             }
        }

       
        private void TS_Repo_Click(object sender, EventArgs e)
        {
           // InstantObject.ThLoading.Open_Loading();
            FrmReport Frm = new FrmReport();
            Frm.ShowReportAnalysisPatientAll();
           // InstantObject.ThLoading.Abort_Loading();

            Frm.Show();
          
        }

        private void Cmb_PatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Fill_VistiWithEvent();
        }

        private void Fill_VistiWithEvent()
        {
            try
            {
                Cmb_Fill_Visit();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Cmb_VisitID.DataSource = null;
            }
        }

        private void Cmb_PatientName_Enter(object sender, EventArgs e)
        {
            Fill_VistiWithEvent();

        }

        private void Cmb_PatientName_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill_VistiWithEvent();
        }

        private void Ts_ReportForPatientId_Click(object sender, EventArgs e)
        {
            if (Cmb_PatientName_1.Text == "")
            {
                MessageBox.Show("اختر المريض");
                return;
            }
            else
            {
             //   InstantObject.ThLoading.Open_Loading();
                FrmReport Frm = new FrmReport();
                Frm.ReportAnalysisForPatientID(Convert.ToInt32(Cmb_PatientName_1.SelectedValue));
              //  InstantObject.ThLoading.Abort_Loading();
                Frm.Show();
               
            }
        }

        private void Ts_ReportForPatientIDS_Click(object sender, EventArgs e)
        {
          //  InstantObject.ThLoading.Open_Loading();
            FrmReport Frm = new FrmReport();
            Frm.ReportRptAnalysisAll();
            //InstantObject.ThLoading.Abort_Loading();

            Frm.Show();
        }

        private void btn_Clear_TooLs_Click(object sender, EventArgs e)
        {
            Fill_Cmbo();
            Clear_Tools();
        }

        private void TS_BAck_Click(object sender, EventArgs e)
        {
            this.Close();
        }



       

      

    }
}
