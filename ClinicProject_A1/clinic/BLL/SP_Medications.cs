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
    public class SP_Medications
    {
        public static readonly Inter_Felid_Medications dal = DataAccess.CreatMedications();


        #region Inter_Felid_Medications Members

        public List<Felid_Medications> SP_Browes_Medications_All()
        {
            return dal.SP_Browes_Medications_All();
        }

        public List<Felid_Medications> SP_Browes_Medications_By_ID(int MedicationID)
        {
            return dal.SP_Browes_Medications_By_ID(MedicationID);
        }

        public List<Felid_Medications> SP_Browes_Medications_By_Name(string MedicationName)
        {
            return dal.SP_Browes_Medications_By_Name(MedicationName);
        }

        public Felid_Medications SP_Browes_Medications_By_ID_Felid(int MedicationID)
        {
            return dal.SP_Browes_Medications_By_ID_Felid(MedicationID);
        }

        public int SP_Insert_Medications(Felid_Medications Felid)
        {
            return dal.SP_Insert_Medications(Felid);
        }

        public int SP_UpDate_Medications_By_ID(Felid_Medications Felid)
        {
            return dal.SP_UpDate_Medications_By_ID(Felid);
        }

        public int SP_Delete_Medications_By_ID(int MedicationID)
        {
            return dal.SP_Delete_Medications_By_ID(MedicationID);
        }

        #endregion

        #region Inter_Felid_Medications Members


        public DataTable SP_Browes_Pharmacy_By_Medication_Name(string MedicationName)
        {
            return dal.SP_Browes_Pharmacy_By_Medication_Name(MedicationName);
        }

        public DataTable SP_Browes_Pharmacy_By_Company_Name(string CompanyName)
        {
            return dal.SP_Browes_Pharmacy_By_Company_Name(CompanyName);
        }

        public DataTable SP_Browes_Pharmacy_By_SideEffect(string SideEffect)
        {
            return dal.SP_Browes_Pharmacy_By_SideEffect(SideEffect);
        }

        public DataTable SP_Browes_Pharmacy_By_MedicalOfConsultation(string MedicalOfConsultation)
        {
            return dal.SP_Browes_Pharmacy_By_MedicalOfConsultation(MedicalOfConsultation);
        }

        public DataTable SP_Browes_Pharmacy_By_OverlapOfMedication(string OverLap)
        {
            return dal.SP_Browes_Pharmacy_By_OverlapOfMedication(OverLap);
        }

        #endregion
    }
}
