using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
 public    class Filed_AnalysisType
    {

        private int _AnalysisTypeID;

        public int AnalysisTypeID
        {
            get { return _AnalysisTypeID; }
            set { _AnalysisTypeID = value; }
        }

        private string _Analysis;

        public string Analysis
        {
            get { return _Analysis; }
            set { _Analysis = value; }
        }

    }
}
