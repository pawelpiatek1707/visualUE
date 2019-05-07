using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wirtualne
{
    abstract class Samochod
    {
         public int predkosc,drzwi;
        public string paliwo;
        public Samochod(int predkosc,int drzwi,string paliwo)
        {
            this.predkosc = predkosc;
            this.paliwo = paliwo;
            this.drzwi = drzwi;
        }
        public abstract void Jade();
        public abstract void Naczepa();
        public virtual void Paliwo()
        {
            Console.WriteLine("Paliwo: "+this.paliwo);
        }
        public virtual void Drzwi()
        {
            Console.WriteLine("Liczba drzwi: "+this.drzwi);
        }
    }
}
