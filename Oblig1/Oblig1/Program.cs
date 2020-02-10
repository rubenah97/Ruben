using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Oblig1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Arne = new Person(0,  "Arne",  "Fredriksen", 1982, null);
            var Jens = new Person(1, "Jens", "Karlsen", 1992, null);
            var Ida = new Person(2, "Ida", "Larsen", 2000, null);
            var Ludvig = new Person(3, null, "Jensen", null, null);
            var Per = new Person(4, "Per", null, null, 1990);
            var Louise = new Person(5, "Louise", "Fredriksen", 1950, null);
            var Carl = new Person(6, "Carl", "Karlsen", 1948, null);
            var Espen = new Person(7, "Espen", "Larsen", 1970, null);
            var Ellen = new Person(8, "Ellen", "Larsen", 1969, null);
            var Ken = new Person(9, "Ken", "Normann", 1920, 1992);
            var Camilla = new Person(10, "Camilla", "Normann", 1915, 1989);
            var Sigurd = new Person(11, "Sigurd", "Normann", 1950, null);
            var Kevin = new Person(12, "Kevin", "Fredriksen", 1940, null);
            

            Arne.Mother = Louise;

            Ida.Father = Espen;
            Ida.Mother = Ellen;

            Carl.Father = Ken;
            Carl.Mother = Camilla;

            Ken.Married = Camilla;
            Camilla.Married = Ken;

            Sigurd.Father = Ken;
            Sigurd.Mother = Camilla;

            Louise.Father = Kevin;
            Arne.Father = Kevin;


            

            int AmountOfPeople = 12;
            Person[] personList = new Person[AmountOfPeople];
            personList[0] = Arne;
            personList[1] = Jens;
            personList[2] = Ida;
            personList[3] = Ludvig;
            personList[4] = Per;
            personList[5] = Louise;
            personList[6] = Carl;
            personList[7] = Espen;
            personList[8] = Ellen;
            personList[9] = Ken;
            personList[10] = Camilla;
            personList[11] = Sigurd;
            var chosenPath = "";
            do
            {
                Console.WriteLine("Type in one of the commands");
                Console.WriteLine();
                Console.WriteLine("Help");
                Console.WriteLine("List");
                Console.WriteLine("Id");
                Console.WriteLine("Exit");
                Console.WriteLine();

                chosenPath = Console.ReadLine();
                Console.WriteLine();

                if (chosenPath == "Help" || chosenPath == "help")
                {
                    Console.WriteLine("Help  : Explains all the commands");
                    Console.WriteLine("List  : Shows a List of all the registered people");
                    Console.WriteLine("Id    : shows more detailed information for one specified person");
                    Console.WriteLine("Exit  : Exits the app");
                }

                else if (chosenPath == "List" || chosenPath == "list")
                {
                    foreach (var p in personList)
                    {
                        p.ShowInList();
                    }
                }

                else if (chosenPath == "Id" || chosenPath == "id")
                {
                    int typedId;
                    bool success;
                    
                    do
                    {
                        Console.Write("Type in id from 0-" + (AmountOfPeople-1) + ": ");
                        success = int.TryParse(Console.ReadLine(), out typedId);
                        Console.WriteLine();
                        if (typedId < 0 || typedId > AmountOfPeople-1
                            )
                        {
                            success = false;
                        }
                        
                    }while (!success || typedId >= AmountOfPeople && typedId <= 0);

                    var person = personList[typedId];
                    person.Show();
                    Console.WriteLine();
                    Console.WriteLine("Children : ");
                    Console.WriteLine();
                    foreach (var p in personList)
                    {
                        if (p.Father == person || p.Mother == person)
                            p.ShowInList();
                       
                    }

                    Console.WriteLine();
                    Console.WriteLine("Siblings: ");
                    Console.WriteLine();
                    foreach (var p in personList)
                    {
                        if (p != person &&
                            (p.Father == person.Father && person.Father != null|| p.Mother == person.Mother && person.Father != null))
                        {
                            p.ShowInList();
                        }
                    }

                }
                else
                {
                    if (chosenPath != "Exit" && chosenPath != "exit" && chosenPath != "")
                    {
                        Console.WriteLine("The command you wrote is not a valid command");
                    }
                }

                Console.WriteLine();

            } while (chosenPath != "Exit" && chosenPath != "exit" && chosenPath != "");
        }
    }
}
