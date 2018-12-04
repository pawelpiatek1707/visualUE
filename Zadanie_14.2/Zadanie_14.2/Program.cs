using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie_14._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Intel\\gitVisual\\Zadanie_14.1\\Katalog_Zadanie";
            DirectoryInfo di = new DirectoryInfo(path);
            
            if (di.Exists)
            {
                Console.WriteLine("Data utworzenia katalogu: "+di.CreationTime);
                Console.WriteLine("Data ostatniegi dostępu: "+di.LastAccessTime);
                Console.WriteLine("Dysk na którym katllog jest zapisany: "+di.Root);
                Console.WriteLine("Katalog macierzysty: "+ di.Parent);
                Console.WriteLine("Pełna ścieżka dostępu: "+di.FullName);
            }

            else
            {
                Console.WriteLine("Katalog nie istnieje");
            }
            Console.ReadKey();
        }
    }
}
