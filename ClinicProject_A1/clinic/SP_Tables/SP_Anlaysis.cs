using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using Lib_Felid;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;


namespace SP_Tables
{
    public class SP_Anlaysis:Inter_Felid_Anlaysis
    {
        #region Inter_Felid_Anlaysis Members
        SqlDataReader _Reader;
        public List<Felid_Anlaysis> SP_Browes_Analysis_All()
        {
            List<Felid_Anlaysis> List_Anlaysis = new List<Felid_Anlaysis>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,"SP_Browes_Analysis_All");
                while (_Reader.Read())
                {
                    Felid_Anlaysis _Felid = new Felid_Anlaysis();
                    _Felid.AnalysisID = (int)_Reader["AnalysisID"];
                    _Felid.AnalysisTypeID = (int)_Reader["AnalysisTypeID"];
                    _Felid.AnalysisSubject = (string)_Reader["AnalysisSubject"];
                    _Felid.AnalysisResult = (string)_Reader["AnalysisResult"];
                    _Felid.VisitID = (int)_Reader["VisitID"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    List_Anlaysis.Add(_Felid);


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
            return List_Anlaysis;
        }

        public Felid_Anlaysis SP_Browes_Analysis_By_AnalysisID_Felid(int ID)
        {
            Felid_Anlaysis _Felid = new Felid_Anlaysis();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Analysis_By_AnalysisID_Felid",ID);
                if (_Reader.Read())
                {
                   
                    _Felid.AnalysisID = (int)_Reader["AnalysisID"];
                    _Felid.AnalysisTypeID = (int)_Reader["AnalysisTypeID"];
                    _Felid.AnalysisSubject = (string)_Reader["AnalysisSubject"];
                    _Felid.AnalysisResult = (string)_Reader["AnalysisResult"];
                    _Felid.VisitID = (int)_Reader["VisitID"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                   


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

        public List<Felid_Anlaysis> SP_Browes_Analysis_By_PatientID(int ID)
        {
            List<Felid_Anlaysis> List_Anlaysis = new List<Felid_Anlaysis>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Analysis_By_PatientID",ID);
                while (_Reader.Read())
                {
                    Felid_Anlaysis _Felid = new Felid_Anlaysis();
                    _Felid.AnalysisID = (int)_Reader["AnalysisID"];
                    _Felid.AnalysisTypeID = (int)_Reader["AnalysisTypeID"];
                    _Felid.AnalysisSubject = (string)_Reader["AnalysisSubject"];
                    _Felid.AnalysisResult = (string)_Reader["AnalysisResult"];
                    _Felid.VisitID = (int)_Reader["VisitID"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    List_Anlaysis.Add(_Felid);


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
            return List_Anlaysis;
        }

        public int SP_Insert_Analysis(Felid_Anlaysis Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Analysis", Felid.AnalysisTypeID, Felid.AnalysisSubject, Felid.AnalysisResult, Felid.VisitID, Felid.PatientID);
        }

        public int SP_UpData_Analysis(Felid_Anlaysis Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_Analysis", Felid.AnalysisID, Felid.AnalysisTypeID, Felid.AnalysisSubject, Felid.AnalysisResult, Felid.VisitID, Felid.PatientID);
            
        }

        public int SP_Delete_Analysis(int ID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Analysis", ID);
        }

        #endregion

        #region Inter_Felid_Anlaysis Members


        public DataTable SP_Browes_AnalysisTB_details()
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr,"SP_Browes_AnalysisTB_details");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable SP_Browes_AnalysisTB_Report_By_PatientID(int PatientID)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_AnalysisTB_Report_By_PatientID", PatientID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

       
    }
}
