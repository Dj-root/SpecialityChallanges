using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit16
{
    class Point
    {
        int x, y, z;

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int Z { get { return z; } }

        public void ShowPoint3D()
        {
            Console.WriteLine("X={0}, Y={1}, Z={2}", x, y, z);
        }

        public static Point operator +(Point p1, Point p2)
        {
            Point p3 = new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
            return p3;
        }
    }
}
