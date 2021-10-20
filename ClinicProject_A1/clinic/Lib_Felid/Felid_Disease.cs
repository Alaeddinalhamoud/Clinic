using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
    public class Felid_Disease
    {
        private int _DiseaseID;

        public int DiseaseID
        {
            get { return _DiseaseID; }
            set { _DiseaseID = value; }
        }
        private string _DiseaseName;

        public string DiseaseName
        {
            get { return _DiseaseName; }
            set { _DiseaseName = value; }
        }
    }
}
