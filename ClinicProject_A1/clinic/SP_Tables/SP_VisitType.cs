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
    public class SP_VisitType : Inter_Felid_VisitType
    {
        #region Inter_Felid_VisitType Members
        SqlDataReader _Reader;
        public List<Felid_VisitType> VisitTypeTB_Browes_All()
        {
            List<Felid_VisitType> List_VisitType = new List<Felid_VisitType>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "VisitTypeTB_Browes_All");
                while (_Reader.Read())
                {
                    Felid_VisitType _Felid = new Felid_VisitType();
                    _Felid.VisitTypeID = (int)_Reader["VisitTypeID"];
                    _Felid.VisitType = (string)_Reader["VisitType"];
                    List_VisitType.Add(_Felid);
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
            return List_VisitType;
        }

        public List<Felid_VisitType> VisitTypeTB_Browes_By_ID(int ID)
        {

            List<Felid_VisitType> List_VisitType = new List<Felid_VisitType>();
            Felid_VisitType _Felid = new Felid_VisitType();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "VisitTypeTB_Browes_By_ID", ID);
                if (_Reader.Read())
                {
                    
                    _Felid.VisitTypeID = (int)_Reader["VisitTypeID"];
                    _Felid.VisitType = (string)_Reader["VisitType"];
                    List_VisitType.Add(_Felid);
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
            return List_VisitType;
        }

        public Felid_VisitType VisitTypeTB_Browes_By_ID_Felid(int ID)
        {
            
            Felid_VisitType _Felid = new Felid_VisitType();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "VisitTypeTB_Browes_By_ID_Felid", ID);
                if (_Reader.Read())
                {

                    _Felid.VisitTypeID = (int)_Reader["VisitTypeID"];
                    _Felid.VisitType = (string)_Reader["VisitType"];
                   
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

        public int VisitTypeTB_Delete_By_ID(int ID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr,"VisitTypeTB_Delete_By_ID");
        }

        public int VisitTypeTB_Insert(Felid_VisitType Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "VisitTypeTB_Insert"
                ,Felid.VisitType);
        }

        public int VisitTypeTB_UpDate_By_ID(Lib_Felid.Felid_VisitType Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "VisitTypeTB_UpDate_By_ID"
                ,Felid.VisitType);
        }

        #endregion
    }
}
