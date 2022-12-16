using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class Employee1
    {
        protected int empid;
        protected string empname;
        protected double basic, hra, pf, da, gross;


        public Employee1(int empid, string empname, double basic)
        {
            this.basic = basic;
            this.empid = empid;
            this.empname = empname;
           
        }
        
        public virtual void CalculateSal()
        {
            hra = basic * 0.40;
            pf = basic * 0.12;
            da = basic * 0.20;
            gross = (basic + hra + da) - pf;
        }
        public override string ToString()
        {
            return $"Employee id {empid}, emp name {empname} & gross salary of employee {gross}";
        }



    }
    public class Manager : Employee1
    {
        private double food;
        public Manager(int id, string name, double basic, double food) : base(id, name, basic)
        {
            this.food = food;
        }
        public override void CalculateSal()
        {
            hra = basic * 0.40;
            pf = basic * 0.12;
            da = basic * 0.20;
            gross = (basic + hra + da+food ) - pf;
        }

        public override string ToString()
        {
            return $"Employee id {empid}, emp name {empname} & gross salary of manager {gross}";
        }
    }
    
    
   

   

}
