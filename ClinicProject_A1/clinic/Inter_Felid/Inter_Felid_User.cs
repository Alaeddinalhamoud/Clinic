using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
    public interface  Inter_Felid_User
    {
        Felid_User SP_Browes_User_All_Felid(int UserID);
        DataTable SP_Browes_User_Detalis();
        int SP_Delete_User(int UserID);
        int SP_Insert_User(Felid_User Felid);
        int SP_UpDate_User(Felid_User Felid);
        int SP_UpDate_User_Image(Felid_User Felid);
        Felid_User SP_Browse_UserInfo_For_Login(string UserName, string PassWord);



    }
}
