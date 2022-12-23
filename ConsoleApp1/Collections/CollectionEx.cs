using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Collections
{
    class CollectionEx
    {
        int rollno;
        string name;
        double marks;

        /*static void Main(string[] args)
        {
            CollectionEx c = new CollectionEx();
            c.rollno = 101;
            c.name = "Ritu";
            c.marks = 70.70;
            CollectionEx c1 = new CollectionEx();
            c1.rollno = 102;
            c1.name = "Navin";
            c1.marks = 69.69;
            Console.WriteLine("##########################################################");
            List<CollectionEx> coll = new List<CollectionEx>();
            coll.Add(c);
            coll.Add(c1);
            Console.WriteLine("*  List  *");
            foreach (var item in coll)
            {
                Console.WriteLine(item.rollno);
                Console.WriteLine(item.name);
                Console.WriteLine(item.marks);
            }
            Console.WriteLine("####################################################");
            Stack<int> s = new Stack<int>();
            s.Push(c.rollno);
            s.Push(c1.rollno);
            Console.WriteLine("* Stack *");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("##################################################");
            Queue<string> q = new Queue<string>();
            q.Enqueue(c.name);
            q.Enqueue(c1.name);
            Console.WriteLine("* Queue *");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("###################################################");
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(c.rollno, c.name);
            d.Add(c1.rollno, c1.name);
            Console.WriteLine("* Dictionary *");
            foreach (KeyValuePair<int,string> item in d)
            {
                Console.WriteLine(item.Key+"--->"+item.Value);
            }
            Console.WriteLine("###############################################");
            SortedList<int, double> s1 = new SortedList<int, double>();
            s1.Add(c.rollno, c.marks);
            s1.Add(c1.rollno, c1.marks);
            Console.WriteLine("* SortedList *");
            foreach (KeyValuePair<int,double> item in s1)
            {
                Console.WriteLine(item.Key+"--->"+item.Value);
            }
            Console.WriteLine();
        }*/
    }
}
