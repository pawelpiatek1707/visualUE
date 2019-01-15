using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    { 
        static int [] test2()
        {
            int[] liczby = { 3, 4, 5, 6, 7 };
            for(int i = 0; i< liczby.Length; i++)
            {
                liczby[i] = liczby[i] * 2;
            }
            foreach(var x in liczby)
            {
                Console.WriteLine(x);
            }

            return liczby;
        }
        static void test1(params int[]tab1)
        {
            foreach(var x in tab1)
            {
                Console.WriteLine(x);
            }

        }
        static void test(out int x, out int y)
        {
            x = 10;
            y = 5;
            Console.WriteLine(x+ " " + y);

        }
        static int metoda1(int x)
        {
            x += 2;
            return x;
        }
        static void oblicz (out int a)
        {
            a = 0;
        }
        static void refmet1(int x, int y)
        {
            x += 1;
            y += 1;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        static void Main(string[] args)
        {
            //int[] arr1 = new int[5];
            //int[] arr2 = new int[5];
            //Random rand1 = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    arr1[i] = rand1.Next(1, 10);
            //}
            //Console.WriteLine("First array");
            //foreach (var x in arr1)
            //{
            //    Console.Write(x);
            //}
            //Console.WriteLine();

            //for (int i = arr2.Length - 1; i <= 0; i--)
            //{
            //    arr2[i] = arr1[i - arr2.Length - 1];





            //}
            //foreach (var x in arr2)
            //{
            //    Console.Write(x);
            //}
            //string[] tab1 = new string[]{ "Ala", "Ada" };
            //foreach(var x in tab1)
            //{
            //    Console.Write(x);
            //}
            //Console.WriteLine();
            //String.Join(tab1, ",", 0);
            //int a = 10;
            //oblicz(out a);
            //Console.WriteLine(a );
            //int x = 3;
            //float y = 3.5f;
            //float wynik = x * y;
            //int x = 4;
            //int y = 4;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine("wartości z metody");
            //refmet1(x, y);
            //Console.WriteLine("Ponownie oryginalne wartości");
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //double srednia = 15.5;
            //int srednia1;
            //srednia1 = (int)srednia;
            //Console.WriteLine(srednia1);
            //int test = 258;
            //byte test1 = (byte)test;
            //Console.WriteLine(test1);

            // Tablica tablic jednowymiarowych
            int a;
            int b;
            test(out a, out b);
            Console.WriteLine(a+ " " + b);
            test1(3, 4, 5, 6, 7, 8);
            Console.WriteLine("-----------------------");
            int[] tab1 = { 1, 7, 6, 4, 6, 7, 8 }; ;
            test1(tab1);
            Console.WriteLine("---------------------------");
            test2();
            

            Console.ReadKey();
        }
    }
}
