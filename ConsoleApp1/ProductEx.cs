using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProductEx
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return $"Id {Id} Name {Name}  Price {Price} ";
            }

           /* static void Main(string[] args)
            {
                 List<ProductEx> l = new List<ProductEx>();
                 l.Add(new ProductEx { Id = 100, Name = "Mouse", Price = 6000 });
                 l.Add(new ProductEx { Id = 101, Name = "Keyboard", Price = 4500 });
                 l.Add(new ProductEx { Id = 103, Name = "Pendrive", Price = 300 });
                 l.Add(new ProductEx { Id = 104, Name = "CPU", Price = 1000 });
                 foreach (ProductEx p in l)
                 {
                   Console.WriteLine(p);
                 }
                 Console.WriteLine("Price less than 2000....");
                 foreach (ProductEx p in l)
                 {
                    if (p.Price < 2000)
                    {
                       Console.WriteLine(p);
                    }
                 }

             }*/
    }
}




                                  /*int[] arr = { 1, 2, 3, 4, 5 };
                                    for (int i = 0; i < arr.Length; i++)
                                     {
                                       Console.WriteLine(arr[i]);
                                     }
                                     Console.WriteLine(arr[7]);*/ 
