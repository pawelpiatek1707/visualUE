using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_przed_kolosem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1 listy
            //Console.WriteLine("Lista autorów książek");
            //List<string> authors = new List<string>();
            //authors.Add("Autor1");
            //authors.Add("Autor2");
            //authors.Add("Autor3");
            //authors.Add("Autor4");
            //foreach(var x in authors)
            //{
            //    Console.Write(x+", ");
            //}
            //int capacity =authors.Capacity;
            //Console.WriteLine("Pojemność listy: "+capacity);
            //Console.WriteLine("Opcje programu: ");
            //Console.WriteLine("1. Sprawdzanie czy dane nazwisko jest na liście");
            //Console.WriteLine("2. Dodawanie nazwisk do listy");
            //Console.WriteLine("3. Usuwanie nazwiska z listy");
            //Console.WriteLine("4. Całkowite czyszczenie listy");
            //Console.WriteLine();
            //Console.Write("wybierz opcję: ");
            //int option = int.Parse(Console.ReadLine());
            //switch(option)
            //{
            //    case 1:
            //        {
            //            Console.Clear();
            //            Console.Write("Podaj nazwisko do sprawdzenia: ");
            //            string name = Console.ReadLine();
            //            if(authors.Contains(name))
            //                Console.WriteLine("Nazwisko jest na liście");
            //            else
            //                Console.WriteLine("Nazwiska nie ma naliście");
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Podaj nazwisko do dodania: ");
            //            string name = Console.ReadLine();
            //            if(!authors.Contains(name))
            //            {
            //                authors.Add(name);
            //                Console.Write("Wyświetlić ponownie zmodyfikowaną listę? tak/nie: ");
            //                string choice = Console.ReadLine();
            //                if(choice =="tak")
            //                {
            //                    foreach(var x in authors)
            //                    {
            //                        Console.Write(x + ", ");
            //                    }
            //                }
            //            }
            //            else
            //                Console.WriteLine("Nazwisko już jest na liście");
            //            break;
            //        }
            //    case 3:
            //        {
            //            Console.Clear();
            //            Console.Write("Podaj nazwisko do usunięcia: ");
            //            string name = Console.ReadLine();
            //            if(authors.Contains(name))
            //            {
            //                authors.Remove(name);
            //                Console.Write("Wyświetlić ponownie zmodyfikowaną listę? tak/nie: ");
            //                string choice = Console.ReadLine();
            //                if (choice == "tak")
            //                {
            //                    foreach (var x in authors)
            //                    {
            //                        Console.Write(x + ", ");
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Podana wartość nie występuje na liście");
            //            }
            //            break;
            //        }

            //    case 4:
            //        {
            //            Console.Clear();
            //            authors.Clear();
            //            Console.Write("Wyświetlić ponownie zmodyfikowaną listę? tak/nie: ");
            //            string choice = Console.ReadLine();
            //            if (choice == "tak")
            //            {
            //                foreach (var x in authors)
            //                {
            //                    Console.Write(x + ", ");
            //                }
            //            }
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Nie ma takiej opcji");
            //            break;
            //        }
            //}
            //Zadanie 2 słownik 
            //Dictionary<string, string> books = new Dictionary<string, string>();
            //books.Add("1", "Książka1");
            //books.Add("2", "Książka2");
            //books.Add("3", "Książka3");
            //books.Add("4", "Książka4");
            //Console.WriteLine("[klucz, ksiżąka]");
            //Console.WriteLine();
            //foreach(var x in books)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine("Opcje:");
            //Console.WriteLine("1. Dodawanie do słownika po kluczu: ");
            //Console.WriteLine("2. Dodawanie do słownika po nazwie: ");
            //Console.WriteLine("3. Usuwanie elementu z listy: ");
            //Console.Write("Wybierz opcje: ");
            //int option = int.Parse(Console.ReadLine());
            //switch(option)
            //{
            //    case 1:
            //        {
            //            Console.Write("Podaj klucz książki która chcesz dodać: ");
            //            string key = Console.ReadLine();
            //            if(!books.ContainsKey(key))
            //            {
            //                Console.Write("Podaj nazwę książki któą chcesz dodać: ");
            //                string name = Console.ReadLine();
            //                books.Add(key, name);
            //                Console.Write("Wyświetlić ponownie słownik? ta/nie: ");
            //                string choice = Console.ReadLine();
            //                if(choice =="tak")
            //                {
            //                    foreach(var x in books)
            //                    {
            //                        Console.WriteLine(x);
            //                    }
            //                }
            //            }
            //            else
            //                Console.WriteLine("Książka o podanym kluczu ostnieje już w słowniku");
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.Write("Podaj nazwę ksiżąki która chcesz dodac: ");
            //            string name = Console.ReadLine();
            //            if(!books.ContainsValue(name))
            //            {
            //                Console.WriteLine("Podaj klucz książki która chcesz dodac: ");
            //                string key = Console.ReadLine();
            //                if(!books.ContainsKey(key))
            //                {
            //                    books.Add(key, name);
            //                    Console.Write("Wyświetlić ponownie słownik? ta/nie: ");
            //                    string choice = Console.ReadLine();
            //                    if (choice == "tak")
            //                    {
            //                        foreach (var x in books)
            //                        {
            //                            Console.WriteLine(x);
            //                        }
            //                    }
            //                }
            //            }
            //            Console.WriteLine("Podana pozycja istnieje juz w słowniku");
            //            break;
            //        }
            //    case 3:
            //        {
            //            Console.Write("Podaj klucz elementu do usunięcia: ");
            //            string key = Console.ReadLine();
            //            if(books.ContainsKey(key))
            //            {
            //                books.Remove(key);
            //                Console.Write("Wyświetlić ponownie słownik? tak/nie: ");
            //                string choice = Console.ReadLine();
            //                if (choice == "tak")
            //                {
            //                    foreach (var x in books)
            //                    {
            //                        Console.WriteLine(x);
            //                    }
            //                }
            //            }
            //            else
            //                Console.WriteLine("Podanej wartości nie ma w słowniku: ");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Nie ma takiej opcji: ");
            //            break;
            //        }
            //}
            //Zadnie 3 Sorted list
            //SortedList<int, string> animals = new SortedList<int, string>(); ;
            //animals.Add(1, "zwierze1");
            //animals.Add(2, "zwierze2");
            //animals.Add(3, "zwierze3");
            //animals.Add(4, "zwierze4");
            //foreach(var x in animals)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine("Opcje");
            //Console.WriteLine("1. Dodawanie zwierzęcia jeśli klucza nie ma na liście");
            //Console.WriteLine("2. Zmiana nazwy zwierzęcia dla danego klucza");
            //Console.WriteLine("3. Usuwanie nazwy zwierzęcia z listy");
            //Console.Write("Wybierz opvje: ");
            //int option = int.Parse(Console.ReadLine());
            //switch(option)
            //{
            //    case 1:
            //        {
            //            Console.Write("Podaj klucz zwierzęcia do dodania: ");
            //            int key = int.Parse(Console.ReadLine());
            //            Console.Write("Podaj nazwe zwierzęcia do dodania: ");
            //            string name = Console.ReadLine();
            //            try
            //            {
            //                animals.Add(key,name);
            //            }
            //            catch(ArgumentException e)
            //            {
            //                Console.WriteLine(e.Message);
            //            }
            //            Console.Write("Wyświetlić ponownie listę? tak/nie: ");
            //            string choice = Console.ReadLine();
            //            if(choice == "tak")
            //            {
            //                foreach(var x in animals)
            //                {
            //                    Console.WriteLine(x);
            //                }
            //            }
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.Write("Podaj klucz zwierzęcia do zamiany nazwy: ");
            //            int key = int.Parse(Console.ReadLine());
            //            Console.Write("Podaj nową nazwę: ");
            //            string name = Console.ReadLine();
            //            try
            //            {
            //                animals.Remove(key);
            //                animals.Add(key, name);

            //            }
            //            catch(KeyNotFoundException e1)
            //            {
            //                Console.WriteLine(e1.Message);
            //            }
            //            Console.Write("Wyświetlić ponownie listę? tak/nie: ");
            //            string choice = Console.ReadLine();
            //            if (choice == "tak")
            //            {
            //                foreach (var x in animals)
            //                {
            //                    Console.WriteLine(x);
            //                }
            //            }

            //            break;
            //        }
            //    case 3:
            //        {
            //            //usuwanie jak wyżej 
            //            break;
            //        }
            //}
            //Zadanie 4 Sorted dictionary
            SortedDictionary<string, string> workers = new SortedDictionary<string, string>();
            workers.Add("98071706657", "Adam");
            workers.Add( "98071706658","Ada");
            workers.Add( "98071706659","Kamil");
            workers.Add( "98071706650","Karol");
            foreach(var x in workers)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Opcje");
            Console.WriteLine("1. Dodawanie pracownika jeśli jego peselu nie ma na liście");
            Console.WriteLine("2. Zamiana danych po peselu");
            Console.WriteLine("3. Usuwanie imienia z listy jesśli sie na nim znajduje");
            Console.Write("Wybierz opcję: ");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                    {
                        Console.Write("Podaj numer pesel: ");
                        string pesel = Console.ReadLine();
                        Console.WriteLine("Podaj imie pracownika: ");
                        string name = Console.ReadLine();
                        try
                        {
                            workers.Add(pesel, name);

                        }
                        catch(ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.Write("Wyświetlić pononie zmodyfikowaną listę ? tak/nie: ");
                        string choice = Console.ReadLine();
                        if(choice == "tak")
                        {
                            foreach(var x in workers)
                            {
                                Console.WriteLine(x);
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("Podaj numer pesel pracownika do zmiany danych: ");
                        string pesel = Console.ReadLine();
                        Console.Write("Podaj nowe imie dla pracownika: ");
                        string name = Console.ReadLine();
                        try
                        {
                            workers.Remove(pesel);
                            workers.Add(pesel,name);
                        }
                        catch(KeyNotFoundException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.Write("Wyświetlić pononie zmodyfikowaną listę ? tak/nie: ");
                        string choice = Console.ReadLine();
                        if (choice == "tak")
                        {
                            foreach (var x in workers)
                            {
                                Console.WriteLine(x);
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nie ma takiej opcji:");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
