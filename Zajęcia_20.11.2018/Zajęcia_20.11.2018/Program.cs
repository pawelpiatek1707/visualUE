using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_20._11._2018
{
    class Program
    {
        static float stopnie(float celsjusze)
        {

            float far = 32 + (9 / 5 * celsjusze);
            return far;
        }
        static string zwrot(float a, float b, float x)
        {
            string wynik;
            if (x > a && x < b)
            {
                wynik = "Jest z przedziału: <" + a + ", " + b + ">";
            }
            else
            {
                wynik = "Nie jest z przedziału: <" + a + ", " + b + ">";
            }
            return wynik;

        }
        static double dziel(double x, double y)
        {
            double wynik = 0;
            if (y != 0)
            {
                wynik = x / y;
            }
            return (wynik);
        }
        static void Elems(params int[] arr1)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine();
        }
        static void rys(int a, int b, string c)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
        static void mno (int[] arr1, int liczba)
            {
            for(int i=0;i<5;i++)
            {
                arr1[i] = liczba * arr1[i];
            }
            foreach(var x in arr1)
            {
                Console.Write(x+" ");
            }
            }
        
        static void Main(string[] args)
        {
            //zamiana stopni
            //Console.WriteLine( stopnie(10f) ); 
            //dzielenie z zajęć 
            //Console.WriteLine( dziel(10f, 5f) );

            //referencja ->ref albo out jakiś argument a w c++ &
            //params
            //Elems(1, 2, 3);//params
            //Console.WriteLine("Podaj a:");
            //float a = float.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj b:");
            //float b = float.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj x:");
            //float x = float.Parse(Console.ReadLine());
            //Console.WriteLine(zwrot(a,b,x));
            //rys(3, 3, "*");
            //Console.WriteLine();


            //rys(8, 4, "ó");
            //Console.WriteLine();

            //rys(4, 10, "#");

            int[] arr1 = new int[5];
            Random rand1 = new Random();
            for(int i =0;i<5;i++)
            {
                arr1[i] = rand1.Next(-5, 5);
            }
            Console.WriteLine("Tablica bez modyfikacji");
            Console.WriteLine();
            foreach(var x in arr1)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Tablica po modyfikacji (mnożenie *3)");
            Console.WriteLine();
            mno(arr1,3);
            Console.ReadKey();
        }
    }
}
