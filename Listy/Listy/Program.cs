using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy
{
    class Program
    {
       static void dodaj(List<string> autorzy)
        {
            int ilosc;
            Console.WriteLine("Podaj ile autorow chcesz dodać: ");
            ilosc = int.Parse(Console.ReadLine());
            for(int i = 0; i < ilosc; i++)
            {
                Console.WriteLine("Podaj kolejnego autora do dodania: ");
                string nazwa = Console.ReadLine();
                if(autorzy.Exists(j => j == nazwa) == true){
                    Console.WriteLine("Autor jest juz w liscie:");
                }
                else
                autorzy.Add(nazwa);
            }
        }
        static void usun(List<string> autorzy)
        {
            Console.WriteLine("Podaj nazwisko do usuniecia: ");
            string nazwisko = Console.ReadLine();
            if (autorzy.Exists(j => j == nazwisko) == true)
            {
                autorzy.RemoveAll(i=> i==nazwisko);
            }
            else
                Console.WriteLine("Autor nie ma na liscie:");

        }
        static void Main(string[] args)
        {
            List<string> autorzy = new List<string>();
           
            string autor;
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Podaj autorów książek ");
                autor = Console.ReadLine();
                autorzy.Add(autor);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Lista autorow: ");
            foreach(string a in autorzy)
            {
                Console.WriteLine(a);
                    
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Pojemność listy: "+autorzy.Count());
            Console.WriteLine("---------------");
            Console.WriteLine("1. Sprawdzanie czy dane nazwisko jest na liście: ");
            Console.WriteLine("2. Dodaj kolejnych autorów: ");
            Console.WriteLine("3. Usun autorad: ");
            int wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                
                case 1:
                    {
                        string szuk = Console.ReadLine();
                        Console.WriteLine(autorzy.Exists(i => i == szuk)); 
                        break;
                    }
                case 2:
                    {
                        
                        dodaj(autorzy);
                        Console.WriteLine("-----------");
                        Console.WriteLine("Lista po dodaniu dodatkowych elementów");
                        Console.WriteLine();
                        Console.WriteLine("Wyswietlic ponownie zmodyfikowana tablice? tak/nie");
                        string taknie = Console.ReadLine();
                        if (taknie == "tak")
                            Console.Clear();
                            foreach (string x in autorzy)
                            {
                                Console.WriteLine(x);
                                
                            }
                        
                            break;
                        
                    }
                case 3:
                    {
                        usun(autorzy);
                        Console.WriteLine("Wyswietlic ponownie zmodyfikowana tablice? tak/nie");
                        string taknie = Console.ReadLine();
                        if (taknie == "tak")
                            Console.Clear();
                        foreach (string x in autorzy)
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
