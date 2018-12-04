using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_15._2
{
    class Program
    {
        //public void Add(string book_title1, string book_author1, int pages1, int chapters1, float price1)
        //{
        //    Console.Write("Podaj tytuł: ");
        //    book_title1 = Console.ReadLine();
        //    Console.Write("Podaj autora: ");
        //    book_author1 = Console.ReadLine();
        //    Console.Write("Podaj ilość stron: ");
        //    pages1 = int.Parse(Console.ReadLine());
        //    Console.Write("Podaj ilość rozdziałów: ");
        //    chapters1 = int.Parse(Console.ReadLine());
        //    do
        //    {
        //        Console.Write("Podaj cenę: ");
        //        price1 = float.Parse(Console.ReadLine());
        //    }
        //    while (price1 < 0);

        //}
        static void Main(string[] args)
        {
            //Console.Write("Podaj tytuł: ");
            //string book_title1 = Console.ReadLine();
            //Console.Write("Podaj autora: ");
            //string book_author1 = Console.ReadLine();
            //Console.Write("Podaj ilość stron: ");
            //int pages1 = int.Parse(Console.ReadLine());
            //Console.Write("Podaj ilość rozdziałów: ");
            //int chapters1 = int.Parse(Console.ReadLine());
            //float price1;
            //do
            //{
            //    Console.Write("Podaj cenę: ");
            //     price1 = float.Parse(Console.ReadLine());
            //}
            //while (price1 < 0);
            Book b1 = new Book(book_title1, book_author1, pages1, chapters1, price1);
            
            Console.Clear();
            
            b1.Show();
            b1.Price();
            float rab = 0.25f;
            Console.WriteLine("Rabat 25%");
            b1.Price(rab);
            Console.ReadKey();
        }
    }
}
