using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inter_Felid;
using Lib_Felid;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace SP_Tables
{
   public class SP_Permission : Inter_Felid_Permission
    {
        #region Inter_Felid_Permission Members
       SqlDataReader _Reader;

        public Felid_Permission SP_Browes_Permission_ByUserID_Felid(int UserID)
        {
            Felid_Permission _Felid = new Felid_Permission();
            try
            {
                _Reader = SqlHelper.ExecuteReader(SqlHelper.ConnStr,"SP_Browes_Permission_ByUserID_Felid", UserID);
                if (_Reader.Read())
                {
                    _Felid.UserID = (int)_Reader["UserID"];
                    _Felid.PatientMenu = (bool)_Reader["PatientMenu"];
                    _Felid.CHB_FilePatient = (bool)_Reader["CHB_FilePatient"];
                    _Felid.CHB_OperationOfPatient = (bool)_Reader["CHB_OperationOfPatient"];
                    _Felid.CHB_lastDisease = (bool)_Reader["CHB_lastDisease"];
                    _Felid.CHB_LastMedication = (bool)_Reader["CHB_LastMedication"];
                    _Felid.CHB_Visit = (bool)_Reader["CHB_Visit"];
                    _Felid.AnalysisMeun = (bool)_Reader["AnalysisMeun"];
                    _Felid.CHB_Analysis=(bool)_Reader["CHB_Analysis"];
                    _Felid.CHB_Radio=(bool)_Reader["CHB_Radio"];
                    _Felid.InvoiceMeun = (bool)_Reader["InvoiceMeun"];
                    _Felid.CHB_Invoice = (bool)_Reader["CHB_Invoice"];
                    _Felid.ToolsMeun = (bool)_Reader["ToolsMeun"];
                    _Felid.CHB_CameraWatiching = (bool)_Reader["CHB_CameraWatiching"];
                    _Felid.CHB_BrowesImage = (bool)_Reader["CHB_BrowesImage"];
                    _Felid.CHB_ControlPanel=(bool)_Reader["CHB_ControlPanel"];
                    _Felid.CHB_ControlPanel = (bool)_Reader["CHB_ControlPanel"];
                    _Felid.CHB_AdminControlPanal = (bool)_Reader["CHB_AdminControlPanal"];
                    _Felid.CHB_UserContolPanel = (bool)_Reader["CHB_UserContolPanel"];
                    _Felid.CHB_BackUp = (bool)_Reader["CHB_BackUp"];
                    _Felid.AppointmentMeun = (bool)_Reader["AppointmentMeun"];
                    _Felid.CHB_Appointment = (bool)_Reader["CHB_Appointment"];
                    _Felid.PrescriptionMeun=(bool)_Reader["PrescriptionMeun"];
                    _Felid.CHB_Prescription = (bool)_Reader["CHB_Prescription"];

                
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _Felid;
        }

        public int SP_Insert_Permission(Felid_Permission Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Insert_Permission"
                ,Felid.UserID
                ,Felid.PatientMenu
                ,Felid.CHB_FilePatient
                ,Felid.CHB_OperationOfPatient
                ,Felid.CHB_lastDisease
                ,Felid.CHB_LastMedication
                ,Felid.CHB_Visit
                ,Felid.AnalysisMeun
                ,Felid.CHB_Analysis
                ,Felid.CHB_Radio
                ,Felid.InvoiceMeun
                ,Felid.CHB_Invoice
                ,Felid.ToolsMeun
                ,Felid.CHB_CameraWatiching 
                ,Felid.CHB_BrowesImage 
                ,Felid.CHB_ControlPanel
                ,Felid.CHB_AdminControlPanal
                ,Felid.CHB_UserContolPanel
                ,Felid.CHB_BackUp
                ,Felid.AppointmentMeun
                ,Felid.CHB_Appointment
                ,Felid.PrescriptionMeun
                ,Felid.CHB_Prescription);
        }

        public int SP_Update_Permission(Felid_Permission Felid)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Update_Permission"
                , Felid.UserID
                , Felid.PatientMenu
                , Felid.CHB_FilePatient
                , Felid.CHB_OperationOfPatient
                , Felid.CHB_lastDisease
                , Felid.CHB_LastMedication
                , Felid.CHB_Visit
                , Felid.AnalysisMeun
                , Felid.CHB_Analysis
                , Felid.CHB_Radio
                , Felid.InvoiceMeun
                , Felid.CHB_Invoice
                , Felid.ToolsMeun
                , Felid.CHB_CameraWatiching
                , Felid.CHB_BrowesImage 
                , Felid.CHB_ControlPanel
                , Felid.CHB_AdminControlPanal
                , Felid.CHB_UserContolPanel
                , Felid.CHB_BackUp
                , Felid.AppointmentMeun
                , Felid.CHB_Appointment
                , Felid.PrescriptionMeun
                , Felid.CHB_Prescription);
        }

        public int SP_Delete_Permission(int UserID)
        {
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnStr, "SP_Delete_Permission", UserID);
 
        }

        #endregion
    }
}
