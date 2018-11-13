using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_13._11._18q
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program do obliczania pola");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Pole trapezu");
            Console.WriteLine("2. Pole trójkąta");
            Console.WriteLine("3. Pole kwadratu");
            Console.WriteLine("----------------------------");
            Console.Write("Wybierz opcje: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Podaj pierwsza podstawe trapezu: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Podaj druga podstawe trapezu: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.Write("Podaj wysokość trapezu: ");
                        int h = int.Parse(Console.ReadLine());
                        int p = ((a + b) * h) / 2;
                        Console.WriteLine("Pole trapezu: "+p);
                            
                        break;
                    }
                case 2:
                    {
                        Console.Write("Podaj podstawe trójkąta: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Podaj wysokość trójkąta: ");
                        int h = int.Parse(Console.ReadLine());
                        int p = (a * h) / 2;
                        Console.WriteLine("Pole trójkąta: "+p);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Podaj bok kwadratu: ");
                        int a = int.Parse(Console.ReadLine());
                        int p = a * a;
                        Console.WriteLine("Pole kwadratu: "+p);
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
