using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;

namespace BLL
{
    public class SP_OperationType 
    {
        public static readonly Inter_Felid_OperationType dal = DataAccess.CreateOperationTypeTB();


        #region Inter_Felid_OperationType Members

        public List<Felid_OperationType> SP_Browes_OperationType_All()
        {
            return dal.SP_Browes_OperationType_All();
        }

        public List<Felid_OperationType> SP_Browes_OperationType_By_ID(int ID)
        {
            return dal.SP_Browes_OperationType_By_ID(ID);
        }

        public Felid_OperationType SP_Browes_OperationType_By_ID_Felid(int ID)
        {
            return dal.SP_Browes_OperationType_By_ID_Felid(ID);
        }

        public Felid_OperationType SP_Browes_OperationType_By_Name(string Name)
        {
            return dal.SP_Browes_OperationType_By_Name(Name);
        }

        public int SP_Delete_OperationType_By_ID(int ID)
        {
            return dal.SP_Delete_OperationType_By_ID(ID);
        }

        public int SP_Insert_OperationType(Felid_OperationType Felid)
        {
            return dal.SP_Insert_OperationType(Felid);
        }

        public int SP_UpData_OperationType_By_ID(Felid_OperationType Felid)
        {
            return dal.SP_UpData_OperationType_By_ID(Felid);
        }

        #endregion
    }
}
