using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
   public  class Felid_Prescription_Medications
    {
        private int _PrescriptionID;

        public int PrescriptionID
        {
            get { return _PrescriptionID; }
            set { _PrescriptionID = value; }
        }
        private int _MedicationID;

        public int MedicationID
        {
            get { return _MedicationID; }
            set { _MedicationID = value; }
        }
        private int _Dose;

        public int Dose
        {
            get { return _Dose; }
            set { _Dose = value; }
        }
        private int _MedicalCount;

        public int MedicalCount
        {
            get { return _MedicalCount; }
            set { _MedicalCount = value; }
        }


        private string _Cleander_Of_Dose;

        public string Cleander_Of_Dose
        {
            get { return _Cleander_Of_Dose; }
            set { _Cleander_Of_Dose = value; }
        }

        private string _Type_Of_Medication;

        public string Type_Of_Medication
        {
            get { return _Type_Of_Medication; }
            set { _Type_Of_Medication = value; }
        }
        private string _Time_Of_Dose;

        public string Time_Of_Dose
        {
            get { return _Time_Of_Dose; }
            set { _Time_Of_Dose = value; }
        }
       
       private string _Note;

   
       public string Note
       {
           get { return _Note; }
           set { _Note = value; }
       }

   }
}
