using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_26._02._19
{
    class Osoba
    {
        public string imie;
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        public string nazwisko;
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public string miejsceUrodzenia;
        public string MiejsceUrodzenia
        {
            get { return miejsceUrodzenia; }
            set { miejsceUrodzenia = value; }
        }
        public Adres adres;
        public Adres Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public Osoba(string imie1, string nazwisko1, DateTime data1, string miejsceUrodzenia1, Adres adres1)
        {
            imie = imie1;
            nazwisko = nazwisko1;
            data = data1;
            miejsceUrodzenia = miejsceUrodzenia1;
            adres = adres1;
        }
        public void ObliczWiek()
        {
            int rok = data.Year;
            DateTime teraz = DateTime.Now;
            int rokTeraz = teraz.Year;
            int wiek = rokTeraz - rok;
            Console.WriteLine("Wiek osoby: "+wiek);
        }
        public void Czy18()
        {
            int rok = data.Year;
            DateTime teraz = DateTime.Now;
            int rokTeraz = teraz.Year;
            int wiek = rokTeraz - rok;
            if(wiek>19)
            {
                Console.WriteLine("Osoba jest doosła");
            }
            else
            {
                Console.WriteLine("Osoba jeszcze nie jest dorosła");
            }

        }
    }
}
