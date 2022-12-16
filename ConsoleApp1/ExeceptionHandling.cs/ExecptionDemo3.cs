using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExeceptionHandling.cs
{
    public class MinimumAgeException:Exception
    {
        public MinimumAgeException(string message):base(message)
        {

        }
    }
    class ExecptionDemo3
    {
        
        public void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new MinimumAgeException("Below 18 age not valid for voting");
            }
            else 
            {
                
                Console.WriteLine("valid for voting");
            }
        }
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("enter the age");
            age = int.Parse(Console.ReadLine());
            ExecptionDemo3 ex1 = new ExecptionDemo3();
            try
            {
                ex1.CheckAge(age);
            }
            catch(MinimumAgeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }
            finally
            {
                Console.WriteLine("Execution is done Sucessfully");
            }
           
        }
    }
}
