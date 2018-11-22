using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._4
{
    class Program
    {
        static void Matrix()
        {
            
            Random rand1 = new Random();
            Console.Write("Podaj ilość elementów tablicy jednowymiarowej: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            for (int i =0;i<n;i++)
            {
                arr1[i] = rand1.Next(-10, 10);
            }
            Console.WriteLine("Wyjściowa tablica");
            Console.WriteLine();
            foreach(var x in arr1)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
            Console.Write("Podaj liczbe przez którą chcesz przemnoożyć macierz: ");
            int a = int.Parse(Console.ReadLine());
            int[] arr2 = new int[n];
            for(int i =0;i<n;i++)
            {
                arr2[i] = arr1[i] * a;
            }
            Console.WriteLine();
            Console.WriteLine("Macierz po mnożeniu");
            foreach(var x in arr2)
            {
                Console.Write(x+" ");
            }
        }
        static void Main(string[] args)
        {
            
            Matrix();
            Console.ReadLine();
        }
    }
}
