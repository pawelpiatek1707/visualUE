using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string napis1 = "ala ma kota";
            string napis2 = "ALA MA KOTA";
            Console.WriteLine("1. Porównanie dwóch nnapisów z uwzględnieniem wielkosc liter");
            if(napis1 == napis2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine("-----------------------");
            string napis3 = napis1.ToUpper();
            string napis4 = napis2.ToUpper();
            Console.WriteLine("2. Porównanie dwóch nnapisów bez uwzglednienia wielkosci liter");
            if (napis3 == napis4)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("3: Złączenie napisów: ");
            string napis5 = String.Concat(napis1, napis2);
            Console.WriteLine(napis5);
            Console.WriteLine("----------------------");
            Console.WriteLine("Dluosc elementu: "+napis1.Length);
            Console.WriteLine("----------------------");
            Console.WriteLine("Znak znajdujacy sie na 3 miejscu w napisie");
            //substring
            Console.ReadKey();
            //skonczyc
        }
    }
}
