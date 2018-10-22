using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._3
{
    class Program
    {
        static void secondMethod(int years)
        {
            int year = 1;
            for(int i = 2; i<=years; i++)
            {
                year *= 2;
            }
            Console.WriteLine("Oszczednosci po wybraniu drugiego sposobu: " + year);
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program bankowy");
            Console.WriteLine("Pierwsza metoda oszczędzania: ");
            Console.WriteLine("Każdego roku odkladasz 1000 zl ");
            Console.WriteLine("Druga metoda oszczędzania: ");
            Console.WriteLine("Rzopoczynasz oszczedzanie od 1zl i kazdego roku odkladasz podwojona ilosc swoich oszczednoosci");
            Console.WriteLine("Podaj na ile lat chcesz otworzyc lokate: ");
            int years = int.Parse(Console.ReadLine());
            int first = years * 1000;
            Console.Clear();
            Console.WriteLine("Oszczednosci po wybraniu pierwszego sposobu: " +first);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            secondMethod(years);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            if (years >= 15)
            {
                Console.WriteLine("Bardzie opłaca sie oszczedzac drugim sposobem jednak bedzie on zabojczy dla oszczesdzajacego, poniewaz 15 roku bedzie musial on odlozycz ponad 16 tys"); ;
            }
            else
            {
                Console.WriteLine("Bardziej oplaca sie oszczedzac pierwszym sposobem ");
            }
            Console.ReadKey();
        }
    }
}
