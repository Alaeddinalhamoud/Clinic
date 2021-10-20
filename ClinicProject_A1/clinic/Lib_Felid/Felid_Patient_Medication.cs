using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
    public class Felid_Patient_Medication
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
    }
}
