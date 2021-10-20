using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface  Inter_Felid_Patient_Medication
    {
        List<Felid_Patient_Medication> Felid_Patient_Medication();
        int SP_Insert_Patient_Medication(Felid_Patient_Medication Felid);
        int SP_UpData_Patient_Medication(Felid_Patient_Medication Felid);
    }
}
