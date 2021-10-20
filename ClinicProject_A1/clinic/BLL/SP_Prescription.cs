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
    public class SP_Prescription 
    {
        public static readonly Inter_Felid_Prescription dal = DataAccess.CreatePrescriptionTB();


        #region Inter_Felid_Prescription Members

        public int SP_UpData_Prescription(Felid_Prescription Felid)
        {
            return dal.SP_UpData_Prescription(Felid);
        }

        public int SP_Insert_Prescription(Felid_Prescription Felid)
        {
            return dal.SP_Insert_Prescription(Felid);
        }

        public int SP_Delete_Prescription(int PrescriptionID)
        {
            return dal.SP_Delete_Prescription(PrescriptionID);
        }

        public List<Felid_Prescription> SP_Browes_Prescription_By_Patient(int PatientID)
        {
            return dal.SP_Browes_Prescription_By_Patient(PatientID);
        }

        public Felid_Prescription SP_Browes_Prescription_By_ID_Felid(int PatientID)
        {
            return dal.SP_Browes_Prescription_By_ID_Felid(PatientID);
        }

        


        public DataTable SP_Browes_Prescription_Datials_PatientID(int ID)
        {
            return dal.SP_Browes_Prescription_Datials_PatientID(ID);
        }

        public DataTable SP_Browes_Prescription_Datials()
        {
            return dal.SP_Browes_Prescription_Datials();
        }

        #endregion

        #region Inter_Felid_Prescription Members


        public Felid_Prescription Browes_Perscreption_All_List_By_PatientID(int PatientID)
        {
            return dal.Browes_Perscreption_All_List_By_PatientID(PatientID);
        }

        #endregion
    }
}
