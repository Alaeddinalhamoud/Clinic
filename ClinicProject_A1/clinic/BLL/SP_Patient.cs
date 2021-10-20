using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid.Patient;
using System.Data;
using System.Drawing;

namespace BLL
{
    public class SP_Patient 
    {
        private static readonly Inter_Felid_Patient dal = DataAccess.CreatePatientTB();
        #region Inter_Felid_Patient Members

        public List<Felid_Patient> SP_Browes_Patient_All()
        {
            return dal.SP_Browes_Patient_All();
        }

        public List<Felid_Patient> SP_Browes_Patient_FullName()
        {
            return dal.SP_Browes_Patient_FullName();
        }

        public Felid_Patient SP_Browes_Patient_By_PatientID(int PatientID)
        {
            return dal.SP_Browes_Patient_By_PatientID(PatientID);
        }

        public Felid_Patient SP_Browes_Patient_Name_By_ID(int PatientID)
        {
            return dal.SP_Browes_Patient_Name_By_ID(PatientID);
        }

        public Felid_Patient SP_Browes_Patient_By_LastName(string LastName)
        {
            return dal.SP_Browes_Patient_By_LastName(LastName);
        }

        public Felid_Patient SP_Browes_Patient_By_FirstName(string FirstName)
        {
            return dal.SP_Browes_Patient_By_FirstName(FirstName);
        }

        public List<Felid_Patient> SP_Browes_Patient_By_PatientID_Felid(int PatientID)
        {
            return dal.SP_Browes_Patient_By_PatientID_Felid(PatientID);
        }

        public List<Felid_Patient> SP_Browes_Patient_List_By_FirstName(string FirstName)
        {
           return  dal.SP_Browes_Patient_List_By_FirstName(FirstName);
        }

        public List<Felid_Patient> SP_Browes_Patient_List_By_LastName(string LastName)
        {
            return dal.SP_Browes_Patient_List_By_LastName(LastName);
        }

        public int SP_Insert_Patient(Felid_Patient Felid)
        {
           return  dal.SP_Insert_Patient(Felid);     
        }

        public int SP_Update_Patient_By_PatientID(Felid_Patient Felid)
        {
            return dal.SP_Update_Patient_By_PatientID(Felid);
        }

        public int SP_Delete_Patient_By_PatientID(int PatientID)
        {
            return dal.SP_Delete_Patient_By_PatientID(PatientID);
        }

        public List<Felid_Patient> SP_Browes_Patient_FullName_By_ID(int ID)
        {
            return dal.SP_Browes_Patient_FullName_By_ID(ID);
        }

        public Felid_Patient SP_Browes_Patient_FullName_By_ID_Felid(int ID)
        {
            return dal.SP_Browes_Patient_FullName_By_ID_Felid(ID);
        }

        public int SP_UpData_Patient_Image_Path_By_ID(Felid_Patient Felid)
        {
            return dal.SP_UpData_Patient_Image_Path_By_ID(Felid);
        }

        


        public DataTable SP_Brows_Datails_Patient_Report_From_To_Date(DateTime FromDate, DateTime ToDate)
        {
            return dal.SP_Brows_Datails_Patient_Report_From_To_Date(FromDate, ToDate);
        }

        public DataTable SP_Brows_Datails_Patient_Report(int ID,Image i)
        {
            return dal.SP_Brows_Datails_Patient_Report(ID,i);
        }

        #endregion
    }
}
