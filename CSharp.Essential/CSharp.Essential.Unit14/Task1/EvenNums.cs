using System.Collections;
using System.Collections.Generic;

namespace CSharp.Essential.Unit14
{
    public class EvenNums : IEnumerable
    {
        private int[] numbers;

        public EvenNums(int[] nums)
        {
            numbers = nums;
        }


        public IEnumerator GetEnumerator()
        {
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    yield return num;
                }
            }
        }

    }
}