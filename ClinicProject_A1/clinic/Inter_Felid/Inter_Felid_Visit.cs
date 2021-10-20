using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
    public interface Inter_Felid_Visit
    {
        List<Felid_Visit> SP_Browes_VisitTB_All();
        List<Felid_Visit> SP_Browes_VisitTB_By_ID(int ID);
        List<Felid_Visit> SP_Browes_VisitTB_By_PatientID(int PatientID);
        Felid_Visit SP_Browes_VisitTB_By_ID_Felid(int ID);
        int SP_Delete_VisitTB_By_ID(int ID);
        int SP_Insert_VisitTB(Felid_Visit Felid);
        int SP_UpData_VisitTB_By_ID(Felid_Visit Felid);
        List<Felid_Visit> SP_Browes_Visit_Date_By_PatientID(int ID);
        List<Felid_Visit> SP_Browes_Visit_Date_All();
        DataTable SP_Brows_VisitTB_Ditalse();
        DataTable SP_Browes_Visit_Detiles_PatientID(int PatientID);
    }
}
