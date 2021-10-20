using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.ApplicationBlocks.Data;
using clinic.Reports;
using System.Data.SqlClient;
using System.Configuration;
using CrystalDecisions.Shared;
using BLL;
using System.IO;

namespace clinic.Report_Form
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }
        SP_Operation _SP_Opreation_Detalis = new SP_Operation();
        public int ID;
        private void FrmReport_Load(object sender, EventArgs e)
        {



        }
        public void ShowReportForPateintOperation(int text)
        {
            ConnectionInfo Cinfo = new ConnectionInfo();
            Cinfo.DatabaseName = ConfigurationSettings.AppSettings["DatabaseName"];
            Cinfo.ServerName = ConfigurationSettings.AppSettings["dbServerName"];

            ID = text;
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_All_Dtailse_Opreation_By_PatientID", ID);
            RptOperationPatient rpt = new RptOperationPatient();


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;

        }
        public void ShowPatientFromToDate(DateTime FromDate, DateTime ToDate)
        {
            DataTable tbl = new DataTable();

            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Brows_Datails_Patient_Report_From_To_Date", FromDate, ToDate);
            RptPatientDtailsFromToDate rpt = new RptPatientDtailsFromToDate();


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;
        }
        public void ShowPatientDatils(int PatientID,byte []i)
        {
            
           
            DataTable tbl = new DataTable();
            
            
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Brows_Datails_Patient_Report", PatientID,i);
           // tbl.Rows.Add(i);
            PatientReportByID rpt = new PatientReportByID();
            //  rpt.DataSourceConnections = Cinfo;

            //rpt.ReportAppServer = Cinfo.ServerName;
            //rpt.SetParameterValue("@PatientID",PatientID);
            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;

        }
        public void ShowOperationForAllPatient()
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_All_Dtailse_Opreation");
            RptOpeationAllPateint rpt = new RptOpeationAllPateint();
            //rpt.DataSourceConnections = SqlHelper.ConnStr;


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;
        }

        private void CryView_Load(object sender, EventArgs e)
        {


        }
        public void ShowReportInvoiceID(int VoiceID)
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Brows_Invoic_By_Invoice_Report", VoiceID);
            RptInoiceByInvoiceID rpt = new RptInoiceByInvoiceID();
            //rpt.DataSourceConnections = SqlHelper.ConnStr;


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;
        }

        public void ShowReportAnalysisFlowChar()
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_AnalysisTB_details");
            RptAnalysisFlowChar rpt = new RptAnalysisFlowChar();
            //rpt.DataSourceConnections = SqlHelper.ConnStr;


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;
        }

        public void ShowReportAnalysisAll()
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_AnalysisTypeTB_All");
            RptAnalysisTypeAll rpt = new RptAnalysisTypeAll();
            //rpt.DataSourceConnections = SqlHelper.ConnStr;


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;
        }

        public void ShowReportDiseaseAll()
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Disease_All");
            RptDiseaseAll rpt = new RptDiseaseAll();
            //rpt.DataSourceConnections = SqlHelper.ConnStr;


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;
        }

        public void ShowReportOperationTypeAll()
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_OperationType_All");
            RptOperationTypeAll rpt= new RptOperationTypeAll();
            //rpt.DataSourceConnections = SqlHelper.ConnStr;


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;
        }

        public void ShowReportOperationTypeFlowChar()
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_All_Dtailse_Opreation");
            RptOpeartaionFlowChar rpt = new RptOpeartaionFlowChar();
            //rpt.DataSourceConnections = SqlHelper.ConnStr;


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;
        }


        public void ShowReportMedication()
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Medications_All");
            RptMedication rpt = new RptMedication();
            //rpt.DataSourceConnections = SqlHelper.ConnStr;


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;
        }
        public void ShowReportAnalysisPatientAll()
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_AnalysisTB_details");
            RptAnalysisPatientID rpt = new RptAnalysisPatientID();
            //rpt.DataSourceConnections = SqlHelper.ConnStr;


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;
        }
        public void ReportPrscriptionPatient(int ID,byte[] imageP)
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Prescription_Report",ID,imageP);
            RptPescription rpt = new RptPescription();
            //rpt.DataSourceConnections = SqlHelper.ConnStr;


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;
        }
        public void ReportAnalysisForPatientID(int ID)
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_AnalysisTB_Report_By_PatientID", ID);
            rptAnalysisForPateintID rpt = new rptAnalysisForPateintID();
            //rpt.DataSourceConnections = SqlHelper.ConnStr;


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;

        }
         public void ReportRptAnalysisAll()
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_AnalysisTB_details");
            RptAnalysisAll rpt = new RptAnalysisAll();
            //rpt.DataSourceConnections = SqlHelper.ConnStr;


            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;

        }

        public void ReportRptRadioReportPatientID(int ID)
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Radio_Report_PatientID", ID);
            RptRadioReportPatientID rpt = new RptRadioReportPatientID();
            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;

        }

           public void ReportRptRptRadioAll()
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Radio_Dateils");
            RptRadioAll rpt = new RptRadioAll();
            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;


        }

          public void ReportRptRadioTypeALL()
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_RadioType_All");
            RptRadioTypeALL rpt = new RptRadioTypeALL();
            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;


        }

         public void ReportRptRadioFlowChar()
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Radio_Dateils");
            RptRadioFlowChar rpt = new RptRadioFlowChar();
            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;


        }
         public void ReportRptDiseaseInhert()
        {
            DataTable tbl = new DataTable();
            tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_LastDisease_details_IsTrue");
             RptDiseaseInhert rpt = new  RptDiseaseInhert();
            rpt.SetDataSource(tbl);
            CryView.ReportSource = rpt;


        }
         public void ReportRptPatientInvoice(int PatientID)
         {
             DataTable tbl = new DataTable();
             tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Invoice_ReprtByPatientID", PatientID);
             RptInvoiceByPatientID rpt = new RptInvoiceByPatientID();
             rpt.SetDataSource(tbl);
             CryView.ReportSource = rpt;


         }

         public void ReportInvoicebyMonth(DateTime From,DateTime To)
         {
             DataTable tbl = new DataTable();
             tbl = SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Invoice_ReportMonth", From, To);
             RptInvoice_ReportMonth rpt = new RptInvoice_ReportMonth();
             rpt.SetDataSource(tbl);
             CryView.ReportSource = rpt;


         }
       
        
  

    }
}
