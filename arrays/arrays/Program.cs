using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Zadanie 4.1 i 7.4
            Console.WriteLine("Podaj liczbe elementow tablicy: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            Console.WriteLine("Podaj elementy tablicy: ");
            int a;
            for(int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                arr1[i] = a;
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Elementy tablicy: ");
           
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();

          
        }
    }
}
