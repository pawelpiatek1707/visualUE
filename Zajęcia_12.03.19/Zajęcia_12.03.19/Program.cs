using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_12._03._19
{
    static class Zadanie1
    {
        public static void Metoda()
        {
            Console.WriteLine("Metoda bez argumentów");
        }
        public static  void Metoda(int a)
        {
            Console.WriteLine("Metoda z jednym parametrem wynoszącym: "+a);
        }
        public static  void Metoda(int a,int b)
        {
            Console.WriteLine("Metoda z dwoma argumentami tego samego typu, pierwszy: "+a+", drugi: "+b);
        }
        public static  string Metoda(string napis)
        {
            return napis;
        }
    }
    static class Zadanie2
    {
        public static  int Metoda(int a)
        {
            return a + 10;
        }

        public static  double Metoda(double a)
        {
            return a - 20;
        }
        public static  float Metoda(float a)
        {
            return a * 3;
        }
    }
    static class Zadanie3
    {
        public static int Dodawanie(int a,int b)
        {
            return a + b;
        }
        public static int Dodawanie(int a,int b,int c)
        {
            return a + b + c;
        }
        public static double Dodawanie(double a, double b)
        {
            return a + b;
        }
        public static double Dodawanie(double a,double b, double c)
        {
            return a + b + c;
        }
    }
    class Zadanie4
    {
        double a;
        double b;
        public Zadanie4(double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        public Zadanie4(double a)
        {
            this.a = a;
            this.b = a;
        }
        public Zadanie4()
        {
            this.a = 0;
            this.b = 0;
        }

        public void Pole()
        {
            double pole;
            if(this.a ==0&&this.b==0)
            {
                Console.WriteLine("Nie podano boku kwadratu, wiec pole tego kwadratu nie istnieje");
            }
            else if(this.a==this.b)
            {
                pole = this.a * this.a;
                Console.WriteLine("Pole kwadratu wynosi: "+pole);
            }
            else
            {
                pole = this.a * this.b;
                Console.WriteLine("Pole prostokąta wynosi: " + pole);
            }
        }
    }
    class Ksiazki
    {
        public string tytul;
        public string autor;
        public int strony;
        public int rozdzialy;
        public double cena;
        public const double rabat = 0.05;

        public Ksiazki(string tytul,string autor,int strony,int rozdzialy,double cena)
        {
            this.tytul = tytul;
            this.autor = autor;
            this.strony = strony;
            this.rozdzialy = rozdzialy;
            this.cena = cena;
        }

        public double Rabat()
        {
            double Nowacena = this.cena * rabat;
            double poRabacie = this.cena - Nowacena;
            return poRabacie;
        }
        public double Rabat(double a)
        {
            double rabatKlienta = a * 0.01;
            double sumRabat = rabat + rabatKlienta;
            double NowaCena = this.cena * sumRabat;
            double poRabacie = this.cena - NowaCena;
            return poRabacie;
        }

    }
    class Pracownicy
    {
        public string nazwisko;
        public string imie;
        public double placa;
        public int rokUrodzenia;
        public const double premia = 0.1;

        public Pracownicy(string nazwisko, string imie, double placa, int rokUrodzenia)
        {
            this.nazwisko = nazwisko;
            this.imie = imie;
            this.placa = placa;
            this.rokUrodzenia = rokUrodzenia;
        }

        public double Placa()
        {
            double Premia = this.placa * premia;
            double nowaPlaca = this.placa - Premia;
            return nowaPlaca;
        }
    }
    class Punkt_3D
    {
        private double x;
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        private double y;
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        private double z;
        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        public Punkt_3D()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }
        public Punkt_3D(double x,double y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Punkt_3D(Punkt_3D a)
        {
            this.x = a.X;
            this.y = a.Y;
            this.z = a.Z;
        }
    }
    static class Punkt_3D_Metody
    {
        static double Odleglosc(Punkt_3D a,Punkt_3D b)
        {
            double odleglosc = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2));
            return odleglosc;
              
        }
    }
    class Kolo
    {
        private double r;
        public double R
        {
            get { return r; }
            set { r = value; }
        }
        public double D
        {
            get { return 2 * r; }
            set { r = value / 2; }
        }
        public double Pole
        {
            get { return Math.PI * r * r; }
        }
        public double Obw
        {
            get { return Math.PI * 2 * r; }
        }
        public Kolo()
        {
            this.r = 1;
        }
        public Kolo(double r)
        {
            try
            {
                this.r = r;
            }
            catch(Exception e)
            {
                Console.WriteLine("Promien nie moze byc rowny 0");
            }
            
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie4 z1 = new Zadanie4(4,2);
            //z1.Pole();
            //Console.WriteLine("/////////////////////////////////////");
            //Console.WriteLine("Podaj cene ksiazki");
            //double  a = double.Parse(Console.ReadLine());
            //while(a<=0)
            //{
            //    Console.WriteLine("Podaj cene ksiazki");
            //    a = double.Parse(Console.ReadLine());
            //}
            
            //Ksiazki k1 = new Ksiazki("Dziady","Adam Mickiewicz",123,4,a);
            //Console.WriteLine("Cena ksiazki wyłącznie po ustalonym rabacie 5%: "+k1.Rabat()); 
            //Console.WriteLine("Cena ksiazki  po ustalonym rabacie 5% oraz po rabacie podannym przez użytkownika: "+k1.Rabat(10));
            //Console.WriteLine("///////////////////////////////////////");
            //Console.Write("Podaj rok urodzenia: ");
            //int b = int.Parse(Console.ReadLine());
            //while (b < 1900 || b > 2000)
            //{
            //    Console.Write("Podaj rok urodzenia: ");
            //     b = int.Parse(Console.ReadLine());
            //}
            //Pracownicy p1 = new Pracownicy("Kowalski", "Jan", 2345.5, b);
            //Console.WriteLine(p1.Placa());
            Console.WriteLine("////////////////////////////////////");
            Kolo k2 = new Kolo(3);
            Console.WriteLine(k2.Pole);
            Console.WriteLine(k2.Obw);
            Console.WriteLine(k2.R);


            Console.ReadKey();
        }
    }
}
