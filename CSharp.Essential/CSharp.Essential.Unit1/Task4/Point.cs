using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit1
{
    class Point
    {
        private int x;
        private int y;
        private string pointName;

        public Point(int x, int y, string pointName)
        {
            this.x = x;
            this.y = y;
            this.pointName = pointName;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string PointName
        {
            get { return pointName; }
        }
    }
}
