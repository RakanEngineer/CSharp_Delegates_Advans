using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Delegates_Advans
{
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }

        public Person(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        //public byte GetAge()
        //{
        //    string datePart = SocialSecurityNumber.Substring(0, 6);

        //    DateTime birthDate = DateTime.ParseExact(datePart, "yyMMdd", System.Globalization.CultureInfo.InvariantCulture);

        //    TimeSpan timeSpan = DateTime.Today - birthDate;

        //    byte years = (byte)(timeSpan.Days / 365);

        //    return years;
        //}
        public byte Age
        {
            get
            {
                string datePart = SocialSecurityNumber.Substring(0, 6);

                DateTime birthDate = DateTime.ParseExact(datePart, "yyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                TimeSpan timeSpan = DateTime.Today - birthDate;

                byte years = (byte)(timeSpan.Days / 365);

                return years;
            }

        }
        //public bool IsFemale()
        //{
        //    var genderNumber = int.Parse(SocialSecurityNumber.Substring(9, 1));

        //    return genderNumber % 2 == 0;
        //}
        public bool IsFemale
        {
            get
            {
                var genderNumber = int.Parse(SocialSecurityNumber.Substring(9, 1));

                return genderNumber % 2 == 0;
            }
        }
    }
}