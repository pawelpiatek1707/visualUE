using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie_14._1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string path = "D:\\Intel\\gitVisual\\Zadanie_14.1\\Katalog_Zadanie";
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

            Console.ReadKey();
        }
    }
}
