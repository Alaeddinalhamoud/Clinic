using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
    public interface  Inter_Felid_Prescription_Medications
    {
      
        int SP_Delete_Prescription_Medication(int ID);
        int SP_Insert_Prescription_Medication(Felid_Prescription_Medications Felid);
        int SP_UpDate_Prescription_Medication(Felid_Prescription_Medications Felid);
       DataTable SP_Browes_Prescription_Medication_By_PrescriptionID_List(int PrescriptionID);
       Felid_Prescription_Medications SP_Browes_Prescription_Medication_By_PrescriptionID_Felid(int PrescriptionID);
       DataTable SP_Prescription_Report(int ID);
    }
}
