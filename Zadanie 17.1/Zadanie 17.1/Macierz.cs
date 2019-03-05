using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_17._1
{
    class Macierz
    {
        public int rozmiar;
        public int[,] macierzA;

        Random randA = new Random();
        public void Uzupelnij( Random rand)
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
}
