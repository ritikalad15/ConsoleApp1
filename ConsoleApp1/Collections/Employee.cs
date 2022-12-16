using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Collections
{
    public class Check : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Salary == y.Salary)
            {
                return 0;
            }
            else if (x.Salary > y.Salary)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }

     public class Employee :IComparable<Employee>
     {
        private string name;
        private int salary;
        public int Salary { get; set; }
        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"{name}-->{salary}";
        }

        public int CompareTo(Employee o)
        {
           if(this.salary== o.salary)
            {
                return 0;
            }
           else if (this.salary > o.salary)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
     }
    public class Office : IEnumerable

    {
        private  Employee[] emp;
        public Office()
        {
            emp = new Employee[4];
            emp[0] = new Employee("Ritika", 23000);
            emp[1] = new Employee("Ashwini",20000);
            emp[2] = new Employee("Pranit", 100000);
            emp[3] = new Employee("Arun",   200000);



        }
        public IEnumerator GetEnumerator()
        {
            return emp.GetEnumerator();
        }

        static void Main(string[] args)
        {
            Office of = new Office();
            foreach (Employee item in of )
            { 
                Console.WriteLine(item);
            }

            Employee  e1= new Employee("Ritika", 23000);
            Employee  e2 = new Employee("Ashwini", 20000);
            Employee e3= new Employee("Pranit", 100000);
            Employee e4= new Employee("Arun", 200000);

           int a= e2.CompareTo(e3);

            if (a == 0)
            {
                Console.WriteLine("Salary is Same");
            }
            else if (a == 1)
            {
                Console.WriteLine("Ashwinis is high");
            }
            else
            {
                Console.WriteLine("Pranit salary is High");
            }
        }

    }
}
