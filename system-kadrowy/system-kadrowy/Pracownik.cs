using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_kadrowy
{
    class Pracownik
    {
        public string nazwisko;
        public string imie;
        public float placa;
        public string dataUrodzenia;
        public float premia = 10;

        //Pracownik(string nazw, string imie1, float kasa,string data)
        //{
        //    nazwisko = nazw;
        //    imie = imie1;
        //    placa = kasa;
        //    dataUrodzenia = data;
        //}
        public void pokaz()
        {
            Console.WriteLine("nazwisko: "+nazwisko+", imie: "+imie+", placa: "+placa+", data urodzenia: "+dataUrodzenia);
        }
        public void obliczBrutto()
        {

            float placa1 = this.placa * 0.23f;
            placa = placa - placa1;
            Console.WriteLine(placa);
        }

    }
}
