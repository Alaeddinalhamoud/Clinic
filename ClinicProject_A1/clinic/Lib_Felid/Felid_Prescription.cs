using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
   public class Felid_Prescription
    {

        private int _PrescriptionID;

        public int PrescriptionID
        {
            get { return _PrescriptionID; }
            set { _PrescriptionID = value; }
        }
        private DateTime _DateOfPrescription;

        public DateTime DateOfPrescription
        {
            get { return _DateOfPrescription; }
            set { _DateOfPrescription = value; }
        }
        private int _PatientID;

        public int PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }
        private int _VisitID;

        public int VisitID
        {
            get { return _VisitID; }
            set { _VisitID = value; }
        }
    }
}
