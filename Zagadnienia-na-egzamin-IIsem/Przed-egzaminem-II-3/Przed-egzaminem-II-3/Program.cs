using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przed_egzaminem_II_3
{
    /*
     * 1. Konstruktor statyczny
     * 2. Konstruktor prywatny
     * 3. Seald
     * 4. Kllasy abstrakcyjne, interfejst, metody wirtualne
     * 5. Enum
     * */
    //1. Konstruktor statyczny
    class Osoba
    {
        public string imie, nazwisko;
        public int wiek;
        static readonly double data;

        public double PodajDate()
        {
            return data;
        }

        static  Osoba()
        {
            data = DateTime.Now.Ticks;
        }
    }
    //2. Konstruktor prywatny
    // - Nie można dziedziczyć po klasach mających jedynie konstruktor prywatny
    // - Jeśli klasa posiada jeden bądź kilka konstruktorów prywatnych oraz nie posada konstruktora publicznego to inne klasy nie moga tworzyć obiektów tej klasy
    // - Gdy klasa posiada konstruktor prywatny nie można dodać konstruktora poblicznego nie przyjmującego parametrów
    class Car
    {
        // w tej klasie nie ma konstruktora publicznego
        private Car()
        {

        }
        public void Info()
        {
            Console.WriteLine("Informacje o klasie Car");
            
        }
        public static Car NowaInstancja()
        {
            return new Car();
        }
    }
    //3. Seald
    class X
    {
        protected virtual void Metoda() { Console.WriteLine("Metoda klasy X"); }
    }
    class Y : X {
        sealed protected override void Metoda() { Console.WriteLine("Przysłonięta metoda z klasy X:"); } //pieczętujemy metode
    }
    class Z : Y
    {
       // protected override void Metoda() { Console.WriteLine("Przysłonięta metoda z klasy Y"); } // nie można tego wykonać ponieważ zapieczętowaliśmy tą metodę
    }
    //4. Klasy abstrakcyjne, interfejsy, metody wirtualne
    abstract class Pralka
    {
        private int rozmiarPrania; // klasa abstrakcyjna może zawierać pola a interfejs nie 
        private int predkoscWirowania;

        public Pralka()
        {

        }

        //abstract protected void Pranie()
        //{
                                        //taka konstrukcja jest niemożliwa, ponieważ jest to klasa abstrakcyjna i może zawierać jedynie deklaracje metod
        //}                             // bez ich definicji 

        abstract protected void Pranie();
        abstract protected void Plukanie(int rozmiarPrania);
        abstract protected void Wirowanie(int predkoscWirowania);
        

    }
    public interface Bazowy
    {
        void Info();
    }
    public interface Pracz:Bazowy
    {
         void Zadanie();
    }
    class Pralki : Pralka,Pracz
    {
        protected  override void Pranie()
        {

        }
        protected override void Plukanie(int rozmiarPrania)
        {

        }
        protected override void Wirowanie(int predkoscWirowania)
        {

        }
        void Pracz.Zadanie()
        {
            Console.WriteLine("Zadanie pracza");
        }
        void Bazowy.Info() // przy definiowaniu metody z bazowego interfejsu, przy jawnej implementacji używamy nazwy interfejsu bazowego
        {

        }
    }
    class KlasaBazowa
    {
        public int x;
        public KlasaBazowa(int x)
        {
            this.x = x;
        }
        public virtual void Metoda()
        {
            Console.WriteLine("Metoda z klasy bazwoej");
        }
    }
    class KlasaPochodna : KlasaBazowa
    {
        public int x, y;
        public override void Metoda()
        {
            Console.WriteLine($"Metoda z klasy pochodnej, wartości: {this.x}, {this.y}");
        }
        public KlasaPochodna(int x,int y):base(x) //w inicjalizatorze base pokazujemy co jest z klasy bazowej 
        {
            this.x = x;
            this.y = y;
        }
    }
  
    
    class Program
    {
        public enum Kierunek {Brak=0, Lewo=1, Prawo=2, Gora=4, Dol=8 }; // po"=" przypisujemy wartość skojarzoną dla enum
                                                                        // Wartość dla wartości skojarzonych domyślnie zaczyna sie od 0 i jest inkrementowana z każdym elementem
                                                                        // Jeżeli chcemy składac enum to warto wartościom skojarzonym przypisywać wielokrotości 2
                                                                        //Wartości skojarzone są domyślnie typu int. Można zmienić ta wartość
        
        static void Main(string[] args)
        {
            //1. Konstruktor statyczny
            //Osoba o1 = new Osoba();
            //Console.WriteLine(o1.PodajDate());
            //Osoba o2 = new Osoba();
            //=======================================
            //2. Konstruktor prywatny
            //Car c1 = new Car(); - nie można tego zrobić ponieważ nie ma on publicznego konstruktora instancjii
            //Car c2;
            //c2 = Car.NowaInstancja(); // można tworzyć instancje takiej klasy za pomoca metody statycznej, która zawiera mechanizm tworzenia obiektu
            //c2.Info();
            //=================================================
            //4. Klasy abstrakcyjne, interfejsy, metody wirtualne
            //Pralka p1 = new Pralka(); // - nie można utworzyć instancji klasy abtrakcyjnej
            //Pralki p1 = new Pralki();
            //((Pracz)p1).Zadanie(); // przy wywołaniu należy zrzutować na typ interfejsu 
            //KlasaBazowa k1 = new KlasaBazowa(3);
            //k1.Metoda();
            //KlasaPochodna k2 = new KlasaPochodna(3, 4);
            //k2.Metoda();
            //===========================================================
            //5.Enums
            Kierunek aktualny = Kierunek.Gora;
            if(aktualny == Kierunek.Gora)
            {
                Console.WriteLine("kierujesz sie w górę");
            }

            int a = (int)Kierunek.Gora; // Rzutowanie enuma na wartość iczbową
            Console.WriteLine(a);

            Kierunek kierunekPoKonwersji = (Kierunek)a; // Rzutowanie z inta na enum

            Console.WriteLine(kierunekPoKonwersji);
            //Skłądanie typów wyliczeniowych

            Kierunek prawoGora = Kierunek.Prawo | Kierunek.Gora; // Operator "|" dodaje wartości skojarzone
            Kierunek dolLewo = Kierunek.Dol & Kierunek.Lewo;
            Console.WriteLine(prawoGora);
            Console.WriteLine(dolLewo);



            
            Console.ReadKey();
        }
    }
}
