using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wirtualne
{
    class Ciezarowka:Samochod
    {
        public Ciezarowka(int predkosc, int drzwi, string paliwo):base(predkosc,drzwi,paliwo)
        {
            this.predkosc = predkosc;
            this.paliwo = paliwo;
            this.drzwi = drzwi;
        }

        public override void Jade()
        { 
            Console.WriteLine("Jestem Ciezarowka, jade z predkoscia: "+this.predkosc);
        }

        public override void Naczepa()
        {
            Console.WriteLine("Jestem ciezarowka i mam naczepe");
        }
        public void Drzwi()
        {
            Console.WriteLine("Nie mam drzwi");
        }
    }
}
