using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_13._5
{
    class Osoby
    {
        private string imie;
        private string nazwisko;
        
        int dzien;
        int miesiac;
        int rok;
        public Osoby(string imie1,string nazwisko1,int dzien1,int miesiac1,int rok1)
        {
            imie = imie1;
            nazwisko = nazwisko1;
            dzien = dzien1;
            miesiac = miesiac1;
            rok = rok1;
        }
        public void WyświetDane()
        {
            Console.WriteLine("Imie: "+imie);
            Console.WriteLine("Nazwisko: "+nazwisko);
            Console.WriteLine("Data urodzenia: "+dzien+" "+miesiac+ " "+rok);
            
        }
    }
}
