using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface Inter_Felid_VisitType
    {
        List<Felid_VisitType> VisitTypeTB_Browes_All();
        List<Felid_VisitType> VisitTypeTB_Browes_By_ID(int ID);
        Felid_VisitType VisitTypeTB_Browes_By_ID_Felid(int ID);
        int VisitTypeTB_Delete_By_ID(int ID);
        int VisitTypeTB_Insert(Felid_VisitType Felid);
        int VisitTypeTB_UpDate_By_ID(Felid_VisitType Felid);

    }
}
