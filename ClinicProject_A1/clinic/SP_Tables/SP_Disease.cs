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
    public class SP_Disease : Inter_Felid_Disease
    {
        #region Inter_Felid_Disease Members
        SqlDataReader _Reader;
        public List<Felid_Disease> SP_Browes_Disease_All()
        {
            List <Felid_Disease> List_Disease=new List<Felid_Disease> ();
            try
            {

                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Disease_All");
                while (_Reader.Read())
                {
                    Felid_Disease _Felid = new Felid_Disease();
                    _Felid.DiseaseID = (int)_Reader["DiseaseID"];
                    _Felid.DiseaseName = (string)_Reader["DiseaseName"];
                    List_Disease.Add(_Felid);
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
            return List_Disease;

        }

        #endregion

        #region Inter_Felid_Disease Members


        public List<Felid_Disease> SP_Browes_Disease_By_ID(int DiseaseID)
        {
            List<Felid_Disease> List_Disease = new List<Felid_Disease>();
            Felid_Disease _Felid = new Felid_Disease();
            try
            {

                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Disease_By_ID", DiseaseID);
               if (_Reader.Read())
                {
                    
                    _Felid.DiseaseID = (int)_Reader["DiseaseID"];
                    _Felid.DiseaseName = (string)_Reader["DiseaseName"];
                    List_Disease.Add(_Felid);
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
            return List_Disease;
        }

        public List<Felid_Disease> SP_Browes_Disease_By_Name(string DiseaseName)
        {
            List<Felid_Disease> List_Disease = new List<Felid_Disease>();
            Felid_Disease _Felid = new Felid_Disease();
            try
            {

                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Disease_By_Name", DiseaseName);
                if (_Reader.Read())
                {

                    _Felid.DiseaseID = (int)_Reader["DiseaseID"];
                    _Felid.DiseaseName = (string)_Reader["DiseaseName"];
                    List_Disease.Add(_Felid);
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
            return List_Disease;
        }

        public int SP_Insert_Disease(Felid_Disease Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Disease"

               , Felid.DiseaseName);
        }

        public int SP_UpDate_Disease_By_ID(Felid_Disease Felid)
        {
            
                return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpDate_Disease_By_ID"
                    , Felid.DiseaseID
                          , Felid.DiseaseName);
            
        }

        public int SP_Delete_Disease_By_ID(int DiseaseID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Disease_By_ID"
                ,DiseaseID );
        }

        #endregion

        #region Inter_Felid_Disease Members


        public Felid_Disease SP_Browes_Disease_By_ID_Felid(int DiseaseID)
        {
           
            Felid_Disease _Felid = new Felid_Disease();
            try
            {

                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Disease_By_ID_Felid", DiseaseID);
               if (_Reader.Read())
                {
                    
                    _Felid.DiseaseID = (int)_Reader["DiseaseID"];
                    _Felid.DiseaseName = (string)_Reader["DiseaseName"];
                  
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
    }
}
