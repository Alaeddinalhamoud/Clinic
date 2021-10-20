using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface  Inter_Felid_AnlaysisType
    {
        List<Filed_AnalysisType> SP_Browes_AnalysisTypeTB_All();
        List<Filed_AnalysisType> SP_Browes_AnalysisType_By_ID_List(int ID);
        List<Filed_AnalysisType> SP_Browes_AnalysisTypeTB_By_Name(string AnalysisType);
        int SP_Delete_AnalysisTypeTB(int AnalysisTypeID);
        Filed_AnalysisType SP_Browes_AnalysisTypeTB_By_Name_Felid(string  Analysis);
        int SP_UpData_AnalysisTypeTB(Filed_AnalysisType Felid);
        int SP_Insert_AnalysisTypeTB(Filed_AnalysisType Felid);
        Filed_AnalysisType SP_Browes_AnalysisTypeTB_By_ID_Felid(int AnalysisTypeID);
        bool   MakeSureToAddAnalysis(string s);
        string  SP_Make_Sure_Analysis(int s);

    }
}