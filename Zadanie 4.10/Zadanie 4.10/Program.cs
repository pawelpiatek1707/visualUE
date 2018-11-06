using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj datę w formacie: DD-MM-RRRR");
            string date = Console.ReadLine();
            string month = date.Substring(3, 2);
            
            switch (month)
            {
                case "01":
                    {
                        Console.WriteLine("Miesiac: Styczeń");
                        break;
                    }
                case "02":
                    {
                        Console.WriteLine("Miesiac: Luty");
                        break;
                    }
                case "03":
                    {
                        Console.WriteLine("Miesiac: Marzec");
                        break;
                    }
                case "04":
                    {
                        Console.WriteLine("Miesiac: Kwiecień");
                        break;
                    }
                case "05":
                    {
                        Console.WriteLine("Miesiac: Maj");
                        break;
                    }
                case "06":
                    {
                        Console.WriteLine("Miesiac: Czerwiec");
                        break;
                    }
                case "07":
                    {
                        Console.WriteLine("Miesiac: Lipiec");
                        break;
                    }
                case "08":
                    {
                        Console.WriteLine("Miesiac: Sierpień");
                        break;
                    }
                case "09":
                    {
                        Console.WriteLine("Miesiac: Wrzesień");
                        break;
                    }
                case "10":
                    {
                        Console.WriteLine("Miesiac: Październik");
                        break;
                    }
                case "11":
                    {
                        Console.WriteLine("Miesiac: Listopad");
                        break;
                    }
                case "12":
                    {
                        Console.WriteLine("Miesiac: Grudzień");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
