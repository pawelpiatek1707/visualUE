using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_17._1
{
    static class Operacje
    {
        public static void Dodaj(int[,] macierz1, int[,] macierz2)
        {
            Console.WriteLine("Dodane macierze");
            Console.WriteLine("---------------");
            for (int i = 0; i < macierz1.GetLength(0); i++)
            {
                for (int j = 0; j < macierz1.GetLength(0); j++)
                {
                    Console.Write(macierz1[i, j] + macierz2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Odejmowanie(int[,] macierz1, int[,] macierz2)
        {
            Console.WriteLine("Odjęte macierze");
            Console.WriteLine("---------------");
            for (int i = 0; i < macierz1.GetLength(0); i++)
            {
                for (int j = 0; j < macierz1.GetLength(0); j++)
                {
                    Console.Write(macierz1[i, j] - macierz2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Mnozenie(int[,] macirz1, int[,] macierz2)
        {
            int n = macirz1.GetLength(0);
            int[,] macierz3 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    macierz3[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        macierz3[i, j] += macirz1[i, k] * macierz2[k, j];
                    }
                }
            }
            Console.WriteLine("Pomnożone macierze");
            Console.WriteLine("------------------");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(macierz3[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }

    class Macierz
    {
        public int rozmiar;
        public int[,] macierzA;

        Random randA = new Random();
        public void Uzupelnij(Random rand)
        {
            for (int i = 0; i < macierzA.GetLength(0); i++)
            {
                for (int j = 0; j < macierzA.GetLength(0); j++)
                {
                    macierzA[i, j] = rand.Next(1, 20);
                }
            }
        }

        public void Pokaz()
        {
            for (int i = 0; i < macierzA.GetLength(0); i++)
            {
                for (int j = 0; j < macierzA.GetLength(0); j++)
                {
                    Console.Write(macierzA[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public Macierz(int wymiar)
        {
            rozmiar = wymiar;
            macierzA = new int[rozmiar, rozmiar];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj stopien macierzy kwadratowej: ");
            int n = int.Parse(Console.ReadLine());
            Macierz macierz1 = new Macierz(n);
            Macierz macierz2 = new Macierz(n);
            Random randA = new Random();
            macierz1.Uzupelnij(randA);
            macierz2.Uzupelnij(randA);
            Console.WriteLine("Pierwsza macierz");
            Console.WriteLine("----------------");
            macierz1.Pokaz();
            Console.WriteLine();
            Console.WriteLine("Druga macierz");
            Console.WriteLine("--------------");
            macierz1.Pokaz();
            Console.WriteLine();
            Operacje.Dodaj(macierz1.macierzA, macierz2.macierzA);
            Console.WriteLine();
            Operacje.Odejmowanie(macierz1.macierzA, macierz2.macierzA);
            Console.WriteLine();
            Operacje.Mnozenie(macierz1.macierzA, macierz2.macierzA);
            Console.ReadLine();

        }
    }
}
