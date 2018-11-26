using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12._4
{
    class Program
    {
        static void firt(double a,double b)
        {
            double p = a * b;
            double l = 2 * a + 2 * b;
            Console.WriteLine("Pole prostokąta: "+p+". Obwód prostokąta: "+l);
        }
        static double[] second (double a, double b)
        {
           
            double p = a * b;
            double l = 2 * a + 2 * b;
            double[] arr1 = new double[2];
            arr1[0] = p;
            arr1[1] = l;
           
            return arr1;
            
        }
        static void Main(string[] args)
        {
            firt(2.4, 3.5);
            Console.WriteLine();
            Console.WriteLine(second(2, 3));
            
            Console.ReadKey();
        }
    }
}
