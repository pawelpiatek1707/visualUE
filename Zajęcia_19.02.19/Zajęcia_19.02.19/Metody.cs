using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_19._02._19
{
    static class Metody
    {
        public static double [] Zwracaj(double [] Arr)
        {
            return (Arr);
        }

        public static void Wyswietl(double [] Arr, int numerWierzcholka)
        {
            Console.WriteLine("Współrzędne Wierzchołka "+numerWierzcholka);
            Console.WriteLine("------------------------");
            foreach(var x in Arr)
            {
                Console.Write( x+ ", ");
            }
        }
        
    }
}
