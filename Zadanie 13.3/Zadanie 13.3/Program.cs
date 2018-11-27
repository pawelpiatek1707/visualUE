using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochód s1 = new Samochód("BMW", 666);
            s1.startSilnika();
            s1.jedzie(350);
            s1.stop();
            Console.ReadKey();

        }
    }
}
