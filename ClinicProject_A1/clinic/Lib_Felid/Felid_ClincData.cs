using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
    public class Felid_ClincData
    {
        private int _DrID;

        public int DrID
        {
            get { return _DrID; }
            set { _DrID = value; }
        }
        private string _DrName;

        public string DrName
        {
            get { return _DrName; }
            set { _DrName = value; }
        }
        private string _Speciaty;

        public string Speciaty
        {
            get { return _Speciaty; }
            set { _Speciaty = value; }
        }
        private string _Phone;

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        private string _Mobile;

        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }
        private string _Fax;

        public string Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _WebSiteAddress;

        public string WebSiteAddress
        {
            get { return _WebSiteAddress; }
            set { _WebSiteAddress = value; }
        }
        private string _Image;

        public string Image
        {
            get { return _Image; }
            set { _Image = value; }
        }
        private string _City;

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
    }
}
