using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using DataAccessDal;
using Lib_Felid;

namespace BLL
{
    public class SP_Time 
    {
       public static readonly Inter_Felid_Time dal = DataAccess.CreateTime();

       #region Inter_Felid_Time Members

       public int Delete_TimeTB(int ID)
       {
           return dal.Delete_TimeTB(ID);
       }

       public int Insert_TimeTB(Felid_Time Time)
       {
           return dal.Insert_TimeTB(Time);
       }

       public List<Felid_Time> Browes_TimeTB_All_List()
       {
           return dal.Browes_TimeTB_All_List();
       }

       #endregion
    }
}
