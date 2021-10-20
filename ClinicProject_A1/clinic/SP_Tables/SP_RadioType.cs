using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using Lib_Felid;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;



namespace SP_Tables
{
    public class SP_RadioType:Inter_Felid_RadioType
    {
        #region Inter_Felid_RadioType Members

        SqlDataReader _Reader;


        public List<Felid_RadioType> SP_Browes_RadioType_All()
        {
            List<Felid_RadioType> List_RadioType = new List<Felid_RadioType>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_RadioType_All");
                while (_Reader.Read())
                {
                    Felid_RadioType _Felid = new Felid_RadioType();
                    _Felid.RadioTypeID = (int)_Reader["RadioTypeID"];
                    _Felid.RadioType = (string)_Reader["RadioType"];
                    List_RadioType.Add(_Felid);

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
            return List_RadioType;
        }

        public List<Felid_RadioType> SP_Browes_RadioType_By_Name(string RadioType)
        {
            List<Felid_RadioType> List_RadioType = new List<Felid_RadioType>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_RadioType_By_Name",RadioType);
                while (_Reader.Read())
                {
                    Felid_RadioType _Felid = new Felid_RadioType();
                    _Felid.RadioTypeID = (int)_Reader["RadioTypeID"];
                    _Felid.RadioType = (string)_Reader["RadioType"];
                    List_RadioType.Add(_Felid);

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
            return List_RadioType;
        }

        public Felid_RadioType SP_Browes_RadioType_By_Name_Felid(string RadioType)
        {
            Felid_RadioType _Felid = new Felid_RadioType();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_RadioType_By_Name_Felid", RadioType);
                if (_Reader.Read())
                {
                    
                    _Felid.RadioTypeID = (int)_Reader["RadioTypeID"];
                    _Felid.RadioType = (string)_Reader["RadioType"];
                    

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
            return _Felid;
        }

        public Felid_RadioType SP_Browes_RadioType_By_ID_Felid(int RadioTypeID)
        {
            Felid_RadioType _Felid = new Felid_RadioType();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_RadioType_By_ID_Felid", RadioTypeID);
                if  (_Reader.Read())
                {

                    _Felid.RadioTypeID = (int)_Reader["RadioTypeID"];
                    _Felid.RadioType = (string)_Reader["RadioType"];


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
            return _Felid;
        }

        public int SP_UpData_RadioType(Felid_RadioType Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_RadioType", Felid.RadioTypeID, Felid.RadioType);
        }

        public int SP_Insert_RadioType(Felid_RadioType Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_RadioType", Felid.RadioType);
        }

        public int SP_Delete_RadioType(int RadioTypeID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_RadioType", RadioTypeID);
        }

        #endregion

        #region Inter_Felid_RadioType Members


        public List<Felid_RadioType> SP_Browes_RadioType_By_RadioTypeID_List(int RadioTypeID)
        {
            List<Felid_RadioType> List_RadioType = new List<Felid_RadioType>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_RadioType_By_RadioTypeID_List", RadioTypeID);
                while (_Reader.Read())
                {
                    Felid_RadioType _Felid = new Felid_RadioType();
                    _Felid.RadioTypeID = (int)_Reader["RadioTypeID"];
                    _Felid.RadioType = (string)_Reader["RadioType"];
                    List_RadioType.Add(_Felid);

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
            return List_RadioType;
        }

        #endregion
    }
}
