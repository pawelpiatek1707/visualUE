using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_17._1
{
    class Macierz
    {
        public int wiersz1;
        
        


        public int[,] macierzA;

        Random randA = new Random();
        public void Uzupelnij(int [,]macierz1, Random rand)
        {
            for (int i = 0; i < macierz1.GetLength(0); i++)
            {
                for (int j = 0; j < macierz1.GetLength(0); j++)
                {
                    macierz1[i, j] = rand.Next(1, 20);

                }
            }
        }
        public void Pokaz(int[,]macierz1)
        {
            for (int i = 0; i < macierz1.GetLength(0); i++)
            {
                for (int j = 0; j < macierz1.GetLength(0); j++)
                {
                    Console.Write(macierz1[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public Macierz(int wierszPierwszy  )
        {
            wiersz1 = wierszPierwszy;
           
            
            macierzA = new int[wiersz1, wiersz1];
            

        }

       
        
    }
}
