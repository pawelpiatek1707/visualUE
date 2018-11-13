using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odejmowanie macierzy");
            Console.WriteLine("-------------------");
            Console.Write("Podaj wymiar macierzy kwadratowej:");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            int[,] arr1 = new int[n,n];
            Random rand1 = new Random();
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr1[i, j] = rand1.Next(-10, 10);
                }
                Console.WriteLine();
            }
            int[,] arr2 = new int[n,n];
            Random rand2 = new Random();
            for(int i = 0; i < n; i++)
            {
                for(int j=0;j<n;j++)
                {
                arr2[i,j] = rand2.Next(-10, 10);
                }
               
            }
            Console.WriteLine("Macierz 1:");
            for(int i=0;i<n;i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(arr1[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("Macierz 2:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr2[i, j]+ " ");
                }
                Console.WriteLine();
            }
            int[,] arr3 = new int[n,n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("Macierz wynikowa: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
