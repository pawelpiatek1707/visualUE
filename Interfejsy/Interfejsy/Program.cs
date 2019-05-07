using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy
{
    //Zadanie 1
    public interface Zadanie1
    {
          void Metoda();
    }
    public class Klasa1: Zadanie1
    {
        public void Metoda()
        {
            Console.WriteLine("Przykładowa implementacja interfejsu");
        }
    }
    //Zadanie 2
    public interface IPokaz
    {
         void Pokaz();
    }
    public class Punkt:IPokaz
    {
        public double x,y;
        public Punkt(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Pokaz()
        {
            Console.WriteLine("Wspolrzedna x punktu: "+this.x+", współrzędna y punktu: "+this.y);
        }
    }
    //Zadanie 3
    public interface Rodzic
    {
        void MetodaRodzic();
    }
    public interface Dziecko:Rodzic
    {
        void MetodaDziecko();
    }
    public class Klasa3:Dziecko
    {
        public void MetodaRodzic()
        {
            Console.WriteLine("Metoda Rodzica");
        }
        public void MetodaDziecko()
        {
            Console.WriteLine("Metoda Dziecka");
        }
    }
    //Zadanie 4
    public interface ISamochod1
    {
         string Marka { get; set; }
         void Jade();
    }
    public interface ISamochod2
    {
        string Model { get; set; }
        int Rok { get; set; }
        void Stoje();
    }
    public class Samochod:ISamochod1,ISamochod2
    {
        private string marka;
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int rok;
        public int Rok
        {
            get { return rok; }
            set { rok = value; }
        }
        public Samochod(string marka,string model,int rok)
        {
            this.marka = marka;
            this.model = model;
            this.rok = rok;
        }
        public void Jade()
        {
            Console.WriteLine("Samochod jedzie");
        
        }
        public void Stoje()
        {
            Console.WriteLine("Samochod stoi");
        }
        public void Wypisz()
        {
            Console.WriteLine("Marka: "+this.Marka);
            Console.WriteLine("Model: "+this.Model);
            Console.WriteLine("Rok produkcji: "+this.Rok);
        }
    }
    //Zadanie 5
    public class Ksiazka
    {
        public string tytul, autor;
        public int rokWydania;
        private int Id;
       
    }
    public class Bibliotekarz:IBibliotekarz
    {
        public string imie, nazwisko;
        private int Id;
        public void DodajKsiazke()
        {
            Console.WriteLine("Dodano ksiazke");
        }
        public void ModyfikujKsiazke()
        {
            Console.WriteLine("Zmodyfikowano ksiazke");
        }
        public void DodajWypozyczajacego()
        {
            Console.WriteLine("Dane wypozyczajcego");
        }
        public void WyswietlInfoKsiazka()
        {
            Console.WriteLine("Informacje o ksiazce");
        }
    }
    public class Wypozyczajacy:IWypozyczajcy
    {
        public string imie, nazwisko, adres;
        private int Id;
        public void WyswietlInfoKsiazka()
        {
            Console.WriteLine("Informacje o ksiazce");
        }
        public void WyswietlInfoWypozyczajocy()
        {
            Console.WriteLine("Informacje o wypozyczajżacym");
        }
        public void Zamow()
        {
            Console.WriteLine("Zamowiono ksiazke");
        }
    }
    interface IBibliotekarz
    {
        void DodajKsiazke();
        void ModyfikujKsiazke();
        void WyswietlInfoKsiazka();
        void DodajWypozyczajacego();
    }
    interface IWypozyczajcy
    {
        void WyswietlInfoKsiazka();
        void WyswietlInfoWypozyczajocy();
        void Zamow();
    }
    //Zadanie 6
    public struct KandydatNaStudia
    {
        public string nazwisko;
        public int punktyMatematyka, punktyInformatyka, punktyJezyk;
        public void Punkkty()
        {
            
            double punkty = 0.6 * this.punktyMatematyka + 0.5 * this.punktyInformatyka + 0.2 * this.punktyJezyk;
            Console.WriteLine("Punkty studenta "+this.nazwisko+" do rekrutacji: "+punkty);
        }
    }
    //Zadanie 7
    public enum Tydzien
    { poniedzialek=1,
        wtorek,
        sroda, czwartek,
        piatek,
        sobota,
        niedziela

    };
    public enum TydzinSkrot
    {
        pon=1,
        wt,
        sr,
        czw,
        pt,
        sob,
        nd
    }
    public enum typTrasy {0.8,1,1.3};
    //Zadanie 8
    class SamochodZadanie8
    {
        public string  nrVin,Nazwa;
        public int Rocznik;
        public float srednieSpalanie, pojemnoscSilnika;
        
        public SamochodZadanie8(float pojemnoscSilnika, string nrVin, int rocznik,string nazwa,float srednieSpalanie)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.nrVin = nrVin;
            this.Rocznik = rocznik;
            this.Nazwa = nazwa;
            this.srednieSpalanie = srednieSpalanie;
        }
        public void Create()
        {
            SamochodZadanie8 s1 = new SamochodZadanie8(1.9f, "asdfvc24432", 2008, "bmw", 6.0f);
            SamochodZadanie8 s2 = new SamochodZadanie8(1.5f, "asdadsa4432", 2010, "hinda", 7.0f);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            //Klasa1 K1 = new Klasa1();
            //K1.Metoda();
            //Zadanie 2
            //Punkt p1 = new Punkt(3, 4);
            //p1.Pokaz();
            //Zadanie 3
            //Klasa3 k3 = new Klasa3();
            //k3.MetodaDziecko();
            //k3.MetodaRodzic();
            //Zadanie 4
            //Samochod s1 = new Samochod("BMW","E46",2008);
            //s1.Jade();
            //s1.Stoje();
            //s1.Wypisz();
            //Zadanie 6
            //int liczbaStudentow = 2;
            //KandydatNaStudia[] tablicaKandydaci = new KandydatNaStudia[liczbaStudentow];

            //for (int i = 0; i < liczbaStudentow; i++)
            //{
            //    Console.Write("Podaj nazwisko studenta: ");
            //    tablicaKandydaci[i].nazwisko = Console.ReadLine();
            //    Console.Write("Podaj punkty z matematyki: ");
            //    tablicaKandydaci[i].punktyMatematyka = int.Parse(Console.ReadLine());
            //    Console.Write("Podaj punkty z informatyki: ");
            //    tablicaKandydaci[i].punktyInformatyka = int.Parse(Console.ReadLine());
            //    Console.Write("Podaj punkty z jezyka: ");
            //    tablicaKandydaci[i].punktyJezyk = int.Parse(Console.ReadLine());
            //}
            //Console.Clear();
            //for (int i = 0; i < liczbaStudentow; i++)
            //{
            //    tablicaKandydaci[i].Punkkty();
            //}
            //Zadanie 7
            Console.Write("Podaj dzien tygodnia : ");
             string dzienString = Console.ReadLine();

            int dzien = int.Parse(Console.ReadLine());
            Tydzien aaa = Tydzien.dzien
            Tydzien dzienTygodnia = (Tydzien)dzien;
            TydzinSkrot dzienTygodaniSkrot = (TydzinSkrot)dzien;
            Console.WriteLine(dzienTygodaniSkrot);



            Console.ReadKey();
        }
    }
}
