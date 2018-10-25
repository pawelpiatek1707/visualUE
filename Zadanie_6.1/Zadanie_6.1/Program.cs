using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program obliczajacy silnie");
            Console.WriteLine("Wprowadz silnie: ");
            int  a= int.Parse(Console.ReadLine());
            int silnia =1;
            if (a >= 0)
            {


                if (a == 0 || a == 1)
                {
                    silnia = 1;
                    Console.WriteLine("Silnia: " + silnia);
                }
                else
                {
                    
                    for(int i = 1; i <= a;i++)
                    {
                        
                        silnia = silnia *i;
                       
                    
                    }
                    Console.WriteLine("Silnia: "+ silnia);
                }
            }
            else
            {

                Console.WriteLine("Silnia musi byc dodatnia: ");
            }
            Console.ReadKey();
        }
    }
}
