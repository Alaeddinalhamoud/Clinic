using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
    public interface  Inter_Felid_Disase_Visit
    {
        int SP_Insert_Diasase_Patient_AndVisit(Felid_Disase_Visit Felid);
        int SP_UPdate_Diasase_Patient_AndVisit(Felid_Disase_Visit Felid);
        int SP_Delete_Diasase_Patient_AndVisit(int DisisaeID);
        DataTable SP_Brows_Diasase_Patient_AndVisit(int PatientID, int VisitID);
        Felid_Disase_Visit SP_Brows_Disise_Visit_Felid(int DisiaseID);
    }
}
