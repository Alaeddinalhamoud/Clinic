using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
   public class Felid_SocialState
    {
        private int _SocialStateID;

        public int SocialStateID
        {
            get { return _SocialStateID; }
            set { _SocialStateID = value; }
        }
        private string _SocialState;

        public string SocialState
        {
            get { return _SocialState; }
            set { _SocialState = value; }
        }

    }
}
