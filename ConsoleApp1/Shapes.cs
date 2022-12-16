using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract public class Shapes
    {
        public abstract void CalculateArea();
    }
    public class Circle : Shapes
    {

        private int r;
        private double area;

        public Circle(int r)
        {
            this.r = r;
        }

        public override void CalculateArea()
        {
            area = 3.14 * r * r;
        }
        public override string ToString()
        {
            return $"Area of Circle is :{area}";
        }
    }
    public class Rectanclge : Shapes
    {
        private int l;
        private int w;
        private double area;

        public Rectanclge(int l,int w)
        {
            this.l = l;
            this.w = w;

        }
        
        public override void CalculateArea()
        {
            area = l * w;

        }
        public override string ToString()
        {
            return $"Area of RecTangle is :{area}";
        }

    }

    

}

