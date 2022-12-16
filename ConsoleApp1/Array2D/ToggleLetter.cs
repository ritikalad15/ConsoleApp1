using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array2D
{
    class ToggleLetter
    {
        public void Alternate(string a)
        {
            char[] r = a.ToCharArray();
            for (int i = 0; i < r.Length; i++)
            {
                if (r[i] >= 'a' && r[i] <= 'z')
                {
                    r[i] = (char)(r[i] + 2);
                }
            }
            Console.WriteLine(string.Join("", r));
        }


        public void Toggle(string s)
        {
            char[] c = s.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] >= 'a' && c[i] <= 'z')
                {
                    c[i] = (char)(c[i] - 32);

                }
                else if (c[i] >= 'A' && c[i] <= 'Z')
                {
                    c[i] = (char)(c[i] + 32);

                }
            }
            Console.WriteLine(string.Join("", c));
        }
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");

            // string s = Console.ReadLine();
            //ToggleLetter t = new ToggleLetter()
            //t.Toggle(s);
            string a = Console.ReadLine();
            ToggleLetter t = new ToggleLetter();
            t.Alternate(a);
         }*/


    }
}
