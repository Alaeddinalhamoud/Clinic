using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
  public  interface Inter_Felid_Prescription
    {
      int SP_UpData_Prescription(Felid_Prescription Felid);
      int SP_Insert_Prescription(Felid_Prescription Felid);
      int SP_Delete_Prescription(int PrescriptionID);
      List<Felid_Prescription> SP_Browes_Prescription_By_Patient(int PatientID);
      Felid_Prescription Browes_Perscreption_All_List_By_PatientID(int PatientID); 
      Felid_Prescription SP_Browes_Prescription_By_ID_Felid(int PatientID);
      DataTable SP_Browes_Prescription_Datials_PatientID(int ID);
      DataTable SP_Browes_Prescription_Datials();

    }
}
