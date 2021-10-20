using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Felid
{
   public class Felid_Invoice
    {
        private int _InVoiceID;

        public int InVoiceID
        {
            get { return _InVoiceID; }
            set { _InVoiceID = value; }
        }
        private int _VisitID;

        public int VisitID
        {
            get { return _VisitID; }
            set { _VisitID = value; }
        }
        //private string _FirstName;

        //public string FirstName
        //{
        //    get { return _FirstName; }
        //    set { _FirstName = value; }
        //}
        private int _PatientID;

        public int PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }
        private int _PaidMoney;

        public int PaidMoney
        {
            get { return _PaidMoney; }
            set { _PaidMoney = value; }
        }
        private int _Reminder;

        public int Reminder
        {
            get { return _Reminder; }
            set { _Reminder = value; }
        }
       private int _Discount;

       public int Discount
       {
           get { return _Discount; }
           set { _Discount = value; }
       }
       private int _Total;

       public int Total
       {
           get { return _Total; }
           set { _Total = value; }
       }
       private DateTime _DateInvoice;

       public DateTime DateInvoice
       {
           get { return _DateInvoice; }
           set { _DateInvoice = value; }
       }
      
           
    }
}
