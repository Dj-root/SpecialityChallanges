using CSharp.Essential.Unit7;

namespace CSharp.Essential.Unit7
{
    public static class TrainsBubbleSorter
    {
        public static Train[] SortByAsc(this Train[] srcTrains)
        {
            Train[] sortedTrains = srcTrains;
            BubbleSort(ref sortedTrains);

            return sortedTrains;
        }

        private static void BubbleSort(ref Train[] srcTrains)
        {
            int n = srcTrains.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                    if (srcTrains[j].TrainNumber > srcTrains[j + 1].TrainNumber)
                    {
                        Train temp = srcTrains[j];
                        srcTrains[j] = srcTrains[j + 1];
                        srcTrains[j + 1] = temp;
                    }
            }
        }
    }
}