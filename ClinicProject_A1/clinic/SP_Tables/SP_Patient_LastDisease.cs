using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using System.Data.SqlClient;
using Lib_Felid;
using Microsoft.ApplicationBlocks.Data;
using System.Data;


namespace SP_Tables
{
    public class SP_Patient_LastDisease : Inter_Felid_Patient_LastDisease
    {
        #region Inter_Felid_Patient_LastDisease Members

        SqlDataReader _Reader;

        public List<Felid_Patient_LastDisease> SP_Browes_Patient_LastDisease_All()
        {

            List<Felid_Patient_LastDisease> List_LastDisease = new List<Felid_Patient_LastDisease>();

            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Patient_LastDisease_All");
                while (_Reader.Read())
                {
                    Felid_Patient_LastDisease _Felid = new Felid_Patient_LastDisease();
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.DiseaseID = (int)_Reader["DiseaseID"];
                    _Felid.LastDiseaseID = (int)_Reader["LastDiseaseID"];
                    _Felid.FamilyDisease = (bool)_Reader["FamilyDisease"];
                    _Felid.DateOfDisease = (DateTime)_Reader["DateOfDisease"];

                    List_LastDisease.Add(_Felid);

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
            return List_LastDisease;

        }

        public Felid_Patient_LastDisease SP_Browes_Patient_LastDisease_By_ID_Felid(int ID)
        {
            
          Felid_Patient_LastDisease _Felid = new Felid_Patient_LastDisease();

            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Patient_LastDisease_By_ID_Felid",ID);
                if (_Reader.Read())
                {
                 
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.DiseaseID = (int)_Reader["DiseaseID"];
                    _Felid.LastDiseaseID = (int)_Reader["LastDiseaseID"];
                    _Felid.FamilyDisease = (bool)_Reader["FamilyDisease"];
                    _Felid.DateOfDisease = (DateTime)_Reader["DateOfDisease"];


                  

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

        public int SP_Delete_Patient_LastDisease(int ID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Patient_LastDisease", ID);
        }

        public int SP_Insert_Patient_LastDisease(Felid_Patient_LastDisease Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Patient_LastDisease",
                 Felid.PatientID, Felid.DiseaseID,Felid.FamilyDisease,Felid.DateOfDisease);
        }

        public int SP_UpData_Patient_LastDisease(Felid_Patient_LastDisease Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_Patient_LastDisease",
               Felid.PatientID, Felid.DiseaseID, Felid.LastDiseaseID,Felid.FamilyDisease,Felid.DateOfDisease);
        }

        #endregion

        #region Inter_Felid_Patient_LastDisease Members


        public DataTable SP_Browes_LastDisease_details()
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_LastDisease_details");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Inter_Felid_Patient_LastDisease Members


        public DataTable SP_Browes_LastDisease_details_IsTrue()
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_LastDisease_details_IsTrue");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
