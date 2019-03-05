using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_17._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj stopien macierzy kwadratowej: ");
            int n = int.Parse(Console.ReadLine());
            Macierz macierz1 = new Macierz(n);
            Macierz macierz2 = new Macierz(n);
            Random randA = new Random();
            macierz1.Uzupelnij( randA);
            macierz2.Uzupelnij( randA);
            Console.WriteLine("Pierwsza macierz");
            Console.WriteLine("----------------");
            macierz1.Pokaz();
            Console.WriteLine();
            Console.WriteLine("Druga macierz");
            Console.WriteLine("--------------");
            macierz1.Pokaz();
            Console.WriteLine();
            Operacje.Dodaj(macierz1.macierzA, macierz2.macierzA);
            Console.WriteLine();
            Operacje.Odejmowanie(macierz1.macierzA, macierz2.macierzA);
            Console.WriteLine();
            Operacje.Mnozenie(macierz1.macierzA, macierz2.macierzA);
            Console.ReadLine();
            
        }
    }
}
