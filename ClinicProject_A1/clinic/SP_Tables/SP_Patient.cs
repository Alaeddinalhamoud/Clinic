using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data.SqlClient;
using Inter_Felid;
using Lib_Felid.Patient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;



namespace SP_Tables
{
    public class SP_Patient : Inter_Felid_Patient
    {
        #region Inter_Felid_Patient Members
        SqlDataReader _Reader;

        public int SP_Insert_Patient(Felid_Patient Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Patient"
         , Felid.FirstName
         , Felid.LastName

         , Felid.DataOfRegister
         , Felid.DataOFBirth
         , Felid.SexID
         , Felid.BloodID
         , Felid.SocialStateID
         , Felid.ChidNo
         , Felid.Job
         , Felid.AddressHome
         , Felid.AddressWork
         , Felid.Email
         , Felid.Tel
         , Felid.Mobile
         , Felid.TelWork
         , Felid.Smoke
         , Felid.Win
         , Felid.Sensitive
         , Felid.Note
        , Felid.ImagePath);
        }

        public int SP_Update_Patient_By_PatientID(Felid_Patient Felid)
        {

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Update_Patient_By_PatientID"
         , Felid.PatientID
          , Felid.FirstName
         , Felid.LastName

         , Felid.DataOFBirth
         , Felid.DataOFBirth
         , Felid.SexID
         , Felid.BloodID
         , Felid.SocialStateID
         , Felid.ChidNo
         , Felid.Job
         , Felid.AddressHome
         , Felid.AddressWork
         , Felid.Email
         , Felid.Tel
         , Felid.Mobile
         , Felid.TelWork
         , Felid.Smoke
         , Felid.Win
         , Felid.Sensitive
         , Felid.Note
         );
        }

        public int SP_Delete_Patient_By_PatientID(int PatientID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Patient_By_PatientID", PatientID);
        }

        #endregion

        #region Inter_Felid_Patient Members

        public List<Felid_Patient> SP_Browes_Patient_All()
        {

            List<Felid_Patient> List_Patient = new List<Felid_Patient>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Patient_All");
                while (_Reader.Read())
                {
                    Felid_Patient _Felid = new Felid_Patient();
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.FirstName = (string)_Reader["FirstName"];
                    _Felid.LastName = (string)_Reader["LastName"];
                    _Felid.DataOfRegister = (DateTime)_Reader["DataOfRegister"];
                    _Felid.DataOFBirth = (DateTime)_Reader["DataOFBirth"];
                    _Felid.SexID = (int)_Reader["SexID"];
                    _Felid.BloodID = (int)_Reader["BloodID"];
                    _Felid.SocialStateID = (int)_Reader["SocialStateID"];
                    _Felid.ChidNo = (int)_Reader["ChidNo"];
                    _Felid.Job = (string)_Reader["Job"];
                    _Felid.AddressHome = (string)_Reader["AddressHome"];
                    _Felid.AddressWork = (string)_Reader["AddressWork"];
                    _Felid.Email = (string)_Reader["Email"];
                    _Felid.Tel = (string)_Reader["Tel"];
                    _Felid.Mobile = (string)_Reader["Mobile"];
                    _Felid.TelWork = (string)_Reader["TelWork"];
                    _Felid.Smoke = (bool)_Reader["Smoke"];
                    _Felid.Win = (bool)_Reader["Win"];
                    _Felid.Sensitive = (string)_Reader["Sensitive"];
                    _Felid.Note = (string)_Reader["Note"];
                    _Felid.ImagePath = (string)_Reader["ImagePath"];

                    List_Patient.Add(_Felid);
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
            return List_Patient;
        }

        public Felid_Patient SP_Browes_Patient_By_PatientID(int PatientID)
        {
            Felid_Patient _Felid = new Felid_Patient();

            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Patient_By_PatientID", PatientID);

                if (_Reader.Read())
                {

                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.FirstName = (string)_Reader["FirstName"];
                    _Felid.LastName = (string)_Reader["LastName"];
                    _Felid.DataOfRegister = (DateTime)_Reader["DataOfRegister"];
                    _Felid.DataOFBirth = (DateTime)_Reader["DataOFBirth"];
                    _Felid.SexID = (int)_Reader["SexID"];
                    _Felid.BloodID = (int)_Reader["BloodID"];
                    _Felid.SocialStateID = (int)_Reader["SocialStateID"];
                    _Felid.ChidNo = (int)_Reader["ChidNo"];
                    _Felid.Job = (string)_Reader["Job"];
                    _Felid.AddressHome = (string)_Reader["AddressHome"];
                    _Felid.AddressWork = (string)_Reader["AddressWork"];
                    _Felid.Email = (string)_Reader["Email"];
                    _Felid.Tel = (string)_Reader["Tel"];
                    _Felid.Mobile = (string)_Reader["Mobile"];
                    _Felid.TelWork = (string)_Reader["TelWork"];
                    _Felid.Smoke = (bool)_Reader["Smoke"];
                    _Felid.Win = (bool)_Reader["Win"];
                    _Felid.Sensitive = (string)_Reader["Sensitive"];
                    _Felid.Note = (string)_Reader["Note"];

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

        public Felid_Patient SP_Browes_Patient_By_LastName(string LastName)
        {

            Felid_Patient _Felid = new Felid_Patient();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Patient_By_LastName", LastName);

                if (_Reader.Read())
                {

                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.FirstName = (string)_Reader["FirstName"];
                    _Felid.LastName = (string)_Reader["LastName"];

                    _Felid.DataOfRegister = (DateTime)_Reader["DataOfRegister"];
                    _Felid.DataOFBirth = (DateTime)_Reader["DataOFBirth"];
                    _Felid.SexID = (int)_Reader["SexID"];
                    _Felid.BloodID = (int)_Reader["BloodID"];
                    _Felid.SocialStateID = (int)_Reader["SocialStateID"];
                    _Felid.ChidNo = (int)_Reader["ChidNo"];
                    _Felid.Job = (string)_Reader["Job"];
                    _Felid.AddressHome = (string)_Reader["AddressHome"];
                    _Felid.AddressWork = (string)_Reader["AddressWork"];
                    _Felid.Email = (string)_Reader["Email"];
                    _Felid.Tel = (string)_Reader["Tel"];
                    _Felid.Mobile = (string)_Reader["Mobile"];
                    _Felid.TelWork = (string)_Reader["TelWork"];
                    _Felid.Smoke = (bool)_Reader["Smoke"];
                    _Felid.Win = (bool)_Reader["Win"];
                    _Felid.Sensitive = (string)_Reader["Sensitive"];
                    _Felid.Note = (string)_Reader["Note"];
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

        public Felid_Patient SP_Browes_Patient_By_FirstName(string FirstName)
        {

            Felid_Patient _Felid = new Felid_Patient();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Patient_By_FirstName", FirstName);

                if (_Reader.Read())
                {

                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.FirstName = (string)_Reader["FirstName"];
                    _Felid.LastName = (string)_Reader["LastName"];

                    _Felid.DataOfRegister = (DateTime)_Reader["DataOfRegister"];
                    _Felid.DataOFBirth = (DateTime)_Reader["DataOFBirth"];
                    _Felid.SexID = (int)_Reader["SexID"];
                    _Felid.BloodID = (int)_Reader["BloodID"];
                    _Felid.SocialStateID = (int)_Reader["SocialStateID"];
                    _Felid.ChidNo = (int)_Reader["ChidNo"];
                    _Felid.Job = (string)_Reader["Job"];
                    _Felid.AddressHome = (string)_Reader["AddressHome"];
                    _Felid.AddressWork = (string)_Reader["AddressWork"];
                    _Felid.Email = (string)_Reader["Email"];
                    _Felid.Tel = (string)_Reader["Tel"];
                    _Felid.Mobile = (string)_Reader["Mobile"];
                    _Felid.TelWork = (string)_Reader["TelWork"];
                    _Felid.Smoke = (bool)_Reader["Smoke"];
                    _Felid.Win = (bool)_Reader["Win"];
                    _Felid.Sensitive = (string)_Reader["Sensitive"];
                    _Felid.Note = (string)_Reader["Note"];
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





        #endregion

        #region Inter_Felid_Patient Members


        public List<Felid_Patient> SP_Browes_Patient_By_PatientID_Felid(int PatientID)
        {
            List<Felid_Patient> List_Patient = new List<Felid_Patient>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Patient_By_PatientID_Felid", PatientID);
                while (_Reader.Read())
                {
                    Felid_Patient _Felid = new Felid_Patient();
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.FirstName = (string)_Reader["FirstName"];
                    _Felid.LastName = (string)_Reader["LastName"];

                    _Felid.DataOfRegister = (DateTime)_Reader["DataOfRegister"];
                    _Felid.DataOFBirth = (DateTime)_Reader["DataOFBirth"];
                    _Felid.SexID = (int)_Reader["SexID"];
                    _Felid.BloodID = (int)_Reader["BloodID"];
                    _Felid.SocialStateID = (int)_Reader["SocialStateID"];
                    _Felid.ChidNo = (int)_Reader["ChidNo"];
                    _Felid.Job = (string)_Reader["Job"];
                    _Felid.AddressHome = (string)_Reader["AddressHome"];
                    _Felid.AddressWork = (string)_Reader["AddressWork"];
                    _Felid.Email = (string)_Reader["Email"];
                    _Felid.Tel = (string)_Reader["Tel"];
                    _Felid.Mobile = (string)_Reader["Mobile"];
                    _Felid.TelWork = (string)_Reader["TelWork"];
                    _Felid.Smoke = (bool)_Reader["Smoke"];
                    _Felid.Win = (bool)_Reader["Win"];
                    _Felid.Sensitive = (string)_Reader["Sensitive"];
                    _Felid.Note = (string)_Reader["Note"];
                    _Felid.ImagePath = (string)_Reader["ImagePath"];

                    List_Patient.Add(_Felid);
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
            return List_Patient;
        }

        #endregion

        #region Inter_Felid_Patient Members


        public Felid_Patient SP_Browes_Patient_Name_By_ID(int PatientID)
        {
            Felid_Patient _Felid = new Felid_Patient();

            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Patient_By_PatientID", PatientID);

                if (_Reader.Read())
                {


                    _Felid.FirstName = (string)_Reader["FirstName"];


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

        #region Inter_Felid_Patient Members


        public List<Felid_Patient> SP_Browes_Patient_List_By_FirstName(string FirstName)
        {
            List<Felid_Patient> List_FirstName = new List<Felid_Patient>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Patient_List_By_FirstName", FirstName);

                while (_Reader.Read())
                {
                    Felid_Patient _Felid = new Felid_Patient();

                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.FirstName = (string)_Reader["FirstName"];
                    _Felid.LastName = (string)_Reader["LastName"];

                    _Felid.DataOfRegister = (DateTime)_Reader["DataOfRegister"];
                    _Felid.DataOFBirth = (DateTime)_Reader["DataOFBirth"];
                    _Felid.SexID = (int)_Reader["SexID"];
                    _Felid.BloodID = (int)_Reader["BloodID"];
                    _Felid.SocialStateID = (int)_Reader["SocialStateID"];
                    _Felid.ChidNo = (int)_Reader["ChidNo"];
                    _Felid.Job = (string)_Reader["Job"];
                    _Felid.AddressHome = (string)_Reader["AddressHome"];
                    _Felid.AddressWork = (string)_Reader["AddressWork"];
                    _Felid.Email = (string)_Reader["Email"];
                    _Felid.Tel = (string)_Reader["Tel"];
                    _Felid.Mobile = (string)_Reader["Mobile"];
                    _Felid.TelWork = (string)_Reader["TelWork"];
                    _Felid.Smoke = (bool)_Reader["Smoke"];
                    _Felid.Win = (bool)_Reader["Win"];
                    _Felid.Sensitive = (string)_Reader["Sensitive"];
                    _Felid.Note = (string)_Reader["Note"];
                    _Felid.ImagePath = (string)_Reader["ImagePath"];

                    List_FirstName.Add(_Felid);

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
            return List_FirstName;
        }

        public List<Felid_Patient> SP_Browes_Patient_List_By_LastName(string LastName)
        {
            List<Felid_Patient> List_LastName = new List<Felid_Patient>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Patient_List_By_LastName", LastName);

                while (_Reader.Read())
                {
                    Felid_Patient _Felid = new Felid_Patient();

                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.FirstName = (string)_Reader["FirstName"];
                    _Felid.LastName = (string)_Reader["LastName"];

                    _Felid.DataOfRegister = (DateTime)_Reader["DataOfRegister"];
                    _Felid.DataOFBirth = (DateTime)_Reader["DataOFBirth"];
                    _Felid.SexID = (int)_Reader["SexID"];
                    _Felid.BloodID = (int)_Reader["BloodID"];
                    _Felid.SocialStateID = (int)_Reader["SocialStateID"];
                    _Felid.ChidNo = (int)_Reader["ChidNo"];
                    _Felid.Job = (string)_Reader["Job"];
                    _Felid.AddressHome = (string)_Reader["AddressHome"];
                    _Felid.AddressWork = (string)_Reader["AddressWork"];
                    _Felid.Email = (string)_Reader["Email"];
                    _Felid.Tel = (string)_Reader["Tel"];
                    _Felid.Mobile = (string)_Reader["Mobile"];
                    _Felid.TelWork = (string)_Reader["TelWork"];
                    _Felid.Smoke = (bool)_Reader["Smoke"];
                    _Felid.Win = (bool)_Reader["Win"];
                    _Felid.Sensitive = (string)_Reader["Sensitive"];
                    _Felid.Note = (string)_Reader["Note"];
                    _Felid.ImagePath = (string)_Reader["ImagePath"];

                    List_LastName.Add(_Felid);

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
            return List_LastName;
        }

        #endregion

        #region Inter_Felid_Patient Members


        public List<Felid_Patient> SP_Browes_Patient_FullName()
        {
            List<Felid_Patient> List_Patient = new List<Felid_Patient>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Patient_FullName");
                while (_Reader.Read())
                {
                    Felid_Patient _Felid = new Felid_Patient();
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.FirstName = (string)_Reader["FirstName"];

                    List_Patient.Add(_Felid);
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
            return List_Patient;

        }

        #endregion

        #region Inter_Felid_Patient Members


        public List<Felid_Patient> SP_Browes_Patient_FullName_By_ID(int ID)
        {
            List<Felid_Patient> List_Patient = new List<Felid_Patient>();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Patient_FullName_By_ID", ID);
                if (_Reader.Read())
                {
                    Felid_Patient _Felid = new Felid_Patient();
                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.FirstName = (string)_Reader["FirstName"];

                    List_Patient.Add(_Felid);
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
            return List_Patient;
        }

        #endregion

        #region Inter_Felid_Patient Members


        public Felid_Patient SP_Browes_Patient_FullName_By_ID_Felid(int ID)
        {
            Felid_Patient _Felid = new Felid_Patient();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,
                    "SP_Browes_Patient_FullName_By_ID_Felid", ID);
                if (_Reader.Read())
                {

                    _Felid.PatientID = (int)_Reader["PatientID"];
                    _Felid.FirstName = (string)_Reader["FirstName"];


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

        #region Inter_Felid_Patient Members


        public int SP_UpData_Patient_Image_Path_By_ID(Felid_Patient Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_UpData_Patient_Image_Path_By_ID", Felid.PatientID, Felid.ImagePath);
        }

        #endregion








        #region Inter_Felid_Patient Members


        public DataTable SP_Brows_Datails_Patient_Report_From_To_Date(DateTime FromDate, DateTime ToDate)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr,"SP_Brows_Datails_Patient_Report_From_To_Date", FromDate, ToDate);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SP_Brows_Datails_Patient_Report(int ID,Image i)
        {
            try
            {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr,"SP_Brows_Datails_Patient_Report", ID,i);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
