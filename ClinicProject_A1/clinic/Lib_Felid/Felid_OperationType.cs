using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
   public class Felid_OperationType
    {
        private int _OperationTypeID;

        public int OperationTypeID
        {
            get { return _OperationTypeID; }
            set { _OperationTypeID = value; }
        }
        private string _OperationType;

        public string OperationType
        {
            get { return _OperationType; }
            set { _OperationType = value; }
        }
    }
}
