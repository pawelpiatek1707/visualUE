using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 3.11");
            int a = 1;
            int b = 2;
            int step = 0;
            while(a < 100){
                a = a + b;
                b++;
                step++;
            }
            //Console.WriteLine(a);
            Console.WriteLine(step-1);
            Console.ReadKey();
        }
    }
}
