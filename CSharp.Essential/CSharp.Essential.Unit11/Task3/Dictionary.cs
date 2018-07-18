using System;

namespace CSharp.Essential.Unit11
{
    public class Dictionary<TKey, TValue> : IDict<TKey, TValue>
    {
        private TKey[] keys = new TKey[1];
        private TValue[] values = new TValue[1];
        private int curPosition = -1;

        public TValue this[TKey index]
        {
            get
            {
                try
                {
                    return values[FindByKey(index)];
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Error:\nNo value for {0}", index.ToString());
                    throw;
                }
            }
        }

        public void Add(TKey key, TValue value)
        {
            if (keys.Length <= GetDictCapacity())
            {
                this.Extend();
            }

            curPosition++;
            keys[curPosition] = key;
            values[curPosition] = value;
        }

        private int FindByKey(TKey key)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i] != null && keys[i].Equals(key))
                {
                    return i;
                }
            }

            return -1;
        }

        private void Extend()
        {
            TKey[] tempKeys = new TKey[keys.Length + 5];
            TValue[] tempVals = new TValue[values.Length + 5];

            for (int i = 0; i < keys.Length; i++)
            {
                tempKeys[i] = keys[i];
                tempVals[i] = values[i];
            }

            keys = tempKeys;
            values = tempVals;
        }

        public int GetDictCapacity()
        {
            return curPosition + 1;
        }
    }
}