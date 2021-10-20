using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
   public  class Felid_Time
    {
        private int _TimeID;

        public int TimeID
        {
            get { return _TimeID; }
            set { _TimeID = value; }
        }
        private string  _Time;

        public string  Time
        {
            get { return _Time; }
            set { _Time = value; }
        }
    }
}
