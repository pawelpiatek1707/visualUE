using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "ala lubi zwiereta";
            string string2 = "ZWŁASZCZA PSY I KOTY";
            Console.WriteLine(String.Concat(string1, string2));
            Console.WriteLine(string2.ToLower());
            Console.WriteLine(String.Compare(string1,string2));
            Console.WriteLine(string1[3]+" "+ string2[6]);
            Console.WriteLine(string1.IndexOf("lubi"));
            string string3 = string1.Insert(9, "bardzo ");
            Console.WriteLine(string3);
            Console.ReadKey();
        }
    }
}
