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
    public class SP_ClincData:Inter_Felid_ClinicData
    {
        #region Inter_Felid_ClinicData Members
        SqlDataReader _Reader;
        public int SP_Insert_Dr_Info(Felid_ClincData Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Dr_Info", Felid.DrName, Felid.Speciaty,
                Felid.Phone, Felid.Mobile, Felid.Fax, Felid.Email, Felid.WebSiteAddress, Felid.Image, Felid.City, Felid.Address);
        }

        public int SP_UpData_Dr_Info(Felid_ClincData Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_Dr_Info", Felid.DrID, Felid.DrName, Felid.Speciaty,
                Felid.Phone,Felid.Mobile , Felid.Fax, Felid.Email,Felid.WebSiteAddress , Felid.City, Felid.Address);
        }

        public Felid_ClincData SP_Browse_Dr_Felid()
        {
            Felid_ClincData _Felid = new Felid_ClincData();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browse_Dr_Felid");
                while (_Reader.Read())
                {
                    _Felid.DrID =(int)_Reader["DrID"];
                    _Felid.DrName = (string)_Reader["DrName"];
                    _Felid.Speciaty = (string)_Reader["Speciaty"];
                    _Felid.Phone=(string )_Reader["Phone"];
                    _Felid.Mobile = (string)_Reader["Mobile"];
                    _Felid.Fax=(string)_Reader["Fax"];
                    _Felid.Email=(string )_Reader["Email"];
                    _Felid.WebSiteAddress = (string)_Reader["WebSiteAddress"];
                    _Felid.Image=(string)_Reader["Image"];
                    _Felid.City=(string)_Reader["City"];
                    _Felid.Address=(string)_Reader["Address"];
                    
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

        #endregion

        #region Inter_Felid_ClinicData Members


        public int SP_UpData_Dr_Image(Felid_ClincData Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_Dr_Image", Felid.DrID,Felid.Image);           
        }

        #endregion
    }
}
