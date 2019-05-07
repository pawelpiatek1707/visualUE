using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_przed_2_kolosem
{
    //Dziedziczenie
    class PierwszaKlasa
    {
        public int a, b;
        
        protected void Wyswietl()
        {
            Console.WriteLine("Wartosc a: "+this.a+", wartosc b: "+this.b);
        }
        
    }
     class DrugaKlasa: PierwszaKlasa
    {
        public int c;
        public void Wyswietl1()
        {
            Console.WriteLine("Wartosc a: "+this.a+", wartosc b: "+this.b+", wartosc c: "+this.c);
        }
        public void Sumuj()
        {
            Console.WriteLine("Suma wartosci: "+(this.a+this.b+this.c));
        }

    }
    class Zwierze
    {
        protected string gatunek, pokarm;
        protected void Informacje()
        {
            Console.WriteLine(this.gatunek+" je "+this.pokarm);
        }

    }
    class Pies : Zwierze
    {
        public string rasa, odglos;

        public Pies(string rasa,string odglos,string gatunek,string pokarm)
        {
            this.rasa = rasa;
            this.odglos = odglos;
            this.gatunek = gatunek;
            this.pokarm = pokarm;
        }

        public void InfoPies()
        {
            Console.WriteLine("Pies rasy: "+this.rasa+",wydaje odglos: "+this.odglos);
            Informacje();
        }
    }
    //Dziedziczenie z 2 konstrruktorami 
    class Telefon
    {
        public string producent, model, aumulator, czasCzuwania,wymiary;
        public double waga;
        public Telefon(string producent,string model,string akumulator,string czasCzuwania,string wymiary,double waga)
        {
            this.producent = producent;
            this.model = model;
            this.aumulator = akumulator;
            this.czasCzuwania = czasCzuwania;
            this.wymiary = wymiary;
            this.waga = waga;
        }
    }
    class TelefonDotykowy:Telefon
    {
        public string system, typRysika;
        public bool WAP;
        public TelefonDotykowy(string producent, string model, string akumulator, string czasCzuwania, string wymiary, double waga,
            string system,string typRysika,bool WAP):base(producent,model,akumulator,czasCzuwania,wymiary,waga)
        {
            this.producent = producent;
            this.model = model;
            this.aumulator = akumulator;
            this.czasCzuwania = czasCzuwania;
            this.wymiary = wymiary;
            this.waga = waga;
            this.system = system;
            this.typRysika = typRysika;
            this.WAP = WAP;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //PierwszaKlasa k1 = new PierwszaKlasa();
            //k1.a = 4;
            //k1.b = 5;
            //DrugaKlasa k2 = new DrugaKlasa();
            //k2.b = 5;
            //k2.Wyswietl1();
            Pies p1 = new Pies("Owcarek","szczekanie","pies","karma");
            p1.InfoPies();
            Console.ReadKey();
        }
    }
}
