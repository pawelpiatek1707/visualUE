using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium2
{
    //Zadanie 1
    class Sprzedawca
    {
        public string imie, nazwisko, dzial;
        public int kodSprzedawcy, doKiedyZatrudniony;
        public double wynagrodzenie;
        public Sprzedawca(string imie, string nazwisko, string dzial, int kodSprzedawcy, int doKiedyZatrudniony, double wynagrodzenie)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dzial = dzial;
            this.kodSprzedawcy = kodSprzedawcy;
            this.doKiedyZatrudniony = doKiedyZatrudniony;
            this.wynagrodzenie = wynagrodzenie;
        }

        public virtual void Info()
        {
            Console.WriteLine("Imie: " + this.imie);
            Console.WriteLine("Nazwisko: " + this.nazwisko);
            Console.WriteLine("Dział: " + this.dzial);
            Console.WriteLine("Kod sprzedawcy: " + this.kodSprzedawcy);
            Console.WriteLine("Do kiedy zatrudniony: " + this.doKiedyZatrudniony);
            Console.WriteLine("Wynagrodzenie: " + this.wynagrodzenie);

        }

    }
    class KierownikSprzedazy : Sprzedawca
    {
        public string uprawnienia;
        public double dodatekFunkcyjny;//%

        public KierownikSprzedazy(string imie, string nazwisko, string dzial, int kodSprzedawcy, int doKiedyZatrudniony,
            double wynagrodzenie, string uprawnienia, double dodatekFunkcyjny)
            : base(imie, nazwisko, dzial, kodSprzedawcy, doKiedyZatrudniony, wynagrodzenie)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dzial = dzial;
            this.kodSprzedawcy = kodSprzedawcy;
            this.doKiedyZatrudniony = doKiedyZatrudniony;
            this.wynagrodzenie = wynagrodzenie;

            this.uprawnienia = uprawnienia;
            this.dodatekFunkcyjny = dodatekFunkcyjny;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Uprawnienia: " + this.uprawnienia);

            Console.WriteLine("Dodatek funkcyjny: " + this.dodatekFunkcyjny * 100 + "%");
        }

        public void Placa()
        {
            double premia = this.wynagrodzenie * this.dodatekFunkcyjny;
            double ostateczneWynagrodzenie = this.wynagrodzenie + premia;
            Console.WriteLine("Wynagrodzenie z uwzglednieniem premii: " + ostateczneWynagrodzenie);
        }
    }
    //Zadanie 2
    struct Osoba
    {
        public string imie, nazwisko;
        public int wiek;

        public void PobierzOsobe()
        {
            Console.Write("Podaj imie: ");
            string imie = Console.ReadLine();
            this.imie = imie;
            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();
            this.nazwisko = nazwisko;
            Console.Write("Podaj wiek: ");
            int wiek = int.Parse(Console.ReadLine());
            this.wiek = wiek;
        }
        public void WypiszOsobe()
        {
            Console.Clear();
            Console.WriteLine("-----Dane Osoby-----");
            Console.WriteLine("Imie: " + this.imie);
            Console.WriteLine("Nazwisko: " + this.nazwisko);
            Console.WriteLine("Wiek: " + this.wiek);
        }
    }
    //Zadanie 3
    public interface IRecepcjonista
    {
        void DodajLekarza();
        void ModyfikujLekarza();
        void InfoLekarz();
        void DodajPacjenta();
        void PrzypiszPacjenta();
    }
    public interface IPacjent
    {
        void InfoLekarz();
    }
    class Lekarz
    {
        public string imie, nazwisko, specjalizacja;
        public int id;
        public Lekarz(string imie, string nazwisko, string specjalizacja, int id)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.specjalizacja = specjalizacja;
            this.id = id;
        }
    }
    class Pacjent : IPacjent
    {
        public string imie, nazwisko, adres, lekarzRodzinny;
        public int id;
        public Pacjent(string imie, string nazwisko, string adres, string lekarzRodzinny, int id)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adres = adres;
            this.lekarzRodzinny = lekarzRodzinny;
            this.id = id;
        }

        public void InfoLekarz()
        {
            Console.WriteLine("Informacje na temat lekarza od danego pacjenta");
            Console.WriteLine("Lekarz: " + this.lekarzRodzinny);
        }
    }
    
    class Recepcjonista : IRecepcjonista
    {
        public string imie, nazwisko;
        public int id;

        public Recepcjonista(string imie, string nazwisko, int id)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.id = id;
        }

        public void DodajLekarza()
        {
            Console.WriteLine("Dodano nowego lekarza");
        }

        public void DodajPacjenta()
        {
            Console.WriteLine("Dodano nowego pacjenta");
        }

        public void InfoLekarz()
        {
            Console.WriteLine("Imie lekarza: " + this.imie);
            Console.WriteLine("Nazwisko lekarza: " + this.nazwisko);
            Console.WriteLine("Identyfikator lekarza: " + this.id);
        }

        public void ModyfikujLekarza()
        {
            Console.WriteLine("Zmieniono lekarza");
        }

        public void PrzypiszPacjenta()
        {
            Console.WriteLine("Przypisano nowego pacjenta");
        }
    }
    //Zadanie 4
    public enum Miesiace
    {
        styczen = 1,
        luty,
        marzec,
        kwiecien,
        maj,
        czerwiec,
        lipiec,
        sierpien,
        wrzesien,
        pazdziernik,
        listopad,
        grudzien
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            Console.WriteLine("Zadanie 1");
            Sprzedawca s1 = new Sprzedawca("Jan", "Kowalski", "Marketing", 123, 2020, 4500);
            s1.Info();
            Console.WriteLine("---------------------------------------------");
            KierownikSprzedazy k1 = new KierownikSprzedazy("Stefan", "Nowak", "Kadry", 435, 2024, 6500, "wszystkie", 0.1d);
            k1.Info();
            k1.Placa();
            Console.ReadKey();
            Console.Clear();
            //Zaddanie 2
            Console.WriteLine("Zadanie 2");
            Osoba o1 = new Osoba();
            o1.PobierzOsobe();
            o1.WypiszOsobe();
            Console.ReadKey();
            Console.Clear();
            //Zadanie 3
            Console.WriteLine("Zadanie 3");
            Lekarz l1 = new Lekarz("Jan", "Nowak", "kardiolog", 1);

            Pacjent p1 = new Pacjent("Stefan", "Kowalski", "Katowice", "Nowak", 2);
            p1.InfoLekarz();
            Console.WriteLine("---------------------------------------------");
            Recepcjonista r1 = new Recepcjonista("Halina", "Polok", 3);
            r1.InfoLekarz();
            r1.PrzypiszPacjenta();
            r1.ModyfikujLekarza();
            Console.ReadKey();
            Console.Clear();
            //Zadanie 4
            Console.WriteLine("Zadanie 4");
            Console.Write("Podaj aktualny miesiac (numer miesiaca): ");
            int miesiacUzytkownika = int.Parse(Console.ReadLine());
            Miesiace danyMiesiac = (Miesiace)miesiacUzytkownika;
            int zostalo = 12 - (int)danyMiesiac;
            Console.WriteLine("Miesiac uzytkownika: " + danyMiesiac);
            Console.WriteLine();
            Console.WriteLine("Pozostało jeszcze: " + zostalo + " miesiecy do konca roku");
            Console.WriteLine();



            Console.WriteLine("Pozostałe miesiace: ");

            for (int i = miesiacUzytkownika + 1; i < 13; i++)
            {
                Miesiace wyswietlMiesiac = (Miesiace)i;
                Console.WriteLine(wyswietlMiesiac);
            }


            Console.ReadKey();
        }
    }
}
