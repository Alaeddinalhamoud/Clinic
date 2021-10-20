using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;

namespace BLL
{
    public class SP_VisitType 
    {
        public static readonly Inter_Felid_VisitType dal = DataAccess.CreateVisitTypeTB();


        #region Inter_Felid_VisitType Members

        public List<Felid_VisitType> VisitTypeTB_Browes_All()
        {
            return dal.VisitTypeTB_Browes_All();
        }

        public List<Felid_VisitType> VisitTypeTB_Browes_By_ID(int ID)
        {
            return dal.VisitTypeTB_Browes_By_ID(ID);
        }

        public Felid_VisitType VisitTypeTB_Browes_By_ID_Felid(int ID)
        {
            return dal.VisitTypeTB_Browes_By_ID_Felid(ID);
        }

        public int VisitTypeTB_Delete_By_ID(int ID)
        {
            return dal.VisitTypeTB_Delete_By_ID(ID);
        }

        public int VisitTypeTB_Insert(Felid_VisitType Felid)
        {
            return dal.VisitTypeTB_Insert(Felid);
        }

        public int VisitTypeTB_UpDate_By_ID(Felid_VisitType Felid)
        {
            return dal.VisitTypeTB_UpDate_By_ID(Felid);
        }

        #endregion
    }
}
