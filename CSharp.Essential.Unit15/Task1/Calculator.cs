using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit15
{


    class Calculator
    {
        private enum Operation : short
        {
            Add,
            Subtract,
            Multily,
            Divide,
            Help,
            Exit
        }

        private static bool exitFlag = false;

        static ConsoleColor dfltTextColor = ConsoleColor.Gray;
        static ConsoleColor rsltTextColor = ConsoleColor.White;
        static ConsoleColor errorTextColor = ConsoleColor.Red;
        static ConsoleColor successTextColor = ConsoleColor.Green;

        public static void Calc()
        {
            Console.WriteLine("Welcome to simple calculator.");

            MenuHelp();
            do
            {
                Console.Write("\nSelect action, press 0 for help or 'X' for exit");
                Console.Write("Your choice: ");
                ExecuteAction();


            } while (!exitFlag);
            Console.WriteLine("Thank you for using our program");
        }

        private static void MenuHelp()
        {
            Console.WriteLine("Calculator usage:\n" +
                "1 - Add\n" +
                "2 - Subtract\n" +
                "3 - Multily\n" +
                "4 - Divide\n" +
                "0 - Help\n" +
                "X - Exit");
        }

        private static double GetOperand()
        {
            double operand;
            string strOper = Console.ReadLine();

            if (Double.TryParse(strOper, out operand))
            {
                return operand;
            }
            else
            {
                throw new InvalidCastException();
            }


        }

        private static void ExecuteAction()
        {
            string choice = Console.ReadLine();
            Operation operation = Operation.Help;
            switch (choice)
            {
                case "1":
                    operation = Operation.Add;
                    break;
                case "2":
                    operation = Operation.Subtract;
                    break;
                case "3":
                    operation = Operation.Multily;
                    break;
                case "4":
                    operation = Operation.Divide;
                    break;
                case "0":
                    operation = Operation.Help;
                    break;
                case "X":
                    operation = Operation.Exit;
                    break;
                case "x":
                    operation = Operation.Exit;
                    break;
                default:
                    operation = Operation.Help;
                    break;
            }

            Console.WriteLine("Your operation is {0}", operation);

            if (operation == Operation.Help)
            {
                MenuHelp();
                return;
            }
            else if (operation == Operation.Exit)
            {
                Console.WriteLine("Exiting");
                exitFlag = true;
                return;
            }
            else
            //Executing mathematical oparations
            {
                double left, right;

                try
                {
                    Console.Write("Type left operator: ");
                    left = GetOperand();
                    Console.Write("Type right operator: ");
                    right = GetOperand();

                    if (operation == Operation.Add)
                    {
                        Add(left, right);
                    }
                    else if (operation == Operation.Subtract)
                    {
                        Sub(left, right);
                    }
                    else if (operation == Operation.Multily)
                    {
                        Mul(left, right);
                    }
                    else if (operation == Operation.Divide)
                    {
                        Div(left, right);
                    }
                    Console.ForegroundColor = successTextColor;
                    Console.WriteLine("Calculation completed successfully");
                    Console.ForegroundColor = dfltTextColor;
                }
                catch (InvalidCastException e)
                {
                    Console.ForegroundColor = errorTextColor;
                    Console.WriteLine("Cannot cast typed string into double value.\n" +
                        "Try calculation again");
                    //return;
                }
                catch (DivideByZeroException e)
                {
                    Console.ForegroundColor = errorTextColor;

                    Console.WriteLine("Cannot divide by zero.\n" +
                        "Try calculation again");
                    //return;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = errorTextColor;

                    Console.WriteLine("Unknown exception happened.");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Exiting the program");

                    exitFlag = true;
                    //return;
                }
                finally
                {
                    Console.ForegroundColor = dfltTextColor;
                }
            }


            //Console.WriteLine(operation);


        }

        public static void Add(double a, double b)
        {
            double rslt = a + b;

            Console.ForegroundColor = rsltTextColor;
            Console.WriteLine("{0} + {1} = {2}", a, b, rslt);
            Console.ForegroundColor = dfltTextColor;

        }
        public static void Sub(double a, double b)
        {
            double rslt = a - b;

            Console.ForegroundColor = rsltTextColor;
            Console.WriteLine("{0} - {1} = {2}", a, b, rslt);
            Console.ForegroundColor = dfltTextColor;
        }
        public static void Mul(double a, double b)
        {
            double rslt = a * b;

            Console.ForegroundColor = rsltTextColor;
            Console.WriteLine("{0} * {1} = {2}", a, b, rslt);
            Console.ForegroundColor = dfltTextColor;
        }
        public static void Div(double a, double b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }

                double rslt = a / b;

                Console.ForegroundColor = rsltTextColor;
                Console.WriteLine("{0} / {1} = {2}", a, b, rslt);
                Console.ForegroundColor = dfltTextColor;
            }
            catch (Exception)
            {
                throw;
            }


        }


    }
}
