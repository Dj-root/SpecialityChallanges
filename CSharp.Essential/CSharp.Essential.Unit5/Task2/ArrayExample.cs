using System;
using System.Linq;

namespace CSharp.Essential.Unit5
{
    public class ArrayExample
    {
        private int[] nums;

        public ArrayExample(int qty)
        {
            nums = new int[qty];

            Random r = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(100);
            }
        }


        public void PrintAllInfo()
        {
            PrintArray();
            PrintMinMaxAvg();
            PrintOddValues();
        }

        void PrintArray()
        {
            Console.WriteLine("All elements of array:");
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(new String('+', 50));
        }


        void PrintMinMaxAvg()
        {
            Console.WriteLine("The Max value of array is {0}", nums.Max());
            Console.WriteLine("The Mix value of array is {0}", nums.Min());
            Console.WriteLine("The Average value of array is {0}", nums.Average());
            Console.WriteLine("The Summ all elements of array is {0}", nums.Sum());
            Console.WriteLine(new String('+', 50));
        }

        void PrintOddValues()
        {
            Console.WriteLine("All odd elements of array:");
            foreach (int i in nums)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine(new String('+', 50));
        }
    }
}