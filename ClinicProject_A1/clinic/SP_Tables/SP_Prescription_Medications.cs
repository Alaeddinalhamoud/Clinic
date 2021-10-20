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
    public class SP_Prescription_Medications : Inter_Felid_Prescription_Medications
    {
        #region Inter_Felid_Prescription_Medications Members
      
        
       

        public int SP_Delete_Prescription_Medication(int ID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Prescription_Medication", ID);
        }

        public int SP_Insert_Prescription_Medication(Felid_Prescription_Medications Felid)
        {
            
                return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Prescription_Medication"
                    , Felid.PrescriptionID, Felid.MedicationID, Felid.Dose, Felid.MedicalCount, Felid.Cleander_Of_Dose, Felid.Type_Of_Medication, Felid.Time_Of_Dose, Felid.Note);
            
        }

        public int SP_UpDate_Prescription_Medication(Felid_Prescription_Medications Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpDate_Prescription_Medication"
               , Felid.PrescriptionID, Felid.MedicationID, Felid.Dose, Felid.MedicalCount, Felid.Cleander_Of_Dose, Felid.Type_Of_Medication, Felid.Time_Of_Dose, Felid.Note);
            
        }

        


        public DataTable SP_Browes_Prescription_Medication_By_PrescriptionID_List(int PrescriptionID)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Prescription_Medication_By_PrescriptionID_List",PrescriptionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        


        


        Felid_Prescription_Medications Inter_Felid_Prescription_Medications.SP_Browes_Prescription_Medication_By_PrescriptionID_Felid(int PrescriptionID)
        {
            SqlDataReader _Reader;
            Felid_Prescription_Medications _Felid = new Felid_Prescription_Medications();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Prescription_Medication_By_PrescriptionID_Felid", PrescriptionID);
                while (_Reader.Read())
                {
                    
                    _Felid.PrescriptionID = (int)_Reader["PrescriptionID"];
                    _Felid.MedicationID = (int)_Reader["MedicationID"];
                    _Felid.Dose = (int)_Reader["Dose"];
                    _Felid.MedicalCount = (int)_Reader["MedicalCount"];
                    _Felid.Cleander_Of_Dose = (string)_Reader["Cleander_Of_Dose"];
                    _Felid.Type_Of_Medication = (string)_Reader["Type_Of_Medication"];
                    _Felid.Time_Of_Dose = (string)_Reader["Time_Of_Dose"];
                    _Felid.Note = (string)_Reader["Note"];
                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _Felid;  
        }

        #endregion

        #region Inter_Felid_Prescription_Medications Members


        public DataTable SP_Prescription_Report(int ID)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr,"SP_Prescription_Report", ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
