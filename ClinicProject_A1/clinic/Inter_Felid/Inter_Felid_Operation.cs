using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
   public interface Inter_Felid_Operation
    {
       List<Felid_Operation> SP_Browes_Operation_All();
       List<Felid_Operation> SP_Browes_Operation_All_By_ID(int ID);//no
       Felid_Operation SP_Browes_Operation_All_By_ID_Felid(int ID);
       Felid_Operation SP_Browes_Operation_All_By_PatientID_Felid(int PatientID);
       List<Felid_Operation> SP_Browes_Operation_All_By_PatientID(int PatientID);
       int SP_Delete_Operation_By_ID(int ID);
       int SP_Insert_Operation(Felid_Operation Felid);
       int SP_UpData_Operation_By_ID(Felid_Operation Felid);
       DataTable SP_Browes_All_Dtailse_Opreation();
       DataTable  SP_Browes_All_Dtailse_Opreation_By_PatientID(int ID);
    }
}
