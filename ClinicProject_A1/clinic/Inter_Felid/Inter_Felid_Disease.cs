using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;

namespace Inter_Felid
{
    public interface  Inter_Felid_Disease
    {
        List<Felid_Disease> SP_Browes_Disease_All();
        List<Felid_Disease> SP_Browes_Disease_By_ID(int DiseaseID);
        List<Felid_Disease> SP_Browes_Disease_By_Name(string DiseaseName);
        int SP_Insert_Disease(Felid_Disease Felid);
        int SP_UpDate_Disease_By_ID(Felid_Disease Felid);
        int SP_Delete_Disease_By_ID(int DiseaseID);
        Felid_Disease SP_Browes_Disease_By_ID_Felid(int DiseaseID);
       
    }
}
