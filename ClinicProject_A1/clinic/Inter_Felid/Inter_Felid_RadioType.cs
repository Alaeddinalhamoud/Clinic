using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface Inter_Felid_RadioType
    {
        List<Felid_RadioType> SP_Browes_RadioType_All();
        List<Felid_RadioType> SP_Browes_RadioType_By_RadioTypeID_List(int RadioTypeID);
        List<Felid_RadioType> SP_Browes_RadioType_By_Name(string RadioType);
        Felid_RadioType SP_Browes_RadioType_By_Name_Felid(string RadioType);
        Felid_RadioType SP_Browes_RadioType_By_ID_Felid(int RadioTypeID);
        int SP_UpData_RadioType(Felid_RadioType Felid);
        int SP_Insert_RadioType(Felid_RadioType Felid);
        int SP_Delete_RadioType(int RadioTypeID);

    }
}
