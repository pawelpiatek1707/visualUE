using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdzający czy podany rok jest rokiem przestępnym");
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("Podaj rok: ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0) && (year % 400 == 0))
            {
                Console.WriteLine("Jest rokiem przetępnym");
            }
            else
                Console.WriteLine("Nie jjest rokiem przetępnym");
            Console.ReadKey();
        }
       
    }
}
