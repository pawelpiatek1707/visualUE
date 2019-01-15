using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przed_II_Kolosem
{
    class Person
    {
        private string name;
        private string lastName;
        private string birthDate;

        public void  ShowData()
        {
            Console.WriteLine("Imię: "+name+", nazwisko: "+lastName+", data urodzenia"+birthDate);
        }
        public void NewData()
        {
            Console.Write("Podaj jaką zawartośc chcesz zmienić: ");
            string change = Console.ReadLine();
            switch (change)
            {
                case "imie":
                    {
                        Console.Write("Podaj nowe imię: ");
                        string newName = Console.ReadLine();
                        name = newName;
                        break;
                    }
                case "imię":
                    {

                        goto case "imie";
                    }
                case "nazwisko":
                    {
                        Console.Write("Podaj nowe nazwisko: ");
                        string newLastName = Console.ReadLine();
                        lastName = newLastName;
                        break;
                    }
                case "data urodzenia":
                    {
                        Console.Write("Podaj nową datę urodzenia (dd-mm-rrrr): ");
                        string newBirth = Console.ReadLine();
                        birthDate = newBirth;
                        break;
                    }
            }

        }
        public void BirthMethod()
        {
            string shortDate = birthDate.Substring(6,4);
            int year = int.Parse(shortDate);
            Console.WriteLine("Rok urodzenia osoby: "+year);
            if(year>2000)
            {
                Console.WriteLine("Osoba nie jest pełnoletnia");
            }
            else
            {
                Console.WriteLine("Osoba jest pełnoletnia");
            }
        }
        public Person(string a,string b,string c)
        {
            name = a;
            lastName = b;
            birthDate = c;
        }
    }
}
