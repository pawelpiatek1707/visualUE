using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._8
{
    class Program
    {
       static  void Sum(int[] number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            Console.WriteLine("Suma cyfr w liczbie: "+ sum);
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbe: ");
            int[] number = 
            Sum(number);
            
            Console.ReadLine();
        }
    }
}
