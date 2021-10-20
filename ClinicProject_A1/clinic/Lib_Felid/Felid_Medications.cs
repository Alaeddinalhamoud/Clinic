using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
    public class Felid_Medications
    {
        private int _MedicationID;

        public int MedicationID
        {
            get { return _MedicationID; }
            set { _MedicationID = value; }
        }
        private string _MedicationName;

        public string MedicationName
        {
            get { return _MedicationName; }
            set { _MedicationName = value; }
        }




        private string _Company;

        public string Company
        {
            get { return _Company; }
            set { _Company = value; }
        }
        private string _GroupOfRemedial;

        public string GroupOfRemedial
        {
            get { return _GroupOfRemedial; }
            set { _GroupOfRemedial = value; }
        }
        private string _Classification;

        public string Classification
        {
            get { return _Classification; }
            set { _Classification = value; }
        }
        private int _Page;

        public int Page
        {
            get { return _Page; }
            set { _Page = value; }
        }
        private string _MedicalOfConsultation;

        public string MedicalOfConsultation
        {
            get { return _MedicalOfConsultation; }
            set { _MedicalOfConsultation = value; }
        }
        private string _AntiOfMedical_Consultation;

        public string AntiOfMedical_Consultation
        {
            get { return _AntiOfMedical_Consultation; }
            set { _AntiOfMedical_Consultation = value; }
        }
        private string _Warning;

        public string Warning
        {
            get { return _Warning; }
            set { _Warning = value; }
        }
        private string _OverlapOfMedication;

        public string OverlapOfMedication
        {
            get { return _OverlapOfMedication; }
            set { _OverlapOfMedication = value; }
        }
        private string _SideOfEffect;

        public string SideOfEffect
        {
            get { return _SideOfEffect; }
            set { _SideOfEffect = value; }
        }



    }
}
