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
    public class SP_User 
    {
        public static readonly Inter_Felid_User dal = DataAccess.CreateUser();


        #region Inter_Felid_User Members

        public Felid_User SP_Browes_User_All_Felid(int UserID)
        {
            return dal.SP_Browes_User_All_Felid(UserID);
        }

        public DataTable SP_Browes_User_Detalis()
        {
            return dal.SP_Browes_User_Detalis();
        }

        public int SP_Delete_User(int UserID)
        {
            return dal.SP_Delete_User(UserID);
        }

        public int SP_Insert_User(Felid_User Felid)
        {
            return dal.SP_Insert_User(Felid);
        }

        public int SP_UpDate_User(Felid_User Felid)
        {
            return dal.SP_UpDate_User(Felid);
        }

     


        public int SP_UpDate_User_Image(Felid_User Felid)
        {
            return dal.SP_UpDate_User_Image(Felid);
        }

       


        public Felid_User SP_Browse_UserInfo_For_Login(string UserName, string PassWord)
        {
            return dal.SP_Browse_UserInfo_For_Login(UserName, PassWord);
        }

        #endregion
    }
}
