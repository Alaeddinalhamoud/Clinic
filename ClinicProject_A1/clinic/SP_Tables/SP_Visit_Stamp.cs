using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using Lib_Felid;
using System.Data.SqlClient;

namespace SP_Tables
{
    public class SP_Visit_Stamp:Inter_Felid_Visit_Stamp
    {
        #region Inter_Felid_Visit_Stamp Members
        SqlDataReader _Reader;
        
        public DataTable SP_Browes_Visit_Stamp_ByVisitID(int VisitID)
        {
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Visit_Stamp_ByVisitID", VisitID);
        }

        public int SP_Delete_Visit_Stamp_ByVisitID(int StampID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Visit_Stamp_ByVisitID", StampID);
        }

        public int SP_UpDate_Visit_Stamp_ByVisitID(Felid_Visit_Stamp Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpDate_Visit_Stamp_ByVisitID", Felid.StampID, Felid.VisitID, Felid.PatientID);
        }

        public int SP_Insert_Visit_Stamp(Felid_Visit_Stamp Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Visit_Stamp", Felid.StampID, Felid.VisitID, Felid.PatientID);
        }

        #endregion

        #region Inter_Felid_Visit_Stamp Members


        public List<int> SP_Browes_Stamp_Visit_ByPatient_Visit(int VisitID, int PatientID)
        {
            List<int> _List = new List<int>();
            _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Stamp_Visit_ByPatient_Visit", VisitID, PatientID);
            while (_Reader.Read())
            {
                Felid_Visit_Stamp _Felid = new Felid_Visit_Stamp();
                
                _Felid.StampID = (int)_Reader["StampID"];
                _List.Add(Convert.ToInt32(_Felid.StampID));
              
            }
            return _List;
            
        }

        #endregion
    }
}
