using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1
{
    class Licz
    {
        public int wartosc;

        public Licz(int wartosc )
        {
            this.wartosc = wartosc;
        }

        public int Dodaj(int x)
        {
            int sum = x + this.wartosc;
            return sum;
        }
        public int Odejmin(int x)
        {
            int odj = this.wartosc - x;
            return odj;
        }
    }
    static class Rzymskie
    {
        //static void DoRzymskich(double a)
        //{
        //    string roman = "";
        //    if(a/100>0)
        //    {
        //        roman = roman + "L";
        //        a-
        //    }
            
        //}
        public static string DoBinarnych(int a)
        {
           
            string bin = Convert.ToString(a, 2);
            return bin;

        }
        
    }
    class Trojmian
    {
        double a, b, c;
        public Trojmian(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void czytaj_dane()
        {
           
                Console.WriteLine("Współczynnik a równania kwadratowego jest równy 0, wiec równanie kwadratowe jest rówaniem liniowym");
                double x = -c / b;
                Console.WriteLine("Jedno rozwiązanie: " + x);
            
        }
        public void Przetwór_Dane()
        {

            if (a == 0)
            {
                czytaj_dane();
            }
            else
            {
                double delta = (b * b) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Delta mniejsza od 0, rówanianie nie ma rozwiązań");
                }
                else if (delta == 0)
                {
                    double x1 = -b / 2 * a;
                    Console.WriteLine("Delta rówana 0, rówanie ma jedno rozwiązanie x: " + x1);
                }
                else
                {
                    double x1 = -b - (Math.Sqrt(delta)) / 2 * a;
                    double x2 = -b + (Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("Delta większa od 0, rówanie ma dwa rozwiązania x1: " + x1 + " x2: " + x2);
                }
            }
        }
    }
    
    class Prostopadloscian
    {
        public double a;
        public double b;
        public double h;

        public Prostopadloscian(double a,double b,double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }
        public double Objetosc()
        {
            double obj = a * b * h;
            return obj;
        }
        public double Pole()
        {
            double pp = a * b;
            double pb = 2 * (a * h) + 2 * (b * h);
            double pc = 2 * pp + pb;
            return pc;
        }
        public void Porownaj(Prostopadloscian a)
        {
            double objetoscA= Objetosc();
            double objetoscB = a.Objetosc();
            if(objetoscA>objetoscB)
            {
                Console.WriteLine("Objetość pierwszego prostopadloscianu jest wiekasza");
            }
            else if(objetoscB>objetoscA)
            {
                Console.WriteLine("Objetosc drugiego prostopadlosciany jest wieksza");
            }
            else
            {
                Console.WriteLine("Objetosci sa równe");
            }

        }
    }
    class Czasopima
    {
        public string tytul;
        public string wydawca;
        public int numer;
        public int naklad;
        public double cena;
        public const double rabbatStandardowy=0.03;
        public Czasopima(string tytul)
        {
            this.tytul = tytul;
        }
        public Czasopima(string tytul,string wydawca)
        {
            this.tytul = tytul;
            this.wydawca = wydawca;
        }
        public Czasopima(string tytul, string wydawca,int numer,int naklad,double cena)
        {
            this.tytul = tytul;
            this.wydawca = wydawca;
            this.numer = numer;
            this.naklad = naklad;
            this.cena = cena;

        }
        public void CenaPoRabacie()
        {
            double procent = this.cena * rabbatStandardowy;
            double nowaCena = this.cena - procent;
            Console.WriteLine("Cena czasopisma po rabacie: "+nowaCena);
        }
        public void CenaPoRabacie(double rabat)
        {
            double rabatProcent = rabat * 0.01;
            double rabarSum = rabatProcent + rabbatStandardowy;
            double procent = this.cena * rabarSum;
            double nowaCena = this.cena - procent;
            Console.WriteLine("Cena czasopisma po rabacie standardowym wynoszacym 3% oraz po dodatkowym rabacie podanym przez użytkownika: " + nowaCena); ;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            //Licz l1 = new Licz(5);
            //Console.WriteLine(l1.Dodaj(10));
            //Console.WriteLine(l1.Odejmin(10));
            //Zadanie2
            //Console.WriteLine( "Konwersja wartosci do liczb binarnych: " +Rzymskie.DoBinarnych(125)); 
            //Zadanie3
            Trojmian t1 = new Trojmian(4,-4,1);
            t1.Przetwór_Dane();
            //Zadanie 4
            //Prostopadloscian a = new Prostopadloscian(3, 4, 5);
            //Prostopadloscian b = new Prostopadloscian(5, 6, 5);
            //Console.WriteLine("Objetosc pierwszego prostopadloscianu: "+ a.Objetosc());
            //a.Porownaj(b);
            //Zadanie 5
            // Console.Write("Podaj nazwe czasopisma: ");
            // string nazwa = Console.ReadLine();
            // Console.Write("Podaj wydawce czasopisma: "); 
            // string wydawca = Console.ReadLine();
            //  Console.Write("Podaj numer czasopisma: ");
            //  int numer = int.Parse(Console.ReadLine());
            // Console.Write("Podaj naklad czasopisma: ");
            // int naklad = int.Parse(Console.ReadLine());


            //Console.Write("Podaj cene czasopisma: ");
            // double cena= double.Parse(Console.ReadLine());
            // while(cena<=0)
            // {
            //     Console.WriteLine("Podaj nowa cene:");
            //     cena = double.Parse(Console.ReadLine()); 
            // }
            // Czasopima c1 = new Czasopima(nazwa, wydawca,numer,naklad,cena);
            // c1.CenaPoRabacie();
            // c1.CenaPoRabacie(5);
            Console.ReadKey();
        }
    }
}
