using System;
using System.Security.Cryptography.X509Certificates;

namespace Oblig1
{
    public class Persons : IPersonList
    {
        private int _Id;
        private string _FirstName;
        private string _LastName;
        private int _BirthYear;
        private int _YearOfDeath;



        public Persons Father { get; set; }
        public Persons Mother { get; set; }
        public Persons Brother { get; set; }
        public Persons Sister { get; set; }
        public Persons Married { get; set; }


        public Persons(int aId, string aFirstName, string aLastName, int aBirthYear, int aYearOfDeath)
        {
            _Id = aId;
            _FirstName = aFirstName;
            _LastName = aLastName;
            _BirthYear = aBirthYear;
            _YearOfDeath = aYearOfDeath;
        }

        public void Id()
        {
            Console.WriteLine("Id:            " + _Id);
        }

        public void FirstName()
        {
            if (_FirstName == "")
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine("First name:    " + _FirstName);
            }
        }

        public void LastName()
        {
            if (_LastName == "")
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine("Last name:     " + _LastName);
            }
        }

        public void DateOfBirth()
        {
            if (_BirthYear == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine("Date Of birth: " + _BirthYear);
            }
        }

        public void YearOfDeath()
        {
            if (_YearOfDeath == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine("Year of death: " + _YearOfDeath);
            }
        }

        public void Relatives()
        {

            Console.Write("Relatives: ");
            if (Mother == null && Father == null && Sister == null && Brother == null)
            {
                Console.WriteLine("    This person does not have any registered relatives");
            }
            else
            {

                if (Mother == null && Father == null)
                {
                    Console.Write("    This person does not have any registered Parents");
                }
                else
                {
                    if (Mother == null)
                    {
                        Console.Write("    This person Does not have a registered mother");
                    }
                    else
                    {
                        Console.Write("    Mother  - " + Mother._FirstName + " " + Mother._LastName);
                    }
                    if (Father == null)
                    {
                        Console.Write("\n               This person does not have a registered father");
                    }
                    else
                    {
                        Console.Write("\n               Father  - " + Father._FirstName + " " + Father._LastName);
                    }
                }

                if (Sister != null)
                {
                    Console.Write("\n               Sister  - " + Sister._FirstName + " " + Sister._LastName);
                }
               

                if (Brother != null)
                {
                    Console.Write("\n               Brother - " + Brother._FirstName + " " + Brother._LastName);
                }

            }
            if (Married != null)
            {
                Console.Write("               Married with - " + Married._FirstName + " " + Married._LastName);
            }
        }
    }
}  