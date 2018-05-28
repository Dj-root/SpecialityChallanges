using System;

namespace CSharp.Essential.Unit9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unit 9 tasks");
            Console.WriteLine(new String('-', 50));

//            Ex1Demo();
            Console.WriteLine(new String('-', 50));
//            Ex2Demo();
            Console.WriteLine(new String('-', 50));
            Ex3Demo();
            Console.WriteLine(new String('-', 50));
//            Ex4Demo();
            Console.ReadLine();
        }

        public static void Ex1Demo()
        {
            Console.WriteLine("Anonymous method");
            Avg average = delegate(int a, int b, int c) { return ((double) (a + b + c) / 3); };
           double avg =  average(2, 2, 3);
            Console.WriteLine("AVG of 2, 2 and 3 is {0}", avg);
        }

        public static void Ex2Demo()
        {
            SimpleCalc sc = new SimpleCalc();
            sc.RunCalculation();
        }

        public static void Ex3Demo()
        {
            ArrayAverage ae = new ArrayAverage();
            ae.Test();
        }
        public static void Ex4Demo(){}
    }
}