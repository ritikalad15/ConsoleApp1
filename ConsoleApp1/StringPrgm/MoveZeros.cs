using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.StringPrgm
{
    class MoveZeros
    {
        public void MoveZerotoFirst(int[]a)
        {
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] == 0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }     
            }
        }
        public void MoveZerotoLast(int[] a)
        {
            for (int i =a.Length-1;i >=1; i--)
            {
                for (int j =i-1; j >=0; j--)
                {
                    if (a[j] == 0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }     
                }     
            }     
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 10, 0, 5, 3, 0, 4, 1 };
            Console.WriteLine("Original Array...");
            foreach (var item in arr)

            {
                Console.WriteLine(item);
            }
            MoveZeros m = new MoveZeros();
            Console.WriteLine("Move zero to first.......");
            m.MoveZerotoFirst(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Move zero to last.......");
            m.MoveZerotoLast(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
