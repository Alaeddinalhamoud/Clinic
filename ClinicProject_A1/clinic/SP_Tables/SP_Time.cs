using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using Lib_Felid;

namespace SP_Tables
{
    public class SP_Time : Inter_Felid_Time
    {
        SqlDataReader _Reader;

        #region Inter_Felid_Time Members

        public int Delete_TimeTB(int ID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "Delete_TimeTB",ID);
        }

        public int Insert_TimeTB(Felid_Time Time)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "Insert_TimeTB",
                  Time.Time);
        }

        public List<Felid_Time> Browes_TimeTB_All_List()
        {
            List<Felid_Time> List_Time = new List<Felid_Time>();
            try
            {


                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "Browes_TimeTB_All_List");
                while (_Reader.Read())
                {
                    Felid_Time _Felid = new Felid_Time();
                    _Felid.TimeID= (int)_Reader["TimeID"];
                    _Felid.Time= (string)_Reader["Time"];

                    List_Time.Add(_Felid);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _Reader.Close();
                _Reader.Dispose();
            }
            return List_Time;
        }

        #endregion
    }
}
