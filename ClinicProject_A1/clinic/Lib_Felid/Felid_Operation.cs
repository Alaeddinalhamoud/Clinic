using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
    public class Felid_Operation
    {
        private int _OperationID;

        public int OperationID
        {
            get { return _OperationID; }
            set { _OperationID = value; }
        }
        private DateTime _DateOfOperation;

        public DateTime DateOfOperation
        {
            get { return _DateOfOperation; }
            set { _DateOfOperation = value; }
        }
        private int _PatientID;

        public int PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }
        private int _OperationTypeID;

        public int OperationTypeID
        {
            get { return _OperationTypeID; }
            set { _OperationTypeID = value; }
        }
        private string _Note;

        public string Note
        {
            get { return _Note; }
            set { _Note = value; }
        }


    }
}
