using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;

namespace BLL
{
    public class SP_Sex 
    {
        public static readonly Inter_Felid_Sex dal = DataAccess.CreateSexTB();

        #region Inter_Felid_Sex Members

        public List<Felid_Sex> SP_Browes_Sex()
        {
            return dal.SP_Browes_Sex();
        }

        public List<Felid_Sex> SP_Browes_Sex_By_ID(int SexID)
        {
            return dal.SP_Browes_Sex_By_ID(SexID);
        }

        #endregion
    }
}
