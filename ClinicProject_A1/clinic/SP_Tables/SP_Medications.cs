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
    public class SP_Medications : Inter_Felid_Medications
    {
        #region Inter_Felid_Medications Members

        SqlDataReader _Reader;

        public List<Felid_Medications> SP_Browes_Medications_All()
        {
            List<Felid_Medications> List_Medication = new List<Felid_Medications>();

            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Medications_All");
                while (_Reader.Read())
                {
                    Felid_Medications _Felid = new Felid_Medications();
                    _Felid.MedicationID = (int)_Reader["MedicationID"];
                    _Felid.MedicationName = (string)_Reader["MedicationName"];
                    _Felid.Company = _Reader["Company"].ToString();
                    _Felid.GroupOfRemedial = _Reader["GroupOfRemedial"].ToString();
                    _Felid.Classification = _Reader["Classification"].ToString();
                    _Felid.Page = (int)_Reader["Page"];
                    _Felid.MedicalOfConsultation = _Reader["MedicalOfConsultation"].ToString();
                    _Felid.AntiOfMedical_Consultation = _Reader["AntiOfMedical_Consultation"].ToString();
                    _Felid.Warning = _Reader["Warning"].ToString();
                    _Felid.OverlapOfMedication = _Reader["OverlapOfMedication"].ToString();
                    _Felid.SideOfEffect = _Reader["SideOfEffect"].ToString();
                    List_Medication.Add(_Felid);

                }
            }
            catch (Exception ex)
            { throw ex;
            }
            finally
            {
                _Reader.Close();
                _Reader.Dispose();
            }
            return List_Medication;
        }

        public List<Felid_Medications> SP_Browes_Medications_By_ID(int MedicationID)
        {
            List<Felid_Medications> List_Medication = new List<Felid_Medications>();
            Felid_Medications _Felid = new Felid_Medications();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Medications_By_ID", MedicationID);
                if (_Reader.Read())
                {
                   
                    _Felid.MedicationID = (int)_Reader["MedicationID"];
                    _Felid.MedicationName = (string)_Reader["MedicationName"];
                    _Felid.Company = _Reader["Company"].ToString();
                    _Felid.GroupOfRemedial = _Reader["GroupOfRemedial"].ToString();
                    _Felid.Classification = _Reader["Classification"].ToString();
                    _Felid.Page = (int)_Reader["Page"];
                    _Felid.MedicalOfConsultation = _Reader["MedicalOfConsultation"].ToString();
                    _Felid.AntiOfMedical_Consultation = _Reader["AntiOfMedical_Consultation"].ToString();
                    _Felid.Warning = _Reader["Warning"].ToString();
                    _Felid.OverlapOfMedication = _Reader["OverlapOfMedication"].ToString();
                    _Felid.SideOfEffect = _Reader["SideOfEffect"].ToString();
                    List_Medication.Add(_Felid);

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
            return List_Medication;
        }

        public List<Felid_Medications> SP_Browes_Medications_By_Name(string MedicationName)
        {
            List<Felid_Medications> List_Medication = new List<Felid_Medications>();
            Felid_Medications _Felid = new Felid_Medications();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Medications_By_Name", MedicationName);
                if (_Reader.Read())
                {

                    _Felid.MedicationID = (int)_Reader["MedicationID"];
                    _Felid.MedicationName = (string)_Reader["MedicationName"];
                    _Felid.Company = _Reader["Company"].ToString();
                    _Felid.GroupOfRemedial = _Reader["GroupOfRemedial"].ToString();
                    _Felid.Classification = _Reader["Classification"].ToString();
                    _Felid.Page = (int)_Reader["Page"];
                    _Felid.MedicalOfConsultation = _Reader["MedicalOfConsultation"].ToString();
                    _Felid.AntiOfMedical_Consultation = _Reader["AntiOfMedical_Consultation"].ToString();
                    _Felid.Warning = _Reader["Warning"].ToString();
                    _Felid.OverlapOfMedication = _Reader["OverlapOfMedication"].ToString();
                    _Felid.SideOfEffect = _Reader["SideOfEffect"].ToString();
                    List_Medication.Add(_Felid);

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
            return List_Medication;
        }

        public int SP_Insert_Medications(Felid_Medications Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Medications"
           
                ,Felid.MedicationName
                ,Felid.Company
                ,Felid.GroupOfRemedial
                ,Felid.Classification
                ,Felid.Page
                ,Felid.MedicalOfConsultation
                ,Felid.AntiOfMedical_Consultation
                ,Felid.Warning
                ,Felid.OverlapOfMedication
                ,Felid.SideOfEffect);
        }

        public int SP_UpDate_Medications_By_ID(Felid_Medications Felid)
        {
           return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpDate_Medications_By_ID"
                , Felid.MedicationID
                , Felid.MedicationName
                ,Felid.Company
                ,Felid.GroupOfRemedial
                ,Felid.Classification
                ,Felid.Page
                ,Felid.MedicalOfConsultation
                ,Felid.AntiOfMedical_Consultation
                ,Felid.Warning
                ,Felid.OverlapOfMedication
                ,Felid.SideOfEffect);
        }

        public int SP_Delete_Medications_By_ID(int MedicationID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Medications_By_ID"
                  , MedicationID);
        }

        #endregion

        #region Inter_Felid_Medications Members


        public Felid_Medications SP_Browes_Medications_By_ID_Felid(int MedicationID)
        {
            
            Felid_Medications _Felid = new Felid_Medications();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Medications_By_ID_Felid", MedicationID);
                if (_Reader.Read())
                {

                    _Felid.MedicationID = (int)_Reader["MedicationID"];
                    _Felid.MedicationName = (string)_Reader["MedicationName"];
                    _Felid.Company = _Reader["Company"].ToString();
                    _Felid.GroupOfRemedial = _Reader["GroupOfRemedial"].ToString();
                    _Felid.Classification = _Reader["Classification"].ToString();
                    _Felid.Page = (int)_Reader["Page"];
                    _Felid.MedicalOfConsultation = _Reader["MedicalOfConsultation"].ToString();
                    _Felid.AntiOfMedical_Consultation = _Reader["AntiOfMedical_Consultation"].ToString();
                    _Felid.Warning = _Reader["Warning"].ToString();
                    _Felid.OverlapOfMedication = _Reader["OverlapOfMedication"].ToString();
                    _Felid.SideOfEffect = _Reader["SideOfEffect"].ToString();

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

        #region Inter_Felid_Medications Members


        public DataTable SP_Browes_Pharmacy_By_Medication_Name(string MedicationName)
        {
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Pharmacy_By_Medication_Name", MedicationName);
        }

        public DataTable SP_Browes_Pharmacy_By_Company_Name(string CompanyName)
        {
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Pharmacy_By_Company_Name", CompanyName);
        }

        public DataTable SP_Browes_Pharmacy_By_SideEffect(string SideEffect)
        {
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Pharmacy_By_SideEffect", SideEffect);
        }

        public DataTable SP_Browes_Pharmacy_By_MedicalOfConsultation(string MedicalOfConsultation)
        {
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Browes_Pharmacy_By_MedicalOfConsultation", MedicalOfConsultation);
        }

        public DataTable SP_Browes_Pharmacy_By_OverlapOfMedication(string OverLap)
        {
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr,"SP_Browes_Pharmacy_By_OverlapOfMedication", OverLap);
        }

        #endregion
    }
}
