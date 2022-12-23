using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DelegateEx
{
                                           // EventExample
    public delegate void MyDel();
    public class Stud
    {
        public event MyDel Pass;
        public event MyDel Fail;
        public void Accept(int marks)
        {
            if (marks >= 40)
            {
                Pass(); 
            }
            else
            {
                Fail();
            }
        }
        public static class Message
        {
            public static void PassMessage()
            {
                Console.WriteLine("Great ! you are pass");
            }
            public static void FailMessage()
            {
                Console.WriteLine("Sorry ! you are Fail");
            }
        }
        public class Wxyz
        {
            static void Main(string[] args)
            {
                {
                    Stud s1 = new Stud();

                    s1.Pass += new MyDel(Message.PassMessage); 
                    s1.Fail += new MyDel(Message.FailMessage);
                    Console.WriteLine("Marks ");
                    int marks = int.Parse(Console.ReadLine());
                    s1.Accept(marks);
                }

            }
        }

    }
}
