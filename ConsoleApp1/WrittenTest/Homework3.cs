using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.WrittenTest
{
    class Homework3
    {
        // Count number of digits in any number.

        public void CountNum(int num)
        {
            int count = 0;
            
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine("Number of digits is : " + count);


        }

       /* static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Homework3 c = new Homework3();
            c.CountNum(num);

        }*/
          
    }
}
