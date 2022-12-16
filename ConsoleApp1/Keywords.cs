using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Keywords
    {

        //USING PARAMS KEYWORD
        public static void AcceptName(params string[] name)
        {
            Console.WriteLine("value to be print" + name.Length);
            for (int i = 0; i < name.Length; i++)
            {

                Console.WriteLine(name[i]);

            }
        }





        // USING OUT KEYWORD


        public static void Calculate(int a, int b, out int sum, out int sub, out int multiply)
        {
            sum = a + b;
            sub = a - b;
            multiply = a * b;

        }



        // USING REF KEYWORD 
        public  static void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }
    }
}
