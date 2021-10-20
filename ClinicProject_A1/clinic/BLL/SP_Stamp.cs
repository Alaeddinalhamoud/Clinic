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
    public class SP_Stamp 
    {
        public static readonly Inter_Felid_Stamp dal = DataAccess.CreateStamp();


        #region Inter_Felid_Stamp Members

        public DataTable SP_Browes_StampAll()
        {
            return dal.SP_Browes_StampAll();
        }

        public Felid_Stamp SP_Browse_Stamp_ByID(int StampID)
        {
            return dal.SP_Browse_Stamp_ByID(StampID);
        }

        public int SP_Delete_Stamp(int StampID)
        {
            return dal.SP_Delete_Stamp(StampID);
        }

        public int SP_Insert_Stamp(Felid_Stamp Felid)
        {
            return dal.SP_Insert_Stamp(Felid);
          
        }

        public int SP_UpDate_Stamp(Felid_Stamp Felid)
        {
            return dal.SP_UpDate_Stamp(Felid);
        }

        #endregion

        #region Inter_Felid_Stamp Members


        public DataTable SP_Browes_Stamp_By_ID_DataTale(int StampID)
        {
            return dal.SP_Browes_Stamp_By_ID_DataTale(StampID);
        }

        public Felid_Stamp SP_Browes_Stamp_By_Name_DataTale(string StampName)
        {
            return dal.SP_Browes_Stamp_By_Name_DataTale(StampName);
        }

        #endregion

        #region Inter_Felid_Stamp Members


        public int SP_Browes_Stamp_ID_By_Name(string StampName)
        {
            return dal.SP_Browes_Stamp_ID_By_Name(StampName);
        }

        #endregion
    }
}
