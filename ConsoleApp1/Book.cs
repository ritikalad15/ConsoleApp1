using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public  class Book
   {
        private int bookid;
        private string bookname;
        private string authorname;
        private int bookprice;

        public void Acceptdetails(int id,string name,string aname,int p)
        {
            bookid = id;
            bookname = name;
            authorname = aname;
            bookprice = p;


        }
        public void Showdetails()
        {
            Console.WriteLine("bookidis" + bookid);
            Console.WriteLine("book name is" + bookname);
            Console.WriteLine("Author name is" + authorname);
            Console.WriteLine("book price is" + bookprice);

        }
        
   }
}
