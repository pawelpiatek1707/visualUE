using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajęcia_23._10._2018_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //przykład 1
            /*int a = 3, b = 3;
            if (a > b)
            {
                Console.WriteLine("a jest mnniejsze od b");
            }
            else
            {
                Console.WriteLine("a nie jest mnijesze od b");


            }*/
            /* int x , y , z ;
             Console.WriteLine("Podaj pierwsza liczbe: ");
             x = int.Parse(Console.ReadLine());
             Console.WriteLine("Podaj druga liczbe: ");
             y = int.Parse(Console.ReadLine());
             Console.WriteLine("Podaj trzecia liczbe: ");
             z = int.Parse(Console.ReadLine());

             if (x==1 | y++ > 2 | ++z > 0)
             {
                 Console.WriteLine("warunek spelniony: ");
             }
             else
                 Console.WriteLine("warunek nie jest spelniony: ");*/
            Console.WriteLine("wybierz numer dnia tygodnia");
            int number = int.Parse(Console.ReadLine());
            

            
                switch (number)
                {
                    case 1:
                        {
                            Console.WriteLine("Poniedzialek");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Wtorek");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Środa");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Czwartek");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Piątek");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Sobota");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Niedziela");
                            break;
                        }
                default:
                    {
                        Console.WriteLine("To nie jest dzien tygodnia");
                        break;

                    }
                }
           
            Console.ReadKey();
        }
    }
}
