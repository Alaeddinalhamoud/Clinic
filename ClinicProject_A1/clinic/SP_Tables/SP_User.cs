using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using Lib_Felid;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace SP_Tables
{
    public class SP_User : Inter_Felid_User
    {
        #region Inter_Felid_User Members
        SqlDataReader _Reader;
        public Felid_User SP_Browes_User_All_Felid(int UserID)
        {
            Felid_User _Felid = new Felid_User();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_User_All_Felid", UserID);
                if (_Reader.Read())
                {
                    _Felid.UserID = (int)_Reader["UserID"];
                    _Felid.FullName = (string)_Reader["FullName"];
                    _Felid.SexID = (int)_Reader["SexID"];
                    _Felid.UserName = (string)_Reader["UserName"];
                    _Felid.PassWord = (string)_Reader["PassWord"];
                    _Felid.TelHome = (string)_Reader["TelHome"];
                    _Felid.TelMobil = (string)_Reader["TelMobil"];
                    _Felid.Address = (string)_Reader["Address"];
                    _Felid.IsAdmin = (bool)_Reader["IsAdmin"];
                    _Felid.ImagePath = (string)_Reader["ImagePath"];


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _Felid;
        }

        public DataTable SP_Browes_User_Detalis()
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_User_Detalis");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SP_Delete_User(int UserID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_User", UserID);
        }

        public int SP_Insert_User(Felid_User Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_User", Felid.FullName, Felid.SexID, Felid.UserName, Felid.PassWord, Felid.TelHome, Felid.TelMobil, Felid.Address, Felid.IsAdmin, Felid.ImagePath);

        }

        public int SP_UpDate_User(Felid_User Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpDate_User", Felid.UserID, Felid.FullName, Felid.SexID, Felid.PassWord, Felid.TelHome, Felid.TelMobil, Felid.Address, Felid.IsAdmin);
        }


        public int SP_UpDate_User_Image(Felid_User Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpDate_User_Image", Felid.UserID, Felid.ImagePath);
        }

        #endregion

        #region Inter_Felid_User Members


        public Felid_User SP_Browse_UserInfo_For_Login(string UserName, string PassWord)
        {
            Felid_User _Felid = new Felid_User();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browse_UserInfo_For_Login", UserName, PassWord);
                if (_Reader.Read())
                {
                    _Felid.UserID = (int)_Reader["UserID"];

                    _Felid.FullName = (string)_Reader["FullName"];
                    _Felid.UserName = (string)_Reader["UserName"];
                    _Felid.PassWord = (string)_Reader["PassWord"];




                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _Felid;
        }

        #endregion
    }
}
