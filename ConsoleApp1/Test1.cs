using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Test1
    {

        public void M1()
        {
            Console.WriteLine("M1 method ");

        }
        public void M2()
        {
            Console.WriteLine("M2 method");
        }
    }
    public static class ExtensionClass
    {
        public static void M3(this Test1 t1)
        {
            Console.WriteLine("M3 method");
        }
        public static void M4(this Test1 t1, string name)
        { 
           Console.WriteLine("M4 method " + name);
        }
    }


       

    
}
