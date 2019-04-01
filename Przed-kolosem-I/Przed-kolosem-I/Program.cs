using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przed_kolosem_I
{
    static class Test
    {
        private static string test = "aaaa";
        public static string Wlasciwosc
        {
            get { return test; }
            set { test = value; }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(1998,07,17);//datetime object -> three int values representing year, month, day (hours are optional)
            Console.WriteLine(d1.Year);
            ConsoleColor kolor = ConsoleColor.Blue;
            Console.ForegroundColor = kolor;//color square
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0;  j< 10; j++)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
            Test.Wlasciwosc = "zmieniaona wlasciwosc";
            Console.WriteLine(Test.Wlasciwosc);
            Console.ReadKey();
        }
    }
}
