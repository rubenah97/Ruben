using System;
using System.Security.Cryptography.X509Certificates;

namespace Oblig1
{
    public class Person
    {
        private int _Id;
        private string _FirstName;
        private string _LastName;
        private int? _BirthYear;
        private int? _YearOfDeath;



        public Person Father { get; set; }
        public Person Mother { get; set; }
        public Person Brother { get; set; }
        public Person Sister { get; set; }
        public Person Married { get; set; }


        public Person(int aId, string aFirstName = null, string aLastName = null, int? aBirthYear = null, int? aYearOfDeath = null)
        {
            _Id = aId;
            _FirstName = aFirstName;
            _LastName = aLastName;
            _BirthYear = aBirthYear;
            _YearOfDeath = aYearOfDeath;
        }



        public void Show()
        {
            Console.WriteLine("Id:            " + _Id);
            if (_FirstName != null)
            {
                Console.WriteLine("First name:    " + _FirstName);
            }
            if (_LastName != null)
            {
                Console.WriteLine("Last name:     " + _LastName);
            }
            if (_BirthYear != null)
            {
                Console.WriteLine("Date Of birth: " + _BirthYear);
            }
            if (_YearOfDeath != null)
            {
                Console.WriteLine("Year of death: " + _YearOfDeath);
            }
           
            if (Married != null)
            {
                Console.Write("Married with - " + Married._FirstName + " " + Married._LastName);
            }

            Console.WriteLine();
        }


        public void ShowInList()
        {
            Console.WriteLine("Id:            " + _Id);
            if (_FirstName != null)
            {
                Console.WriteLine("First name:    " + _FirstName);
            }
            if (_LastName != null)
            {
                Console.WriteLine("Last name:     " + _LastName);
            }

            Console.WriteLine();
        }
    }
}  