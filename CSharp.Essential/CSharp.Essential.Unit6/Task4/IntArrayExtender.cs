namespace CSharp.Essential.Unit6
{
    public static class IntArray
    {
        public static int[] SortByAsc(this int[] srcNums)
        {
            int[] sortedNums = srcNums;
            QuickSort(ref sortedNums, 0, sortedNums.Length - 1);

            return sortedNums;
        }


//        Using Quick Sort method

        static void QuickSort(ref int[] srcNums, int loIdx, int hiIdx)
        {
            int splitPoint;
            if (loIdx < hiIdx)
            {
                splitPoint = Partition(ref srcNums, loIdx, hiIdx);
                QuickSort(ref srcNums, loIdx, splitPoint);
                QuickSort(ref srcNums, splitPoint + 1, hiIdx);
            }
        }

        static int Partition(ref int[] srcNums, int loIdx, int hiIdx)
        {
            int pivot = srcNums[loIdx];
            int left, right, swap;

            left = loIdx - 1;
            right = hiIdx + 1;

            while (true)
            {
                do
                {
                    left++;
                } while (srcNums[left] < pivot);

                do
                {
                    right--;
                } while (srcNums[right] > pivot);

                if (left >= right)
                {
                    return right;
                }

                swap = srcNums[left];
                srcNums[left] = srcNums[right];
                srcNums[right] = swap;
            }
        }
    }
}