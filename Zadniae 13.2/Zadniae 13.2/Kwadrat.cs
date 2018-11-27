using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadniae_13._2
{
    class Kwadrat
    {
        int bok;
        ConsoleColor kolor;
        string a;
        public Kwadrat(int bok1, ConsoleColor kolor1,string a1)
        {
            bok = bok1;
            kolor = kolor1;
            a = a1;

        }
        public void  rysuj()
        {
            Console.ForegroundColor = kolor;
            for(int i =0;i<bok;i++)
            {
                for(int j=0;j<bok;j++)
                {
                    Console.Write(a+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
