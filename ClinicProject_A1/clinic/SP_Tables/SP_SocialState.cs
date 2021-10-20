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
   public class SP_SocialState:Inter_Felid_SocialState
    {
        #region Inter_Felid_SocialState Members
       SqlDataReader _Reader;
        public List<Felid_SocialState> SP_Browes_SocialState()
        {
           List<Felid_SocialState> List_SocialState =new List<Felid_SocialState>();

           try
           {
               _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_SocialState");
               while (_Reader.Read())
               {
                   Felid_SocialState _Felid = new Felid_SocialState();
                   _Felid.SocialStateID = (int)_Reader["SocialStateID"];
                   _Felid.SocialState = (string)_Reader["SocialState"];
                   List_SocialState.Add(_Felid);
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
           return List_SocialState;
        }

        #endregion

        #region Inter_Felid_SocialState Members


        public List<Felid_SocialState> SP_Browes_SocialState_By_ID(int ID)
        {
            List<Felid_SocialState> List_SocialState = new List<Felid_SocialState>();
            Felid_SocialState _Felid = new Felid_SocialState();

            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_SocialState_By_ID",ID);
                while (_Reader.Read())
                {
                  
                    _Felid.SocialStateID = (int)_Reader["SocialStateID"];
                    _Felid.SocialState = (string)_Reader["SocialState"];
                    List_SocialState.Add(_Felid);
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
            return List_SocialState;
        }

        #endregion
    }
}
