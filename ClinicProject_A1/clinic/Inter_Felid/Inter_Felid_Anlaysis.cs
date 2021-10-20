using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
    public interface  Inter_Felid_Anlaysis
    {
        List<Felid_Anlaysis> SP_Browes_Analysis_All();
        Felid_Anlaysis SP_Browes_Analysis_By_AnalysisID_Felid(int ID);
        List<Felid_Anlaysis> SP_Browes_Analysis_By_PatientID(int ID);
        int SP_Insert_Analysis(Felid_Anlaysis Felid);
        int SP_UpData_Analysis(Felid_Anlaysis Felid);
        int SP_Delete_Analysis(int ID);
        DataTable SP_Browes_AnalysisTB_details();
        DataTable SP_Browes_AnalysisTB_Report_By_PatientID(int PatientID);

    }
}
