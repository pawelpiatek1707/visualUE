using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string>slownik = new Dictionary<string,string>();
            slownik.Add("1:", "Ksiazka 1");
            slownik.Add("2:", "Ksiazka 2");
            slownik.Add("3:", "Ksiazka 3");
            slownik.Add("4:", "Ksiazka 4");
            Console.WriteLine("Klucz: Wartość: ");
            Console.WriteLine("---------------");
            foreach(KeyValuePair<string, string> x in slownik)
            {
                Console.WriteLine(x.Key + " " + x.Value);
            }

            Console.WriteLine("Wybierz opcje.\n Opcja 1:Sprawdz czy lista zawiera klucz i ja dodaj. \n Opcja 2: Sprawdz czy lista zawiera ksiazke i ja dodaj. \n Opcja 3: Usun tytul z listy jesli jest \n");
            int wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    {
                        Console.WriteLine("Podaj klucz: ");
                        string wybor1 = Console.ReadLine();
                        Console.WriteLine("Podaj tytuł: ");
                        string wybor2 = Console.ReadLine();
                        if(slownik.ContainsKey(wybor1))
                        {
                            Console.WriteLine("Podany tytuł znajduje sie juz w słowniku");
                        }
                        else
                        {
                             slownik.Add(wybor1, wybor2);
                        Console.WriteLine("Wyswietlic ponownie zmodyfikowana liste ksiazek? tak/nie ");
                        string wybor3 = Console.ReadLine();
                        if(wybor3 == "tak")
                        {
                            foreach (KeyValuePair<string, string> x in slownik)
                            {
                                Console.WriteLine(x.Key + " " + x.Value);
                            }
                            break;
                        }
                        }
                       
                        
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Podaj klucz: ");
                        string wybor1 = Console.ReadLine();
                        Console.WriteLine("Podaj tytuł: ");
                        string wybor2 = Console.ReadLine();
                        if(slownik.ContainsValue(wybor2))
                            {
                            Console.WriteLine("Podana pozycja znajduje sie juz w słowniku");
                            }
                        else
                            {
                               slownik.Add(wybor1, wybor2);
                        Console.WriteLine("Wyswietlic ponownie zmodyfikowana liste ksiazek? tak/nie ");
                        string wybor3 = Console.ReadLine();
                        if(wybor3 == "tak")
                        {
                            foreach (KeyValuePair<string, string> x in slownik)
                            {
                                Console.WriteLine(x.Key + " " + x.Value);
                            }
                            break;
                        }
                            }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Podaj klucz elementu do usunięcia: ");
                        string wybor1 = Console.ReadLine();
                        if(!slownik.ContainsKey(wybor1)){
                            Console.WriteLine("Podanej pozycji nie ma w słowniku");
                        }
                        else{
                            slownik.Remove(wybor1);
                            Console.WriteLine("Wyswietlic ponownie zmodyfikowana liste ksiazek? tak/nie ");
                        string wybor3 = Console.ReadLine();
                        if(wybor3 == "tak")
                        {
                            foreach (KeyValuePair<string, string> x in slownik)
                            {
                                Console.WriteLine(x.Key + " " + x.Value);
                            }
                            break;
                        }
                        }
                        break;
                    }
            }
            Console.ReadKey();

        }
    }
}
