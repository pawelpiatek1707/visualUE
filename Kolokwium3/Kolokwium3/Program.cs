using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Kolokwium3
{
    //-----------------------
    public class testowa
    {
        public int a;
    }

   //------------------------
    //Zadanie 1 i Zadanie 2
    [Serializable]
    public class Samochod
    {
        public string marka, model,nadwozie;
        public double rok_produkcji, pojemnosc_silnika, liczba_miejsc, liczba_drzwi;
        public Samochod()
        {

        }
        public Samochod(string marka,string model,string nadwozie,double rok_produkcj, double pojemnosc_silnika,double liczba_miejsc,
         double liczba_drzwi)
        {
            this.marka = marka;
            this.model = model;
            this.rok_produkcji = rok_produkcj;
            this.pojemnosc_silnika = pojemnosc_silnika;
            this.liczba_miejsc = liczba_miejsc;
            this.liczba_drzwi = liczba_drzwi;

        }

        public void Moje_dane()
        {
            Console.WriteLine("Marka: "+this.marka);
            Console.WriteLine("Model: "+this.model);
            Console.WriteLine("Rok produkcji: "+this.rok_produkcji);
            Console.WriteLine("Pojemność silnika "+this.pojemnosc_silnika);
            Console.WriteLine("Liczba miejsc "+this.liczba_miejsc);
            Console.WriteLine("Liczba drzwi "+this.liczba_drzwi);
        }

        public void Jade(string znak, int kolumny, int wiersze)
        {
            for (int i = 0; i < kolumny; i++)
            {
                for (int j = 0; j < wiersze; j++)
                {
                    Console.Write(znak);
                }
                Console.WriteLine();
            }
        }
    }
    //Zadanie 3
    class Ulamek
    {
        public double licznik, mianownik;
        public Ulamek(double licznik,double mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Ułamek: " +this.licznik+"/"+this.mianownik);
        }

        public static Ulamek operator * (Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.licznik * u2.licznik, u1.mianownik * u2.mianownik);
        }

        public static implicit  operator double(Ulamek u1)
        {
            return u1.licznik / u1.mianownik;
        }
            
    }
    //Zadanie 4
    class Osoba
    {
        public string imie, nazwisko;

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public static Malzenstwo operator +(Osoba o1, Osoba o2)
        {
            return new Malzenstwo(o1.imie, o1.nazwisko, o2.imie, o2.nazwisko);
        }


    }
    class Malzenstwo
    {
        public string imieZony, nazwiskoZony, imieMeza, nazwiskoMeza;

        public Malzenstwo(string imieZony, string nazwiskoZony, string imieMeza, string nazwiskoMeza)
        {
            this.imieZony = imieZony;
            this.nazwiskoZony = nazwiskoZony;
            this.imieMeza = imieMeza;
            this.nazwiskoMeza = nazwiskoMeza;
        }

        public void WyswietlDane()
        {
            Console.WriteLine("Imie Zony: "+this.imieZony);
            Console.WriteLine("Nazwisko Zony: "+this.nazwiskoZony);
            Console.WriteLine("Imie Meza: " + this.imieMeza);
            Console.WriteLine("Nazwisko Meza: " + this.nazwiskoMeza);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            //Samochod s1 = new Samochod("Skoda", "Octavia", "Liftback", 2008, 1.9d, 5, 5);
            //s1.Moje_dane();
            //s1.Jade("@", 4, 4);
            //XmlSerializer xs = new XmlSerializer(typeof(Samochod));
            //Stream path = File.Create("samochod1.xml");
            //xs.Serialize(path, s1);
            //Zadanie 2
            //Samochod s2;
            //XmlSerializer xd = new XmlSerializer(typeof(Samochod));
            //Stream path1 = File.OpenRead("samochod1.xml");
            //s2 = (Samochod)xd.Deserialize(path1);
            //s2.Moje_dane();
            //s2.Jade("*", 4, 4);
            //Zadanie 3
            //Ulamek u1 = new Ulamek(1, 2);
            //u1.Wyswietl();
            //Console.WriteLine("Konwersja na double");
            //Console.WriteLine((double)u1);
            //Ulamek u2 = new Ulamek(1, 3);

            //u2.Wyswietl();
            //Console.WriteLine("Konwersja na double");
            //Console.WriteLine((double)u2);
            //Ulamek u3 = u1 * u2;
            //Console.WriteLine("Wynik mnożenia");
            //u3.Wyswietl();
            //Console.WriteLine("Konwersja na double");
            //Console.WriteLine((double)u3);
            //Zadanie 4
            Osoba o1 = new Osoba("Kamil", "Ślimak");
            Osoba o2 = new Osoba("Halina", "Nowak");
            Malzenstwo m1 = o2 + o1;
            m1.WyswietlDane();
            
            Console.ReadKey();
        }
    }
}
