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
    public class SP_AnalysisType:Inter_Felid_AnlaysisType
    {
        #region Inter_Felid_AnlaysisType Members
        SqlDataReader _Reader;

        public List<Filed_AnalysisType> SP_Browes_AnalysisTypeTB_All()
        {
            List<Filed_AnalysisType> List_AnalysisType = new List<Filed_AnalysisType>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_AnalysisTypeTB_All");
                 while(_Reader.Read())
                 {
                   Filed_AnalysisType _Felid=new Filed_AnalysisType ();
                   _Felid.AnalysisTypeID=(int)_Reader["AnalysisTypeID"];
                     _Felid.Analysis=(string)_Reader["Analysis"];
                     List_AnalysisType.Add(_Felid);

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
            return List_AnalysisType;
        }

        public List<Filed_AnalysisType> SP_Browes_AnalysisTypeTB_By_Name(string AnalysisType)
        {
            List<Filed_AnalysisType> List_AnalysisType = new List<Filed_AnalysisType>();
            Filed_AnalysisType _Felid = new Filed_AnalysisType();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_AnalysisTypeTB_By_Name", AnalysisType);
                while (_Reader.Read())
                {
                   
                    _Felid.AnalysisTypeID = (int)_Reader["AnalysisTypeID"];
                    _Felid.Analysis = (string)_Reader["Analysis"];
                    List_AnalysisType.Add(_Felid);

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
            return List_AnalysisType;
        }

        public int SP_Delete_AnalysisTypeTB(int AnalysisTypeID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_AnalysisTypeTB", AnalysisTypeID);
        }

        public Filed_AnalysisType SP_Browes_AnalysisTypeTB_By_Name_Felid(string  Analysis)
        {
            
            Filed_AnalysisType _Felid = new Filed_AnalysisType();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_AnalysisTypeTB_By_Name_Felid", Analysis);
                if (_Reader.Read())
                {

                    _Felid.AnalysisTypeID = (int)_Reader["AnalysisTypeID"];
                    _Felid.Analysis = (string)_Reader["Analysis"];
                  

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

        public int SP_UpData_AnalysisTypeTB(Filed_AnalysisType Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_AnalysisTypeTB", Felid.AnalysisTypeID, Felid.Analysis);
        }

        public int SP_Insert_AnalysisTypeTB(Filed_AnalysisType Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_AnalysisTypeTB",Felid.Analysis);
        }

        #endregion

        #region Inter_Felid_AnlaysisType Members


        public Filed_AnalysisType SP_Browes_AnalysisTypeTB_By_ID_Felid(int AnalysisTypeID)
        {
            Filed_AnalysisType _Felid = new Filed_AnalysisType();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_AnalysisTypeTB_By_ID_Felid", AnalysisTypeID);
                if (_Reader.Read())
                {

                    _Felid.AnalysisTypeID = (int)_Reader["AnalysisTypeID"];
                    _Felid.Analysis = (string)_Reader["Analysis"];


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

        #region Inter_Felid_AnlaysisType Members


        public List<Filed_AnalysisType> SP_Browes_AnalysisType_By_ID_List(int ID)
        {
            List<Filed_AnalysisType> List_AnalysisType = new List<Filed_AnalysisType>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_AnalysisType_By_ID_List",ID);
                while (_Reader.Read())
                {
                    Filed_AnalysisType _Felid = new Filed_AnalysisType();
                    _Felid.AnalysisTypeID = (int)_Reader["AnalysisTypeID"];
                    _Felid.Analysis = (string)_Reader["Analysis"];
                    List_AnalysisType.Add(_Felid);

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
            return List_AnalysisType;
        }

        #endregion

        #region Inter_Felid_AnlaysisType Members


        public bool   MakeSureToAddAnalysis(string s)
        {
            bool r;
            try
            {
                r= Convert.ToBoolean(SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "MakeSureToAddAnalysis", s));
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       


        public string  SP_Make_Sure_Analysis(int s)
        {
            try
            {
                return SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Make_Sure_Analysis", s).ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
