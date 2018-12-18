using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_15._2_edit_
{
    class Program
    {
        static void Main(string[] args)
        {
            //skończyć 
            Book[] arr1 = new Book[3];
            arr1[0] = new Book("Książka1", "autor2", 123, 2, 15f);
            arr1[1] = new Book("Książka2", "autor2", 133, 10, 10f);
            arr1[2] = new Book("Książka2", "autor2", 133, 9, 33f);
        }
    }
}
