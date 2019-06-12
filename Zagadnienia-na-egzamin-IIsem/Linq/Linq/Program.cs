using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Osoby
    {
        public string imie;
        public int wiek;

        public Osoby(string imie,int wiek)
        {
            this.imie = imie;
            this.wiek = wiek;
        }
    }
    class Zwierzeta
    {
        public string imie;
        public string wlasciciel;

        public Zwierzeta(string imie,string wlasciciel)
        {
            this.imie = imie;
            this.wlasciciel = wlasciciel;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Przykład zastosowania LINQ
            //1. Klauzula from:
            // - zapytanie zawsze zaczyna sie od klauzuli from
            // - określamy źródło danych na których jest wykonywane zapytanie 
            //      oraz zakres zmiennej lokalnej która reprezentuje elementy ze źródła
            //int[] cyfry = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var mniejsza = from cyfra in cyfry
            //               where cyfra < 4
            //               select cyfra;

            //var mniejszaPomDwa = from cyfra in cyfry
            //                     where cyfra < 4
            //                     select cyfra * 2; //można wykonywać dodatkowe operacje na elementah z selecta
            //foreach(var x in mniejszaPomDwa)
            //{
            //    Console.WriteLine(x);
            //}
            //===================================================================
            //2. Klauzula where:
            // - Pozwlala na określenie warunku logicznego, który musi być spełniony przez dane zwrócone ze źródła 
            //=====================================================================
            //3. Projekja danych z klasy za pomocą select

            //Osoby o1 = new Osoby("Paweł", 20);
            //Osoby o2 = new Osoby("Adam", 17);
            //Osoby o3 = new Osoby("Kamil", 21);

            //Osoby[] lista = { o1, o2, o3 };

            //var pelnoletni = from Osoba in lista
            //                 where  Osoba.wiek >= 18
            //                 orderby Osoba.imie ascending //sortowaniee
            //                 select Osoba;

            //foreach (var x in pelnoletni)
            //{
            //    Console.WriteLine(x.imie + " " + x.wiek);
            //}
            //==========================================================================
            //4. Group by 

            //int[] cyfry = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
            //var grupy = from cyfra in cyfry
            //            group  cyfra by  cyfra% 2 == 0;

            //foreach(var x in grupy)
            //{
            //    foreach(int cyfra in x)
            //    {
            //        Console.WriteLine(cyfra); //wypisywanie liczb parzystych 
            //    }
            //}
            //===========================================================================
            //5. Join

            //Osoby o1 = new Osoby("Paweł", 20);
            //Osoby o2 = new Osoby("Adam", 17);
            //Osoby[] listaOsob = { o1, o2 };

            //Zwierzeta z1 = new Zwierzeta("zwierze1", "Paweł");
            //Zwierzeta z2 = new Zwierzeta("Zwierze2", "Adam");

            //Zwierzeta[] listaZwierzat = { z1, z2 };

            //var polaczone = from Osoba in listaOsob
            //                join Zwierze in listaZwierzat
            //                on Osoba.imie equals Zwierze.wlasciciel
            //                select new { NazwaWlasciciela = Osoba.imie, NazwaZwierzecia = Zwierze.imie };

            //foreach(var x in polaczone)
            //{
            //    Console.WriteLine(x.NazwaWlasciciela+ " " +x.NazwaZwierzecia);
            //}
            //===============================================================================
            //6. Łączenie zbiorów danych 
            // - concat - dodawanie do siebie dwóch zbbiorów danych
            // - union - łaczenie dwóch zbiorów danych bez powtórzeń
            // - Intersect - część wspólna dwóch zbiorów 
            // - Except - wyłączenie części wspólnej ze zbbioru źródłowego 

            //List<string> kolory = new List<string> { "czarny", "biały", "żółty", "czerwony" };
            //List<string> kolory1 = new List<string> { "zielony", "biały", "szary", "niebieski" };

            //var cKolory = kolory.Concat(kolory1);
            //var uKolory = kolory.Union(kolory1);
            //var iKolory = kolory.Intersect(kolory1);
            //var eKolory = kolory.Except(kolory1);

            //foreach(var x in cKolory)
            //{
            //    Console.WriteLine(x);

            //}
            //Console.WriteLine("____");
            //foreach (var x in uKolory)
            //{
            //    Console.WriteLine(x);

            //}
            //Console.WriteLine("____");
            //foreach (var x in iKolory)
            //{
            //    Console.WriteLine(x);

            //}
            //Console.WriteLine("____");
            //foreach (var x in eKolory)
            //{
            //    Console.WriteLine(x);

            //}
            //Console.WriteLine("____");
            //==================================================================
            //7. Kaskadowe operatorry zapytań 

            //string[] imiona = { "Arek", "Ala", "Gosia", "Daniel", "Jerzy" };

            //var wynik = imiona.Where(n => n.Contains("e")) // wewnąrz klauzul where,order by, select wykorzystujemy jako
            //                   .OrderBy(n => n.Length)     // argument anonimową funkcje (wyrażenie lamda)
            //                   .Select(n => n.ToUpper());

            //foreach(var x in wynik)
            //{
            //    Console.WriteLine(x);
            //}
            //==============================================================
            //8. Słowo kluczowe let
            // Pozwala na wprowadzenie dodatkowej zmiennej obok zmiennej zakreowej 
            //string[] imiona = { "Arek", "Ala", "Gosia", "Daniel", "Jerzy" };

            //var wynik = from imie in imiona
            //            let ibs = 3
            //            where imie.Length > ibs
            //            select imie + " " + imie.Length;

            //foreach(var x in wynik)
            //{
            //    Console.WriteLine(x);
            //}
            //===========================================================
            //9. Zapytania z wieloma klauzulami from
            //int[] cyfry = { 1, 2, 3 };
            //string[] litery = { "a", "b", "c" };

            //var razem = from cyfra in cyfry //W tym przypadku mamy do czynienia z iloczynem kartezjańskim
            //            from litera in litery
            //            select cyfra.ToString() + litera;

            //foreach(var x in razem)
            //{
            //    Console.WriteLine(x);
            //}
            //==========================================================
            //10. LINQ to Object
            //1)Zliczanie wystąpień słowa w tekście 
            //string tekst = "byc albo nie byc oto jest pytanie";
            //string szukane="byc";
            //string [] slowa = tekst.Split(' ');

            //var znalezione = from slowo in slowa
            //                 where slowo.ToLower() == szukane.ToLower()
            //                 select slowo;

            //foreach(var x in znalezione)
            //{
            //    Console.WriteLine(x); // wypisanie znalezionych słów 

            //}

            //int ileZnalwziono = znalezione.Count();
            //Console.WriteLine($"Znaleziono: {ileZnalwziono} wystąpień słowa {szukane}");
           
            
        

            Console.ReadKey();
        }
    }
}
