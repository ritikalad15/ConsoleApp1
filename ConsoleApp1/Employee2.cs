using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee2
    {
        protected int empid;
        protected string empname;
        protected double basic, hra, pf, da, gross;


        public Employee2(int empid, string empname, double basic)
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
    public class SalesManger : Employee2
    {
        private double Comision;
        private double bonus;

        public SalesManger(int id, string name, double basic, double comision,double bonus) : base(id, name, basic)
        {
            this.Comision =comision ;
            this.bonus = bonus;
        }
        public override void CalculateSal()
        {
            hra = basic * 0.40;
            pf = basic * 0.12;
            da = basic * 0.20;
            gross = (basic + hra + da + Comision+ bonus) - pf;
        }

        public override string ToString()
        {
            return $"Employee id {empid}, emp name {empname} & gross salary of Salesmanager {gross}";
        }
    }
}
