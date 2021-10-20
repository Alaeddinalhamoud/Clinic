using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid.Patient;
using System.Data;
using System.Drawing;

namespace Inter_Felid
{
    public interface  Inter_Felid_Patient
    {
      List<Felid_Patient> SP_Browes_Patient_All();
      List<Felid_Patient> SP_Browes_Patient_FullName();
      Felid_Patient SP_Browes_Patient_By_PatientID(int PatientID);
      Felid_Patient SP_Browes_Patient_Name_By_ID(int PatientID);
      Felid_Patient SP_Browes_Patient_By_LastName(string LastName);
      Felid_Patient SP_Browes_Patient_By_FirstName(string FirstName);
      List<Felid_Patient> SP_Browes_Patient_By_PatientID_Felid(int PatientID);
      List<Felid_Patient> SP_Browes_Patient_List_By_FirstName(string FirstName);
      List<Felid_Patient> SP_Browes_Patient_List_By_LastName(string LastName);
      int SP_Insert_Patient(Felid_Patient Felid);
      int SP_Update_Patient_By_PatientID(Felid_Patient Felid);
      int SP_Delete_Patient_By_PatientID(int PatientID);
      List<Felid_Patient> SP_Browes_Patient_FullName_By_ID(int ID);
      Felid_Patient SP_Browes_Patient_FullName_By_ID_Felid(int ID);
       int SP_UpData_Patient_Image_Path_By_ID(Felid_Patient Felid);
        DataTable SP_Brows_Datails_Patient_Report_From_To_Date(DateTime FromDate, DateTime ToDate); 
       
       DataTable  SP_Brows_Datails_Patient_Report(int ID,Image i);
  
    }
}
