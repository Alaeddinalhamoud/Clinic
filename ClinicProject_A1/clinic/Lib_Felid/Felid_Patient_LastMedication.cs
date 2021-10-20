using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
    public class Felid_Patient_LastMedication
    {
        private int _PatientID;

        public int PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }
        private int _MedicationID;

        public int MedicationID
        {
            get { return _MedicationID; }
            set { _MedicationID = value; }
        }
        private int _LastMedicationID;

        public int LastMedicationID
        {
            get { return _LastMedicationID; }
            set { _LastMedicationID = value; }
        }
        private DateTime _DateOfMedication;

        public DateTime DateOfMedication
        {
            get { return _DateOfMedication; }
            set { _DateOfMedication = value; }
        }
    }
}
