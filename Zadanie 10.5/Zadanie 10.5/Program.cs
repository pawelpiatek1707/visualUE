using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sprawdzanie czy podane liczby tworzą trójke pitagorejską: ");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbe: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbe: ");
            int c = int.Parse(Console.ReadLine());
            if(a*a+b*b==c*c)
                Console.WriteLine("Podane liczby tworzą trójke pitagorejską");
            else
                Console.WriteLine("Podane liczby nie tworzą trójki pitagorejskiej");
            Console.ReadKey();
        }
    }
}
