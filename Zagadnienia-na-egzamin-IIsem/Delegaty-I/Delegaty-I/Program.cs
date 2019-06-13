using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty_I
{
    //1. Delegaty
    /* - Delegat odpowiada za komunikacje między dwoma elemetamim
     * - Działają jak takie callbacki. Metoda może jako argument przyjmować delegat 
     * */
     //Praktyczne zasotsowanie delegatu
     class Delegaty
    {
        public delegate void Delegat(int i);
        public void Metoda(Delegat obj)
        {
            for (int i = 0; i < 100; i++)
            {
                obj(i);
                //robi sie coś w tle
            }

        }
    }
    class Program
    {
        public delegate void Delegat1();
        static void Metoda1( int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            // Delegat1 del = Metoda;
            //del.Invoke(); // wywołąnie metody z wykorzystaniem delegatu 
            Delegaty d1= new Delegaty();
            d1.Metoda(Metoda1);


            Console.ReadKey();
        }
    }
}
