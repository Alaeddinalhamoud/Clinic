using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
    public interface  Inter_Felid_Patient_LastMedication
    {
        List<Felid_Patient_LastMedication> SP_Browes_Patient_LastMedication_All();
        Felid_Patient_LastMedication SP_Browes_Patient_LastMedication_By_ID_Felid(int ID);
        int SP_Delete_Patient_LastMedication_By_ID(int ID);
        int SP_Insert_Patient_LastMedication(Felid_Patient_LastMedication Felid);
        int SP_UpData_Patient_LastMedication_By_ID(Felid_Patient_LastMedication Felid);
        DataTable SP_Browes_LastMedication_details();
        DataTable SP_Browes_LastMedication_Report(int LastMedicationID);
    }
}
