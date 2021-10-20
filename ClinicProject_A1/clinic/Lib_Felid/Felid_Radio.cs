using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
   public  class Felid_Radio
    {
        private int _RadioID;

        public int RadioID
        {
            get { return _RadioID; }
            set { _RadioID = value; }
        }
        private int _RadioTypeID;

        public int RadioTypeID
        {
            get { return _RadioTypeID; }
            set { _RadioTypeID = value; }
        }
        private string _RadioSubject;

        public string RadioSubject
        {
            get { return _RadioSubject; }
            set { _RadioSubject = value; }
        }
        private string _RadioResult;

        public string RadioResult
        {
            get { return _RadioResult; }
            set { _RadioResult = value; }
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
       private string _ImagePath;

       public string ImagePath
       {
           get { return _ImagePath; }
           set { _ImagePath = value; }
       }


    }
}
