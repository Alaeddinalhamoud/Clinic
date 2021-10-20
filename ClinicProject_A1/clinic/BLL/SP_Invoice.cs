using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;
using System.Data;

namespace BLL
{
    public class SP_Invoice 
    {
        public static readonly Inter_Felid_Invoice dal = DataAccess.CreateInvoiceTB();

        #region Inter_Felid_Invoice Members

        public List<Felid_Invoice> SP_Browes_Invioce_All()
        {
            return dal.SP_Browes_Invioce_All();
        }

        public Felid_Invoice SP_Browes_Invioce_By_PatientID_Felid(int ID)
        {
            return dal.SP_Browes_Invioce_By_PatientID_Felid(ID);
        }

        public Felid_Invoice SP_Browes_Invoic_By_ID_Felid(int InvoicID)
        {
            return dal.SP_Browes_Invoic_By_ID_Felid(InvoicID);
        }

        public int SP_Insert_Invoice(Felid_Invoice Felid)
        {
            return dal.SP_Insert_Invoice(Felid);
        }

        public int SP_UpDate_Invoice(Felid_Invoice Felid)
        {
            return dal.SP_UpDate_Invoice(Felid);
        }

        public int SP_Delete_Invoice(int ID)
        {
            return dal.SP_Delete_Invoice(ID);
        }

        public List<Felid_Invoice> SP_Browes_InVoiceID_By_PatientID(int ID)
        {
            return dal.SP_Browes_InVoiceID_By_PatientID(ID);
        }


        public DataTable SP_Brows_Invoic_By_Invoice_Report(int InvoiceID)
        {
            return dal.SP_Brows_Invoic_By_Invoice_Report(InvoiceID);
        }

        public DataTable SP_Brows_Invoice_Datials()
        {
            return dal.SP_Brows_Invoice_Datials();
        }

    


        public DataTable SP_Brows_Invoice_Detials_By_PatientID(int ID)
        {
            return dal.SP_Brows_Invoice_Detials_By_PatientID(ID);
        }

        


        public DataTable SP_Browes_Invoice_ReprtByPatientID(int PatientID)
        {
            return dal.SP_Browes_Invoice_ReprtByPatientID(PatientID);
        }

    

       


        public DataTable SP_Browes_Invoice_ReportMonth(DateTime From, DateTime To)
        {
            return dal.SP_Browes_Invoice_ReportMonth(From, To);
        }

        #endregion
    }
}
