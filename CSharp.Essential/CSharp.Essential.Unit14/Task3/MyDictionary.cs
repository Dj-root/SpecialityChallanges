using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp.Essential.Unit14
{
    public class MyDictionary<TKey, TValue> : IEnumerable<object>, IEnumerator<object>
    {
        TKey[] keys = new TKey[1];
        TValue[] vals = new TValue[1];
        private int pos = -1;

        private bool ExtendItems()
        {
            TKey[] tempKeys = new TKey[keys.Length + 1];
            TValue[] tempVals = new TValue[vals.Length + 1];

            for (int i = 0; i < this.keys.Length; i++)
            {
                tempKeys[i] = keys[i];
                tempVals[i] = vals[i];
            }

            this.keys = tempKeys;
            this.vals = tempVals;

            if (keys.Length == tempKeys.Length & vals.Length == tempVals.Length)
            {
                return true;
            }

            return false;
        }

        public void AddItem(TKey key, TValue value)
        {
            if (pos + 1 == keys.Length)
            {
                ExtendItems();
            }

            keys[++pos] = key;
            vals[pos] = value;
        }

        public string this[int index]
        {
            get
            {
                if (index >=0 && index < keys.Length)
                {
                    return keys[index] + " - " + vals[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public int GetItemsQty
        {
            get { return keys.Length; }
        }

        public IEnumerator<object> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object Current { get; }
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}

//foreach (var item in items)
//{
//yield return item;
//}