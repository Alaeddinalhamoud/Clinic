using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
     public class Felid_Anlaysis
    {
        private int _AnalysisID;

        public int AnalysisID
        {
            get { return _AnalysisID; }
            set { _AnalysisID = value; }
        }
        private int _AnalysisTypeID;

        public int AnalysisTypeID
        {
            get { return _AnalysisTypeID; }
            set { _AnalysisTypeID = value; }
        }
        private string _AnalysisSubject;

        public string AnalysisSubject
        {
            get { return _AnalysisSubject; }
            set { _AnalysisSubject = value; }
        }
        private string _AnalysisResult;

        public string AnalysisResult
        {
            get { return _AnalysisResult; }
            set { _AnalysisResult = value; }
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

    }
}
