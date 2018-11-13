using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Ala Ela Karol Marek Tadeusz";
            Console.WriteLine(tekst);
            string tekst2 = tekst.Replace(" ", ", ");
            Console.WriteLine(tekst2);
            Console.ReadKey();

        }
    }
}
