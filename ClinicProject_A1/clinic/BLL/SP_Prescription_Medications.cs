using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;
using System.Data;

namespace BLL
{
    public class SP_Prescription_Medications 
    {
        public static readonly Inter_Felid_Prescription_Medications dal = DataAccess.CreatePrescription_Medication();


        #region Inter_Felid_Prescription_Medications Members

        public int SP_Delete_Prescription_Medication(int ID)
        {
            return dal.SP_Delete_Prescription_Medication(ID);
        }

        public int SP_Insert_Prescription_Medication(Felid_Prescription_Medications Felid)
        {
            return dal.SP_Insert_Prescription_Medication(Felid);
        }

        public int SP_UpDate_Prescription_Medication(Felid_Prescription_Medications Felid)
        {
            return dal.SP_UpDate_Prescription_Medication(Felid);
        }




        public DataTable SP_Browes_Prescription_Medication_By_PrescriptionID_List(int PrescriptionID)
        {
            return dal.SP_Browes_Prescription_Medication_By_PrescriptionID_List(PrescriptionID);
        }

        public Felid_Prescription_Medications SP_Browes_Prescription_Medication_By_PrescriptionID_Felid(int PrescriptionID)
        {
            return dal.SP_Browes_Prescription_Medication_By_PrescriptionID_Felid(PrescriptionID);
        }
  


        public DataTable SP_Prescription_Report(int ID)
        {
            return dal.SP_Prescription_Report(ID);
        }

        #endregion
    }
}
