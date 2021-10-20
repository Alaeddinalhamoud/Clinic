using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using System.Data.SqlClient;
using Lib_Felid;
using Microsoft.ApplicationBlocks.Data;
using System.Data;


namespace SP_Tables
{
    public class SP_Visit:Inter_Felid_Visit
    {
        #region Inter_Felid_Visit Members
        SqlDataReader _Reader;
        public List<Felid_Visit> SP_Browes_VisitTB_All()
        {
            List<Felid_Visit> List_Visit = new List<Felid_Visit>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_VisitTB_All");
                while (_Reader.Read())
                {
                    Felid_Visit _Felid = new Felid_Visit();
                    _Felid.VisitID = (int)_Reader["VisitID"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.DataOfVisit = (DateTime)_Reader["DataOfVisit"];
                    _Felid.VisitTypeID = (int)_Reader["VisitTypeID"];
                    _Felid.Weight = (double)_Reader["Weight"];
                    _Felid.BloodPressure = (double)_Reader["BloodPressure"];
                    _Felid.PulseHeart = (int)_Reader["PulseHeart"];
                    _Felid.Temperature = (double)_Reader["Temperature"];
                    _Felid.PhysicalExamination = (string)_Reader["PhysicalExamination"];
                   
                    _Felid.Note=(string) _Reader["Note"];
                    List_Visit.Add(_Felid);
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
            return List_Visit;
            
        }

        public List<Felid_Visit> SP_Browes_VisitTB_By_ID(int ID)
        {
            List<Felid_Visit> List_Visit = new List<Felid_Visit>();
            Felid_Visit _Felid = new Felid_Visit();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_VisitTB_By_ID",ID);
                if (_Reader.Read())
                {
                    _Felid.VisitID = (int)_Reader["VisitID"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.DataOfVisit = (DateTime)_Reader["DataOfVisit"];
                    _Felid.VisitTypeID = (int)_Reader["VisitTypeID"];
                    _Felid.Weight = (double)_Reader["Weight"];
                    _Felid.BloodPressure = (double)_Reader["BloodPressure"];
                    _Felid.PulseHeart = (int)_Reader["PulseHeart"];
                    _Felid.Temperature = (double)_Reader["Temperature"];
                    _Felid.PhysicalExamination = (string)_Reader["PhysicalExamination"];
                 
                    _Felid.Note = (string)_Reader["Note"];
                    List_Visit.Add(_Felid);
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
            return List_Visit;
            
        }

        public List<Felid_Visit> SP_Browes_VisitTB_By_PatientID(int PatientID)
        {

            List<Felid_Visit> List_Visit = new List<Felid_Visit>();
            Felid_Visit _Felid = new Felid_Visit();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_VisitTB_By_PatientID",PatientID);
                while (_Reader.Read())
                {

                    _Felid.VisitID = (int)_Reader["VisitID"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.DataOfVisit = (DateTime)_Reader["DataOfVisit"];
                    _Felid.VisitTypeID = (int)_Reader["VisitTypeID"];
                  
                    _Felid.Weight = (double)_Reader["Weight"];
                    _Felid.BloodPressure = (double)_Reader["BloodPressure"];
                    _Felid.PulseHeart = (int)_Reader["PulseHeart"];
                    _Felid.Temperature = (double)_Reader["Temperature"];
                    _Felid.PhysicalExamination = (string)_Reader["PhysicalExamination"];
                  
                    _Felid.Note = (string)_Reader["Note"];
                    List_Visit.Add(_Felid);
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
            return List_Visit;
            
        }

        public Felid_Visit SP_Browes_VisitTB_By_ID_Felid(int ID)
        {
            
            Felid_Visit _Felid = new Felid_Visit();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_VisitTB_By_ID_Felid", ID);
                if (_Reader.Read())
                {

                    _Felid.VisitID = (int)_Reader["VisitID"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.DataOfVisit = (DateTime)_Reader["DataOfVisit"];
                    _Felid.VisitTypeID = (int)_Reader["VisitTypeID"];
                    _Felid.Weight = (double)_Reader["Weight"];
                    _Felid.BloodPressure = (double)_Reader["BloodPressure"];
                    _Felid.PulseHeart = (int)_Reader["PulseHeart"];
                    _Felid.Temperature = (double)_Reader["Temperature"];
                    _Felid.PhysicalExamination = (string)_Reader["PhysicalExamination"];
                    
                    _Felid.Note = (string)_Reader["Note"];
                   
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

        public int SP_Delete_VisitTB_By_ID(int ID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_VisitTB_By_ID",ID);
        }

        public int SP_Insert_VisitTB(Felid_Visit Felid)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.ConnStr,"SP_Insert_VisitTB",
                Felid.PatientID 
                ,Felid.DataOfVisit 
                ,Felid.VisitTypeID 
             
                ,Felid.Weight
                ,Felid.BloodPressure
                ,Felid.PulseHeart
                ,Felid.Temperature 
                ,Felid.PhysicalExamination
      
                ,Felid.Note
                ));
        }

        public int SP_UpData_VisitTB_By_ID(Felid_Visit Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_VisitTB_By_ID",
               Felid.VisitID 
                ,Felid.PatientID
                , Felid.DataOfVisit
                , Felid.VisitTypeID
                , Felid.Weight
                , Felid.BloodPressure
                , Felid.PulseHeart
                , Felid.Temperature
                , Felid.PhysicalExamination
  
                , Felid.Note
                );
        }

        #endregion

        #region Inter_Felid_Visit Members


        public List<Felid_Visit> SP_Browes_Visit_Date_By_PatientID(int ID)
        {
            List<Felid_Visit> List_Visit = new List<Felid_Visit>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Visit_Date_By_PatientID",ID);
                while (_Reader.Read())
                {
                    Felid_Visit _Felid = new Felid_Visit();
                    _Felid.VisitID = (int)_Reader["VisitID"];
                   
                    _Felid.DataOfVisit = (DateTime)_Reader["DataOfVisit"];
                  
                    List_Visit.Add(_Felid);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            
            return List_Visit;
        }

    




        public List<Felid_Visit> SP_Browes_Visit_Date_All()
        {
            List<Felid_Visit> List_Visit = new List<Felid_Visit>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Visit_Date_All");
                while (_Reader.Read())
                {
                    Felid_Visit _Felid = new Felid_Visit();
                    _Felid.VisitID = (int)_Reader["VisitID"];

                    _Felid.DataOfVisit = (DateTime)_Reader["DataOfVisit"];

                    List_Visit.Add(_Felid);
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
            return List_Visit;
        }

       
    


        public DataTable SP_Brows_VisitTB_Ditalse()
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr,"SP_Brows_VisitTB_Ditalse");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    


        public DataTable SP_Browes_Visit_Detiles_PatientID(int PatientID)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Visit_Detiles_PatientID",PatientID);
            }
            catch(Exception ex)
            {
                throw ex;
            }
           }
 #endregion


    }
}
