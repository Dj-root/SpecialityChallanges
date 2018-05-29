using System;

namespace CSharp.Essential.Unit9
{
    public delegate double ArrayAverager(ArrayElements[] arrayElements);

    public delegate int ArrayElements();

    public class ArrayAverage
    {
        public static int GetRandInt()
        {
            return new Random().Next(0, 100);
        }

        private static ArrayElements ae1 = () =>
        {
            Random r = new Random();
            return r.Next(0, 100);
        };

        public void DelArrayDemo()
        {
            int elements;
            Console.Write("How many elements should be in array? : ");
            Int32.TryParse(Console.ReadLine(), out elements);

            var elementsArray = new ArrayElements[elements];

            for (int i = 0; i < elementsArray.Length; i++)
            {
                elementsArray[i] = () => new ArrayElements(GetRandInt).Invoke();
            }

            aa(elementsArray);

            Console.WriteLine("Type of elementsArray: ", elementsArray.GetType());
        }

        private static ArrayAverager aa = delegate (ArrayElements[] arrayElements)
        {
            {
                int divisor = arrayElements.Length;
                double sum = 0;
                double rslt;

                Console.Write("Quantity of elements in array is {0}, they are: ", divisor);
                foreach (var item in arrayElements)
                {
                    sum += item.Invoke();
                    Console.Write(item.Invoke() + " ");
                }

                rslt = sum / divisor;
                Console.WriteLine("\nAverage of elements is {0}", rslt);

                return rslt;
            };
        };
    }
}