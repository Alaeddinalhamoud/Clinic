using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using Lib_Felid;
using System.Data.SqlClient;

using Microsoft.ApplicationBlocks.Data;
using System.Data;




namespace SP_Tables
{
    public class SP_Radio : Inter_Felid_Radio
    {
        #region Inter_Felid_Radio Members
        SqlDataReader _Reader;
        public List<Felid_Radio> SP_Browes_RadioTB_All()
        {
            List<Felid_Radio> List_Radio = new List<Felid_Radio>();
            try
            {
            
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_RadioTB_All");
                while (_Reader.Read())
                {
                    Felid_Radio _Felid = new Felid_Radio();
                    _Felid.RadioID=(int)_Reader["RadioID"];
                    _Felid.RadioTypeID = (int)_Reader["RadioTypeID"];
                    _Felid.RadioSubject = (string)_Reader["RadioSubject"];
                    _Felid.RadioResult = (string)_Reader["RadioResult"];
                    _Felid.VisitID = (int)_Reader["VisitID"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.ImagePath = (string)_Reader["ImagePath"];
                    List_Radio.Add(_Felid);
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
            return List_Radio;
        }

        public Felid_Radio SP_Browes_RadioTB_By_RadioID_Felid(int RadioID)
        {
            Felid_Radio _Felid = new Felid_Radio();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_RadioTB_By_RadioID_Felid",RadioID);
                if(_Reader.Read())
                {
                    
                    _Felid.RadioID = (int)_Reader["RadioID"];
                    _Felid.RadioTypeID = (int)_Reader["RadioTypeID"];
                    _Felid.RadioSubject = (string)_Reader["RadioSubject"];
                    _Felid.RadioResult = (string)_Reader["RadioResult"];
                    _Felid.VisitID = (int)_Reader["VisitID"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.ImagePath = (string)_Reader["ImagePath"];
                   
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

        public int SP_Delete_RadioTB(int RadioID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr,"SP_Delete_RadioTB",RadioID);
        }

        public int SP_Insert_RadioTB(Felid_Radio Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_RadioTB",Felid.RadioTypeID,
                Felid.RadioSubject, Felid.RadioResult, Felid.VisitID, Felid.PatientID, Felid.ImagePath);
        }

        public int SP_UpData_RadioTB(Felid_Radio Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_RadioTB", Felid.RadioID,Felid.RadioTypeID,
                Felid.RadioSubject, Felid.RadioResult, Felid.VisitID, Felid.PatientID);
        }

        #endregion

        #region Inter_Felid_Radio Members


        public int SP_UpDate_RadioTB_Image_By_ID(Felid_Radio Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpDate_RadioTB_Image_By_ID", Felid.RadioID, Felid.ImagePath);
        }

        #endregion

        #region Inter_Felid_Radio Members


        public DataTable SP_Browes_Radio_Report_PatientID(int ID)
        {
            try 
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr,"SP_Browes_Radio_Report_PatientID",ID);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SP_Browes_Radio_Dateils()
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Radio_Dateils");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
