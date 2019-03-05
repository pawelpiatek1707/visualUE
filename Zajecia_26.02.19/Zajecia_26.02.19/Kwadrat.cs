using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_26._02._19
{
    class Kwadrat
    {
        public double bok;
        public ConsoleColor kolor;

        public Kwadrat(double bok1,  ConsoleColor kolor1)
        {
            bok = bok1;
            kolor = kolor1;
        }

        public void RysujKwadrat()
        {
            Console.ForegroundColor = kolor;
            for (int i = 1; i <= bok; i++)
            {
                for (int j = 1; j <= bok; j++)
                    Console.Write("*"+" ");
                Console.WriteLine();
            }
        }
    }
}
