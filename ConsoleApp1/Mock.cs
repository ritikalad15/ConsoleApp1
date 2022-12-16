using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mock
    { 
       public void SumDigitByString(string s)
       {
            int sum = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i]>='0' && s[i] <= '9')
                {
                    sum = sum + (s[i] - '0');
                }
            }
            Console.WriteLine("sum of digits by string "+sum);
       }
       
        public void SumDigitByChar(string s)
        {
            int sum = 0;
           char[]c= s.ToCharArray();
            //Console.WriteLine(string.Join(" ",c));
            for(int i = 0; i < c.Length; i++)
            {
                if(c[i]>='0'&& c[i] <= '9')
                {
                    sum = sum + (c[i]-'0');
                }
            }
            Console.WriteLine("Sum of digits present in string is:"+sum);
        }  
       /* static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");

            string s = Console.ReadLine();
            Mock m = new Mock();
            m.SumDigitByChar(s);
            m.SumDigitByString(s);
            
        }*/
    }
    
}
