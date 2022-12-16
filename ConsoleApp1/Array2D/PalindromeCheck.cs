using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array2D
{
    class PalindromeCheck
    {
        public void Palindrome(string s)
        {
            bool flag = false;
            for(int i=0,j=s.Length-1;i<s.Length/2 && j>=s.Length/2;i++,j--)
            {
                if (s[i] == s[j])
                {
                    flag = true; 
                }
            }
            if (flag == true)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }
        }
       /* static void Main(string[] args)
        {
            string s = Console.ReadLine();
            PalindromeCheck p = new PalindromeCheck();
            p.Palindrome(s);
        }*/
    }
}
 