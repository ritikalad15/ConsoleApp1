using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Collections
{

    public enum Productss { Furniture, Mobiles }
    public class prod
    {
        public Productss Production;
        public string Name { get; set; }
        public int Price { get; set; }

    }


    class ProDuctEx
    {
        static void Main(string[] args)
        {
            List<prod> List3 = new List<prod>()
            {
                new prod {Production=Productss.Furniture ,Name ="Table",Price =1234},
                new prod {Production=Productss.Furniture ,Name ="Chair",Price =534},
                new prod {Production=Productss.Furniture ,Name ="Sofa",Price =4234},
                new prod {Production=Productss.Furniture ,Name ="Study table",Price =2234},

                new prod {Production =Productss.Mobiles ,Name ="Samsung",Price =7894},
                new prod {Production =Productss.Mobiles ,Name ="Iphone",Price =7894},
                new prod {Production =Productss.Mobiles ,Name ="realme",Price =7894}
            };
            foreach (prod c in List3)
            {
                Console.WriteLine($"Product Type={c.Production },\tName of Product={c.Name },\tPrice of Product={c.Price }");
            }

            Console.WriteLine("------------------------------------------------------------------");

            foreach (prod d in List3)
            {
                if (d.Production == Productss.Mobiles)
                {
                    Console.WriteLine($"Product Type={d.Production },\tName of Product={d.Name },\tPrice of Product={d.Price }");
                }

            }
        }
    }
}

   

   

