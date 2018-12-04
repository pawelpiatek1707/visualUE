using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_15._2
{
    class Book 
    {
       private string book_title;
       private  string book_author;
        private int pages;
        private int chapters;
        private float price;
        private const float extra_price = 0.05f;
        

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
        public void Price()
        {
            float price = this.price;
            Console.WriteLine("Cena przed rabatem:" +price);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Cena po rabacie (5%): "+ (price-(price*extra_price)));
            Console.WriteLine();
        }
        public void Price(float extra1)
        {
            
            float price = this.price;
            Console.WriteLine("Cena książki po innym rabacie: "+(price-(price*extra1)));
        }
        public void Show()
        {
            Console.WriteLine("Zawartość obiektu");
            Console.WriteLine("---------------------");
            Console.WriteLine("Tytuł: "+ book_title);
            Console.WriteLine("Autor: "+ book_author);
            Console.WriteLine("Liczba stron: "+ pages);
            Console.WriteLine("Liczba rozdziałów: "+ chapters);
            Console.WriteLine("Cena: "+ price);
        }
        public Book(string book_title1,string book_author1, int pages1,int chapters1, float price1)
        {
            book_title = book_title1;
            book_author = book_author1;
            pages = pages1;
            chapters = chapters1;
            price = price1;
            
        }
    }
}
