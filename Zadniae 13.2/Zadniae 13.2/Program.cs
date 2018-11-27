using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadniae_13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj bok kwadratu: ");
            int bok = int.Parse(Console.ReadLine());
            Console.Write("Podaj znak: ");
            string a = Console.ReadLine();
            Kwadrat k1 = new Kwadrat(bok, ConsoleColor.Cyan, a);
            k1.rysuj();
            Console.ReadKey();
        }
    }
}
