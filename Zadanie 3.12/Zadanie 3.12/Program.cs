using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sumowanie liczb wprowadzonnych przez użytkownika do czasu gdy nie wprowadzi on 0: ");
            int a;
            int suma=0;
            do
            {
                Console.WriteLine("Wprowadz liczby: ");
                a = int.Parse(Console.ReadLine());
                suma += a;
            } while (a != 0);
            Console.WriteLine("suma: "+suma);
            Console.ReadKey();
            
        }
    }
}
