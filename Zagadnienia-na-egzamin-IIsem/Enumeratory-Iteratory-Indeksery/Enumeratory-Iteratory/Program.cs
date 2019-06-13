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
    //2. Enumeratory
    //3. Iteratory 
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
        static IEnumerable<int> Fib(int fibCount)
        {
            for (int i = 0, prevFib =1,currFib = 1; i < fibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + currFib;
                prevFib = currFib;
                currFib = newFib;
            }
        }
        static void Main(string[] args)
        {
            //1. Indeksery
            //DniTygodnia d1 = new DniTygodnia();
            //Console.WriteLine(d1[5]);
            //==========================================
            //2. Emumeratory
            //Przykład wysokopoziomowego zastosowania enumeratora
            //string tekst = "tekst";
            //var enumerator = tekst.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    var element = enumerator.Current;
            //    Console.WriteLine(element);
            //}
            //Prztkład niskopoziomowego zastosowana enumeratora 
            //foreach(var x in tekst)
            //{
            //    Console.WriteLine(x);
            //}
            //===========================================
            //3. Iteratory - producent enumeratora
            Console.WriteLine(Fib(5));
            Console.ReadKey();
        }
    }
}
