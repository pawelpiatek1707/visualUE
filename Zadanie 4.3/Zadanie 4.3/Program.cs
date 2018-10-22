using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program obliczjacy reszte z dzielenia dwoch liczb");
            Console.WriteLine();
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            int b = int.Parse(Console.ReadLine());
            int wynik = a % b;
            Console.WriteLine("Reszta z dzielenia: " + wynik);
            Console.ReadKey();
        }
    }
}
