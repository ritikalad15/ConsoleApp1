using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book1
    {
        public int Bookid { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int BookPrice { get; set; }


        public override string ToString()
        {
            return $"Bookid is{Bookid} Book name is {BookName} Author name is {AuthorName}  Book price is {BookPrice} ";
        }
    }
}
