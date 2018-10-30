using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = new int[10] { 1, 2, -3, -4, 5, -6, 7, 8, -9,0 };
            int[] tab2 = new int[10];

            Console.WriteLine("Tablica 1: ");
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(tab1[i]);
            }
            Console.WriteLine("Tablica 2: ");
            for(int i =0; i<10; i++)
            {
                if (tab1[i] > 0)
                {
                    tab2[i] = tab1[i];
                    Console.WriteLine(tab2[i]);

                }
             
                
            }
            Console.ReadKey();
        }

    }
}
