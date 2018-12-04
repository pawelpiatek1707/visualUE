using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_13._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoby os1 = new Osoby("Seba", "Mazur", 07, 11, 1998);
            os1.WyświetDane();
            Console.ReadKey();
        }
    }
}
