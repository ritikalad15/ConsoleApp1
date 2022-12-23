using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StaticStudy
{
    public  class Student
    {
        static int count=100;
        int a = 10;
        int id;
        string name;
        static string schoolname = "pune University";

        public  Student(string name)
        {
            count=count+2;
            this.id = count;
            this.name = name;
        }
        public override string ToString()
        {
            return $"Student name is{name} Student Id is {id} School name is {schoolname}";
        }
         public static void Arun(string s)
         {

            schoolname = s;
            Console.WriteLine("I am Static method");
            
         }

        static void Main(string[] args)
        {
            
            Student s = new Student( "Arun");
            Student s1 = new Student( "pranit");
            Student s2 = new Student("ajay");
            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(schoolname);
            Console.WriteLine(s.a);
            Arun("Mumbai university");
            Console.WriteLine(schoolname);

            // Console.WriteLine("Total object created:"+count);
        }


    }
   
    
}
