using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;

namespace BLL
{
    public class SP_BackUpDataBase
    {
        public static readonly Inter_TakeBakeup dal = DataAccess.CreateBackUP();
        #region Inter_TakeBakeup Members

        public object TakeBackUpDatabase(string BackupPath)
        {
            return dal.TakeBackUpDatabase(BackupPath);
        }

        #endregion
    }
}
