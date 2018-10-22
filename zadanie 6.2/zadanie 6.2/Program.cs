using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wprowadz ilosc iteracji: ");
            int it = int.Parse(Console.ReadLine());
            Console.WriteLine("Iteracje petla do while: ");
            int i = 0;
            do
            {
                Console.WriteLine(++i);
            } while (i <= it);
            Console.WriteLine();
            Console.WriteLine("Iteracje petla for: ");

            for (int j = 0; j <= it+1; j++)
            {
                Console.WriteLine(j); ;
            }
            Console.ReadKey();
        }
    }
}
