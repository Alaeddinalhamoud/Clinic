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
    public class SP_Appointment : Inter_Felid_Appointment 
    {
        #region Inter_Felid_Appointment Members
        SqlDataReader _Redear;

        public List<Felid_Appointment> SP_Browes_Appointment_All_By_Date(DateTime Date)
        {
            List<Felid_Appointment> List_Appointment = new List<Felid_Appointment>();
            try
                
            {
                _Redear = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Appointment_All_By_Date", Date);
                while (_Redear.Read ())
                {
                    Felid_Appointment _Felid = new Felid_Appointment();
                    _Felid.AppointmentID = (int)_Redear["AppointmentID"];
                    _Felid.PatientName = (string)_Redear["PatientName"];
                    _Felid.Date = (DateTime)_Redear["Date"];
                    _Felid.Time = (string)_Redear["Time"];
                    _Felid.VisitTypeID=(int)_Redear["VisitTypeID"];
                    _Felid.Note = (string)_Redear["Note"];
                    List_Appointment.Add(_Felid);

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _Redear.Close();
                _Redear.Dispose();
            }
            return List_Appointment;
        }

        public Felid_Appointment SP_Browes_Appointment_By_ID_Felid(int ID)
        {
            Felid_Appointment _Felid = new Felid_Appointment();
            try
            {
                _Redear = SqlHelper.ExecuteReader(SqlHelper.ConnStr, "SP_Browes_Appointment_By_ID_Felid", ID);
                while (_Redear.Read())
                {
                    
                    _Felid.AppointmentID = (int)_Redear["AppointmentID"];
                    _Felid.PatientName = (string)_Redear["PatientName"];
                    _Felid.Date = (DateTime)_Redear["Date"];
                    _Felid.Time = (string)_Redear["Time"];
                    _Felid.VisitTypeID = (int)_Redear["VisitTypeID"];
                    _Felid.Note = (string)_Redear["Note"];
                    
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _Redear.Close();
                _Redear.Dispose();
            }
            return _Felid;
        }

        public int SP_Delete_Appointment_By_ID(int ID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr,"SP_Delete_Appointment_By_ID", ID);
        }

        public int SP_Insert_Appointment(Felid_Appointment Felid)
        {
            try
            {
                return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Appointment",
                    Felid.PatientName,
                    Felid.Date,
                    Felid.Time,
                    Felid.VisitTypeID,
                    Felid.Note);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SP_Updata_Appointment_By_ID(Felid_Appointment Felid)
        {
            try{
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Updata_Appointment_By_ID",
               Felid.AppointmentID
               , Felid.PatientName,
                Felid.Date,
                Felid.Time,
                Felid.VisitTypeID,
                Felid.Note);
             }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        #endregion

        #region Inter_Felid_Appointment Members


        public DataTable SP_Brows_Datials_Appointement(DateTime Da)
        {
            try {
                return SqlHelper.ExecuteDataTable(SqlHelper.ConnStr, "SP_Brows_Datials_Appointement", Da);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Inter_Felid_Appointment Members


        public int SP_Delete_Appoitment_By_Date(DateTime Date)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Appoitment_By_Date", Date);
        }

        #endregion
    }
}
