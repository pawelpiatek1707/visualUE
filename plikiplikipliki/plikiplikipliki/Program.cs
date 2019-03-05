using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace plikiplikipliki
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter strumien = new StreamWriter("./plik.txt");
            Console.Write("Podaj co chcesz zapisac do pliku: ");
            string napis = Console.ReadLine();

            strumien.WriteLine(napis);
            strumien.Close();
            Console.Clear();
            StreamReader strumien1 = new StreamReader("./plik.txt");
            string linia;
            while((linia = strumien1.ReadLine())!=null)
            {
                Console.WriteLine(linia);
            }
            strumien1.Close();
            using (StreamWriter str1 = new StreamWriter("./plik1.txt"))
            {
                str1.WriteLine("sssss");
            }
            using (StreamReader str13 = new StreamReader("./plik1.txt"))
            {
                string linia2;
                while ((linia2 = str13.ReadLine()) != null);
                {
                    Console.WriteLine(linia2);
                }

            }
                Console.ReadKey();
            

        }
    }
}
