using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;
using System.Data;

namespace BLL
{
    public class SP_Anlaysis 
    {
        public static readonly Inter_Felid_Anlaysis dal = DataAccess.CreateAnalysisTB();


        #region Inter_Felid_Anlaysis Members

        public List<Felid_Anlaysis> SP_Browes_Analysis_All()
        {
            return dal.SP_Browes_Analysis_All();
        }

        public Felid_Anlaysis SP_Browes_Analysis_By_AnalysisID_Felid(int ID)
        {
            return dal.SP_Browes_Analysis_By_AnalysisID_Felid(ID);
        }

        public List<Felid_Anlaysis> SP_Browes_Analysis_By_PatientID(int ID)
        {
            return dal.SP_Browes_Analysis_By_PatientID(ID);
        }

        public int SP_Insert_Analysis(Felid_Anlaysis Felid)
        {
            return dal.SP_Insert_Analysis(Felid);
        }

        public int SP_UpData_Analysis(Felid_Anlaysis Felid)
        {
            return dal.SP_UpData_Analysis(Felid);
        }

        public int SP_Delete_Analysis(int ID)
        {
            return dal.SP_Delete_Analysis(ID);
        }
        public DataTable SP_Browes_AnalysisTB_details()
        {
            return dal.SP_Browes_AnalysisTB_details();
        }

        public DataTable SP_Browes_AnalysisTB_Report_By_PatientID(int PatientID)
        {
            return dal.SP_Browes_AnalysisTB_Report_By_PatientID(PatientID);
        }

        #endregion
    }
}
