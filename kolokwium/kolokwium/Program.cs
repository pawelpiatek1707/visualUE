using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Program
    {
        static void Kuflowe(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        static void Kuflowe(double x)
        {
            Console.WriteLine(x);
        }
        static void Kuflowe(string x)
        {
            x.Substring(2, 3);
        }
        static void Main(string[] args)
        {
            ////Zadanie 3
            //Console.WriteLine("Wybierz opcje");
            //Console.WriteLine("1. Obliczanie pola kwadratu");
            //Console.WriteLine("2. Oblicznie pola koła");
            //Console.Write("Podaj opcje: ");
            //int x = int.Parse(Console.ReadLine());
            //switch (x)
            //{
            //    case 1:
            //        {
            //            Console.Clear();
            //            Console.Write("Podaj bok kwadratu: ");
            //            double a = double.Parse(Console.ReadLine());
            //            double pole = a * a;
            //            Console.WriteLine("Pole kwadratu: " + pole);
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.Clear();
            //            Console.Write("Podaj promien koła: ");
            //            double r = double.Parse(Console.ReadLine());
            //            double pole = Math.PI * (r * r);
            //            Console.WriteLine("Pole koła: " + pole);
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Nie ma podanej opcji");
            //            break;
            //        }
            //}
            ////Zadanie 6
            //string uczelnia = "Uniwersytet ekonomiczny";
            //Console.WriteLine("Pierwsze wystąpnienie litery e: "+uczelnia.IndexOf("e"));
            //Console.WriteLine("Ciag znaków po wstawieniu słowa \"w Katowicach\": "+uczelnia.Insert(23, " W katowicach"));
            // double x = 4;

            // double wynik = 4 / 3 *x;
            // Console.WriteLine(wynik);
            // double y = 5.4444;
            // int a = (int)y;
            // int b = 4;
            // double d = b;
            // int c = Convert.ToInt32(y);
            // string e = "123";
            // int f = int.Parse(e);
            // Console.WriteLine(c);
            // Console.WriteLine(a);
            //char znak = 'A';
            //Console.WriteLine('B'+znak);
            //int[] x = new int[5];

            //int y = new int();
            //Console.WriteLine(y);
            int[] tab2 = { 3, 4, 5, 6, 7, };
            int a = Array.IndexOf(tab2, 4);
            Console.WriteLine(a);
            int[][] tab =
            {
                new int[]{1,2,4},

                new int[]{3,4,5},
                new int[]{6,7,8}

            };
            int[][,] tab1 =
            {
                new int[,]{{1,2,3},{3,4,5}},
                new int[,]{{1,2,5},{3,4,8}}
            };
            int y = tab1[0][0, 2];
            Console.WriteLine(y);
            //foreach(int[]podtab in tab)
            //{
            //    foreach(int x in podtab)
            //    {
            //        Console.Write(x);
            //    }
            //}
            //for(int i=0;i<tab.Length;i++)
            //{
            //    for(int j=0;j<tab[i].Length;j++)
            //    {
            //        Console.WriteLine(tab[i][j]);
            //    }
            //}
            //int x = tab[0][2];
            Console.WriteLine();
            string napis = "mam juz dosyc";
            string napis1 = "mam juz dosyc";
            Console.WriteLine( String.Compare(napis, napis1) ); 
            Console.WriteLine("-------------------");
            Console.WriteLine(napis.Substring(2,3));
            Console.WriteLine(napis);
            Console.WriteLine("----------------------");
            Console.WriteLine( napis.Insert(2, "chuj") ); 
            Console.WriteLine(napis);
            const int stala = 4;
            
            Console.ReadKey();
        }
    }
}
