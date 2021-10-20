using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
    public class Felid_Visit_Stamp
    {
        private int _StampID;

        public int StampID
        {
            get { return _StampID; }
            set { _StampID = value; }
        }
        private int _VisitID;

        public int VisitID
        {
            get { return _VisitID; }
            set { _VisitID = value; }
        }
        private int _PatientID;

        public int PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }

    }
}
