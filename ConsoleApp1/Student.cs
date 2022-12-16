using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        private int studentid;
        private string studentname;
        private int physics,maths,english,total;
        private double percentage;

        public Student(int studentid, string studentname, int physics, int maths, int english)
        {
            this.studentid = studentid;
            this.studentname = studentname;
            this.physics = physics;
            this.maths = maths;
            this.english = english;
        } 
        public void CalculatePer()
        {
            total = physics + maths + english;
            percentage = (total/300)*100;

        }
        public override string ToString()
        {
            return "studentid is :" + studentid + "studentname is" + studentname + "percentage is" + percentage;
        }            
    }

}
