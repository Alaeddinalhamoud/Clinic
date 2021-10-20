using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;
using System.Data;

namespace BLL
{
    public class SP_Radio 
    {
       public static readonly Inter_Felid_Radio dal = DataAccess.CreateRadioTB();


       #region Inter_Felid_Radio Members

       public List<Felid_Radio> SP_Browes_RadioTB_All()
       {
           return dal.SP_Browes_RadioTB_All();
       }

       public Felid_Radio SP_Browes_RadioTB_By_RadioID_Felid(int RadioID)
       {
           return dal.SP_Browes_RadioTB_By_RadioID_Felid(RadioID);
       }

       public int SP_Delete_RadioTB(int RadioID)
       {
           return dal.SP_Delete_RadioTB(RadioID);
       }

       public int SP_Insert_RadioTB(Felid_Radio Felid)
       {
           return dal.SP_Insert_RadioTB(Felid);
       }

       public int SP_UpData_RadioTB(Felid_Radio Felid)
       {
           return dal.SP_UpData_RadioTB(Felid);
       }

       public int SP_UpDate_RadioTB_Image_By_ID(Felid_Radio Felid)
       {
           return dal.SP_UpDate_RadioTB_Image_By_ID(Felid);
       }

       #endregion

       #region Inter_Felid_Radio Members


       public DataTable SP_Browes_Radio_Report_PatientID(int ID)
       {
           return dal.SP_Browes_Radio_Report_PatientID(ID); 
       }

       public DataTable SP_Browes_Radio_Dateils()
       {
           return dal.SP_Browes_Radio_Dateils();
       }

       #endregion
    }
}
