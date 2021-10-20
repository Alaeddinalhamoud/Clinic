using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
    public class Felid_Patient_Disease
    {

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
