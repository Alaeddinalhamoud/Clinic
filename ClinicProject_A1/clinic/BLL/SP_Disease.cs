using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;

namespace BLL
{
    public class SP_Disease
    {
        public static readonly Inter_Felid_Disease dal = DataAccess.CreateDiseaseTB();


        #region Inter_Felid_Disease Members

        public List<Felid_Disease> SP_Browes_Disease_All()
        {
            return dal.SP_Browes_Disease_All();
        }

        public List<Felid_Disease> SP_Browes_Disease_By_ID(int DiseaseID)
        {
            return dal.SP_Browes_Disease_By_ID(DiseaseID);
        }

        public List<Felid_Disease> SP_Browes_Disease_By_Name(string DiseaseName)
        {
            return dal.SP_Browes_Disease_By_Name(DiseaseName);
        }

        public int SP_Insert_Disease(Felid_Disease Felid)
        {
            return dal.SP_Insert_Disease(Felid);
        }

        public int SP_UpDate_Disease_By_ID(Felid_Disease Felid)
        {
            return dal.SP_UpDate_Disease_By_ID(Felid);
        }

        public int SP_Delete_Disease_By_ID(int DiseaseID)
        {
            return dal.SP_Delete_Disease_By_ID(DiseaseID);
        }

        public Felid_Disease SP_Browes_Disease_By_ID_Felid(int DiseaseID)
        {
            return dal.SP_Browes_Disease_By_ID_Felid(DiseaseID);
        }

        #endregion
    }
}
