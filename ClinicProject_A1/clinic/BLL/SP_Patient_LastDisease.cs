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
    public class SP_Patient_LastDisease 
    {
        public static readonly Inter_Felid_Patient_LastDisease dal = DataAccess.CreatePatient_LastDisease();


        #region Inter_Felid_Patient_LastDisease Members

        public List<Felid_Patient_LastDisease> SP_Browes_Patient_LastDisease_All()
        {
            return dal.SP_Browes_Patient_LastDisease_All();
        }

        public Felid_Patient_LastDisease SP_Browes_Patient_LastDisease_By_ID_Felid(int ID)
        {
            return dal.SP_Browes_Patient_LastDisease_By_ID_Felid(ID);
        }

        public int SP_Delete_Patient_LastDisease(int ID)
        {
            return dal.SP_Delete_Patient_LastDisease(ID);
        }

        public int SP_Insert_Patient_LastDisease(Felid_Patient_LastDisease Felid)
        {
            return dal.SP_Insert_Patient_LastDisease(Felid);
        }

        public int SP_UpData_Patient_LastDisease(Felid_Patient_LastDisease Felid)
        {
            return dal.SP_UpData_Patient_LastDisease(Felid);
        }

        #endregion

        #region Inter_Felid_Patient_LastDisease Members


        public DataTable SP_Browes_LastDisease_details()
        {
            return dal.SP_Browes_LastDisease_details();
            
        }

      

       


        public DataTable SP_Browes_LastDisease_details_IsTrue()
        {
            return dal.SP_Browes_LastDisease_details_IsTrue();
        }

        #endregion
    }
}
