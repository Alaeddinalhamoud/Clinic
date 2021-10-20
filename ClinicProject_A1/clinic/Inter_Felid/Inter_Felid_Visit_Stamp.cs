using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
    public interface Inter_Felid_Visit_Stamp
    {
        DataTable SP_Browes_Visit_Stamp_ByVisitID(int VisitID);
        int SP_Delete_Visit_Stamp_ByVisitID(int StampID);
        int SP_UpDate_Visit_Stamp_ByVisitID(Felid_Visit_Stamp Felid);
        int SP_Insert_Visit_Stamp(Felid_Visit_Stamp Felid);
        List<int> SP_Browes_Stamp_Visit_ByPatient_Visit(int VisitID, int PatientID);
    }
}
