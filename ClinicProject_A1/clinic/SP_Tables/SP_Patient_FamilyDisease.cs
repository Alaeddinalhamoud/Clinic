using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using System.Data.SqlClient;
using Lib_Felid;
using Microsoft.ApplicationBlocks.Data;

namespace SP_Tables
{
    public class SP_Patient_FamilyDisease : Inter_Felid_Patient_FamilyDisease
    {

        #region Inter_Felid_Patient_FamilyDisease Members
        SqlDataReader _Reader;
        public List<Felid_Patient_FamilyDisease> SP_Browes_Patient_FamilyDisease()
        {
            List<Felid_Patient_FamilyDisease> List_Patient_FamilyDisease = new List<Felid_Patient_FamilyDisease>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Patient_FamilyDisease");
                while (_Reader.Read())
                {
                    Felid_Patient_FamilyDisease _Felid = new Felid_Patient_FamilyDisease();
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.DiseaseID = (int)_Reader["DiseaseID"];
                    List_Patient_FamilyDisease.Add(_Felid);
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
            return List_Patient_FamilyDisease;
        }

        public int SP_Insert_Patient_FamilyDisease(Felid_Patient_FamilyDisease Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Patient_FamilyDisease",
                Felid.PatientID,
                Felid.DiseaseID);
        }

        public int SP_UpData_Patient_FamilyDisease_By_PatientID(Felid_Patient_FamilyDisease Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr,"SP_UpData_Patient_FamilyDisease_By_PatientID",
                 Felid.PatientID,
                 Felid.DiseaseID); 
        }

        #endregion
    }
}
