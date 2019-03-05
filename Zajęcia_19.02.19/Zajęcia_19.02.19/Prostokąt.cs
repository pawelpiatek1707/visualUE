using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_19._02._19
{
    class Prostokąt
    {
        public double []a = new double[2];
        public double []b = new double[2];
        public double []c = new double[2];
        public double []d = new double[2];

        public void Wyswietl()
        {
            Console.WriteLine("Pierwszy wierzchołek: "+a[0]+" "+a[1]);
            Console.WriteLine("Drugi wierzchołek: "+b[0]+" "+b[1]);
            Console.WriteLine("Trzeci wierzchołek: "+c[0]+" "+c[1]);
            Console.WriteLine("Czwarty wierzchołek: "+d[0]+" "+d[1]);
        }
    }
}
