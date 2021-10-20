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
    public class SP_Operation : Inter_Felid_Operation
    {
        #region Inter_Felid_Operation Members
        SqlDataReader _Reader;

        public List<Felid_Operation> SP_Browes_Operation_All()
        {
            List<Felid_Operation> List_Operation = new List<Felid_Operation>();

            try
            {
               

                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Operation_All");
                  while  (_Reader.Read ())
                {
                     Felid_Operation _Felid = new Felid_Operation();
                      _Felid.OperationID=(int)_Reader["OperationID"];
                      _Felid.DateOfOperation=(DateTime)_Reader["DateOfOperation"];
                      _Felid.PatientID=(int)_Reader["PatientID"];
                      _Felid.OperationTypeID=(int) _Reader["OperationTypeID"];
                   


                    List_Operation.Add(_Felid);

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
            return List_Operation;
           
           
        }

        public List<Felid_Operation> SP_Browes_Operation_All_By_ID(int ID)
        {
            List<Felid_Operation> List_Operation = new List<Felid_Operation>();

            Felid_Operation _Felid = new Felid_Operation();

            try
            {


                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Operation_All_By_ID",ID);
                if (_Reader.Read())
                {
                  
                    _Felid.OperationID = (int)_Reader["OperationID"];
                    _Felid.DateOfOperation = (DateTime)_Reader["DateOfOperation"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.OperationTypeID = (int)_Reader["OperationTypeID"];

                    _Felid.Note=(string)_Reader["Note"];

                    List_Operation.Add(_Felid);

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
            return List_Operation;
        }

        public Felid_Operation SP_Browes_Operation_All_By_ID_Felid(int ID)
        {
         

            Felid_Operation _Felid = new Felid_Operation();

            try
            {


                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Operation_All_By_ID_Felid", ID);
                if (_Reader.Read())
                {

                    _Felid.OperationID = (int)_Reader["OperationID"];
                    _Felid.DateOfOperation = (DateTime)_Reader["DateOfOperation"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.OperationTypeID = (int)_Reader["OperationTypeID"];
                    _Felid.Note=(string) _Reader["Note"];



                  

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

        public  Felid_Operation SP_Browes_Operation_All_By_PatientID_Felid(int PatientID)
        {

            

            Felid_Operation _Felid = new Felid_Operation();
            try
            {


                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Operation_All_By_PatientID_Felid", PatientID);
                while (_Reader.Read())
                {
                   

                    _Felid.OperationID = (int)_Reader["OperationID"];
                    _Felid.DateOfOperation = (DateTime)_Reader["DateOfOperation"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.OperationTypeID = (int)_Reader["OperationTypeID"];
                    _Felid.Note=(string)_Reader["Note"];
                    

              

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

        public int SP_Delete_Operation_By_ID(int ID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Operation_By_ID", ID);
        }

        public int SP_Insert_Operation(Felid_Operation Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Operation",
                Felid.DateOfOperation 
                ,Felid.PatientID 
                ,Felid.OperationTypeID 
                ,Felid.Note);
        }

        public int SP_UpData_Operation_By_ID(Felid_Operation Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_Operation_By_ID",
                 Felid.OperationID 
                ,Felid.DateOfOperation
                , Felid.PatientID
                , Felid.OperationTypeID
                ,Felid.Note);
        }

        #endregion

        #region Inter_Felid_Operation Members


        public List<Felid_Operation> SP_Browes_Operation_All_By_PatientID(int PatientID)
        {
            List<Felid_Operation> List_Operation = new List<Felid_Operation>();


            try
            {


                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Operation_All_By_PatientID", PatientID);
                while (_Reader.Read())
                {
                    Felid_Operation _Felid = new Felid_Operation();

                    _Felid.OperationID = (int)_Reader["OperationID"];
                    _Felid.DateOfOperation = (DateTime)_Reader["DateOfOperation"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.OperationTypeID = (int)_Reader["OperationTypeID"];
                    _Felid.Note=(string)_Reader["Note"];
                    List_Operation.Add(_Felid);



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
            return List_Operation;
        }

        #endregion

        #region Inter_Felid_Operation Members


        public DataTable SP_Browes_All_Dtailse_Opreation()
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr,"SP_Browes_All_Dtailse_Opreation");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SP_Browes_All_Dtailse_Opreation_By_PatientID(int ID)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_All_Dtailse_Opreation_By_PatientID", ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
