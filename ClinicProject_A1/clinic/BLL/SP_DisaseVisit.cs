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
    public class SP_DisaseVisit 
    {
        public static readonly Inter_Felid_Disase_Visit dal = DataAccess.CreateDisaseVisit();


        #region Inter_Felid_Disase_Visit Members

        public int SP_Insert_Diasase_Patient_AndVisit(Felid_Disase_Visit Felid)
        {
            return dal.SP_Insert_Diasase_Patient_AndVisit(Felid);
        }

        public int SP_UPdate_Diasase_Patient_AndVisit(Felid_Disase_Visit Felid)
        {
            return dal.SP_UPdate_Diasase_Patient_AndVisit(Felid);
        }

        public int SP_Delete_Diasase_Patient_AndVisit(int DisisaeID)
        {
            return dal.SP_Delete_Diasase_Patient_AndVisit(DisisaeID);
        }

        

       


        public DataTable SP_Brows_Diasase_Patient_AndVisit(int PatientID, int VisitID)
        {
            return dal.SP_Brows_Diasase_Patient_AndVisit(PatientID,VisitID);
        }

     


        public Felid_Disase_Visit SP_Brows_Disise_Visit_Felid(int DisiaseID)
        {
            return dal.SP_Brows_Disise_Visit_Felid(DisiaseID);
        }

        #endregion
    }
}
