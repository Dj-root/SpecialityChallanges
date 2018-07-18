using System;
using System.Collections;

namespace CSharp.Essential.Unit11
{
    public class ArrList : IArrayList
    {
        private object[] items;
        private int size = 0;

        public ArrList()
        {
            this.items = new object[3];
        }

        public ArrList(int capacity)
        {
            if (capacity <= 0)
            {
                this.items = new object[2];
            }
            else
            {
                this.items = new object[capacity];
            }
        }


        private void Extend()
        {
            object[] temp = new object[items.Length + 5];
            for (int i = 0; i < items.Length; i++)
            {
                temp[i] = items[i];
            }

            items = temp;
        }

        public void Add(object value)
        {
//            if (items.Length >= size)
            if (size >= items.Length)
            {
                Extend();
            }

            items[size] = value;
            size++;

//            throw new NotImplementedException();
        }

        public void Clear()
        {
            items = new object[3];

//            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == (object) value)
                    // items[i] != null &&
                {
                    return i;
                }
            }

            throw new ArgumentOutOfRangeException();
        }


        public void Insert(int pos, object value)
        {
            if (pos >= 0 & pos <= Capacity)
            {
                object[] temp;
                if (size == Capacity)
                {
                    temp = new object[Capacity + 1];
                }
                else
                {
                    temp = new object[Capacity];
                }


                int i = 0;

                for (; i < pos; i++)
                {
                    temp[i] = items[i];
                }

                temp[i++] = value;


                for (; i < items.Length + 1; i++)
                {
                    if (i >= items.Length)
                    {
                        break;
                    }

                    temp[i] = items[i - 1];
                }

                items = temp;
                size++;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int LastIndexOf(object value)
        {
            for (int i = items.Length; i > 0; i--)
            {
                if (items != null && items[i] == value)
                {
                    return i;
                }
            }

            throw new ArgumentOutOfRangeException();
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));


//            throw new NotImplementedException();
        }

        public void RemoveAt(int pos)
        {
            if (pos >= 0 & pos <= Capacity)
            {
                items[pos] = null;
                size--;


                object[] temp = new object[size + 5];
                for (int i = 0; i < size + 1; i++)
                {
                    if (items[i] == null)
                    {
                        continue;
                    }
                    else
                    {
                        temp[i] = items[i];
                    }
                }

                items = temp;
            }

//            throw new NotImplementedException();
        }

        public int Count
        {
            get { return size; }
        }

        public int Capacity
        {
            get { return items.Length; }
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}