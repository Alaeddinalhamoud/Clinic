using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;

namespace BLL
{
    public class SP_Permission 
    {
        public static readonly Inter_Felid_Permission dal = DataAccess.CreatePermission();


        #region Inter_Felid_Permission Members

        public Felid_Permission SP_Browes_Permission_ByUserID_Felid(int UserID)
        {
            return dal.SP_Browes_Permission_ByUserID_Felid(UserID);
        }

        public int SP_Insert_Permission(Felid_Permission Felid)
        {
            return dal.SP_Insert_Permission(Felid);
        }

        public int SP_Update_Permission(Felid_Permission Felid)
        {
            return dal.SP_Update_Permission(Felid);
        }

        public int SP_Delete_Permission(int UserID)
        {
            return dal.SP_Delete_Permission(UserID);
        }

        #endregion
    }
}
