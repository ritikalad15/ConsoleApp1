using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExeceptionHandling.cs
{
     public class NullnameException:Exception
     {
        public NullnameException(string message):base(message)
        {

        }
     }
   /* class Student
    {
        private string name;
        public Student()
        {
           // Console.WriteLine("enter the name");
            //name = Console.ReadLine();
        }   
         public void AcceptName(string name)
         {
            if (name==null)
            {
                throw new NullnameException("name is Empty");
            }
            else
            {
                this.name = name;
            }
         }
         public override string ToString()
         {
            return $" student name is {name}";
         }
         static void Main(string[] args)
         {
            Student s = new Student();
             try
             {
               s.AcceptName(null);
             }
             catch(NullnameException n)
             {
                Console.WriteLine(n.Message);
                Console.WriteLine(n.GetType());
             }
             Console.WriteLine("Execution done sucessfully");   
         }
    }*/
}
