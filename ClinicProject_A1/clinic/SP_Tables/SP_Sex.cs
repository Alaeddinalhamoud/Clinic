using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using System.Data.SqlClient;

using Lib_Felid;
using Microsoft.ApplicationBlocks.Data;

namespace SP_Tables
{
    public class SP_Sex:Inter_Felid_Sex
    {
        #region Inter_Felid_Sex Members
        SqlDataReader _Reader;
        public List<Felid_Sex> SP_Browes_Sex()
        {
            List<Felid_Sex> List_Sex = new List<Felid_Sex>();
            try
            {

                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,"SP_Browes_Sex");
                while  (_Reader.Read ())
                {
                    Felid_Sex _Felid = new Felid_Sex();
                    _Felid.SexID = (int)_Reader["SexID"];
                    _Felid.Sex = (string)_Reader["Sex"];
                    List_Sex.Add(_Felid);

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
            return List_Sex;
        }

        #endregion

        #region Inter_Felid_Sex Members


        public List<Felid_Sex> SP_Browes_Sex_By_ID(int SexID)
        {

            List<Felid_Sex> List_Sex = new List<Felid_Sex>();
            Felid_Sex _Felid = new Felid_Sex();
            try
            {

                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Sex_By_ID", SexID);
                if (_Reader.Read())
                {
                   
                    _Felid.SexID = (int)_Reader["SexID"];
                    _Felid.Sex = (string)_Reader["Sex"];
                    List_Sex.Add(_Felid);

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
            return List_Sex;
        }

        #endregion
    }
}
