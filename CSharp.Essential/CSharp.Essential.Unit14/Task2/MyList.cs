using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp.Essential.Unit14
{
    public class MyList<T> : IEnumerable<T>
    {
        private T[] items = new T[1];
        private int pos = -1;

        private bool ExtendItems()
        {
            T[] temp = new T[items.Length + 1];
            for (int i = 0; i < items.Length; i++)
            {
                temp[i] = items[i];
            }

            this.items = temp;
            if (items.Length == temp.Length)
            {
                return true;
            }

            return false;
        }

        public T this[int index]
        {
            get {
                if (index<=pos)
                {
                    return items[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void AddItem(T item)
        {
            if (pos + 1 == items.Length)
            {
                ExtendItems();
            }

            items[++pos] = item;
        }

        public int GetItemsQty
        {
            get { return items.Length; }
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            }
            
//            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}