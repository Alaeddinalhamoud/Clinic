using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lib_Felid;

namespace Inter_Felid
{
    public interface  Inter_Felid_Stamp
    {
        DataTable SP_Browes_StampAll();
        Felid_Stamp SP_Browse_Stamp_ByID(int StampID);
        int SP_Delete_Stamp(int StampID);
        int SP_Insert_Stamp(Felid_Stamp Felid);
        int SP_UpDate_Stamp(Felid_Stamp Felid);

        DataTable SP_Browes_Stamp_By_ID_DataTale(int StampID);
        Felid_Stamp SP_Browes_Stamp_By_Name_DataTale(string StampName);
        int SP_Browes_Stamp_ID_By_Name(string StampName);
    }
}
