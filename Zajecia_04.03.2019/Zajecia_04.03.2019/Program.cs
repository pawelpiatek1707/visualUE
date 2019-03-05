using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_04._03._2019
{
    static class Telefon
    {
        static int rok = 1876;
        public static int Rok
        {
            get { return rok; }
        }
    }

    static class Liczby
    {
       
       
        public static double WartoscBezwzgledna(double liczba)
        {
            
            if(liczba >0)
            {
                return liczba;
            }
            else
            {
                return -liczba;
            }
        }
        
    }
    static class Kalkulator
    {
        public static double  Dodawanie(double a, double b)
        {
            return a + b;
        }
        public static double Odejmowanie(double a, double b)
        {
            return a - b;
        }
        public static double Mnożenie(double a, double b)
        {
            return a * b;
        }
        public static double Dzielenie(double a, double b)
        {
            return a /b;
        }
        public static double Potegowanie(double a, double b)
        {
            double c = a;
            for (int i = 0; i < b-1; i++)
            {
                a = a * c;
            }
            return a;
        }
    }
    static class Fibbonaci
    {
        public static int FibDlaElem(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return FibDlaElem(n - 1) + FibDlaElem(n - 2);
        }
        public static void Ciag()
        {
            Console.WriteLine("Ciąg Fibonacciego -ciąg liczb naturalnych określony rekurencyjnie w sposób następujący: Pierwszy wyraz jest równy 0, drugi jest równy 1, każdy następny jest sumą dwóch poprzednich.");
        }
        public static void fibonacci(int n)
        {
             long a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                

                Console.WriteLine(b+" ");
                b += a; //pod zmienną b przypisujemy wyraz następny czyli a+b
                a = b - a; //pod zmienną a przypisujemy wartość zmiennej b
            }
        }


    }
    static class Stałe
    {
        public static  double pi = 3.14159;
        public static double e = 0.57721;
        public static double zlotaLiczba = 1.61803;
        public static void PoleKola(double r)
        {
            double pole= pi *r*r;
            Console.WriteLine("Pole koła: "+pole);

        }
        public static void ObwodKoła(double r)
        {
            double obw = 2*pi*r;
            Console.WriteLine("Pole koła: " + obw);

        }
    }
    class MojaKlasa
    {
        public static double PI =3.1415;
        public double r;
        public MojaKlasa(double r)
        {
            this.r = r;
        }
        public double PoleKola()
        {
            double pole = PI * r * r;
            return pole;
        }
    }
    //----------------------------------------------
    class Piosenkarz
    {
        private string imie, nazwisko;
        private DateTime dataUrodzenia;
        public Piosenkarz(string imie, string nazwisko, DateTime dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }
       
        public  void ileMaLat()
        {
            Console.WriteLine("{0} {1} ma {2} lat", imie, nazwisko, DateTime.Now.Year - dataUrodzenia.Year);
        }
        public static void zaspiewajMiPiosenke()
        {
            Console.WriteLine("Śpiewam! Lalalala...");
        }
    }

    //----------------------------------------------
    class Trojmian
    {
        double a, b, c;
        public Trojmian(double a,double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Przetwór_Dane()
        {
            
            if(a==0)
            {
                double wynik;
                wynik = -c / b;
                Console.WriteLine("Jedno rozwiązanie: "+wynik);
            }
            else
            {
                double delta = (b * b) - 4 * a * c;
                if(delta<0)
                {
                    Console.WriteLine("Delta mniejsza od 0, rówanianie nie ma rozwiązań");
                }
                else if(delta==0)
                {
                    double x1 = -b / 2 * a;
                    Console.WriteLine("Delta rówana 0, rówanie ma jedno rozwiązanie x: "+x1);
                }
                else
                {
                    double x1 = -b - (Math.Sqrt(delta))/2*a;
                    double x2 = -b + (Math.Sqrt(delta))/2*a;
                    Console.WriteLine("Delta większa od 0, rówanie ma dwa rozwiązania x1: "+x1+" x2: "+x2);
                }
            }
        }
    }
    static class DniTygodnia
    {
        public static string[,] dniTygodnia = { {"poniedziałek","Monday" },
                                                 {"wtorek","Tuesday" },
                                                   { "śrda","Wednesday" } ,
                                                    {"czwartek","Thursday" },
                                                    {"piątek","Friday" },
                                                    {"sobota" ,"Satturday"},
                                                    {"niedziela","Sunday" } };
        public static string Zwroc(int numer)
        {
            if(numer<0||numer>6)
            {
                return "nie ma takiego dania tygodnia";
            }
            else
            {
                string polaczone = String.Concat(dniTygodnia[numer, 0] +" "+ dniTygodnia[numer, 1]);
                return polaczone;
            }
        }
    }
    static class Temperatura
    {
        public static double DoFar(double celcius)
        {
            double far = 32d + 9d / 5 * celcius;
            return far;
        }
        public static double DoCel(double far)
        {
            double cel = (far - 32d) / 1.8d;
            return cel;
        }
    }
    class Student
    {
        public string imie;
        public string nazwisko;
        public int wiek;
        public int rokStudiow;
        public double srednia;
        public Student()
        {
            this.imie = "noname";
            this.nazwisko = "noname";
            this.wiek = 19;
            this.rokStudiow = 1;
            this.srednia = 0.0;
        }
        public Student(string imie,string nazwisko,int wiek, int rokStudniow,double srednia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            if(wiek<18||wiek>65)
            {
                this.wiek = 19;
            }
            else
            {
                this.wiek = wiek;
            }

            if (rokStudiow < 1 || rokStudiow > 5)
            {
                this.rokStudiow = 1;
            }
            else
            {
                this.rokStudiow = rokStudniow;
            }

            if (srednia < 2.0 || srednia > 5.0)
            {
                this.srednia = 4.0;
            }
            else
            {
                this.srednia = srednia;
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Pierwszy telefon: "+Telefon.Rok);
            //double liczba = -10.14;
            //Console.WriteLine("Wartosc bezwzgledna: "+Liczby.WartoscBezwzgledna(liczba));
            //Console.WriteLine("Zaokrąglenie: "+Math.Round(liczba,0));
            //Console.WriteLine("Najwieksza liczba całkowita: "+Math.Ceiling(liczba));
            //Console.WriteLine("Dodawanie: "+Kalkulator.Dodawanie(2,3));
            //Console.WriteLine("Odejmoanie: "+Kalkulator.Odejmowanie(2,3));
            //Console.WriteLine("Mnożenie: "+Kalkulator.Mnożenie(2,3));
            //Console.WriteLine("Dzielenie: "+Kalkulator.Dzielenie(2,3));
            //Console.WriteLine("Potęgowanie: "+Kalkulator.Potegowanie(2,3));
            //Console.WriteLine("------------------Fibonacci-------------------");
            //Console.WriteLine(Fibbonaci.FibDlaElem(10));
            //Fibbonaci.Ciag();
            //Console.WriteLine("-------------");
            //Fibbonaci.fibonacci(10);
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("Pi"+Stałe.pi);
            //Console.WriteLine("Euler"+Stałe.e);
            //Console.WriteLine("Złota liczba"+Stałe.zlotaLiczba);
            //Stałe.PoleKola(6);
            //Stałe.ObwodKoła(6);
            //Console.WriteLine("---------------------------------------------");
            //MojaKlasa m1 = new MojaKlasa(6);
            //Console.WriteLine("Pole kola:"+ m1.PoleKola() );
            //Console.WriteLine("---------------------------------------------");
            //DateTime d1 = new DateTime(1970,05,17);

            //Piosenkarz p1 = new Piosenkarz("Adam", "Nowal", d1);
            //Console.WriteLine("--------------------------------------------");
            //Trojmian t1 = new Trojmian(1, 2, 1);
            //t1.Przetwór_Dane();
            Console.WriteLine( DniTygodnia.Zwroc(0));
            Console.WriteLine(Temperatura.DoCel(5));
            Console.WriteLine( Temperatura.DoFar(5) ); 
      
            Console.ReadKey();
        }
    }
}
