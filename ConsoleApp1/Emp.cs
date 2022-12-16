using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
    // ENUM EXAMPLE
    public enum Dept { HR, Admin, Sales, Development, Testing }
    
     public class Emp
     {
        private int empid;
        private string empname;
        private double basic, hra, da, pf, gross;
        private Dept dept;
        public Emp(int empid, string empname, double basic, Dept dept)
        {
            this.empid = empid; // this refers to the data member
            this.empname = empname;
            this.basic = basic;
            this.dept = dept;
        }
        public void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da) - pf;
        }
        
        public override string ToString()
        {
            return $"Employee id {empid}, emp name {empname} & gross salary of emp {gross} , Deptarment of emp {dept}";
        }
        /*static void Main(string[] args)
        {
            Emp em = new Emp(101, "Emp1", 23000.55, Dept.HR);
            em.CalculateSalary();
            //string data=emp.Print();
            //Console.WriteLine(data);
            // or
            Console.WriteLine(em);
        }*/
     }
}
