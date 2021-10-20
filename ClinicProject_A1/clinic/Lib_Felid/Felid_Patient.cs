using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lib_Felid.Patient
{
    public class Felid_Patient
    {
        private int _PatientID;

        public int PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }
        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        private string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        
        private DateTime _DataOfRegister;

        public DateTime DataOfRegister
        {
            get { return _DataOfRegister; }
            set { _DataOfRegister = value; }
        }

        private DateTime _DataOFBirth;

        public DateTime DataOFBirth
        {
            get { return _DataOFBirth; }
            set { _DataOFBirth = value; }
        }
        private int _SexID;

        public int SexID
        {
            get { return _SexID; }
            set { _SexID = value; }
        }
        private int _BloodID;

        public int BloodID
        {
            get { return _BloodID; }
            set { _BloodID = value; }
        }
        private int _SocialStateID;

        public int SocialStateID
        {
            get { return _SocialStateID; }
            set { _SocialStateID = value; }
        }
        private int _ChidNo;

        public int ChidNo
        {
            get { return _ChidNo; }
            set { _ChidNo = value; }
        }
        private string _Job;

        public string Job
        {
            get { return _Job; }
            set { _Job = value; }
        }
        private string _AddressHome;

        public string AddressHome
        {
            get { return _AddressHome; }
            set { _AddressHome = value; }
        }
        private string _AddressWork;

        public string AddressWork
        {
            get { return _AddressWork; }
            set { _AddressWork = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _Tel;

        public string Tel
        {
            get { return _Tel; }
            set { _Tel = value; }
        }
        private string _Mobile;

        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }
        private string _TelWork;

        public string TelWork
        {
            get { return _TelWork; }
            set { _TelWork = value; }
        }
        private bool _Smoke;

        public bool Smoke
        {
            get { return _Smoke; }
            set { _Smoke = value; }
        }
        private bool _Win;

        public bool Win
        {
            get { return _Win; }
            set { _Win = value; }
        }
        
        private string _Sensitive;

        public string Sensitive
        {
            get { return _Sensitive; }
            set { _Sensitive = value; }
        }
        private string _Note;

        public string Note
        {
            get { return _Note; }
            set { _Note = value; }
        }

        private string _ImagePath;

        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

    }
}
