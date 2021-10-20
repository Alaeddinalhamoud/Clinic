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
    public class SP_Patient_Medication : Inter_Felid_Patient_Medication
    {
        #region Inter_Felid_Patient_Medication Members
        SqlDataReader _Reader;
        public List<Felid_Patient_Medication> Felid_Patient_Medication()
        {
            List<Felid_Patient_Medication> List_Patient_Medication = new List<Felid_Patient_Medication>();
            
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,"Felid_Patient_Medication");
                while (_Reader.Read())
                {
                    Felid_Patient_Medication _Felid = new Felid_Patient_Medication();
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.MedicationID = (int)_Reader["MedicationID"];
                    List_Patient_Medication.Add(_Felid);
                    
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
            return List_Patient_Medication;
        }

        public int SP_Insert_Patient_Medication(Felid_Patient_Medication Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Patient_Medication",
                Felid.PatientID ,
                Felid.MedicationID);
        }

        public int SP_UpData_Patient_Medication(Felid_Patient_Medication Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_Patient_Medication",
                Felid.PatientID,
                Felid.MedicationID);
        }

        #endregion
    }
}
