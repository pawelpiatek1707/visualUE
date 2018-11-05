using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[]{ 19, 34, 23, 54, 31};
            Console.Write("Wiek uczestników: ");
            int suma = 0;
            foreach (var item in arr1)
            {
                Console.Write(item+", ");
                suma += item;
            }
            double srednia = (double)suma / arr1.Length;
            Console.WriteLine();
            Console.WriteLine("Srednia: " + srednia);
            Console.ReadKey();
        }
    }
}
