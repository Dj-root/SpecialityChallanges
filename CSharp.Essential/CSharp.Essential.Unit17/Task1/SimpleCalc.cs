using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit17
{
    static class SimpleCalc
    {
        public static dynamic Add(double left, double right)
        {
            return left + right;
        }

        public static dynamic Sub(double left, double right)
        {
            return left - right;
        }

        public static dynamic Mul(double left, double right)
        {
            return left * right;
        }

        public static dynamic Div(double left, double right)
        {
            if (right == 0)
            {
                Console.WriteLine("You cannot divide by Zero");
                return null;
            }
            else
            {
                return left / right;
            }
        }
    }
}
