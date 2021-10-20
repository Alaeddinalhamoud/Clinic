using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using System.Data.SqlClient;
using Lib_Felid;

using Lib_Felid.Patient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace SP_Tables
{
   public class SP_Invoice:Inter_Felid_Invoice
    {
        #region Inter_Felid_Invoice Members
       SqlDataReader _Reader;
       
        public List<Felid_Invoice> SP_Browes_Invioce_All()
        {
            List<Felid_Invoice> List_Invoice = new List<Felid_Invoice>();
            
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Invioce_All");
                while(_Reader.Read())
                {
                    Felid_Invoice _Felid = new Felid_Invoice();
                    
                    _Felid.InVoiceID = (int)_Reader["InVoiceID"];
                    _Felid.VisitID=(int)_Reader["VisitID"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    //_Felid.FirstName = (string)_Reader["FirstName"];
                    
                    _Felid.PaidMoney=(int)_Reader["PaidMoney"];
                    _Felid.Reminder=(int)_Reader["Reminder"];
                    _Felid.Discount=(int)_Reader["Discount"];
                    _Felid.Total=(int)_Reader["Total"];
                    _Felid.DateInvoice = (DateTime)_Reader["DateInvoice"];
                    List_Invoice.Add(_Felid);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _Reader.Close();
                _Reader.Dispose();
            }
            return List_Invoice;
        }

        public Felid_Invoice SP_Browes_Invioce_By_PatientID_Felid(int ID)
        {
            Felid_Invoice _Felid = new Felid_Invoice();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Invioce_By_PatientID_Felid", ID);
                while (_Reader.Read())
                {
                    
                    _Felid.InVoiceID = (int)_Reader["InVoiceID"];
                    _Felid.VisitID = (int)_Reader["VisitID"];
                    _Felid.PatientID  = (int)_Reader["PatientID"];
                    _Felid.PaidMoney = (int)_Reader["PaidMoney"];
                    _Felid.Reminder = (int)_Reader["Reminder"];
                    _Felid.Discount = (int)_Reader["Discount"];
                    _Felid.Total = (int)_Reader["Total"];

                    _Felid.DateInvoice = (DateTime)_Reader["DateInvoice"];
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _Reader.Close();
                _Reader.Dispose();
            }
            return _Felid;
        }

        public int SP_Insert_Invoice(Felid_Invoice Felid)
        {

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Invoice",
                 Felid.VisitID, Felid.PatientID, Felid.PaidMoney, Felid.Reminder, Felid.Discount, Felid.Total,Felid.DateInvoice);
        }

        public int SP_UpDate_Invoice(Felid_Invoice Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpDate_Invoice",
                Felid.InVoiceID,Felid.VisitID,Felid.PatientID,Felid.PaidMoney,Felid.Reminder,Felid.Discount,Felid.Total,Felid.DateInvoice);
            
        }

        public int SP_Delete_Invoice(int ID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Invoice", ID);
            
        }

        #endregion

        #region Inter_Felid_Invoice Members


        public Felid_Invoice SP_Browes_Invoic_By_ID_Felid(int InvoicID)
        {
            Felid_Invoice _Felid = new Felid_Invoice();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Invoic_By_ID_Felid",InvoicID);
                while (_Reader.Read())
                {

                    _Felid.InVoiceID = (int)_Reader["InVoiceID"];
                    _Felid.VisitID = (int)_Reader["VisitID"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.PaidMoney = (int)_Reader["PaidMoney"];
                    _Felid.Reminder = (int)_Reader["Reminder"];
                    _Felid.Discount = (int)_Reader["Discount"];
                    _Felid.Total = (int)_Reader["Total"];
                    _Felid.DateInvoice = (DateTime)_Reader["DateInvoice"];

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _Reader.Close();
                _Reader.Dispose();
            }
            return _Felid;
        }

        #endregion

        #region Inter_Felid_Invoice Members


        public List<Felid_Invoice> SP_Browes_InVoiceID_By_PatientID(int ID)
        {
            List<Felid_Invoice> List_Invoice = new List<Felid_Invoice>();

            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_InVoiceID_By_PatientID",ID);
                while (_Reader.Read())
                {
                    Felid_Invoice _Felid = new Felid_Invoice();

                    _Felid.InVoiceID = (int)_Reader["InVoiceID"];
                    _Felid.VisitID = (int)_Reader["VisitID"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    //_Felid.FirstName = (string)_Reader["FirstName"];

                    _Felid.PaidMoney = (int)_Reader["PaidMoney"];
                    _Felid.Reminder = (int)_Reader["Reminder"];
                    _Felid.Discount = (int)_Reader["Discount"];
                    _Felid.Total = (int)_Reader["Total"];
                    _Felid.DateInvoice = (DateTime)_Reader["DateInvoice"];
                    List_Invoice.Add(_Felid);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _Reader.Close();
                _Reader.Dispose();
            }
            return List_Invoice;
        }

        #endregion

        #region Inter_Felid_Invoice Members


        public DataTable SP_Brows_Invoic_By_Invoice_Report(int InvoiceID)
        {
            try
            {
               return  SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Brows_Invoic_By_Invoice_Report", InvoiceID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SP_Brows_Invoice_Datials()
        {
            try
            {
                return  SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Brows_Invoice_Datials");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Inter_Felid_Invoice Members


        public DataTable SP_Brows_Invoice_Detials_By_PatientID(int ID)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Brows_Invoice_Detials_By_PatientID",ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       


        public DataTable SP_Browes_Invoice_ReprtByPatientID(int PatientID)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Invoice_ReprtByPatientID", PatientID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Inter_Felid_Invoice Members


        public DataTable SP_Browes_Invoice_ReportMonth(DateTime From, DateTime To)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Invoice_ReportMonth", From, To);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
