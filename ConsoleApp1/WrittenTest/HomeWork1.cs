using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.WrittenTest
{
    class HomeWork1
    {
        // Check if given number is Armstrong or not

        public void Armstrong(int num)
        {
            int temp = num;
            int result = 0;
            while (num > 0)
            {
                int digit = num % 10;
                result = result + (digit * digit * digit);
                num = num / 10;

            }
            if (result == temp)
            {
                Console.WriteLine("Number is Armstrong");

            }
            else
            {
                Console.WriteLine("Number is not Armstrong");
            }
        }
       /* static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            HomeWork1 s = new HomeWork1();
            s.Armstrong(num);

        }
*/
    }
}   
 