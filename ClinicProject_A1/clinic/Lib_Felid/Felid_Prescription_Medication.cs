using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
   public  class Felid_Prescription_Medication
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

    }
}
