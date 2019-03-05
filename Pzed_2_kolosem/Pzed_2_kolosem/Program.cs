using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pzed_2_kolosem
{
    static class Dzialania
    {
        public static int Dodaj(int x, int y)
        {
            return (x + y);
        }
    }
    class Test
    {
        private int x;
        private int y;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Dodaj()
        {
            return (x + y);
        }
        public int Odejmij()
        {
            return (x - y);
        }
        public void DajGlos()
        {
            Console.WriteLine("A weź sie pierdol");
        }
        public Test(int a, int b)
        {
            x = a;
            y = b;
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {

            string path = "D:\\Intel\\gitVisual\\Pzed_2_kolosem\\Katalog1";
            string path1 = "D:\\Intel\\gitVisual\\Pzed_2_kolosem\\Katalog1\\plik.txt";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Katalog został utworzony");
                return;
            }
            else
            {
                Console.WriteLine("Katalog juz istnieje");
            }
            DirectoryInfo di = new DirectoryInfo(path);
            if(di.Exists)
            {
                Console.WriteLine("Data utworzenia: "+di.CreationTime);
                Console.WriteLine("Data ostatniego dostępu: "+di.LastAccessTime);
                Console.WriteLine("Dysk, na którym sie znajduje: "+di.Root);
                Console.WriteLine("Katalog macierzysty: "+di.Parent);
            }
            FileInfo fi = new FileInfo(path1);
            //File.Create(path1);
            StreamWriter str = new StreamWriter(path1);
            str.WriteLine("tekst zapisany do pliku");
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.CreationTime);
           
            
            str.Close();
            StreamWriter str1 = new StreamWriter(path1);
            Test test1 = new Test(2, 3);
            Console.WriteLine(test1.Dodaj());
            Console.WriteLine(test1.Odejmij());
            test1.DajGlos();
            Console.WriteLine("Wartosc x: " +test1.X);
            test1.Y = 3;
            Console.WriteLine("Nowa wartosc Y: "+test1.Y);
            Console.WriteLine( "Wynik dodawania: "+ Dzialania.Dodaj(3, 4)); 


            Console.ReadKey();
        }
    }
}
