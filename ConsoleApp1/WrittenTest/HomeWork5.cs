using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.WrittenTest
{
    class HomeWork5
    {
        // Find first 10 even numbers.

        public void show (int i)
        {
            while (i <= 20)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    
                }
                i++;
            }
        }

        /*static void Main(string[] args)
        {
            int i = 1;
            HomeWork5 h = new HomeWork5();
            h.show(i);

        }*/
    }
}
