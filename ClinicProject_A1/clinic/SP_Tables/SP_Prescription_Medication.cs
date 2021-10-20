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
    public class SP_Prescription_Medication : Inter_Felid_Prescription_Medication
    {
        #region Inter_Felid_Prescription_Medication Members
        SqlDataReader _Reader;

        public Felid_Prescription_Medication SP_Browes_Patient_Medication()
        {
            Felid_Prescription_Medication _Felid = new Felid_Prescription_Medication();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Patient_Medication");
                while (_Reader.Read())
                {
                    _Felid.PrescriptionID = (int)_Reader["PrescriptionID"];
                    _Felid.MedicationID = (int)_Reader["MedicationID"];

                    
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
