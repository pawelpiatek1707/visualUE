using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeratory_Iteratory
{
    //1. Indeksery
    //  Indeksery pozwalają na indeksowanie obiektów w taki sam sposób jak ma to miejsce w tablicach. Kiedy definiujemy indeksery dla klas,
    //  zachowuje się ona w podobny sposób do wirtualnej tablicy
    class DniTygodnia
    {
        private string[] Dni;

        public DniTygodnia()
        {
            Dni = new string[7];
            Dni[0] = "poniedziałek";
            Dni[1] = "wtorek";
            Dni[2] = "środa";
            Dni[3] = "czwartek";
            Dni[4] = "piątek";
            Dni[5] = "sobota";
            Dni[6] = "niedziela";
        }

        //Indekser
        public string this[int index] //Indekser zawierający wyłącznie akcesor get 
        {                             
            get
            {
                return this.Dni[index - 1];
            }
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            DniTygodnia d1 = new DniTygodnia();
            Console.WriteLine(d1[5]);
            

            Console.ReadKey();
        }
    }
}
