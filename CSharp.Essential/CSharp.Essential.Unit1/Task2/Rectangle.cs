using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit1
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double Area
        {
            get { return this.AreaCalculator(); }
        }

        public double Perimetr
        {
            get { return this.PerimertCalculator(); }
        }
         double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }

         double PerimertCalculator()
        {
            double perimetr = (side1 * 2) + (side2 * 2);
            return perimetr;
        }
    }
}
