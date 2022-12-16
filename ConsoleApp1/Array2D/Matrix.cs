using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array2D
{
    class Matrix
    {
       public void Display(int[,]a)
       {
            

            Console.WriteLine("Matrix");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine(" ");
            }
           
       }
      /* static void Main(string[] args)
       { 
            int[,] arr = new int[4, 3];

            Console.WriteLine("Array Elements are...");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Elements({0},{1}) ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }

            }


             Matrix m = new Matrix();
             m.Display(arr);
       }*/










    }
}
