using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Collections
{
    public enum BookCatagary
    {
        Story, KideBook, HistryBook
    }
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public double BookPrice { get; set; }
        public string BookAuthor { get; set; }

        public BookCatagary bookcatagary;
        public override string ToString()
        {
            return $"Catagary is: {bookcatagary}\nBook Id: {BookId}  book name: {BookName}  book Price:  {BookPrice} Auther is: {BookAuthor} ";
        }


    }
    class BookLibrary
    {
        static void Main(string[] args)
        {


            List<Book> b = new List<Book>();
            b.Add(new Book { BookId = 100, BookName = "hira The story", BookPrice = 2000, BookAuthor = "mr .shyam", bookcatagary = BookCatagary.Story });
            b.Add(new Book { BookId = 100, BookName = "hira The story", BookPrice = 23000, BookAuthor = "mr .tushar", bookcatagary = BookCatagary.Story });
            b.Add(new Book { BookId = 100, BookName = "rama The story", BookPrice = 4000, BookAuthor = "mrs .mira", bookcatagary = BookCatagary.KideBook });
            b.Add(new Book { BookId = 100, BookName = "banta The story", BookPrice = 6000, BookAuthor = "mr .sudhir", bookcatagary = BookCatagary.HistryBook });
            b.Add(new Book { BookId = 100, BookName = "shanta The story", BookPrice = 7000, BookAuthor = "mr .Kumar", bookcatagary = BookCatagary.Story });
            foreach (Book bk in b)
            {
                Console.WriteLine(bk);
                Console.WriteLine("---------------------------");
            }
        }
    }
}
    
