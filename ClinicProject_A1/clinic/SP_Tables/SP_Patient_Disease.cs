using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using Lib_Felid;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace SP_Tables
{
    public class SP_Patient_Disease : Inter_Felid_Patient_Disease
    {
        #region Inter_Felid_Patient_Disease Members
        SqlDataReader _Reader;
        public List<Felid_Patient_Disease> SP_Browes_Patient_Last_Disease()
        {
            List<Felid_Patient_Disease> List_Patient_Disease = new List<Felid_Patient_Disease>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Patient_Last_Disease");
                while (_Reader.Read())
                {
                    Felid_Patient_Disease _Felid = new Felid_Patient_Disease();
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.DiseaseID = (int)_Reader["DiseaseID"];
                    List_Patient_Disease.Add(_Felid);
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
            return List_Patient_Disease;

        }

        public int SP_Insert_Patient_Last_Disease(Felid_Patient_Disease Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Patient_Last_Disease",
                Felid.PatientID ,
                Felid.DiseaseID);
        }

        public int SP_UpData_Patient_Last_Disease_By_PatientID(Felid_Patient_Disease Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr,"SP_UpData_Patient_Last_Disease_By_PatientID",
                 Felid.PatientID,
                 Felid.DiseaseID);
        }

        #endregion
    }
}
