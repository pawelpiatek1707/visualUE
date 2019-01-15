using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod1 = new Samochod("betka", "beemka", 3, 3.0);
            Console.WriteLine("Podaj wartosci (ilosc paliwa, ilosc kilometrow, trasa, cena paliwa)");
            Console.Write("Podaj ilosc paliwa: ");
            double iloscPaliwa = double.Parse(Console.ReadLine());
            Console.Write("Podaj ilosc kilometrow: ");
            double iloscKolometrow = double.Parse(Console.ReadLine());
            Console.Write("Podaj trase: ");
            double trasa = double.Parse(Console.ReadLine());
            Console.Write("Podaj cene paliwa: ");
            double cenaPaliwa = double.Parse(Console.ReadLine());
            samochod1.Info(iloscPaliwa,iloscKolometrow,trasa,cenaPaliwa);
            Console.ReadKey();
        }
    }
}
