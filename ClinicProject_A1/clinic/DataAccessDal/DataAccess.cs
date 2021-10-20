using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Inter_Felid;
using System.Reflection;

namespace DataAccessDal
{
    public class DataAccess
    {
        private static readonly string path = ConfigurationManager.AppSettings["dbProviderDAL"];
        private DataAccess()
        {
        }
        public static Inter_Felid_Patient CreatePatientTB()
        {
            string ClassName = path + ".SP_Patient";
            return (Inter_Felid_Patient)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Visit CreateVisit()
        {
            string ClassName = path + ".SP_Visit";
            return (Inter_Felid_Visit)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_VisitType CreateVisitTypeTB()
        {
            string ClassName = path + ".SP_VisitType";
            return (Inter_Felid_VisitType)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_SocialState CreateSocialStateTB()
        {
            string ClassName = path + ".SP_SocialState";
            return (Inter_Felid_SocialState)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Sex CreateSexTB()
        {
            string ClassName = path + ".SP_Sex";
            return (Inter_Felid_Sex)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_RadioType CreateRadioTypeTB()
        {
            string ClassName = path + ".SP_RadioType";
            return (Inter_Felid_RadioType)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Radio CreateRadioTB()
        {
            string ClassName = path + ".SP_Radio";
            return (Inter_Felid_Radio)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Prescription_Medications CreatePrescription_Medication()
        {
            string ClassName = path + ".SP_Prescription_Medications";
            return (Inter_Felid_Prescription_Medications)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Prescription CreatePrescriptionTB()
        {
            string ClassName = path + ".SP_Prescription";
            return (Inter_Felid_Prescription)Assembly.Load(path).CreateInstance(ClassName);
 
        }
        public static Inter_Felid_Patient_LastMedication CreatePatient_LastMedication()
        {
            string ClassName = path + ".SP_Patient_LastMedication";
            return (Inter_Felid_Patient_LastMedication)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Patient_LastDisease CreatePatient_LastDisease()
        {
            string ClassName = path + ".SP_Patient_LastDisease";
            return (Inter_Felid_Patient_LastDisease)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_OperationType CreateOperationTypeTB()
        {
            string ClassName = path + ".SP_OperationType";
            return (Inter_Felid_OperationType)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Operation CreateOperationTB()
        {
            string ClassName = path + ".SP_Operation";
            return (Inter_Felid_Operation)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Medications CreatMedications()
        {
            string ClassName = path + ".SP_Medications";
            return (Inter_Felid_Medications)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Invoice CreateInvoiceTB()
        {
            string ClassName = path + ".SP_Invoice";
            return (Inter_Felid_Invoice)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Disease CreateDiseaseTB()
        {
            string ClassName = path + ".SP_Disease";
            return (Inter_Felid_Disease)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_ClinicData CreateClinicData()
        {
            string ClassName = path + ".SP_ClincData";
            return (Inter_Felid_ClinicData)Assembly.Load(path).CreateInstance(ClassName);

        }
        public static Inter_Felid_Blood CreateBloodTB()
        {
            string ClassName = path + ".SP_Blood";
            return (Inter_Felid_Blood)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Appointment CreateAppointmentTB()
        {
            string ClassName = path + ".SP_Appointment";
            return (Inter_Felid_Appointment )Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_AnlaysisType CreateAnalysisTypeTB()
        {
            string ClassName = path + ".SP_AnalysisType";
            return (Inter_Felid_AnlaysisType)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Anlaysis CreateAnalysisTB()
        {
            string ClassName = path + ".SP_Anlaysis";
            return (Inter_Felid_Anlaysis)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_TakeBakeup CreateBackUP()
        {
            string ClassName = path + ".SP_Backup";
            return (Inter_TakeBakeup)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Disase_Visit CreateDisaseVisit()
        {
            string ClassName = path + ".SP_DisaseVisit";
            return (Inter_Felid_Disase_Visit)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_User CreateUser()
        {
            string ClassName = path + ".SP_User";
            return (Inter_Felid_User)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Permission CreatePermission()
        {
            string ClassName = path + ".SP_Permission";
           
            return (Inter_Felid_Permission)Assembly.Load(path).CreateInstance(ClassName);
        }

        public static Inter_Felid_Time CreateTime()
        {
            string ClassName = path + ".SP_Time";

            return (Inter_Felid_Time)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Stamp CreateStamp()
        {
            string ClassName = path + ".SP_Stamp";
            return (Inter_Felid_Stamp)Assembly.Load(path).CreateInstance(ClassName);

        }
        public static Inter_Felid_Accident CreateAccident()
        {
            string ClassName = path + ".SP_Accident";
            return (Inter_Felid_Accident)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Visit_Stamp CreateVisitStamp()
        {
            string ClassName = path + ".SP_Visit_Stamp";
            return (Inter_Felid_Visit_Stamp)Assembly.Load(path).CreateInstance(ClassName);
        }
        public static Inter_Felid_Visit_Accident CreateVisitAccident()
        {
            string ClassName = path + ".SP_Visit_Accident";
            return (Inter_Felid_Visit_Accident)Assembly.Load(path).CreateInstance(ClassName);
        }
    }
}
