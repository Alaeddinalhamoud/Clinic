using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
   public class Felid_RadioType
    {
        private int _RadioTypeID;

        public int RadioTypeID
        {
            get { return _RadioTypeID; }
            set { _RadioTypeID = value; }
        }

        private string _RadioType;

        public string RadioType
        {
            get { return _RadioType; }
            set { _RadioType = value; }
        }
    }
}
