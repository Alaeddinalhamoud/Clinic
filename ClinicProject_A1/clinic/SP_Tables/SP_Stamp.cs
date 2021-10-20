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
    public class SP_Stamp:Inter_Felid_Stamp
    {
        #region Inter_Felid_Stamp Members

        public DataTable SP_Browes_StampAll()
        {
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_StampAll");
        }

        public int SP_Delete_Stamp(int StampID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Stamp", StampID);
        }

        public int SP_Insert_Stamp(Felid_Stamp Felid)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Stamp", Felid.StampName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SP_UpDate_Stamp(Felid_Stamp Felid)
        {
            try{
                return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr,"SP_UpDate_Stamp", Felid.StampID, Felid.StampName);
            }
            catch (Exception ex)
            {
                throw ex;
            }  
        }

        #endregion

        #region Inter_Felid_Stamp Members

            SqlDataReader _Reader;
            Felid_Stamp _Felid = new Felid_Stamp();

        public Felid_Stamp SP_Browse_Stamp_ByID(int StampID)
        {
            
            try
            { 
            _Reader=SqlHelper.ExecuteReader(SqlHelper.ConnStr,"SP_Browse_Stamp_ByID",StampID);

                if(_Reader.Read())
                {
                _Felid.StampID=(int)_Reader["StampID"];
                _Felid.StampName=(string)_Reader["StampName"];

                }
            }
            catch (Exception Ex) { throw Ex; }
            finally
            { 
                _Reader.Close();
                _Reader.Dispose();

            }
            return _Felid;

        }

        #endregion

        #region Inter_Felid_Stamp Members


        public DataTable SP_Browes_Stamp_By_ID_DataTale(int StampID)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr,"SP_Browes_Stamp_By_ID_DataTale",StampID);
            }
            catch (Exception Ex) { throw Ex; }
        }

        public Felid_Stamp SP_Browes_Stamp_By_Name_DataTale(string StampName)
        {
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Stamp_By_Name_DataTale", StampName);

                if (_Reader.Read())
                {
                    _Felid.StampID = (int)_Reader["StampID"];
                    _Felid.StampName = (string)_Reader["StampName"];

                }
            }
            catch (Exception Ex) { throw Ex; }
            finally
            {
                _Reader.Close();
                _Reader.Dispose();

            }
            return _Felid;
        }

        #endregion

        #region Inter_Felid_Stamp Members


        public int SP_Browes_Stamp_ID_By_Name(string StampName)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Browes_Stamp_ID_By_Name", StampName);
        }

        #endregion
    }
}
