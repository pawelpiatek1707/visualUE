using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klasy statyczne .........
            Numbers n1 = new Numbers(2,5);
            n1.view();
            Console.WriteLine("---------------");
            n1.mno();
            float a = 2;
            float b = 5;
            NumbersStatic.mno(a, b);
            Console.ReadKey();
        }
    }
}
