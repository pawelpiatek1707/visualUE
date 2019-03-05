using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_19._02._19
{
    class Program
    {
        static void Main(string[] args)
        {
            //LiczbaCalkowita l1 = new LiczbaCalkowita(5);
            //Console.WriteLine( l1.PobierzLicze());
            //l1.WyswietlLiczbe();
            //Console.WriteLine(l1.Liczba);
            // Prostokąt p1 = new Prostokąt();
            // p1.a[0] = 3;
            // p1.a[1] = 3;
            // p1.b[0] = 4;
            // p1.b[1] = 2;
            // p1.c[0] = 5;
            // p1.c[1] = 1;
            // p1.d[0] = 6;
            // p1.d[1] = -3d;
            // p1.Wyswietl();
            //double [] arr= Metody.Zwracaj(p1.a);
            // Metody.Wyswietl(arr,1);

            Punkt p2 = new Punkt(3, 4);
            p2.Wypisz();
            Console.Write("Podaj o ile chcesz zmienic współrzędna X: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Podaj o ile chcesz zmienic współrzędna Y: ");
            double b = double.Parse(Console.ReadLine());
            p2.Przesun(a, b);
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Wypisanie współrzędnej X z użyciem właściwości: "+p2.X);
            Console.WriteLine("Wypisanie współrzędnej Y z użyciem właściwości: "+p2.Y);


            Console.ReadKey();

        }
    }
}
