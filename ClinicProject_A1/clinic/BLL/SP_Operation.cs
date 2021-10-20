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
    public class SP_Operation
    {
        public static readonly Inter_Felid_Operation dal = DataAccess.CreateOperationTB();


        #region Inter_Felid_Operation Members

        public List<Felid_Operation> SP_Browes_Operation_All()
        {
            return dal.SP_Browes_Operation_All();
        }

        public List<Felid_Operation> SP_Browes_Operation_All_By_ID(int ID)
        {
            return dal.SP_Browes_Operation_All_By_ID(ID);
        }

        public Felid_Operation SP_Browes_Operation_All_By_ID_Felid(int ID)
        {
            return dal.SP_Browes_Operation_All_By_ID_Felid(ID);
        }

        public Felid_Operation SP_Browes_Operation_All_By_PatientID_Felid(int PatientID)
        {
            return dal.SP_Browes_Operation_All_By_PatientID_Felid(PatientID);
        }

        public List<Felid_Operation> SP_Browes_Operation_All_By_PatientID(int PatientID)
        {
            return dal.SP_Browes_Operation_All_By_PatientID(PatientID);
        }

        public int SP_Delete_Operation_By_ID(int ID)
        {
            return dal.SP_Delete_Operation_By_ID(ID);
        }

        public int SP_Insert_Operation(Felid_Operation Felid)
        {
            return dal.SP_Insert_Operation(Felid);
        }

        public int SP_UpData_Operation_By_ID(Felid_Operation Felid)
        {
            return dal.SP_UpData_Operation_By_ID(Felid);
        }


        public DataTable SP_Browes_All_Dtailse_Opreation()
        {
            return dal.SP_Browes_All_Dtailse_Opreation();
        }

        public DataTable SP_Browes_All_Dtailse_Opreation_By_PatientID(int ID)
        {
            return dal.SP_Browes_All_Dtailse_Opreation_By_PatientID(ID);
        }

        #endregion
    }
}
