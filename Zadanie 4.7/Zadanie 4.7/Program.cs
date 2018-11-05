using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dodawanie dwóch macierzy");
            Console.WriteLine("------------------------");
            Console.WriteLine("Macierz pierwsza: ");
            int[,] arr1 = { { 1, 2,3 }, { 3, 4,5 }};
            int[,] arr2 = { { 8, 4, 2 }, { 5, 1, 7 }};
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,3}", arr1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Macierz druga: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,3}", arr2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Dodane macierze: ");
            int[,] arr3 = new int[2,3];
            
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("{0,3}", arr3[i, j] = arr1[i, j] + arr2[i, j] ); 
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
