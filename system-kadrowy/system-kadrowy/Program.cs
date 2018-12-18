using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_kadrowy
{

    class Program
    {
        static void Main(string[] args)
        {

            Pracownik pracownik1 = new Pracownik();
            pracownik1.imie = "Jan";
            pracownik1.nazwisko = "Kowallsi";
            pracownik1.placa =2000;
            Console.WriteLine("Podaj date urodzenia: dd-mm-rrrr");
            string data_urodzenia = Console.ReadLine();
            
            
            string mod;
            int mod1;
            mod = data_urodzenia.Substring(6, 4);
            mod1 = int.Parse(mod);
            while (mod1 < 1900 || mod1 > 2003)
            {
                Console.WriteLine("Podaj poprawną datę");
                data_urodzenia = Console.ReadLine();
                mod = data_urodzenia.Substring(6, 4);
                mod1 = int.Parse(mod);
            }
            pracownik1.dataUrodzenia = data_urodzenia;
            pracownik1.pokaz();
            pracownik1.obliczBrutto();
            



             
            //Console.WriteLine("test");


            Console.ReadKey();
        }
    }
}
