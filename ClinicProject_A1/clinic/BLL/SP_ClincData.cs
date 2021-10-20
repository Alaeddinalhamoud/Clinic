using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;

namespace BLL
{
    public class SP_ClincData 
    {
        public static readonly Inter_Felid_ClinicData dal = DataAccess.CreateClinicData();

        #region Inter_Felid_ClinicData Members

        public int SP_Insert_Dr_Info(Felid_ClincData Felid)
        {
            return dal.SP_Insert_Dr_Info(Felid);
        }

        public int SP_UpData_Dr_Info(Felid_ClincData Felid)
        {
            return dal.SP_UpData_Dr_Info(Felid);
        }

        public Felid_ClincData SP_Browse_Dr_Felid()
        {
            return dal.SP_Browse_Dr_Felid();
        }

        public int SP_UpData_Dr_Image(Felid_ClincData Felid)
        {
            return dal.SP_UpData_Dr_Image(Felid);
        }

        #endregion
    }
}
