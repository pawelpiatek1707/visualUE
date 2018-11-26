using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12._3
{
    class Program
    {
        static void Power()
        {
            Console.WriteLine("Podaj początkowe zużycie licznika: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bieżące zużycie licznika: ");
            float b = float.Parse(Console.ReadLine());
            float c = (b - a) * 30f;
            Console.WriteLine("Zużyci energii: "+c);
        }
        static void Power1(out float a, out float b)
        {
            a = 345;
            b = 543;
            Console.WriteLine("Podaj początkowe zużycie licznika: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bieżące zużycie licznika: ");
             b = float.Parse(Console.ReadLine());
            float c = (b - a) * 30f;
            Console.WriteLine("Zużyci energii: " + c);
        }
        static void Main(string[] args)
        {
            float a, b;
            Power();
            Console.WriteLine();
            Power1(out a, out b);
            Console.ReadKey();
        }
    }
}
