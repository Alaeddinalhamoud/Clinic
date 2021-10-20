using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace clinic.Classes
{
    public class IsEmailValidations
    {
        private string _inputString;
        public IsEmailValidations(string input)
        {
            _inputString = input;
        }
        public bool IsValidEmail()
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(_inputString, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }




        public string InputString
        {
            get { return _inputString; }
            set { _inputString = value; }
        }
        

    }
}
