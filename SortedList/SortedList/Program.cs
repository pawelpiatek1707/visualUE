using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void see(SortedList<int,string>list)
        {
            foreach (KeyValuePair<int, string> x in list)
            {
                Console.Write(x.Key);
                Console.Write(": ");
                Console.Write(x.Value);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            SortedList<int, string> list = new SortedList<int, string>();
            Console.WriteLine("Lista posortowana");
            Console.WriteLine("---------------");
            list.Add(1, "zwierze 1");
            list.Add(2, "zwierze 2");
            list.Add(3, "zwierze 3");
            list.Add(4, "zwierze 4");

            see(list);
            Console.WriteLine("Opcje");
            Console.WriteLine("1. Dodawanie zwierzęcia: ");
            Console.WriteLine("2. Zmiana nazwy zwierzęcia: ");
            Console.WriteLine("3. Usuwanie nazwy zwierzęcia z listy: ");
            Console.Write("Wybierz opcję: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Podaj klucz: ");
                        int key = int.Parse(Console.ReadLine());
                        Console.Write("Podaj nazwe zwierzęcia: ");
                        string animal = Console.ReadLine();
                        try
                        {
                            list.Add(key, animal);
                        }
                        catch(ArgumentException e)
                        {
                            Console.WriteLine("Wystapił błąd: " + e.Message);
                        }
                        Console.Write("Wyświetlić ponownie zawartość listy? tak/nie: ");
                        string choice1 = Console.ReadLine();
                        if(choice1 == "tak")
                        {
                            see(list);
                            break;
                        }
                        else
                        break;
                    }
                case 2:
                    {
                        Console.Write("Podaj klucz zwierzęcia którego nazwę chcesz zmienic: ");
                        int key1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj nowa nazwe: ");
                        string animal1 = Console.ReadLine();
                        try
                        {
                            list.Remove(key1);
                            list.Add(key1, animal1);
                            
                        }
                        catch(KeyNotFoundException e)
                        {
                            Console.WriteLine("Wystąpił błąd: "+ e.Message);
                        }

                        Console.Write("Wyświetlić ponownie zawartość listy? tak/nie: ");
                        string choice1 = Console.ReadLine();
                        if (choice1 == "tak")
                        {
                            see(list);
                            break;
                        }
                        else
                            break;
                    }
                case 3:
                    {
                        Console.Write("Podaj klucz zwierzęcia do usunięcia: ");
                        int key2 = int.Parse(Console.ReadLine());
                        try
                        {
                            list.Remove(key2);
                        }
                        catch(KeyNotFoundException e)
                        {
                            Console.WriteLine("wystapił błąd: " + e.Message);
                        }
                        Console.Write("Wyświetlić ponownie zawartość listy? tak/nie: ");
                        string choice1 = Console.ReadLine();
                        if (choice1 == "tak")
                        {
                            see(list);
                            break;
                        }
                        else
                            break;
                    }
            }
            Console.ReadKey();

        }
    }
}
