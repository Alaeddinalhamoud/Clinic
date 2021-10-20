using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessDal;
using Inter_Felid;
using Lib_Felid;

namespace BLL
{
    public class SP_Blood 
    {
        public static readonly Inter_Felid_Blood dal = DataAccess.CreateBloodTB();


        #region Inter_Felid_Blood Members

        public List<Felid_Blood> SP_Browes_Blood()
        {
            return dal.SP_Browes_Blood();
           
        }

        public List<Felid_Blood> SP_Browes_Blood_By_ID(int ID)
        {
            return dal.SP_Browes_Blood_By_ID(ID);
        }

        #endregion
    }
}
