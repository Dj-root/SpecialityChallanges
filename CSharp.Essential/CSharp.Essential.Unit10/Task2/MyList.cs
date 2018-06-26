using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharp.Essential.Unit10
{
    public class MyList<T> :IMyList<T>
    {
        private T[] array;
        private int currentIdx = 0;

        public MyList()
        {
            this.array = new T[2];
        }

        public MyList(int capacity)
        {
            if (capacity>=2)
            {
                this.array = new T[capacity];
            }
            else
            {
                this.array = new T[2]; 
            }
        }

        public T this[int index]
        {
            get { return array[index]; }
        }

        public void AddItem(T item)
        {
            if (currentIdx < array.Length)
            {
                array[currentIdx] = item;
                currentIdx++;
            }
            else
            {
                this.ExtendArray();
                array[currentIdx] = item;
                currentIdx++;

            }
        }

        public int Length
        {
            get { return currentIdx; }
        }

        private void ExtendArray()
        {
            int newCapacity = this.array.Length + 5;
            T[] tempArray = new T[newCapacity];

            for (int i = 0; i < this.array.Length; i++)
            {
                tempArray[i] = this.array[i];
            }

            this.array = tempArray;
        }

    }
}