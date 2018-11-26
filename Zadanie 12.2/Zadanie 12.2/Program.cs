using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12._2
{
    class Program
    {
        static float degrees(out float celc)
        {
            celc = 30;
            float fahr = 32 + 9 / 5 * celc;

            return fahr;
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj temerature w stopiach celsjisza: ");
            float celc = float.Parse(Console.ReadLine());
            Console.WriteLine( "Temperatura w farenheitah: "+degrees(out celc) ); 
            Console.ReadKey();
        }
    }
}
