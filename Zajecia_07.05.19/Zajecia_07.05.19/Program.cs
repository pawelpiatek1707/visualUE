using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_07._05._19
{
    //Zadanie 2
    public class Zadanie2<T>
    {
        T[] dane;
       
        public Zadanie2(int liczba)
        {
            this.dane = new T[liczba];
            
        }
    }
    //Zadanie 3 
    static class Zadanie3
    {
        public static void Metoda<T1, T2,T3>(T1 a, T2 b, T3 c)
        {
            Console.Write(a);
            Console.Write(b);
            Console.WriteLine(c);
        }
    }
    //Zadanie 4
    class Zadanie4<T>where T:struct
    {
        public T[] dane;
        public void Wyswietl()
        {
            Console.Clear();
            foreach(var x in dane)
            {
                Console.Write(x+" ");
            }
        }

        public Zadanie4(int liczba)
        {
            this.dane = new T[liczba];

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           //Zadanie 2
            //Zadanie2<int> tablica = new Zadanie2<int>(4);           
            //Zadanie2<string> tablica1 = new Zadanie2<string>(4);
            //Zadanie 3
            //Zadanie3.Metoda<int, int, int>(3, 4, 5);
            //Zadanie3.Metoda<string, string, string>("a","b","c");
            //Zadanie3.Metoda<string, int, string>("a",1,"c");
            //Zadanie 4
            Console.Write("Podaj rozmair tablicy: ");
            int liczba = int.Parse(Console.ReadLine());
            Zadanie4<int> tablicaInt = new Zadanie4<int>(liczba);
            for(int i = 0; i<liczba;i++)
            {
                Console.WriteLine("Podaj zawartosc tablicy");
                tablicaInt.dane[i] = int.Parse(Console.ReadLine());
            }
            tablicaInt.Wyswietl();
            Console.ReadKey();
        }
    }
}
