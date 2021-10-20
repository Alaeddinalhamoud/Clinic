using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_Felid;
using System.Data;

namespace Inter_Felid
{
    public interface  Inter_Felid_Radio
    {
        List<Felid_Radio> SP_Browes_RadioTB_All();
        Felid_Radio SP_Browes_RadioTB_By_RadioID_Felid(int RadioID);
        int SP_Delete_RadioTB(int RadioID);
        int SP_Insert_RadioTB(Felid_Radio Felid);
        int SP_UpData_RadioTB(Felid_Radio Felid);
        int SP_UpDate_RadioTB_Image_By_ID(Felid_Radio Felid);
        DataTable SP_Browes_Radio_Report_PatientID(int ID);
        DataTable SP_Browes_Radio_Dateils();


    }
}
