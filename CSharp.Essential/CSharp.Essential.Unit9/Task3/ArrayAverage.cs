using System;

namespace CSharp.Essential.Unit9
{
    public delegate double ArrayAverager(ArrayElement[] arrayElements);

    public delegate int ArrayElement();

    public class ArrayAverage
    {
//        private double Result (double rslt) => { return 0; };
        public static int GetRandInt()
        {
            return new Random().Next(0,100);
        }

        private static ArrayElement ae1 = () =>
        {
            Random r = new Random();
            return r.Next(0, 100);
        };

        static void FillArray()
        {
            int elements;
            Console.Write("How many elements should be in array? : ");
            Int32.TryParse(Console.ReadLine(), out elements);
            
            
        }
        
        private static ArrayElement[] arrayElements = new[] {ae1, ae2, ae3, ae4};

        private static ArrayAverager aa = delegate(ArrayElement[] arrayElements)
        {
            {
                int divisor = arrayElements.Length;
                int element;
                double sum = 0;
                double rslt;

                Console.Write("Quantity of elements in array is {0}, they are: ", divisor);
                foreach (var item in arrayElements)
                {
                    element = item();
                    sum += element;
                    Console.Write(element+ " ");
                }

                rslt = sum / divisor;
                Console.WriteLine("\nAverage of elements is {0}", rslt);

                return rslt;
            };
        };


        public void Test()
        {
            aa(arrayElements);
        }
    }
}