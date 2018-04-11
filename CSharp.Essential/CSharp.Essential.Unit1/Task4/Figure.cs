using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit1
{
    class Figure
    {
        private Point a;
        private Point b;
        private Point c;
        private Point d;
        private Point e;

        public Figure(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Figure(Point a, Point b, Point c, Point d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }

        double LengthSide(Point a, Point b)
        {
            double length;
            int deltaX = b.X - a.X;
            int deltaY = b.Y - a.Y;

            length = Math.Abs(Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2)));

            return length;
        }

        public void PerimeterCalculator()
        {
            double perimetr;

            perimetr = LengthSide(a, b);
            perimetr += LengthSide(b, c);

            
            if (e != null)
            {
                perimetr += LengthSide(c, d);
                perimetr += LengthSide(d, e);
                perimetr += LengthSide(e,a);
            }
            else if (d != null)
            {
                perimetr += LengthSide(c, d);
                perimetr += LengthSide(d, a);
            }
            else
            {
                perimetr += LengthSide(c, a);
            }

            
            Console.WriteLine("The perimetr of Your figure is: {0}",perimetr);

        }
    }
}
