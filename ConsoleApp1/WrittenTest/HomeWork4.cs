using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.WrittenTest
{
    class HomeWork4
    {
        // Accept a number from user and Create table of a number

        public void Display(int num)
        {
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i*num);

            }

            
        }
        /*static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            HomeWork4 t = new HomeWork4();
            t.Display(num);

        }*/
    }
}
