using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_06._11._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tablica autorow");
            Console.WriteLine("----------------");
            string[] arr1 = new string[7] { "Lesmian","Tuwim","Milosz","Asnyk","Mickiewicz","Kochanowski","Rej"};
            for(int i= 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            int length = arr1.Length;
            Console.WriteLine("-------------------------");
            Console.WriteLine("Dlugosc tablicy: "+length);
            Console.WriteLine("-------------------------");

            int rejIndex = Array.IndexOf(arr1, "Rej");
            int KonopnickaIndex = Array.IndexOf(arr1, "Konopnicka");
            int MickiewiczIndex = Array.IndexOf(arr1, "Mickiewicz");
            int[] arr2 = new int[3] { rejIndex, KonopnickaIndex, MickiewiczIndex };
            int counter = 1;
            for(int j = 0; j < 3; j++)
            {
                if(arr2[j]<0)
                Console.WriteLine("Index "+counter+" Elementu nie ma w tablicy");
                else
                {
                    Console.WriteLine("index "+counter +" elementu: " + arr2[j]);

                }
                counter++;
            }
            Console.WriteLine("------------");
            
            Console.WriteLine("Odwracanie wartosci");
            Console.WriteLine("------------------");
            Array.Reverse(arr1);
            foreach(string x in arr1)
            {
                Console.WriteLine(x);
            }

                //TODO do końca to zadanie 
            
      

            Console.ReadKey();
        }
    }
}
