using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;

namespace BLL
{
    public class SP_AnalysisType 
    {
        public static readonly Inter_Felid_AnlaysisType dal = DataAccess.CreateAnalysisTypeTB();


        #region Inter_Felid_AnlaysisType Members

        public List<Filed_AnalysisType> SP_Browes_AnalysisTypeTB_All()
        {
           return  dal.SP_Browes_AnalysisTypeTB_All();
        }

        public List<Filed_AnalysisType> SP_Browes_AnalysisType_By_ID_List(int ID)
        {
            return dal.SP_Browes_AnalysisType_By_ID_List(ID);
        }

        public List<Filed_AnalysisType> SP_Browes_AnalysisTypeTB_By_Name(string AnalysisType)
        {
            return dal.SP_Browes_AnalysisTypeTB_By_Name(AnalysisType);
        }

        public int SP_Delete_AnalysisTypeTB(int AnalysisTypeID)
        {
            return dal.SP_Delete_AnalysisTypeTB(AnalysisTypeID);
        }

        public Filed_AnalysisType SP_Browes_AnalysisTypeTB_By_Name_Felid(string Analysis)
        {
            return dal.SP_Browes_AnalysisTypeTB_By_Name_Felid(Analysis);
        }

        public int SP_UpData_AnalysisTypeTB(Filed_AnalysisType Felid)
        {
            return dal.SP_UpData_AnalysisTypeTB(Felid);
        }

        public int SP_Insert_AnalysisTypeTB(Filed_AnalysisType Felid)
        {
            return dal.SP_Insert_AnalysisTypeTB(Felid);
        }

        public Filed_AnalysisType SP_Browes_AnalysisTypeTB_By_ID_Felid(int AnalysisTypeID)
        {
            return dal.SP_Browes_AnalysisTypeTB_By_ID_Felid(AnalysisTypeID);
        }

  


        public bool   MakeSureToAddAnalysis(string s)
        {
            return dal.MakeSureToAddAnalysis(s);
        }

       


        public string  SP_Make_Sure_Analysis(int s)
        {
            return dal.SP_Make_Sure_Analysis(s);
        }

        #endregion
    }
}
