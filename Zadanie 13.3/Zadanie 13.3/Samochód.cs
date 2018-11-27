using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_13._3
{
    class Samochód
    {
        string model;
        int moc;
        public Samochód(string nazwa, int moc1)
        {
            model = nazwa;
            moc = moc1;
        }
        public void startSilnika()
        {
            Console.WriteLine("Silnik uruchomiony");
        }
        public void jedzie(int predkosc)
        {
            Console.WriteLine("Samochód jedzie  "+predkosc+"mk/h");
        }
        public void stop()
        {
            Console.WriteLine("Samochód zatrzymany. Silnik wyłączon");
        }
    }
}
