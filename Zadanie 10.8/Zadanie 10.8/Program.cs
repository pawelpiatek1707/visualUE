using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10._8
{
    class Program
    {
        static void add(SortedDictionary<int,string>films)
            {
            Console.Clear();
            Console.WriteLine("Dodawanie nowych filmów");
            Console.WriteLine("-----------------------");
            int key;
            string name;
            do
            {

            Console.Write("Podaj klucz: ");
             key = int.Parse(Console.ReadLine());
            }while(films.ContainsKey(key));
            do
            {
                Console.Write("Podaj nazwe filmu: ");
                name = Console.ReadLine();
            }while(films.ContainsValue(name));
            films.Add(key,name);
            
            }
        static void remove(SortedDictionary<int,string>films)
            {
            Console.Clear();
            Console.WriteLine("Usuwanie wybranego elementu: ");
            int key;
            Console.WriteLine("Podaj klucz elementu do usuniećia: ");
            key = int.Parse(Console.ReadLine());
            while(!films.ContainsKey(key))
                {
                Console.WriteLine("Klucza nie ma w słowniku, podaj ponownie klucz: ");
                key = int.Parse(Console.ReadLine());
                }
            films.Remove(key);
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Uporządkowany słownik");
            SortedDictionary<int,string>films = new SortedDictionary<int, string>();
            films.Add(1,"film1");
            films.Add(2,"film2");
            films.Add(3,"film3");
            films.Add(4,"film4");
            films.Add(5,"film5");
            foreach(var x in films)
            {
                Console.WriteLine(x);
            }                   
            
            Console.WriteLine("---------------");
            Console.WriteLine("Opcje:");
            Console.WriteLine("1. Dodawanie nieistniejącego filmu do słownika: ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Program będzie prosił użytkownika tak długo o podanie klucza i nazwy dopóki użytkownik nie wprowadzi danych których nie ma jeszcze w słowniku");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("2. Usuwanie wybranego elementu słownika: ");
            Console.WriteLine("3. Usuwanie wszystkich elementów słownika: ");
            Console.Write
                ("Wybierz opcje: ");
            int option = int.Parse(Console.ReadLine());
            switch(option)
                {
                case 1:
                    {
                        add(films);
                        Console.Write("Wyświetlić ponownie zmodyfikowany słownik? tak/nie: ");
                        string choice1 = Console.ReadLine();
                        if(choice1  =="tak")
                            {
                        foreach(var x in films)
                            Console.WriteLine(x);
                        break;
                            }
                        else
                            break;
                  
                    }
                case 2:
                    {
                        remove(films);
                        Console.Write("Wyświetlić ponownie zmodyfikowany słownik? tak/nie: ");
                        string choice1 = Console.ReadLine();
                        if(choice1  =="tak")
                            {
                        foreach(var x in films)
                            Console.WriteLine(x);
                        break;
                            }
                        else
                        break;
                    }
                case 3:
                    {
                        films.Clear();
                        Console.Clear();

                        foreach(var x in films)
                            {
                            Console.WriteLine(x);
                            }
                        break;
                    }
                }
            Console.ReadKey();
        }
    }
}
