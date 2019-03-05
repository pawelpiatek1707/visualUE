using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_26._02._19
{
    class Samochod
    {
        public string model;
        public double moc;

        public void Start()
        {
            Console.WriteLine("Silnik uruchomiony ...");

        }

        public void Jedzie(double predkosc)
        {
            Console.WriteLine("Samochód jedzie z predkoscia: "+predkosc+"km/h");
        }

        public void Stop()
        {
            Console.WriteLine("Sammochód zatrzymany");
        }
        public Samochod(string model1,double moc1)
        {
            model = model1;
            moc = moc1;
        }


    }
}
