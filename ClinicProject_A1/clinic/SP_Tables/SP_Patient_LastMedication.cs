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
    public  class SP_Patient_LastMedication:Inter_Felid_Patient_LastMedication
    {
        #region Inter_Felid_Patient_LastMedication Members
        SqlDataReader _Reader;

        public List<Felid_Patient_LastMedication> SP_Browes_Patient_LastMedication_All()
        {

            List<Felid_Patient_LastMedication> List_Patient_LastMedication = new List<Felid_Patient_LastMedication>();

            try
            {


                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,"SP_Browes_Patient_LastMedication_All");
                while (_Reader.Read())
                {
                    Felid_Patient_LastMedication _Felid = new Felid_Patient_LastMedication();
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.MedicationID = (int)_Reader["MedicationID"];
                    _Felid.LastMedicationID = (int)_Reader["LastMedicationID"];
                    _Felid.DateOfMedication =(DateTime)_Reader["DateOfMedication"];
                    


                   List_Patient_LastMedication.Add(_Felid);

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
            return List_Patient_LastMedication;
         
        }

        public Felid_Patient_LastMedication SP_Browes_Patient_LastMedication_By_ID_Felid(int ID)
        {
            Felid_Patient_LastMedication _Felid = new Felid_Patient_LastMedication();

            try
            {


                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Patient_LastMedication_By_ID_Felid",ID);
                if (_Reader.Read())
                {
                    
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.MedicationID = (int)_Reader["MedicationID"];
                    _Felid.LastMedicationID = (int)_Reader["LastMedicationID"];
                    _Felid.DateOfMedication =(DateTime)_Reader["DateOfMedication"];       

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

        public int SP_Delete_Patient_LastMedication_By_ID(int ID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr,"SP_Delete_Patient_LastMedication_By_ID",ID);
        }

        public int SP_Insert_Patient_LastMedication(Felid_Patient_LastMedication Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Patient_LastMedication", Felid.PatientID,
                Felid.MedicationID, Felid.DateOfMedication);
        }

        public int SP_UpData_Patient_LastMedication_By_ID(Felid_Patient_LastMedication Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_Patient_LastMedication_By_ID"
              
                ,Felid.PatientID,
                 Felid.MedicationID,Felid.LastMedicationID,Felid.DateOfMedication);

        }

        #endregion

        #region Inter_Felid_Patient_LastMedication Members


        public DataTable SP_Browes_LastMedication_details()
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr,"SP_Browes_LastMedication_details");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SP_Browes_LastMedication_Report(int LastMedicationID)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_LastMedication_Report", LastMedicationID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        #endregion
    }
}
