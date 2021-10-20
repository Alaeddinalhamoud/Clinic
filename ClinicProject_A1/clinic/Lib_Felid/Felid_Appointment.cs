using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
   public  class Felid_Appointment
    {


        private int _AppointmentID;

        public int AppointmentID
        {
            get { return _AppointmentID; }
            set { _AppointmentID = value; }
        }
        private string _PatientName;

        public string PatientName
        {
            get { return _PatientName; }
            set { _PatientName = value; }
        }
        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        private string _Time;

        public string Time
        {
            get { return _Time; }
            set { _Time = value; }
        }
        private int _VisitTypeID;

        public int VisitTypeID
        {
            get { return _VisitTypeID; }
            set { _VisitTypeID = value; }
        }
        private string _Note;

        public string Note
        {
            get { return _Note; }
            set { _Note = value; }
        }




    }
}
