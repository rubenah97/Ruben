using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Oblig1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons Arne = new Persons(0,  "Arne",  "Fredriksen",  1982,  0);
            Persons Jens = new Persons(1, "Jens", "Karlsen", 1992, 0);
            Persons Ida = new Persons(2, "Ida", "Larsen", 2000, 0);
            Persons Ludvig = new Persons(3, "", "Jensen", 0, 0);
            Persons Per = new Persons(4, "Per", "", 0, 1990);
            Persons Louise = new Persons(5, "Louise", "Fredriksen", 1950, 0);
            Persons Carl = new Persons(6, "Carl", "Karlsen", 1948, 0);
            Persons Espen = new Persons(7, "Espen", "Larsen", 1970, 0);
            Persons Ellen = new Persons(8, "Ellen", "Larsen", 1969, 0);
            Persons Ken = new Persons(9, "Ken", "Normann", 1920, 1992);
            Persons Camilla = new Persons(10, "Camilla", "Normann", 1915, 1989);

            Arne.Mother = Louise;
            Ida.Father = Espen;
            Ida.Mother = Ellen;
            Carl.Father = Ken;
            Carl.Mother = Camilla;
            Espen.Sister = Louise;
            Ellen.Brother = Jens;
            Ken.Married = Camilla;
            Camilla.Married = Ken;

            

            int AmountOfPeople = 11;
            IPersonList[] personList = new IPersonList[AmountOfPeople];
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
                    for (int i = 0; i < personList.Length; i++)
                    {
                        personList[i].Id();
                        personList[i].FirstName();
                        personList[i].LastName();
                        Console.WriteLine();
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
                        //typedId = Convert.ToInt32(Console.ReadLine());
                        
                    }while (!success || typedId >= AmountOfPeople && typedId <= 0);

                    Console.WriteLine();
                    personList[typedId].Id();
                    personList[typedId].FirstName();
                    personList[typedId].LastName();
                    personList[typedId].DateOfBirth();
                    personList[typedId].YearOfDeath();
                    personList[typedId].Relatives();
                    Console.WriteLine();

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
