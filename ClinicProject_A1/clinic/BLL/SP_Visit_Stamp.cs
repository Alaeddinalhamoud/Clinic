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
    public class SP_Visit_Stamp 
    {
        public static readonly Inter_Felid_Visit_Stamp dal = DataAccess.CreateVisitStamp();


        #region Inter_Felid_Visit_Stamp Members

        public DataTable SP_Browes_Visit_Stamp_ByVisitID(int VisitID)
        {
            return dal.SP_Browes_Visit_Stamp_ByVisitID(VisitID);
        }

        public int SP_Delete_Visit_Stamp_ByVisitID(int StampID)
        {
            return dal.SP_Delete_Visit_Stamp_ByVisitID(StampID);
        }

        public int SP_UpDate_Visit_Stamp_ByVisitID(Felid_Visit_Stamp Felid)
        {
            return dal.SP_UpDate_Visit_Stamp_ByVisitID(Felid);
        }

        public int SP_Insert_Visit_Stamp(Felid_Visit_Stamp Felid)
        {
            return dal.SP_Insert_Visit_Stamp(Felid);
        }


        public List<int> SP_Browes_Stamp_Visit_ByPatient_Visit(int VisitID, int PatientID)
        {
            return dal.SP_Browes_Stamp_Visit_ByPatient_Visit(VisitID, PatientID);
        }

        #endregion
    }
}
