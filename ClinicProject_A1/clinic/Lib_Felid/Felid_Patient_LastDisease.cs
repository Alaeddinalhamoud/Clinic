using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
    public class Felid_Patient_LastDisease
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
        private int _LastDiseaseID;

        public int LastDiseaseID
        {
            get { return _LastDiseaseID; }
            set { _LastDiseaseID = value; }
        }
        private bool _FamilyDisease;

        public bool FamilyDisease
        {
            get { return _FamilyDisease; }
            set { _FamilyDisease = value; }
        }
        private DateTime _DateOfDisease;

        public DateTime DateOfDisease
        {
            get { return _DateOfDisease; }
            set { _DateOfDisease = value; }
        }


    }
}