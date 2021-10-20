using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface  Inter_Felid_Patient_Disease
    {
        List<Felid_Patient_Disease> SP_Browes_Patient_Last_Disease();
        int SP_Insert_Patient_Last_Disease(Felid_Patient_Disease Felid);
        int SP_UpData_Patient_Last_Disease_By_PatientID(Felid_Patient_Disease  Felid);

    }
}
