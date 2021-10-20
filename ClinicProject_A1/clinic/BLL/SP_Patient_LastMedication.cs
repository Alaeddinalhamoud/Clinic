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
    public class SP_Patient_LastMedication 
    {
        public static readonly Inter_Felid_Patient_LastMedication dal = DataAccess.CreatePatient_LastMedication();


        #region Inter_Felid_Patient_LastMedication Members

        public List<Felid_Patient_LastMedication> SP_Browes_Patient_LastMedication_All()
        {
            return dal.SP_Browes_Patient_LastMedication_All();
        }

        public Felid_Patient_LastMedication SP_Browes_Patient_LastMedication_By_ID_Felid(int ID)
        {
            return dal.SP_Browes_Patient_LastMedication_By_ID_Felid(ID);
        }

        public int SP_Delete_Patient_LastMedication_By_ID(int ID)
        {
            return dal.SP_Delete_Patient_LastMedication_By_ID(ID);
        }

        public int SP_Insert_Patient_LastMedication(Felid_Patient_LastMedication Felid)
        {
            return dal.SP_Insert_Patient_LastMedication(Felid);
        }

        public int SP_UpData_Patient_LastMedication_By_ID(Felid_Patient_LastMedication Felid)
        {
            return dal.SP_UpData_Patient_LastMedication_By_ID(Felid);
        }

        


        public DataTable SP_Browes_LastMedication_details()
        {
            return dal.SP_Browes_LastMedication_details();
        }

        public DataTable SP_Browes_LastMedication_Report(int LastMedicationID)
        {
            return dal.SP_Browes_LastMedication_Report(LastMedicationID);
        }

        #endregion
    }
}
