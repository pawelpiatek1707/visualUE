using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przed_II_Kolosem
{
    class Program
    {
        static void Shapes(double x,double y)
        {
            double surface = x * y;
            double circuit = 2 * x + 2 * y;
            Console.WriteLine("Pole prostokąta: " + surface);
            Console.WriteLine("Obwód prostokąta: "+circuit);
        }
        static void Shapes(out double x,out double y)
        {
            x = 3;
            y = 4;
            double surface = x * y;
            double circuit = 2 * x + 2 * y;
            Console.Write("Pole prostokąta: "+surface);
            Console.WriteLine();
            Console.WriteLine("Obwód prostokąta: "+circuit);
        }
        static double Surface(double x, double y)
        {

            return x * y;
        }
        static double Circuit(double x, double y)
        {
            return (2 * x + 2 * y);
        }
        static void Energy()
        {
            Console.Write("Podaj początkowy stan licznika: ");
            float begin = float.Parse(Console.ReadLine());
            Console.Write("Podaj końcowy stan licnzika: ");
            float end = float.Parse(Console.ReadLine());
            float allEnergy = end / begin * 0.5f;
            Console.WriteLine("Zużycie energii elektrycznej: "+allEnergy);
        }
        static void Table(int[]tab1,int x)
        {
            for(int i=0;i<tab1.Length;i++)
            {
                tab1[i] = tab1[i] * x;
            }
            foreach(var y in tab1)
            {
                Console.Write(y+" ");
            }
        }
        static void Main(string[] args)
        {
            //Zadanie 12.1 
            //Console.Write("Pole i obwód obliczany pierwszym sposobem: ");
            //Shapes(4.5, 5.5);
            //Console.Write("Pole obliczone drugim sposobem: ");
            //Console.WriteLine(Surface(4.5, 5.5)); 
            //Console.WriteLine("Obwód obliczany drugim sposobem: ");
            //Console.WriteLine(Circuit(4.5, 5.5)); 
            //--------------------------------------------
            //Zadanie 12.2
            //double a, b;

            //Shapes(out a, out b);
            //--------------------------------------------
            //ZAdanie 12.3
            // Energy();
            //--------------------------------------------
            //Zadananie 12.4
            //Console.Write("Podaj rozmiar tablicy: ");
            //int arrLength = int.Parse(Console.ReadLine());
            //Random rand1 = new Random();
            //int[] tabUser = new int[arrLength];
            //for(int i = 0; i<arrLength;i++)
            //{
            //    tabUser[i] = rand1.Next(1, 10);
            //}
            //Console.WriteLine("Tablica przed mnożeniem przez liczbę");
            //foreach(var x in tabUser)
            //{
            //    Console.Write(x+ " ");
            //}
            //Console.WriteLine();
            //Console.Write("Podaj liczbe przez jaką chcesz przemnożyć zawartość tablicy: ");
            //int userNumber = int.Parse(Console.ReadLine());
            //Table(tabUser, userNumber);
            //-----------------------------------------------
            //Zadanie 13.1, 13.2
            //Mno firstNumber = new Mno(5, 4);
            //firstNumber.Show();
            //firstNumber.mno1();
            //Console.WriteLine("Kwadrat z symboli");
            //Console.Write("Podaj rozmiar kwadratu: ");
            //int squareSize = int.Parse(Console.ReadLine());
            //Console.Write("Podaj symbol z jakiego chcesz zbudować kwadrat: ");
            //string symbol = Console.ReadLine();
            //Mno square = new Mno(squareSize);
            //square.squareDrow(squareSize, symbol);
            //-----------------------------------------------
            //Zadanie 13.3
            //Car car1 = new Car(105, "Skoda");
            //car1.ShowModel();
            //car1.ShowPower();
            //car1.Start();
            //car1.Ride();
            //car1.Stop();
            //-----------------------------------------------
            //Zadaanie 13.4
            //Console.Write("Podaj numer licznika: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("Podaj początkowy stan licznika: ");
            //float begin = float.Parse(Console.ReadLine());
            //Console.Write("Podaj aktualny stan licznika: ");
            //float current = float.Parse(Console.ReadLine());
            //Power power1 = new Power(number, begin, current);
            //Console.WriteLine("Opcje");
            //Console.WriteLine("1. Wyświetl numer licznika");
            //Console.WriteLine("2. Wyświetl początkowy stan licznika");
            //Console.WriteLine("3. Wyświetl obecny stan licznika");
            //Console.WriteLine("4. Oblicz zużycie energii");
            //Console.Write("Wybierz opcje: ");
            //int option = int.Parse(Console.ReadLine());
            //switch (option)
            //{
            //    case 1:
            //        {
            //            power1.ShowMeterId();
            //            break;
            //        }
            //    case 2:
            //        {
            //            power1.ShowBegin();
            //            break;
            //        }
            //    case 3:
            //        {
            //            power1.ShowCurrent();
            //            break;
            //        }
            //    case 4:
            //        {

            //            power1.PowerState();
            //            break;
            //        }

            //}
            //----------------------------------
            //Zadanie 13.5
            Person person1 = new Person("Jan", "Kowalski", "17-07-1998");
            person1.ShowData();
            person1.NewData();
            Console.Write("Wyświetlić ponownie dane? tak/nie: ");
            string choice = Console.ReadLine();
            if(choice == "tak")
            {
                person1.ShowData();
            }
            person1.BirthMethod();
            Console.ReadKey();

        }
    }
}
