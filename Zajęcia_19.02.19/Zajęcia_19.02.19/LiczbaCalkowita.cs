using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_19._02._19
{
    class LiczbaCalkowita
    {
        private int liczba;
        public int Liczba
        {
            get { return liczba; }
            set { liczba = value; }
        }
        public void WyswietlLiczbe()
        {
            Console.WriteLine(liczba);
        }

        public int PobierzLicze()
        {
            return liczba;
        }

        
        public LiczbaCalkowita(int x)
        {
            liczba = x;
        }
    }
}
