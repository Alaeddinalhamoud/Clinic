using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Lib_Felid;

namespace Inter_Felid
{
    public interface  Inter_Felid_Accident
    {
       DataTable SP_Browes_AccidentAll();
        Felid_Accident SP_Browes_Accident_ByID_Felid(int AccidentID);
        Felid_Accident SP_Browes_Accident_ByName_Felid(string AccidentName);
        int SP_Delete_Accident(int AccidentID);
        int SP_Insert_Accident(Felid_Accident Felid);
        int SP_UpDate_Accident(Felid_Accident Felid);

    }
}
