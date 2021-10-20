using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
   public  class Felid_Visit
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
        private DateTime _DataOfVisit;

        public DateTime DataOfVisit
        {
            get { return _DataOfVisit; }
            set { _DataOfVisit = value; }
        }
        private int _VisitTypeID;

        public int VisitTypeID
        {
            get { return _VisitTypeID; }
            set { _VisitTypeID = value; }
        }
       
        private double _Weight;

        public double Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }
        private double _BloodPressure;

        public double BloodPressure
        {
            get { return _BloodPressure; }
            set { _BloodPressure = value; }
        }
        private int _PulseHeart;

        public int PulseHeart
        {
            get { return _PulseHeart; }
            set { _PulseHeart = value; }
        }
        private double _Temperature;

        public double Temperature
        {
            get { return _Temperature; }
            set { _Temperature = value; }
        }
        private string _PhysicalExamination;

        public string PhysicalExamination
        {
            get { return _PhysicalExamination; }
            set { _PhysicalExamination = value; }
        }

       

        private string _Note;

        public string Note
        {
            get { return _Note; }
            set { _Note = value; }
        }

    }
}
