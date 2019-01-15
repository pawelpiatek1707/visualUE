using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_15._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //double r = 10;
            //Console.WriteLine("{0:F2}",Figury.KoloPole(r));
            Punkt punkta = new Punkt(3, 2);
            Punkt punktb = new Punkt(2, 3);
            double odleglosc = Figury.Odlegloc(punktb.X, punkta.X, punktb.Y, punkta.Y);
            Console.WriteLine("Odleglosc miedzy punktami: {0:f4}",odleglosc);

            Console.ReadKey();
        }
        
    }
}
