using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 0. Przekazywnaie argumentów o zmiennej długości do metody 
 * 1. Różnica między deklaracją a definicją metody 
 * 2. Przekazywanie argumentów do metody
 * 3. Przekazywanie i zwracanie tablic w metodach
 * 4. Przeciążanie metod
 * 5. Składanie konstruktorów za pomocą this
 * 6. Kolekcja obiektów
 * 7. Rekurencja
 * 8. Interfejsy w kolekcjach
 * 9. Typy generyczne
 * 10. Przeciążanie operatorów 
 * 11. Wyrażenie Lambda 
 * 
 * */

namespace Przed_egzaminem_II
{
    
    static class Przeciazanie
    {
        public static float Liczby(int a, float b)
        {
            return a * b;
        }
        public static float Liczby(int a,int b,int c)
        {
            return a * b*c;
        }
    }
    class Prostopadloscian
    {
        double a, b, c;
        
        
        //Kostruktor, w którym podaje wszystkie wartości
        public Prostopadloscian(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Prostopadloscian(int a) : this(a, 1, 1) { }
        
        public Prostopadloscian(int a,int b) : this(a, b, 1) { }
       
        public Prostopadloscian():this(1,1,1) { }
        
        //Składanie konstruktowów 
        public void Wypisz()
        {
            Console.WriteLine("a: "+this.a);
            Console.WriteLine("b: "+this.b);
            Console.WriteLine("c: "+this.c);
        }
    }
    class Zwierze
    {
        public string Imie;
        public string Kolor;
        public int Wiek;

        public Zwierze(string imie,string kolor,int wiek)
        {
            this.Imie = imie;
            this.Kolor = kolor;
            this.Wiek = wiek;
        }
        public void Dodaj()
        {
            Random r1 = new Random();
            Console.Write("Podaj imie: ");
            string imie = Console.ReadLine();
            Console.Write("Podaj kolor: ");
            string kolor = Console.ReadLine();
            Console.Write("Podaj wiek: ");
            int wiek = int.Parse(Console.ReadLine());

            int id = r1.Next(1, 100);
            string id1 = id.ToString();
            string nazaObiekt = String.Concat(this.Imie, id1);

            



        }
    }
    //Interfejsy w kolekcjach 
    interface IInfo
    {
        string  Wypisz();
    }
    class Klasa1:IInfo
    {
        public string Wypisz()
        {

            return "Informacje z klasy 1";
        }
    }
    class Klasa2 : IInfo
    {
        public string  Wypisz()
        {
            return "Informacje z klasy 2";
        }
    }
    //Typy generyczne 
    class Stos<T>
    {
        int pozycja;
        T[] dane = new T[100];

        public void Dodaj(T element)
        {
            dane[pozycja++] = element;
        }
        public T Usun()
        {
            return dane[pozycja--];
        }

        public void Wypisz()
        {
            foreach(T x in dane)
            {
                Console.WriteLine(x);
            }
        }
    }
    class Liczby<T>
    {
        T liczba1, liczba2;
        public Liczby(T liczba1,T liczba2)
        {
            this.liczba1 = liczba1;
            this.liczba2 = liczba2;
        }

        public void Wypisz()
        {
            Console.WriteLine(liczba1+" "+liczba2);
        }
    }
    static class Generics
    {
        public static void Inicjalizuj<T>(T[]dane)
        {
            for (int i = 0; i < dane.Length; i++)
            {
                dane[i] = default(T);
                //Inicjalizowanie typem domyślnym dla wybranego typu
            }
        }
    }
    //Przeciążanie operatorów 
    class Zespolone
    {
        public double re, im;
        public Zespolone(double re,double im)
        {
            this.re = re;
            this.im = im;
        }
        public void Wyswietl()
        {
            Console.WriteLine("Liczb zespolona: "+this.re+" + "+this.im+"i");
        }
        //Operatory
        public static  Zespolone operator +(Zespolone z1, Zespolone z2)
        {
            return new Zespolone(z1.re + z2.re, z1.im + z2.im);
        }
        public static bool operator ==(Zespolone z1, Zespolone z2)
        {
            return z1.re == z2.re && z1.im == z2.im;
        }
        public static bool operator != (Zespolone z1, Zespolone z2)
        {
            return z1.re != z2.re && z1.im != z2.im;
        }
        public static bool operator > (Zespolone z1, Zespolone z2)
        {
            return z1.re > z2.re && z1.im > z2.im;
        }
        public static bool operator <(Zespolone z1, Zespolone z2)
        {
            return z1.re < z2.re && z1.im < z2.im;
        }
    }
    //Wyrażenie lambda
    static class Kwadrat
    {
       
        public static double Pole(double x) => x * x;
        public static double Obw(double x)
        {
            return 4 * x;
        }

        

        

    }
    //Delegaty 

