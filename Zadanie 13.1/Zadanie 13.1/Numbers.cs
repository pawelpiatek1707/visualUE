using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_13._1
{
    class Numbers
    {
        private float number1;
        private float number2;

        public Numbers(float n1, float n2)
        {
            number1 = n1;
            number2 = n2;
            
        }
        public void view()
        {
            Console.WriteLine("Pierwsza liczba : "+number1);
            Console.WriteLine("Druga liczba: "+number2);
        }
        public void mno()
        {
            
            Console.WriteLine("Wynik mnożenia: "+number1 * number2);
        }


        
    }
}
