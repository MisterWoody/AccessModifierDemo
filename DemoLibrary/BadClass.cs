using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BadClass
    {
        public string creditCardNumber; // Never do this!


        // propfull allows protection and encapsulation of a classes properties.
        // Do not declare _ssn as public though - as this is back to full visibility

        private string _ssn;

        public string SSN
        {
            get { 
                return "***-**-1234"; 
            }
            set { _ssn = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set 
            { 
                if (value >= 0 && value < 130) // Some validation on the age rather than blindly setting the property and potentially introducing bugs
                {
                    _age = value;

                }
            }
        }


    }
}
