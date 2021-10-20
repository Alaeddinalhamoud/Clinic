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
  public  class SP_OperationType : Inter_Felid_OperationType
    {

     

        #region Inter_Felid_OperationType Members


            SqlDataReader _Reader;


        public List<Felid_OperationType> SP_Browes_OperationType_All()
        {
            List<Felid_OperationType> List_OperationType = new List<Felid_OperationType>();
            try
            {


                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_OperationType_All");
                while (_Reader.Read())
                {
                    Felid_OperationType _Felid = new Felid_OperationType();
                    _Felid.OperationTypeID = (int)_Reader["OperationTypeID"];
                    _Felid.OperationType = (string)_Reader["OperationType"];

                    List_OperationType.Add(_Felid);

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
            return List_OperationType;
        }

        public List<Felid_OperationType> SP_Browes_OperationType_By_ID(int ID)
        {
            List<Felid_OperationType> List_OperationType = new List<Felid_OperationType>();
            Felid_OperationType _Felid = new Felid_OperationType();

            try
            {


                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_OperationType_By_ID",ID);
                if (_Reader.Read())
                {
                  
                    _Felid.OperationTypeID = (int)_Reader["OperationTypeID"];
                    _Felid.OperationType = (string)_Reader["OperationType"];

                    List_OperationType.Add(_Felid);

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
            return List_OperationType;
        }

        public Felid_OperationType SP_Browes_OperationType_By_ID_Felid(int ID)
        {
           
            Felid_OperationType _Felid = new Felid_OperationType();

            try
            {


                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_OperationType_By_ID_Felid", ID);
                if (_Reader.Read())
                {

                    _Felid.OperationTypeID = (int)_Reader["OperationTypeID"];
                    _Felid.OperationType = (string)_Reader["OperationType"];

                   

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

        public int SP_Delete_OperationType_By_ID(int ID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_OperationType_By_ID", ID);
        }

        public int SP_Insert_OperationType(Felid_OperationType Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_OperationType",
                 Felid.OperationType);
               
        }

        public int SP_UpData_OperationType_By_ID(Felid_OperationType Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_OperationType_By_ID",
                Felid.OperationTypeID  
                ,Felid.OperationType);
        }

        #endregion

        #region Inter_Felid_OperationType Members


         

        #endregion

         #region Inter_Felid_OperationType Members


      public   Felid_OperationType SP_Browes_OperationType_By_Name(string Name)
         {
             Felid_OperationType _Felid = new Felid_OperationType();

             try
             {


                 _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_OperationType_By_Name", Name);
                 if (_Reader.Read())
                 {

                     _Felid.OperationTypeID = (int)_Reader["OperationTypeID"];
                     _Felid.OperationType = (string)_Reader["OperationType"];



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
