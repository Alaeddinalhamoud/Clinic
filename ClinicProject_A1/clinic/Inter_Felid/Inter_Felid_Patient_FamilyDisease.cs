using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface  Inter_Felid_Patient_FamilyDisease
    {
        List <Felid_Patient_FamilyDisease>SP_Browes_Patient_FamilyDisease();
        int SP_Insert_Patient_FamilyDisease(Felid_Patient_FamilyDisease Felid);
        int SP_UpData_Patient_FamilyDisease_By_PatientID(Felid_Patient_FamilyDisease Felid);
    }
}
