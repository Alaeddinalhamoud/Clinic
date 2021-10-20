using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
    public interface  Inter_Felid_Patient_LastDisease
    {
        List<Felid_Patient_LastDisease> SP_Browes_Patient_LastDisease_All();
        Felid_Patient_LastDisease SP_Browes_Patient_LastDisease_By_ID_Felid(int ID);
        int SP_Delete_Patient_LastDisease(int ID);
        int SP_Insert_Patient_LastDisease(Felid_Patient_LastDisease Felid);
        int SP_UpData_Patient_LastDisease(Felid_Patient_LastDisease Felid);
        DataTable SP_Browes_LastDisease_details();
        DataTable SP_Browes_LastDisease_details_IsTrue();
      

    }
}
