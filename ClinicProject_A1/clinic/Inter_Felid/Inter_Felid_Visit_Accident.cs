using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lib_Felid;

namespace Inter_Felid
{
    public interface  Inter_Felid_Visit_Accident
    {
        DataTable SP_Browes_Visit_AccidentByVisitID(int VisitID);
        List<int> SP_Browes_Accident_Visit_ByPatient_Visit(int VisitID, int PatientID);
        int SP_Insert_Visit_Accident(Felid_Visit_Accident Felid);
        int SP_Delete_Visit_Accident_ByAccidentID(int AccidentID);

    }
}
 