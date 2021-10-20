using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
    public class Felid_Disase_Visit
    {
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
        private int _DiseaseID;

        public int DiseaseID
        {
            get { return _DiseaseID; }
            set { _DiseaseID = value; }
        }
    }
}
