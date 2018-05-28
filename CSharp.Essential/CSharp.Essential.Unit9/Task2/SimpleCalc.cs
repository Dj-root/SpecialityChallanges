using System;

namespace CSharp.Essential.Unit9
{
    public delegate double Calc(double a, double b);

    public class SimpleCalc
    {
        private double a, b, result;
        private string oper;

        Calc add = (a, b) => { return a + b; };
        Calc sub = (a, b) => { return a - b; };
        Calc mult = (a, b) => { return a * b; };

        Calc div = (double a, double b) =>
        {
            if (b == 0)
            {
                return 0;
            }

            return a / b;
        };

        public void RunCalculation()
        {
            string exitFlag;
            Console.WriteLine("Weclome to simply calculator.");

            do
            {
                Calculate();
                Console.WriteLine("Do you want to calculate another expression? (Y\\N)");
                exitFlag = Console.ReadLine();
            } while (exitFlag !="N");
        }

        private void Calculate()
        {
            Console.Write("Type left operand: ");
            Double.TryParse(Console.ReadLine(), out a);

            Console.Write("Type operator: ");
            oper = Console.ReadLine();

            Console.Write("Type right operand: ");
            Double.TryParse(Console.ReadLine(), out b);

            switch (oper)
            {
                case "+":
                    result = add(a, b);
                    break;
                case "-":
                    result = sub(a, b);
                    break;
                case "*":
                    result = mult(a, b);
                    break;
                case "/":
                    result = div(a, b);
                    break;
                default:
                    Console.WriteLine("Incorrect operator");
                    break;
            }

            Console.WriteLine("The result of operation {0} {1} {2} = {3}", a, oper, b, result);
        }
    }
}