    class Program
    {
        delegate double Operacja(double x);
        static void Main(string[] args)
        {

            //0. Przekazywnaie do metody listy argumentów o zmiennej długości
            //void Metoda( params  int[]argumenty)
            //{
            //    int suma = 0;
            //    for(int i = 0; i < argumenty.Length; i++)
            //    {
            //        suma += argumenty[i];
            //    }
            //    Console.WriteLine("Suma wynosi: "+suma);
            //}
            //int[] arr = { 1, 2, 3 };
            //Metoda(arr);
            //==============================================================
            //1. Różnica między deklaracja a definicją metody 
            /*
             * - Deklaracja: void Metoda();
             * - Definicja: void Metoda()
             *              {
             *                  Ciało metody
             *              }
             *              */
            //Przykład: Metoda mnożąca 3 liczby int int i float i zwracająca wartośc typu float 
            // float Zwroc_float(int a,int b,float c)
            //{
            //    return a * b * c;
            //}

            //Console.WriteLine(Zwroc_float(1,3,1.5f));
            //===============================================================
            /*2. Przekazywanie argumentów do metody
             * - przekazywanie poprzez wartość 
             * - przekazywanie poprzez referencje 
             * - przekazywanie przez wyjście
             * */
            //Przekaztwanie przez referencje 
            //int a = 5;
            //Console.WriteLine("Przed wywołaniem metody: "+a);
            //void Zwieksz(ref int x)
            //{
            //    x++;
            //    Console.WriteLine("Wywołanie w metodzie: "+x);

            //}
            //Zwieksz(ref a);
            //Console.WriteLine("Wywołanie po wykonaniu metody: "+a);
            ////Przekazywanie przez wyjście 
            //int b = 0;
            //Console.WriteLine("Wartość zmiennej przed wykonaniem metody: "+b);
            //void Wyjscie(out int x)
            //{
            //    x = 10;
            //}
            //Wyjscie(out b);
            //Console.WriteLine("Wartość zmiennej po wykonaniu metody: "+b);
            //============================================================
            //3. Przekazywanie i zwracanie tablic w metodach
            //int[] arr = { 1, 2, 3, 4, 5 };
            //void Przekaz(int[] x)
            //{
            //    foreach (var a in x)
            //    {
            //        Console.Write(a + " ");
            //    }
            //}
            //Przekaz(arr);
            //int[] Przekaz_Zwroc(int[] x)
            //{
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        x[i]++;
            //    }
            //    return x;
            //}
            //int[] tab = Przekaz_Zwroc(arr);
            //foreach (var x in tab)
            //{
            //    Console.WriteLine(x);
            //}
            ////Lista argumentów o zmiennej długości
            //void Zmien(params int[] c)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < c.Length; i++)
            //    {
            //        sum += c[i];
            //    }
            //    Console.WriteLine("suma: " + sum);
            //}
            //Zmien(arr);
            //==============================================
            //4. Przeciązanie metod (zrobione w osobnej klasie)
            //Console.WriteLine(Przeciazanie.Liczby(1, 2.5f));
            //Console.WriteLine(Przeciazanie.Liczby(1,2,3));
            //==================================================
            //5. Rekurencyjne wywoływanie metod 
            //int Silnia(int n)
            //{
            //    if (n <= 1)
            //        return 1;
            //    else
            //        return n * Silnia(n - 1);
            //}

            //Console.WriteLine(Silnia(3));
            //===================================================
            //9. Składanie konstruktorów za pomoca this. (Osobna klasa prostopadloscian)
            //Prostopadloscian p1 = new Prostopadloscian(1, 2, 3);
            //p1.Wypisz();
            //Prostopadloscian p4 = new Prostopadloscian(5, 6);
            //p4.Wypisz();
            //Prostopadloscian p2 = new Prostopadloscian(9);
            //p2.Wypisz();
            //Prostopadloscian p3 = new Prostopadloscian();
            //p3.Wypisz();
            //================================================
            //10. Kolekcja obiektów 
            //List < Zwierze > Zwierzeta = new List<Zwierze>();
            //Zwierze z1 = new Zwierze("Koza", "czarna", 10);
            //Zwierzeta.Add(z1);
            //Zwierze z2 = new Zwierze("Pies", "biały", 3);
            //Zwierzeta.Add(z2);
            //foreach(var x in Zwierzeta)
            //{
            //    Console.WriteLine(x.Imie);
            //    Console.WriteLine(x.Kolor);
            //    Console.WriteLine(x.Wiek);
            //}
            //=================================================
            //Interfejsy  w kolekchach 
            //IInfo k1 = new Klasa1();
            //IInfo k2 = new Klasa2();
            //List<IInfo> Interfejsy = new List<IInfo>();
            //Interfejsy.Add(k1);
            //Interfejsy.Add(k2);
            //foreach(var x in Interfejsy)
            //{
            //    Console.WriteLine(x.Wypisz());
            //}
            //================================================
            //Typy generyczne
            //var s1 = new Stos<float>();
            //s1.Dodaj(4.5f);
            //s1.Dodaj(5);
            //s1.Wypisz();
            //s1.Usun();
            //Liczby<int> l1= new Liczby<int>(12,32);
            //l1.Wypisz();
            //Liczby<double> l2 = new Liczby<double>(12.4f, 23);
            //l2.Wypisz();
            //int [] ar = new int[10];
            //Generics.Inicjalizuj<int>(ar);
            //foreach(var x in ar)
            //{
            //    Console.WriteLine(x);
            //}
            //=================================================
            //Przeciążanie operatorów 
            //Zespolone z1 = new Zespolone(3, 4);
            //Zespolone z2 = new Zespolone(3.5d, 5);
            //z1.Wyswietl();
            //z2.Wyswietl();
            //Zespolone z3 = z1 + z2;
            //z3.Wyswietl();
            //Console.WriteLine(z1==z2);
            //Console.WriteLine(z1<z2);
            //================================================
            //Wyrażenie Lambda 
            //Console.WriteLine(Kwadrat.Pole(5));
            //===============================================
            //Delegaty
            Operacja Pole = (double x) => x * x;
            Console.WriteLine(Pole(4));
            
            Console.ReadLine();
        }
    }
}
