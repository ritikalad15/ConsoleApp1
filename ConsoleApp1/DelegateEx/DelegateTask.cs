using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DelegateEx
{
    public delegate int del1(int a, int b);
    public delegate string del2(string s);
    public class DelegateTask
    {
        public int M1(int a,int b)
        {
            return a + b;
        }
        public int M3(int a, int b)
        {
            return a * b;
        }
        public int M4(int a, int b)
        {
            return a - b;
        }
        public string M2(string name)
        {
            return name.ToLower();
        }

    }
    public class XYZ
    {
        static void Main(string[] args)
        {
            DelegateTask d = new DelegateTask();
            del1 d1 = new del1(d.M1);
            d1 += new del1(d.M3);
            d1 += new del1(d.M4);

            Delegate[] list = d1.GetInvocationList();
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(67,45));
            }
           

            //int sum = d1.Invoke(45, 67);
           // Console.WriteLine(sum);

           /* del2 d2 = new del2(d.M2);
            string S= d2.Invoke("RITIKA");
            Console.WriteLine(S);*/
        }
    }
}
