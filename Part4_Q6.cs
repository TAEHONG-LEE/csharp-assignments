using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //Part4_Q6
    class Book
    {
        public string Title;
        public string Author;
        public Book(string title, string athor)
        {
            Title = title;
            Author = athor;
        }

        static public void ShowInfo()
        {
            Book book = new Book("어린왕자", "생택쥐페리");
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
        }

        static public void Main(string[] args)
        {
            ShowInfo();
        }
    }

}
