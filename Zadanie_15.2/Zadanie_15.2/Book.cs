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
            Console.WriteLine("Tytuł: "+ this.book_title);
            Console.WriteLine("Autor: "+ this.book_author);
            Console.WriteLine("Liczba stron: "+ this.pages);
            Console.WriteLine("Liczba rozdziałów: "+ this.chapters);
            Console.WriteLine("Cena: "+ this.price);
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
