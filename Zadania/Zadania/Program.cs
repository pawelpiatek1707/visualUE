﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{

    //Zadanie 1
     class KlasaBazowa
    {
        public   virtual void Test()
        {
            Console.WriteLine("To jest wersja bazowa metody wirtualnej");
        }
    }
    class KlasaDziediczaca:KlasaBazowa
    {
        public override void Test()
        {
            base.Test();
            Console.WriteLine("Wersja nadpisana metody z klasy bazowej");
        }
    }
    //Zadanie 2
    class Figury
    {
        public double bokKwadrat;
        public double xProstokat;
        public double yProstokat;
        public double r;
        public double trojkatPodstawa;
        public double trojkatWysokosc;

        public virtual void Wyswietl()
        {
            Console.WriteLine("Pole figury wynosi: ");
        }
    
    }
    class Kwadrat : Figury
    {
        public const string nazwa = "kwadrat";
        public Kwadrat(double bok)
        {
            bokKwadrat = bok;
        }
        public double Pole()
        {
            return bokKwadrat * bokKwadrat;
        }
        public override void Wyswietl()
        {
            Console.WriteLine("Pole "+nazwa+" wynosi: "+Pole());
            
        }
        
    }
    class Prostokat : Figury
    {
        public const string nazwa = "prostokat";
        public Prostokat(double bokX,double bokY)
        {
            xProstokat = bokX;
            yProstokat = bokY;
        }
        public double Pole()
        {
            return xProstokat * yProstokat;
        }
        public override void Wyswietl()
        {
            Console.WriteLine("Pole " + nazwa + " wynosi: " + Pole());

        }
    }
   
    class Kolo : Figury
    {
        public const string nazwa = "kolo";
        public Kolo(double r)
        {
            this.r = r;
        }
        public double Pole()
        {
            return Math.PI * r * r;
        }
        public override void Wyswietl()
        {
            Console.WriteLine("Pole " + nazwa + " wynosi: " + Pole());

        }
    }
    class TrojkatProstokatny : Figury
    {
        public const string nazwa = "trojkat prostokatny";
        public TrojkatProstokatny(double a,double h)
        {
            trojkatPodstawa = a;
            trojkatWysokosc = h;
        }
        public double Pole()
        {
            return trojkatWysokosc * trojkatPodstawa / 2;
        }
        public override void Wyswietl()
        {
            Console.WriteLine("Pole " + nazwa + " wynosi: " + Pole());

        }
    }
    //Zadanie 3
    class Osoba
    {
        public string nazwisko;
        public string imie;
        public string ulica;
        public string kod;
        public string miasto;

        public virtual void Wczytaj()
        {
            Console.Write("Podaj nazwisko: ");
            this.nazwisko = Console.ReadLine();
            Console.Write("Podaj imie: ");
            this.imie = Console.ReadLine();
            Console.Write("Podaj ulice: ");
            this.ulica = Console.ReadLine();
            Console.Write("Podaj kod pocztowy: ");
            this.kod = Console.ReadLine();
            Console.Write("Podaj miasto: ");
            this.miasto = Console.ReadLine();
            Console.Clear();
        }

        public virtual void Wyswietl()
        {
            Console.WriteLine("Nazwisko: "+this.nazwisko);
            Console.WriteLine("Imie: "+this.imie);
            Console.WriteLine("Ulica: "+this.ulica);
            Console.WriteLine("Kod pocztowy: "+this.kod);
            Console.WriteLine("Miasto: "+this.miasto);
        }
    }
    class Kadra:Osoba
    {
        public string wykształcenie;
        public string stanowisko;

        public override void Wczytaj()
        {
            base.Wczytaj();
            Console.Write("Podaj wyksztalcenie: ");
            this.wykształcenie = Console.ReadLine();
            Console.Write("Podaj stanowisko: ");
            this.stanowisko = Console.ReadLine();
        }
        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.WriteLine("Wykształcenie: "+this.wykształcenie);
            Console.WriteLine("Stanowisko: "+this.stanowisko);
        }
    }
    //Zadanie 4
    class Pracownik
    {
        public virtual void Pracuje()
        {
            Console.WriteLine("Pracuje jak kazdy");
        }
    }
    class DyrektorNaczelny:Pracownik
    {
        public override void Pracuje()
        {
            Console.WriteLine("Pracuje inaczej niz wszyscy");
        }
    }
    class DyrektorZwykly:DyrektorNaczelny
    {
        public override void Pracuje()
        {
            Console.WriteLine("Nigdy nie pracuje, tylko liczy pieniadze");
        }
    }
    //Zadanie 5
    class Pracownik1
    {
        public string imie;
        public string nazwisko;
        public int nip;
        public string  dataUrodzenia;
        public string  dataZatrudnienia;
        public double  pensja;
        public string  dzial;

        public Pracownik1(string imie,string nazwisko,int nip,string dataUrodzenia,string dataZatrudnienia, double pensja,string dzial)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.nip = nip;
            this.dataUrodzenia = dataUrodzenia;
            this.dataZatrudnienia = dataZatrudnienia;
            this.pensja = pensja;
            this.dzial = dzial;
        }
        public virtual void Info()
        {
            Console.WriteLine("Imie: "+this.imie);
            Console.WriteLine("Nazwisko: "+this.nazwisko);
            Console.WriteLine("Nio: "+this.nip);
            Console.WriteLine("Data urodzenia: "+this.dataUrodzenia);
            Console.WriteLine("Data zatrudnienia: "+this.dataZatrudnienia);
            Console.WriteLine("Pensja: "+this.pensja);
            Console.WriteLine("Dział: "+this.dzial);
        }
    }
    class Kierownik:Pracownik1
    {
        public int iloscPodwladnych;
        public string typKierownictwa;
        public double dodatekFunkcyjny;

        public Kierownik(string imie, string nazwisko, int nip, string dataUrodzenia, string dataZatrudnienia, double pensja, string dzial,int iloscPodwladnych, string typKierownictwa,double dodatekFunkcyjny):base( imie,  nazwisko,  nip,  dataUrodzenia,  dataZatrudnienia,  pensja,  dzial)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.nip = nip;
            this.dataUrodzenia = dataUrodzenia;
            this.dataZatrudnienia = dataZatrudnienia;
            this.pensja = pensja;
            this.dzial = dzial;
            this.iloscPodwladnych = iloscPodwladnych;
            this.typKierownictwa = typKierownictwa;
            this.dodatekFunkcyjny = dodatekFunkcyjny;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Ilosc podwladnych: "+this.iloscPodwladnych);
            Console.WriteLine("Typ kierownictwa: "+this.typKierownictwa);
            Console.WriteLine("Dodatek funkcyjn: "+this.dodatekFunkcyjny);
        }

        


    }
    //Zadanie 6
    class Komputer
    {
        public string producent;
        public string model;
        public string plutaGlowna;
        public string procesor;
        public string kartaGraficzna;
        public string dyskTwardy;

        public Komputer(string producent, string model, string plytaGlowna,string procesor, string kartaGraficzna,string dyskTwardy)
        {
            this.producent = producent;
            this.model = model;
            this.plutaGlowna = plytaGlowna;
            this.procesor = procesor;
            this.kartaGraficzna = kartaGraficzna;
            this.dyskTwardy = dyskTwardy;

        }

        public virtual void Info()
        {
            Console.WriteLine("Producent: "+this.producent);
            Console.WriteLine("Model: "+this.model);
            Console.WriteLine("Płyta główna: "+this.plutaGlowna);
            Console.WriteLine("Procesor: "+this.procesor);
            Console.WriteLine("Karta graficzna: "+this.kartaGraficzna);
            Console.WriteLine("Dysk twardy: "+this.dyskTwardy);
        }

    }
    class KomputerPrzenosny:Komputer
    {
        public double waga;
        public string bateria;
        public bool bluetooth;

        public KomputerPrzenosny(string producent, string model, string plytaGlowna, string procesor, string kartaGraficzna, string dyskTwardy, double waga,string bateria,bool bluetooth):base( producent,  model,  plytaGlowna,  procesor,  kartaGraficzna,  dyskTwardy)
        {
            this.producent = producent;
            this.model = model;
            this.plutaGlowna = plytaGlowna;
            this.procesor = procesor;
            this.kartaGraficzna = kartaGraficzna;
            this.dyskTwardy = dyskTwardy;
            this.waga = waga;
            this.bateria = bateria;
            this.bluetooth = bluetooth;

        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Waga: "+this.waga);
            Console.WriteLine("Bateria: "+this.bateria);
            Console.WriteLine("Bluetooth: "+this.bluetooth);
        }


    }
    //Zadanie 7
    class PracownikZadanie7
    {
        public double pensja;
        public const double kwota = 1000;

        public virtual void Wyplata()
        {
            double wyplata = this.pensja * 4 - kwota;
            Console.WriteLine("Pensja podstawowa dla kazdego pracownika: "+wyplata);
        }
    }
    class Programista:PracownikZadanie7
    {
        public double premia;
        public override void Wyplata()
        {
            double wyplata = this.pensja * 4 - kwota + this.premia;
            Console.WriteLine("Pensja podstawowa dla kazdego pracownika: " + wyplata);
        }
    }
    //Zadanie 8
    abstract class Samochod
    {
        public double predkosc;
        public string paliwo;
        public int drzwi;
        public int kola;
        abstract public void Jade();
        abstract public void Przyczepa();
        public virtual void Paliwo()
        {
            Console.WriteLine("Rodzaj paliwa: "+this.paliwo);
        }
        public virtual void Drzwi()
        {
            Console.WriteLine("Ilosc drzwi: "+this.drzwi);
        }
        public virtual void Kola()
        {
            Console.WriteLine("Liczba kol: "+this.kola);
        }
    }
    class Ciezarowka : Samochod
    {
        public override void Jade()
        {
           
            Console.WriteLine("Jestem ciezarowka");
        }
        public override void Przyczepa()
        {
            Console.WriteLine("Mam naczepe");
        }
        public override void Drzwi()
        {
            Console.WriteLine("Nie mam drzwi");
        }
    }
    class Osobowka: Samochod
    {
        public override void Jade()
        {

            Console.WriteLine("Jestem Osobowka");
        }
        public override void Przyczepa()
        {
            Console.WriteLine("Nie mam naczepy");
        }
        public override void Kola()
        {
            Console.WriteLine("Nie mam kół");
        }
    }
    class Hybryda : Samochod
    {
        public override void Jade()
        {
            Console.WriteLine("Jade bardzo szybko");
        }

        public override void Przyczepa()
        {
            Console.WriteLine("Jade duzo szybciej gdy nie mam przyczepy");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            //KlasaBazowa k1 = new KlasaBazowa();
            //KlasaDziediczaca k2 = new KlasaDziediczaca();
            //k1.Test();
            //Console.WriteLine("---------------");
            //k2.Test();
            //
            //Zadanie 2
            //Kwadrat k1 = new Kwadrat(5);
            //k1.Wyswietl();
            //Prostokat p1 = new Prostokat(3, 4);
            //p1.Wyswietl();
            //Kolo k2 = new Kolo(3);
            //k2.Wyswietl();
            //TrojkatProstokatny t1 = new TrojkatProstokatny(4, 4);
            //t1.Wyswietl();
            //Zadanie 3
            //Osoba o1 = new Osoba();
            //o1.Wczytaj();
            //o1.Wyswietl();
            //Kadra k1 = new Kadra();
            //k1.Wczytaj();
            //k1.Wyswietl();
            //Zadanie 4
            //Pracownik p1 = new Pracownik();
            //p1.Pracuje();
            //DyrektorNaczelny d1 = new DyrektorNaczelny();
            //d1.Pracuje();
            //DyrektorZwykly d2 = new DyrektorZwykly();
            //d2.Pracuje();
            Console.ReadKey();
        }
    }
}
