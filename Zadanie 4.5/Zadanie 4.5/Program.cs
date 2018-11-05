using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadz zawartosc tablicy");
            int a;
            int[] arr1 = new int[n];
            for(int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                arr1[i] = a;
            }
            int[] arr2 = new int[n];
            for(int i = 0; i < n-1; i++)
            {
                arr2[i] = arr1[i + 1];
            }
            arr2[n - 1] = arr1[0];
            Console.WriteLine("Zawartosc tablicy po zmianie: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            
            Console.ReadKey();
        }
    }
}
