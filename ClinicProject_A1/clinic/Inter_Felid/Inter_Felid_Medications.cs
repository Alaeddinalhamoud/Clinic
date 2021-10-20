using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
    public interface  Inter_Felid_Medications
    {
        List<Felid_Medications> SP_Browes_Medications_All();
        List<Felid_Medications> SP_Browes_Medications_By_ID(int MedicationID);
        List<Felid_Medications> SP_Browes_Medications_By_Name(string MedicationName);
        Felid_Medications SP_Browes_Medications_By_ID_Felid(int MedicationID);
        int SP_Insert_Medications(Felid_Medications Felid);
        int SP_UpDate_Medications_By_ID(Felid_Medications Felid);
        int SP_Delete_Medications_By_ID(int MedicationID);
        DataTable SP_Browes_Pharmacy_By_Medication_Name(string MedicationName);
        DataTable SP_Browes_Pharmacy_By_Company_Name(string CompanyName);
        DataTable SP_Browes_Pharmacy_By_SideEffect(string SideEffect);
        DataTable SP_Browes_Pharmacy_By_MedicalOfConsultation(string MedicalOfConsultation);
        DataTable SP_Browes_Pharmacy_By_OverlapOfMedication(string OverLap);
    }
}
