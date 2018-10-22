using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu-------------------------------
            
            Console.WriteLine("Opcje 1: ");
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("---------");
            Console.WriteLine("Opcja 2: ");
            Console.WriteLine("****");
            Console.WriteLine("***");
            Console.WriteLine("**");
            Console.WriteLine("*");
            Console.WriteLine("---------");
            Console.WriteLine("Opcja 3: ");
            Console.WriteLine("   *");
            Console.WriteLine("  **");
            Console.WriteLine(" ***");
            Console.WriteLine("****");
            Console.WriteLine("---------");
            Console.WriteLine("Opcja 4: ");
            Console.WriteLine("*****");
            Console.WriteLine("");
            Console.WriteLine("*   *");
            Console.WriteLine("");
            Console.WriteLine("*   *");
            Console.WriteLine("");
            Console.WriteLine("*****");
            Console.WriteLine("Wybierz opcje");
            //------------------------------------
            int choice = int.Parse(Console.ReadLine());
            switch ( choice)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Podaj liczbe wierszy: ");
                        int line = int.Parse(Console.ReadLine());
                        string[,] arr = new string[line,line];
                        string star = "*";
                        for(int i = 0; i < line-1; i++)
                        {
                            for(int j=0; j< line-1; j++)
                            {
                                Console.WriteLine(arr[j, i] = star); 
                            }
                            Console.WriteLine();
                        }

                        break;
                    }
            }
            Console.ReadKey(); 
        }
    }
}
