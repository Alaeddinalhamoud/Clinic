using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;

namespace BLL
{
    public class SP_SocialState 
    {
        public static readonly Inter_Felid_SocialState dal = DataAccess.CreateSocialStateTB();

        #region Inter_Felid_SocialState Members

        public List<Felid_SocialState> SP_Browes_SocialState()
        {
            return dal.SP_Browes_SocialState();
        }

        public List<Felid_SocialState> SP_Browes_SocialState_By_ID(int ID)
        {
            return dal.SP_Browes_SocialState_By_ID(ID);
        }

        #endregion
    }
}
