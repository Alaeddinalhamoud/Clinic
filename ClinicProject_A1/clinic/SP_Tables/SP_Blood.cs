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
   public class SP_Blood:Inter_Felid_Blood
    {
       

        #region Inter_Felid_Blood Members

       SqlDataReader _Reader;

        public List<Felid_Blood> SP_Browes_Blood()
        {
            List<Felid_Blood> List_Blood = new List<Felid_Blood>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Blood");
                while (_Reader.Read())
                {
                    Felid_Blood _Felid = new Felid_Blood();
                    _Felid.BloodID = (int)_Reader["BloodID"];
                    _Felid.BloodType = (string)_Reader["BloodType"];
                    List_Blood.Add(_Felid);
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
            return List_Blood;
        }

        #endregion

        #region Inter_Felid_Blood Members


        public List<Felid_Blood> SP_Browes_Blood_By_ID(int ID)
        {
            List<Felid_Blood> List_Blood = new List<Felid_Blood>();
            Felid_Blood _Felid = new Felid_Blood();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Blood_By_ID",ID);
                if (_Reader.Read())
                {
                   
                    _Felid.BloodID = (int)_Reader["BloodID"];
                    _Felid.BloodType = (string)_Reader["BloodType"];
                    List_Blood.Add(_Felid);
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
            return List_Blood; 
        }

        #endregion
    }
}
