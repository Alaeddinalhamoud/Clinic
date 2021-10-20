using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using Microsoft.ApplicationBlocks.Data;

namespace SP_Tables
{
    public class SP_Backup : Inter_TakeBakeup
    {
        #region Inter_TakeBakeup Members

        public object TakeBackUpDatabase(string BackupPath)
        {
            try
            {
                return SqlHelper.ExecuteScalar(SqlHelper.ConnStr, "TakeBackUpDatabase", BackupPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
