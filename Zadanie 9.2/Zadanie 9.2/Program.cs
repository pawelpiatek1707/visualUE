using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciag znakow: ");
            string ciag = Console.ReadLine();
            string ciag1 = ciag.ToUpper();
            Console.WriteLine("Ciag znakow po zamianie: ");
            for(int i = ciag1.Length-1; i >= 0; i--)
            {
                Console.Write(ciag1[i]);
            }
            Console.ReadKey();
        }
    }
}
