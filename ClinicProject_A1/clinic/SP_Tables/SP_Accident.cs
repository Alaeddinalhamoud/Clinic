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
  public  class SP_Accident:Inter_Felid_Accident
    {
        #region Inter_Felid_Accident Members
       SqlDataReader _Reader;
      Felid_Accident _Felid=new Felid_Accident();

      public DataTable SP_Browes_AccidentAll()
        {
            //List<Felid_Accident> list = new List<Felid_Accident>();
            //try
            //{

            //    _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_AccidentAll");
            //    while (_Reader.Read())
            //    {
            //       // _Felid.AccidentID = (int)_Reader["AccidentID"];
            //        _Felid.AccidentName = (string)_Reader["AccidentName"];
            //        list.Add(_Felid);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //return list;
            return  SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_AccidentAll");
        }
     
        public Felid_Accident SP_Browes_Accident_ByID_Felid(int AccidentID)
        {
             try
            { 
            _Reader=SqlHelper.ExecuteReader(SqlHelper.ConnStr,"SP_Browes_Accident_ByID_Felid",AccidentID);

                if(_Reader.Read())
                {
                _Felid.AccidentID=(int)_Reader["AccidentID"];
                _Felid.AccidentName=(string)_Reader["AccidentName"];

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

        public Felid_Accident SP_Browes_Accident_ByName_Felid(string AccidentName)
        {
            try
            { 
            _Reader=SqlHelper.ExecuteReader(SqlHelper.ConnStr,"SP_Browes_Accident_ByName_Felid",AccidentName);

                if(_Reader.Read())
                {
                _Felid.AccidentID=(int)_Reader["AccidentID"];
                _Felid.AccidentName=(string)_Reader["AccidentName"];

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

        public int SP_Delete_Accident(int AccidentID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Accident", AccidentID);
        }

        public int SP_Insert_Accident(Felid_Accident Felid)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Accident",  Felid.AccidentName);
            }
            catch (Exception Ex) { throw Ex; }
            }

        public int SP_UpDate_Accident(Felid_Accident Felid)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpDate_Accident", Felid.AccidentID, Felid.AccidentName);
            }
            catch (Exception Ex) { throw Ex; }
            }
        }

        #endregion
    }
