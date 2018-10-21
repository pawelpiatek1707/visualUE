using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcje
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
            Console.ReadKey();
        }
        static void test()
        {
            Console.WriteLine("podaj słowo");
           string word = Console.ReadLine();
            Console.WriteLine("podaj ilość iteracji");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= number; i++)
            {
                Console.WriteLine(word);
            }
        }
    }
}
