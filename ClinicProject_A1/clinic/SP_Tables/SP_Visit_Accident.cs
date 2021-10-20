using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using System.Data;
using Lib_Felid;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace SP_Tables
{
    public class SP_Visit_Accident:Inter_Felid_Visit_Accident
    {
        #region Inter_Felid_Visit_Accident Members
        SqlDataReader _Reader;
        public DataTable SP_Browes_Visit_AccidentByVisitID(int VisitID)
        {
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Visit_AccidentByVisitID", VisitID); 
        }

        public List<int> SP_Browes_Accident_Visit_ByPatient_Visit(int VisitID, int PatientID)
        {
            List<int> _List = new List<int>();
            _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Accident_Visit_ByPatient_Visit", VisitID, PatientID);
            while (_Reader.Read())
            {
                Felid_Visit_Accident _Felid = new Felid_Visit_Accident();

                _Felid.AccidentID = (int)_Reader["AccidentID"];
                _List.Add(Convert.ToInt32(_Felid.AccidentID));

            }
            return _List;
        }

        public int SP_Insert_Visit_Accident(Felid_Visit_Accident Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Visit_Accident", Felid.AccidentID, Felid.VisitID, Felid.PatientID);
        }

        #endregion

        #region Inter_Felid_Visit_Accident Members


        public int SP_Delete_Visit_Accident_ByAccidentID(int AccidentID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr,"SP_Delete_Visit_Accident_ByAccidentID", AccidentID);
        }

        #endregion
    }
}
