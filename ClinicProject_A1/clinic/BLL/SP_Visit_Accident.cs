using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using System.Data;
using Lib_Felid;

namespace BLL
{
    public class SP_Visit_Accident 
    {
        public static readonly Inter_Felid_Visit_Accident dal = DataAccess.CreateVisitAccident();


        #region Inter_Felid_Visit_Accident Members

        public DataTable SP_Browes_Visit_AccidentByVisitID(int VisitID)
        {
            return dal.SP_Browes_Visit_AccidentByVisitID(VisitID);
        }

        public List<int> SP_Browes_Accident_Visit_ByPatient_Visit(int VisitID, int PatientID)
        {
            return dal.SP_Browes_Accident_Visit_ByPatient_Visit(VisitID,PatientID);
        }

        public int SP_Insert_Visit_Accident(Felid_Visit_Accident Felid)
        {
            return dal.SP_Insert_Visit_Accident(Felid);
        }

        


        public int SP_Delete_Visit_Accident_ByAccidentID(int AccidentID)
        {
            return dal.SP_Delete_Visit_Accident_ByAccidentID(AccidentID);
        }

        #endregion
    }
}
