using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_15._2_edit_
{
    class Book
    {
        private string book_title { get; set; }
        private string book_author { get; set; }
        private int pages { get; set; }
        private int chapters { get; set; }
        private float price { get; set; }
        private const float extra_price = 0.05f;

        public Book(string book_title1, string book_author1, int pages1, int chapters1, float price1)
        {
            book_title = book_title1;
            book_author = book_author1;
            pages = pages1;
            chapters = chapters1;
            price = price1;

        }
    }
}
