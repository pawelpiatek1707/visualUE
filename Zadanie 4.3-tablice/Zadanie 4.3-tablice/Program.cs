using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._3_tablice
{
    class Program
    {
        static void Srednia(int[]arr, int n)
        {
            
            int suma =0;
            for(int i = 0; i < n; i++)
            {
                suma +=arr[i];
            }
            int srednia = suma / n;
            Console.WriteLine("Srednia: "+srednia);
        }
        static void MaxMin(int[] arr)
        {
            int n = arr.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
            n = arr.Length;
            int indexMax = n - 1;
            int min = arr[0];
            int max = arr[n-1];
            Console.WriteLine("Tablica zostala posortowana");
            Console.WriteLine("Wartosc minimalna: "+min+" Indeks najmniejszaego elementu: 0");
            Console.WriteLine("Wartosc maxymalna: "+max +" Indeks największego elementu: " + indexMax);
           
        }
        static void Plus(int[] arr,int n)
        {
            int suma = 0;
            for(int i=0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    suma++;
                }
            }
            Console.WriteLine("Liczba dodatnich elementow: "+suma);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe elementow tablicy: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj elementy tablicy: ");
            int a;
            int[] arr1 = new int[n];
            for(int i =0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                arr1[i] = a;
                
            }
            Console.Clear();
            for(int i =0; i < n; i++)
            {
                Console.WriteLine(arr1[i]);
              
            }
         
     
           
            Srednia(arr1, n);
            MaxMin(arr1);
            Plus(arr1, n);
            
            Console.ReadKey();

        }
    }
}
