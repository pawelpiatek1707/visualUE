using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ogarnac wyjatki 
namespace kalkulator
{
    class Program
    {
        static void sum(float a, float b,  string choice)
        {
            if (choice == "+")
            {
                Console.WriteLine("Wynik dodawania: " + (a+b));
            }
            else if(choice == "-")
            {
                Console.WriteLine("Wynik odejmowania: " + (a - b));
            }
            else if (choice == "*")
            {
                Console.WriteLine("Wynik mnożenia: " + (a * b));
            }
            else if (choice == "/")
            {   
                if(b==0)
                    {
                    Console.WriteLine("Nie mozna dzielic przez 0 ");
                    
                    }
                else
                Console.WriteLine("Wynik dzielenia: " + (a / b));
            }
           

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkuator");
            Console.WriteLine("---------");
            Console.WriteLine("Podaj pierwsza liczbe: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            float b = float.Parse(Console.ReadLine());
            string choice;
            do
            {
                Console.WriteLine("podaj symbol dzialania: ");
                 choice = Console.ReadLine();
            } while (choice != "+" && choice != "-" && choice != "*" && choice != "/");
            sum(a, b, choice);
            Console.ReadKey();
        }
        
    }
}
