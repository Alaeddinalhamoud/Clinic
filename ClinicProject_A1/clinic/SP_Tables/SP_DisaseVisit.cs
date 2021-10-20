using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using Lib_Felid;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;

namespace SP_Tables
{
    public class SP_DisaseVisit : Inter_Felid_Disase_Visit
    {
        #region Inter_Felid_Disase_Visit Members
        SqlDataReader _Reader;
        public int SP_Insert_Diasase_Patient_AndVisit(Felid_Disase_Visit Felid)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Diasase_Patient_AndVisit", Felid.VisitID, Felid.PatientID, Felid.DiseaseID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SP_UPdate_Diasase_Patient_AndVisit(Felid_Disase_Visit Felid)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UPdate_Diasase_Patient_AndVisit", Felid.VisitID, Felid.PatientID, Felid.DiseaseID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SP_Delete_Diasase_Patient_AndVisit(int DisisaeID)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Diasase_Patient_AndVisit",DisisaeID);
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public DataTable SP_Brows_Diasase_Patient_AndVisit(int PatientID,int VisitID)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Brows_Diasase_Patient_AndVisit",PatientID,VisitID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Inter_Felid_Disase_Visit Members


        public Felid_Disase_Visit SP_Brows_Disise_Visit_Felid(int DisiaseID)
        {
           
            Felid_Disase_Visit _Felid = new Felid_Disase_Visit();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,"SP_Brows_Disise_Visit_Felid", DisiaseID);
                if(_Reader.Read())
                {
                    _Felid.VisitID = (int)_Reader["VisitID"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.DiseaseID = (int)_Reader["DiseaseID"];
                   
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
    }
}
