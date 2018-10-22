using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program liczacy odleglosc miedzy dwoma punktami na plaszczyznie");
            Console.WriteLine();
            Console.WriteLine("Podaj wspolrzedna x pierwszego punktu: ");
            double xa = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolrzedna y pierwszego punktu: ");
            double ya = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolrzedna x drugiego punktu: ");
            double xb = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolrzedna y drugiego punktu: ");
            double yb = Double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya)));
            Console.WriteLine();
            Console.WriteLine("Odleglosc miedzy punktami" +distance);
            Console.ReadKey();
            

        }
    }
}
