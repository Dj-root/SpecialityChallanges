using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit16
{
    class Block
    {
        int side1, side2, side3, side4;

        public Block(int s1, int s2, int s3, int s4)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
            side4 = s4;
        }

        
        public override string ToString()
        {
            return String.Format("Side1 = {0}, Side2 = {1}, Side3 = {2}, Side4 = {3}", side1, side2, side3, side4);
        }

        public override bool Equals(object obj)
        {
            var block = obj as Block;
            return block != null &&
                   side1 == block.side1 &&
                   side2 == block.side2 &&
                   side3 == block.side3 &&
                   side4 == block.side4;
        }

        public override int GetHashCode()
        {
            var hashCode = -1497281178;
            hashCode = hashCode * -1521134295 + side1.GetHashCode();
            hashCode = hashCode * -1521134295 + side2.GetHashCode();
            hashCode = hashCode * -1521134295 + side3.GetHashCode();
            hashCode = hashCode * -1521134295 + side4.GetHashCode();
            return hashCode;
        }
    }
}
