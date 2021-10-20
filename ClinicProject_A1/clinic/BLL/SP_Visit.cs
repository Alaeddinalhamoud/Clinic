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
    public class SP_Visit 
    {
        public static readonly Inter_Felid_Visit dal = DataAccess.CreateVisit();


        #region Inter_Felid_Visit Members

        public List<Felid_Visit> SP_Browes_VisitTB_All()
        {
            return dal.SP_Browes_VisitTB_All();
        }

        public List<Felid_Visit> SP_Browes_VisitTB_By_ID(int ID)
        {
            return dal.SP_Browes_VisitTB_By_ID(ID);
        }

        public List<Felid_Visit> SP_Browes_VisitTB_By_PatientID(int PatientID)
        {
            return dal.SP_Browes_VisitTB_By_PatientID(PatientID);
        }

        public Felid_Visit SP_Browes_VisitTB_By_ID_Felid(int ID)
        {
            return dal.SP_Browes_VisitTB_By_ID_Felid(ID);
        }

        public int SP_Delete_VisitTB_By_ID(int ID)
        {
            return dal.SP_Delete_VisitTB_By_ID(ID);
        }

        public int SP_Insert_VisitTB(Felid_Visit Felid)
        {
            return dal.SP_Insert_VisitTB(Felid);
        }

        public int SP_UpData_VisitTB_By_ID(Felid_Visit Felid)
        {
            return dal.SP_UpData_VisitTB_By_ID(Felid);
        }

        public List<Felid_Visit> SP_Browes_Visit_Date_By_PatientID(int ID)
        {
            return dal.SP_Browes_Visit_Date_By_PatientID(ID);
        }

        public List<Felid_Visit> SP_Browes_Visit_Date_All()
        {
            return dal.SP_Browes_Visit_Date_All();
        }




        public DataTable SP_Brows_VisitTB_Ditalse()
        {
            return dal.SP_Brows_VisitTB_Ditalse();
           
        }

        #endregion

        #region Inter_Felid_Visit Members


        public DataTable SP_Browes_Visit_Detiles_PatientID(int PatientID)
        {
            return dal.SP_Browes_Visit_Detiles_PatientID(PatientID);
        }

        #endregion
    }
}
