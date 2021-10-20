using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;

namespace BLL
{
    public class SP_RadioType
    {
        public static readonly Inter_Felid_RadioType dal = DataAccess.CreateRadioTypeTB();


        #region Inter_Felid_RadioType Members

        public List<Felid_RadioType> SP_Browes_RadioType_All()
        {
            return dal.SP_Browes_RadioType_All();
        }

        public List<Felid_RadioType> SP_Browes_RadioType_By_RadioTypeID_List(int RadioTypeID)
        {
            return dal.SP_Browes_RadioType_By_RadioTypeID_List(RadioTypeID);
        }

        public List<Felid_RadioType> SP_Browes_RadioType_By_Name(string RadioType)
        {
            return dal.SP_Browes_RadioType_By_Name(RadioType);
        }

        public Felid_RadioType SP_Browes_RadioType_By_Name_Felid(string RadioType)
        {
            return dal.SP_Browes_RadioType_By_Name_Felid(RadioType);
        }

        public Felid_RadioType SP_Browes_RadioType_By_ID_Felid(int RadioTypeID)
        {
            return dal.SP_Browes_RadioType_By_ID_Felid(RadioTypeID);
        }

        public int SP_UpData_RadioType(Felid_RadioType Felid)
        {
            return dal.SP_UpData_RadioType(Felid);
        }

        public int SP_Insert_RadioType(Felid_RadioType Felid)
        {
            return dal.SP_Insert_RadioType(Felid);
        }

        public int SP_Delete_RadioType(int RadioTypeID)
        {
            return dal.SP_Delete_RadioType(RadioTypeID);
        }

        #endregion
    }
}
