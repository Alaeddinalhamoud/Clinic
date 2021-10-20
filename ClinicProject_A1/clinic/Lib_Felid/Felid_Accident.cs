using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
    public class Felid_Accident
    {
        private int _AccidentID;

        public int AccidentID
        {
            get { return _AccidentID; }
            set { _AccidentID = value; }
        }
        private string _AccidentName;

        public string AccidentName
        {
            get { return _AccidentName; }
            set { _AccidentName = value; }
        }
    }
}
