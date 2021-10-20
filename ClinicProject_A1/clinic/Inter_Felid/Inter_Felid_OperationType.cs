using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface Inter_Felid_OperationType
    {
        List<Felid_OperationType> SP_Browes_OperationType_All();
        List<Felid_OperationType> SP_Browes_OperationType_By_ID(int ID);
        Felid_OperationType SP_Browes_OperationType_By_ID_Felid(int ID);
        Felid_OperationType SP_Browes_OperationType_By_Name(string Name);
        int SP_Delete_OperationType_By_ID(int ID);
        int SP_Insert_OperationType(Felid_OperationType Felid);
        int SP_UpData_OperationType_By_ID(Felid_OperationType Felid);



    }
}
