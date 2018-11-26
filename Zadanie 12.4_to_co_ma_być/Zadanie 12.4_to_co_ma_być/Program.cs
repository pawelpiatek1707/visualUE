using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12._4_to_co_ma_być
{
    class Program
    {
        static void Matrix(out int a)
        {
             a = 5;
            int[] arr1 = new int[] {1,2,3,4,5};
            Console.Write("Podaj liczbę przez jaką chcesz przemnożyć tablice: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Tablica przed modyfikacją: ");
            foreach(var x in arr1)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Tablica po modyfikacji: ");
            int[] arr2 = new int[5]; 
            for(int i=0;i<5;i++)
            {
                arr2[i] = a * arr1[i];
            }
            foreach(var x in arr2)
            {
                Console.Write(x+" ");
            }

        }
        static void Main(string[] args)
        {
            int a;
            Matrix(out a);
            Console.ReadKey();
        }
    }
}
