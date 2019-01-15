using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przed_II_Kolosem
{
    class Mno
    {
        private float x;
        private float y;
        private int z;
        public void Show()
        {
            Console.WriteLine("Pierwsza liczba " +x+", druga liczba "+y);
        }
        public void mno1()
        {
            Console.WriteLine("Pomnożone wartości: "+x*y);
        }
        public void squareDrow(int size, string symbol)
        {
            for(int i = 0;i<size;i++)
            {
                for( int j=0;j<size;j++)
                {
                    Console.Write(symbol+" ");
                }

                Console.WriteLine();
            }
        }
        public Mno(float a, float b)
        {
            x = a;
            y = b;
        }
        public Mno(int a)
        {
            z = a;
        }
        
    }
}
