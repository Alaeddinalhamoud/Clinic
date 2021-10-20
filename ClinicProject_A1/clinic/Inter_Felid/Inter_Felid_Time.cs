using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface Inter_Felid_Time
    {
        int Delete_TimeTB(int ID);
        int Insert_TimeTB(Felid_Time Time);
        List<Felid_Time> Browes_TimeTB_All_List();

    }
}
