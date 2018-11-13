using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            Random rand = new Random();
            for(int i = 0; i < 10; i++)
            {
                arr1[i] = rand.Next(-10, 10);
            }
            Console.WriteLine("Zawartość tablicy");
            int sum=0;
            foreach(int x in arr1)
            {
                Console.Write(x+", ");
                sum += x;
            }
            
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Wartość maksymalna: "+arr1.Max());
            Console.WriteLine("Wartość minimalna: " + arr1.Min());
            int average = sum / 10;
            Console.WriteLine("Srednia: "+average);
            int[] arr2 = new int[10];
            for(int i =0;i<10;i++)
            {
                arr2[i] = arr1[9 - i];
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Tablica w odwróconej kolejności: ");
            foreach(int x in arr2)
            {
                Console.Write(x+", ");
            }
            Console.ReadKey();
        }
    }
}
