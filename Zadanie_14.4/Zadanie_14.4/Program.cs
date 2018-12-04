using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Zadanie_14._4
{
    class Program
    {
        static void Read(StreamReader str)
        {
            string line="";
            while((line=str.ReadLine())!=null)
                {
                Console.WriteLine(line);
                }
        }
            
        static void CreateFile(FileInfo fi)
        {
            string path = "D:\\Intel\\gitVisual\\Zadanie_14.1\\Katalog_Zadanie\\Nowy1.txt";
            File.Create(path);

        }
        static void Main(string[] args)
        {
            string path = "D:\\Intel\\gitVisual\\Zadanie_14.1\\Katalog_Zadanie\\Nowy1.txt";
            string path2 = "D:\\Intel\\gitVisual\\Zadanie_14.1\\Katalog_Zadanie\\Nowy2.txt";
            FileInfo fi = new FileInfo(path);
            if (!File.Exists(path))
            {
                CreateFile(fi);
            }
            else
            {
                
                StreamWriter str = new StreamWriter(path);
                str.WriteLine("To jest tekst przesyłany z programu Visual Studio do pliku tekstowego");
            

                str.WriteLine("To jest tekst przesyłany z programu Visual Studio do pliku tekstowego");
                str.Close();
                Console.WriteLine("Tekst został zapisany do pliku.");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.Write("Odczytywanie zawartości pliku: ");
                StreamReader str1 = new StreamReader(path);
                Read(str1);
                if(!File.Exists(path2))
                {
                    File.Copy(path,path2);
                    Console.WriteLine("Skopiowano plik");

                }
                else
                 {
                    Console.WriteLine("Pllik juz itnieje");
                 }
                //usuwanie pliku File.Delete(path)
            }
            Console.ReadKey();
        }
    }
}
