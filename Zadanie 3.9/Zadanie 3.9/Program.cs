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
            /*
             Console.WriteLine("Wprowadz liczbe wierszy: ");
            int n = int.Parse(Console.ReadLine());
            for(int i =1 ; i <= n; i
            {
                for(int j = 1; j <= n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
             */
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
                        int n = int.Parse(Console.ReadLine());
                        string word = "";
                        for(int i =1 ; i <= n; i++)
                        {
                            word = word + "*";
                            Console.WriteLine(word);
                            
                            //Console.Write("*");
                        }
                        break;
                    }                   
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Podaj liczbe wierszy: ");
                        int n = int.Parse(Console.ReadLine());
                        string word1 = "";
                       for(int i = n-1;i>0;i--)
                            {
                            word1 = word1+"*";
                            Console.WriteLine(word1);
                            }
                                                                        

                        break;
                    }
                    case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Podaj liczbe wierszy: ");
                        int n = int.Parse(Console.ReadLine());
                         for(int i =1 ; i <= n; i++)
                        {
                            for(int j = 1; j <= n-i; j++)
                            {
                            Console.Write("*");
                            }
                            Console.WriteLine();
                            //Console.Write("*");
                        }
                       break;
                    }
            }
            Console.ReadKey(); 
        }
    }
}
