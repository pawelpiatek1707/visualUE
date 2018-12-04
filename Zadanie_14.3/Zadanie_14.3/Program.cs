using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie_14._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Intel\\gitVisual\\Zadanie_14.1\\Katalog_Zadanie\\Nowy.txt";
            FileInfo fi = new FileInfo(path);
            if (File.Exists(path))
            {
                //File.Create(path);
                Console.WriteLine("Nazwa pliku: "+fi.Name);
                Console.WriteLine("Czas utworzenia pliku: "+fi.CreationTime);
                Console.WriteLine("Czas ostatniego dostępu :"+fi.LastAccessTime);
                Console.WriteLine("Pełna ścieżka dostęu : "+fi.FullName);
            }
            else
            {
                Console.WriteLine("Podany plik nie istnieje");
            }
            Console.ReadKey();
        }
    }
}
