using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_26._02._19
{
    class Licznik
    {
        public double numerLicznika;
        public double stanPoczatkowy;
        public double stanBiezacy;

        public Licznik(double numerLicznika1, double stanPoczatkowy1, double stanBiezacy1)
        {
           numerLicznika = numerLicznika1;
            stanPoczatkowy = stanPoczatkowy1;
            stanBiezacy = stanBiezacy1;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Numer licznika: "+numerLicznika);
            Console.WriteLine("Stan poczatkowy: "+stanPoczatkowy);
            Console.WriteLine("Numer biezacy: "+stanBiezacy);
        }
        public void Zuzycie()
        {
            double zuzycie = stanBiezacy - stanPoczatkowy;
            Console.WriteLine("Zuzycie pradu: "+zuzycie);
        }
    }
}
