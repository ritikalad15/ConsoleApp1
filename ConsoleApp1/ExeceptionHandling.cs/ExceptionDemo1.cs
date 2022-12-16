using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExeceptionHandling.cs
{
    class ExceptionDemo1
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 20, b = 0;
                int c = a / b;
                Console.WriteLine(c);

            }
            catch(DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
            }
            int a1 = 20, b1 = 30;
            int c1 = a1 + b1;
            Console.WriteLine(c1);
            Console.WriteLine("Execution done sucessfully....");
            
        }
    }
}
