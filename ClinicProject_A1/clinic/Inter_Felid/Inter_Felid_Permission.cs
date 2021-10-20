using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface Inter_Felid_Permission
    {
        Felid_Permission SP_Browes_Permission_ByUserID_Felid(int UserID);
        int SP_Insert_Permission(Felid_Permission Felid);
        int SP_Update_Permission(Felid_Permission Felid);
        int SP_Delete_Permission(int UserID);
    }
}
