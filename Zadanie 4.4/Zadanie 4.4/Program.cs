using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                arr1[i] = rand.Next(1, 1000);
            }
                //Console.Write("{0,8}", rand.Next(1, 1000));
            for(int i =0; i<100; i++)
            {
                for(int j=2;j<1000; j++)
                {

                }
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();
        }
    }
}
