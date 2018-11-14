using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("| Program obliczający średnie spalanie |");
            
           
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
             Console.WriteLine("Opcje");
            Console.WriteLine("1. Obliczenie średniego spalania: ");
            Console.WriteLine("2. Prognozowane zużycie paliwa przy podaniu średniego spalania: ");
            Console.WriteLine("3. Obliczanie średniej prędkości: ");
            Console.WriteLine("----------------------------------------");
            Console.Write("Podaj opcję: ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
                {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Obliczanie sredniego zużucia paliwa: ");
                        Console.WriteLine("-------------------------------------");
                        Console.Write("Podaj pojemność baku w twoim samochodzie w L: ");
                        float fuel = float.Parse(Console.ReadLine());
                        Console.Write("Podaj zasięg przejechany na pełnym baku w km: ");
                        float distance = float.Parse(Console.ReadLine());
                        float averrage = fuel/distance*100;
                        Console.WriteLine("Średnie spalanie: " + averrage);
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Obliczanie średniego zużycia paliwa na danej trasie");
                        Console.Write("Podaj średnie spalanie na 100km: ");
                        float averrage = float.Parse(Console.ReadLine());
                        Console.Write("Podaj dłukość trasy jaką chcesz przejechac w km: ");
                        float distance = float.Parse(Console.ReadLine());
                        float fuellost = averrage/100 *distance;
                        Console.WriteLine("Zużycie paliwa na podanej trasie: " + fuellost);
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Obliczanie średniej prędkości na podanym dystansie");
                        Console.Write("Podaj dystans w km: ");
                        float distance = float.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj czas podrózy w minutach: ");
                        float time = float.Parse(Console.ReadLine());
                        float time1 = time/60;
                        float speed = distance/time1;
                        Console.WriteLine("Średnia prędkość na danym odciku: "+speed + "km/h");
                        break;
                    }
                }
            
            Console.ReadKey();
            
        }
    }
}
