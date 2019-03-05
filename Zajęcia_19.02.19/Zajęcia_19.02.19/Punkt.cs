using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_19._02._19
{
    class Punkt
    {
       private  double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public void Przesun(double a,double b)
        {
            x = x + a;
            y = y + b;
            Console.WriteLine();
            Console.WriteLine("Nowa współrzędna X: "+x+", Nowa swpółrzędna Y: "+y);
        }
        public void Wypisz()
        {
            Console.WriteLine("Pierwsza współrzędna: "+x+", Druga współrzędn: "+y);
            Console.WriteLine();
        }
        public Punkt(double a,double b)
        {
            x = a;
            y = b;
        }
        
    }
}
