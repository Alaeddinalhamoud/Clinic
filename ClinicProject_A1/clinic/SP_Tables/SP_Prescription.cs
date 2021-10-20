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
    public class SP_Prescription : Inter_Felid_Prescription
    {
        #region Inter_Felid_Prescription Members
        SqlDataReader _Reader;
        public int SP_UpData_Prescription(Felid_Prescription Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_Prescription", Felid.PrescriptionID
                , Felid.DateOfPrescription, Felid.PatientID, Felid.VisitID);
        }

        public int SP_Insert_Prescription(Felid_Prescription Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Prescription", 
                Felid.DateOfPrescription, Felid.PatientID, Felid.VisitID);
        }

        public int SP_Delete_Prescription(int PrescriptionID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr,"SP_Delete_Prescription", PrescriptionID);
        }

        #endregion

        #region Inter_Felid_Prescription Members


        public List<Felid_Prescription> SP_Browes_Prescription_By_Patient(int PatientID)
        {
            List<Felid_Prescription> List_Prescription = new List<Felid_Prescription>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Prescription_By_Patient", PatientID);
                while(_Reader.Read())
                {
                Felid_Prescription _Felid = new Felid_Prescription();
                _Felid.PrescriptionID = (int)_Reader["PrescriptionID"];
                _Felid.DateOfPrescription = (DateTime)_Reader["DateOfPrescription"];
                _Felid.PatientID = (int)_Reader["PatientID"];
                _Felid.VisitID = (int)_Reader["VisitID"];
                List_Prescription.Add(_Felid);
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
            return List_Prescription;
        }

        public Felid_Prescription SP_Browes_Prescription_By_ID_Felid(int PatientID)
        {
            Felid_Prescription _Felid = new Felid_Prescription();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Prescription_By_ID_Felid", PatientID);
                if (_Reader.Read())
                {
                    
                    _Felid.PrescriptionID = (int)_Reader["PrescriptionID"];
                    _Felid.DateOfPrescription = (DateTime)_Reader["DateOfPrescription"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.VisitID = (int)_Reader["VisitID"];
                    
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

        #region Inter_Felid_Prescription Members


        public DataTable SP_Browes_Prescription_Datials_PatientID(int ID)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr,"SP_Browes_Prescription_Datials_PatientID", ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SP_Browes_Prescription_Datials()
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr,"SP_Browes_Prescription_Datials");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Inter_Felid_Prescription Members


        public Felid_Prescription Browes_Perscreption_All_List_By_PatientID(int PatientID)
        {
            Felid_Prescription _Felid = new Felid_Prescription();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "Browes_Perscreption_All_List_By_PatientID", PatientID);
                if (_Reader.Read())
                {

                    _Felid.PrescriptionID = (int)_Reader["PrescriptionID"];
                    _Felid.DateOfPrescription = (DateTime)_Reader["DateOfPrescription"];
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.VisitID = (int)_Reader["VisitID"];

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
