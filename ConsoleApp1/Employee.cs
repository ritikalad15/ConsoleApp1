using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    class Employee
    {
        private int empid;
        private string empname;
        private int empsalary;
        private static int count;

        public Employee(string name, int sal)
        {
            count++;
            empid = count;
            empname = name;
            empsalary = sal;
             
        }
        public static int GetCount()
        {
            return count;
        }
        public override string ToString()
        {
            return $"{empid}  -> {empname} -> {empsalary} ";
        }


    }
}
