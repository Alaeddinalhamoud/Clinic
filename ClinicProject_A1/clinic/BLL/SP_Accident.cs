using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using System.Data;
using Lib_Felid;

namespace BLL
{
    public class SP_Accident 
    {
        public static readonly Inter_Felid_Accident dal = DataAccess.CreateAccident();

        #region Inter_Felid_Accident Members

        public DataTable SP_Browes_AccidentAll()
        {
            return dal.SP_Browes_AccidentAll();
        }

        public Felid_Accident SP_Browes_Accident_ByID_Felid(int AccidentID)
        {
            return dal.SP_Browes_Accident_ByID_Felid(AccidentID);
        }

        public Felid_Accident SP_Browes_Accident_ByName_Felid(string AccidentName)
        {
            return dal.SP_Browes_Accident_ByName_Felid(AccidentName);
        }

        public int SP_Delete_Accident(int AccidentID)
        {
            return dal.SP_Delete_Accident(AccidentID);
        }

        public int SP_Insert_Accident(Felid_Accident Felid)
        {
            return dal.SP_Insert_Accident(Felid);
        }

        public int SP_UpDate_Accident(Felid_Accident Felid)
        {
            return dal.SP_UpDate_Accident(Felid);
        }

        #endregion
    }
}
