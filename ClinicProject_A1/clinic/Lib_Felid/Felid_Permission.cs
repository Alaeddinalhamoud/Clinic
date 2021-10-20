using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
    public class Felid_Permission
    {
        private int _UserID;

        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
       
        private bool _PatientMenu;

        public bool PatientMenu
        {
            get { return _PatientMenu; }
            set { _PatientMenu = value; }
        }



        private bool _CHB_FilePatient;

        public bool CHB_FilePatient
        {
            get { return _CHB_FilePatient; }
            set { _CHB_FilePatient = value; }
        }
       private bool _CHB_OperationOfPatient;

       public bool CHB_OperationOfPatient
       {
           get { return _CHB_OperationOfPatient; }
           set { _CHB_OperationOfPatient = value; }
       }
       private bool _CHB_lastDisease;

       public bool CHB_lastDisease
       {
           get { return _CHB_lastDisease; }
           set { _CHB_lastDisease = value; }
       }
       private bool _CHB_LastMedication;

       public bool CHB_LastMedication
       {
           get { return _CHB_LastMedication; }
           set { _CHB_LastMedication = value; }
       }
       private bool _CHB_Visit;

       public bool CHB_Visit
       {
           get { return _CHB_Visit; }
           set { _CHB_Visit = value; }
       }
      
        
        private bool _AnalysisMeun;

        public bool AnalysisMeun
        {
            get { return _AnalysisMeun; }
            set { _AnalysisMeun = value; }
        }

        private bool _CHB_Analysis;

        public bool CHB_Analysis
        {
            get { return _CHB_Analysis; }
            set { _CHB_Analysis = value; }
        }
        private bool _CHB_Radio;

        public bool CHB_Radio
        {
            get { return _CHB_Radio; }
            set { _CHB_Radio = value; }
        }
        
        private bool _InvoiceMeun;

        public bool InvoiceMeun
        {
            get { return _InvoiceMeun; }
            set { _InvoiceMeun = value; }
        }

        private bool _CHB_Invoice;

        public bool CHB_Invoice
        {
            get { return _CHB_Invoice; }
            set { _CHB_Invoice = value; }
        }

        private bool _ToolsMeun;

        public bool ToolsMeun
        {
            get { return _ToolsMeun; }
            set { _ToolsMeun = value; }
        }

        private bool _CHB_CameraWatiching;

        public bool CHB_CameraWatiching
        {
            get { return _CHB_CameraWatiching; }
            set { _CHB_CameraWatiching = value; }
        }
        private bool _CHB_BrowesImage;

        public bool CHB_BrowesImage
        {
            get { return _CHB_BrowesImage; }
            set { _CHB_BrowesImage = value; }
        }

        private bool _CHB_ControlPanel;

        public bool CHB_ControlPanel
        {
            get { return _CHB_ControlPanel; }
            set { _CHB_ControlPanel = value; }
        }
        private bool _CHB_AdminControlPanal;

        public bool CHB_AdminControlPanal
        {
            get { return _CHB_AdminControlPanal; }
            set { _CHB_AdminControlPanal = value; }
        }
        private bool _CHB_UserContolPanel;

        public bool CHB_UserContolPanel
        {
            get { return _CHB_UserContolPanel; }
            set { _CHB_UserContolPanel = value; }
        }
      private bool _CHB_BackUp;

      public bool CHB_BackUp
      {
          get { return _CHB_BackUp; }
          set { _CHB_BackUp = value; }
      }


        private bool _AppointmentMeun;

        public bool AppointmentMeun
        {
            get { return _AppointmentMeun; }
            set { _AppointmentMeun = value; }
        }

        private bool _CHB_Appointment;

        public bool CHB_Appointment
        {
            get { return _CHB_Appointment; }
            set { _CHB_Appointment = value; }
        }

        private bool _PrescriptionMeun;

        public bool PrescriptionMeun
        {
            get { return _PrescriptionMeun; }
            set { _PrescriptionMeun = value; }
        }

        private bool _CHB_Prescription;

        public bool CHB_Prescription
        {
            get { return _CHB_Prescription; }
            set { _CHB_Prescription = value; }
        }

    }
}
