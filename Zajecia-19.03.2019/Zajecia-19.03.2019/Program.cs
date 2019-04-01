using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_19._03._2019
{
    class Punkt
    {
        public double x;
        public double y;
        public Punkt(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        protected void PokazPunkt()
        {
            Console.WriteLine("Wspolrzedna x: "+this.x+" wspolrzedna y: "+this.y);
        }
    }
    class KolorowyPunnkt:Punkt
    {
        public void ZmienKolor(ConsoleColor k1)
        {
            Console.WriteLine("Wspolrzedne punktu ze standardowym kolorem");
            PokazPunkt();
            Console.ForegroundColor = k1;
            Console.WriteLine("Wspolrzedne punktu po zmianie koloru: ");
            PokazPunkt();
            
        }
        public KolorowyPunnkt(double x,double y):base( x, y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class PierwszaaKlasa
    {
        public int a;
        public int b;
        public PierwszaaKlasa(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        protected void Metoda()
        {
            Console.WriteLine("Pierwsza wartosc w pierwszej klasie wynosi: "+this.a+", druga wartosc wynosi: "+this.b);
        }
    }
    class DrugaKlasa:PierwszaaKlasa
    {
        public int c;
        public DrugaKlasa(int a,int b,int c):base(a,b)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Metoda1()
        {
            Metoda();
            Console.WriteLine("Wartosc Pola w drugiej klasie: "+this.c);
        }
        public void Metoda2()
        {
            Metoda();
            Console.WriteLine("Dodane wartosci: "+(this.a+this.b+this.c));
        }
        
    }
    class Zwierze
    {
        public string gatunek;
        public string pozyienie;
        protected void Wyswietl()
        {
            Console.WriteLine(this.gatunek+" je: "+this.pozyienie);
        }
    }
    class Pies:Zwierze
    {
        public string rasa;
        public string odglos;
        public Pies(string rasa,string odglos,string gatunek,string pozywienie)
        {
            this.rasa = rasa;
            this.odglos = odglos;
            this.gatunek = gatunek;
            this.pozyienie = pozywienie;
        }
        public void wyswietlPies()
        {
            Console.WriteLine("Rasa: "+this.rasa+", odglos: "+this.odglos);
            Wyswietl();
        }
    }
    class Kot : Zwierze
    {
        public string rasa;
        public string odglos;
        public Kot(string rasa, string odglos, string gatunek, string pozywienie)
        {
            this.rasa = rasa;
            this.odglos = odglos;
            this.gatunek = gatunek;
            this.pozyienie = pozywienie;
        }
        public void wyswietlKot()
        {
            Console.WriteLine("Rasa: " + this.rasa + ", odglos: " + this.odglos);
            Wyswietl();
        }
    }
    class Pracownik
    {
        public string imie;
        public string nazwisko;
        public long pesel;
        public string stanowisko;
        protected void WyswietlPolaKlasy()
        {
            Console.WriteLine("Imie: "+this.imie);
            Console.WriteLine("Nazwisko: "+this.nazwisko);
            Console.WriteLine("Pesel: "+this.pesel);
            Console.WriteLine("Stanowisko: "+this.stanowisko);
        }
    }
    class Programista:Pracownik
    {
        public string jezyk;
        public Programista(string imie,string nazwisko,long pesel,string stanowisko,string jezyk)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.stanowisko = stanowisko;
            this.jezyk = jezyk;
        }
        public void WyswietlInfo()
        {
            WyswietlPolaKlasy();
            Console.WriteLine("Jezyk programowania Programisty: "+this.jezyk);
        }
    }
    class Ksiegowy : Pracownik
    {
        public string wyksztalcenie;
        public string doswiadczenie;
        public Ksiegowy(string imie, string nazwisko, long pesel, string stanowisko, string wyksztalcenie,string doswiadczenie)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.stanowisko = stanowisko;
            this.wyksztalcenie = wyksztalcenie;
            this.doswiadczenie = doswiadczenie;
        }
        public void WyswietlInfo()
        {
            WyswietlPolaKlasy();
            Console.WriteLine("Wyksztalcenie ksiegowego: " + this.wyksztalcenie+", Doswiadczenie ksiegowego: "+this.doswiadczenie);
        }
    }
    class Telefon
    {
        public string Producent;
        public string Model;
        public double waga;
        public string wymiary;
        public string akumulator;
        public double czasDzaialania;
        public Telefon(string Producent, string Model,double waga,string wymiary,string akumulator,double czasDzialania)
        {
            this.Producent = Producent;
            this.Model = Model;
            this.waga = waga;
            this.wymiary = wymiary;
            this.akumulator = akumulator;
            this.czasDzaialania = czasDzialania;
        }
        public Telefon(string Producent,string Model)
        {
            this.Producent = Producent;
            this.Model = Model;
        }
        public void Wyswietl()
        {
            Console.WriteLine("Producent: "+this.Producent);
            Console.WriteLine("Model: "+this.Model);
            Console.WriteLine("Waga: "+this.waga);
            Console.WriteLine("Akumulator: "+this.akumulator);
            Console.WriteLine("Czas dzialania: "+this.czasDzaialania);
        }
    }
 /*Zadanie: Mamy dwie kasy (trzbe będzie korzystac z nowego wątku) 
  * jest jedna kolejka do obydwu kas. Sa tez klienci którzy robia zakupy przez losowy czas i jeśli skończa 
  * te zakupy to sa dodawani do kolejki. Klient jest obsługiwany przez okereskonnny czas a pozniej wycchodzi*/
    class TelefonDotykowy:Telefon
    {
        public string systemOperacyjny;
        public string TypRysika;
        public bool Wap;
        public TelefonDotykowy(string Producent, string Model, double waga, string wymiary, string akumulator, double czasDzialania, string systemOperacyjny,string typRysika, bool Wap) :base(Producent,Model,waga,wymiary,akumulator,czasDzialania)
        {
            this.Producent = Producent;
            this.Model = Model;
            this.waga = waga;
            this.wymiary = wymiary;
            this.akumulator = akumulator;
            this.czasDzaialania = czasDzialania;
            this.systemOperacyjny = systemOperacyjny;
            this.TypRysika = typRysika;
            this.Wap = Wap;
        }
        public void WyswietlDotykowy()
        {
            Wyswietl();
            Console.WriteLine("System Operacyjny: "+this.systemOperacyjny);
            Console.WriteLine("typ rysika: "+this.TypRysika);
            Console.WriteLine("Wap: "+this.Wap);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleColor kolor = ConsoleColor.Blue;
            //KolorowyPunnkt k1 = new KolorowyPunnkt(3, 4);
            //k1.ZmienKolor(kolor);
            //DrugaKlasa d1 = new DrugaKlasa(3, 4,5);
            //d1.Metoda1();
            //d1.Metoda2();
            //Pies p1 = new Pies("Owczarek", "szczekanie", "Pies", "Mieso");
            //Kot k1 = new Kot("Dachowiec", "miauczenie", "Kot", "Ryby");
            //p1.wyswietlPies();
            //k1.wyswietlKot();
            //Programista p1 = new Programista("Marian", "Kowalski", 89761506541, "Senior", "javaScript");
            //Ksiegowy k1= new Ksiegowy("Marian", "Kowalski", 89761506541, "Menedżer", "wyższe","duzo");
            //p1.WyswietlInfo();
            //k1.WyswietlInfo();
            TelefonDotykowy td1 = new TelefonDotykowy("Apple", "Iphone", 340, "12x34", "12345mAh", 12345, "IOS", "brak", true);
            Telefon t1 = new Telefon("Telefon", "Model");
            Telefon t2 = new Telefon("Telefon1", "Model1", 213, "123x12", "2345mAh", 1234);
            td1.WyswietlDotykowy();
            t1.Wyswietl();
            t2.Wyswietl();
            Console.ReadKey();
        }
    }
}
