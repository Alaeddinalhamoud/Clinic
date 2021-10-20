using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
    public class Felid_Stamp
    {
        private int _StampID;

        public int StampID
        {
            get { return _StampID; }
            set { _StampID = value; }
        }
        private string _StampName;

        public string StampName
        {
            get { return _StampName; }
            set { _StampName = value; }
        }


    }
}
