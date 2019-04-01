using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_26._02._19
{

    class Program
    {
        static void Main(string[] args)
        {
            //Samochod s1 = new Samochod("Betka", 666);
            //Console.WriteLine("Model: " + s1.model);
            //Console.WriteLine("Moc: " + s1.moc);
            //s1.Start();
            //s1.Jedzie(420);
            //s1.Stop();
            //Kwadrat k1 = new Kwadrat(10, ConsoleColor.Red);
            //k1.RysujKwadrat();
            //Licznik l1 = new Licznik(333, 345, 654);
            //l1.Zuzycie();
            //l1.Wyswietl();


            DateTime d1 = new DateTime(1998, 3, 12);
            Adres a1 = new Adres("Długa", "Katowice", 32);
            Osoba o1 = new Osoba("Adam", "Nowak", d1, "Katowice", a1);
            o1.ObliczWiek();
            o1.Czy18();
            Console.ReadKey();
        }
    }
}
