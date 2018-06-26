using System;

namespace CSharp.Essential.Unit10
{
    public class MyDictionary<TKey, TValue>
    {
        private TKey[] key;
        private TValue[] value;
        private int currentIdx = 0;


        public MyDictionary()
        {
            key = new TKey[3];
            value = new TValue[3];
        }

        public MyDictionary(int capacity)
        {
            if (capacity <= 3)
            {
                key = new TKey[3];
                value = new TValue[3];
            }
            else
            {
                key = new TKey[capacity];
                value = new TValue[capacity];
            }

            this.key = key;
            this.value = value;
        }

        public void AddPairs(TKey key, TValue value)
        {
            if (currentIdx < this.key.Length)
            {
                this.key[currentIdx] = key;
                this.value[currentIdx] = value;

                currentIdx++;
            }
            else
            {
                this.ExtendArray();

                this.key[currentIdx] = key;
                this.value[currentIdx] = value;

                currentIdx++;
            }
        }


        private void ExtendArray()
        {
            int newCapacity = this.key.Length + 5;
            TKey[] tempKeys = new TKey[newCapacity];
            TValue[] tempValues = new TValue[newCapacity];


            for (int i = 0; i < this.key.Length; i++)
            {
                tempKeys[i] = this.key[i];
                tempValues[i] = this.value[i];
            }

            this.key = tempKeys;
            this.value = tempValues;
        }


        public string this[int index]
        {
            get
            {
                if (index >= 0 && index <= currentIdx - 1)
                {
                    return string.Format((key[index]).ToString() + " - " + (value[index]).ToString());
                }
                else
                {
                    return "Попытка обращения за пределы массива.";
                }
            }
        }


        public string this[TKey idx]
        {
            get
            {
                for (int i = 0; i < this.key.Length; i++)
                    if (key[i] != null && this.key[i].Equals(idx))
                    {
                        return string.Format((key[i]).ToString() + " - " + (value[i]).ToString());
                    }

                return string.Format("{0} - нет перевода для этого слова.", idx.ToString());
            }
        }

        public int Length
        {
            get { return currentIdx; }
        }
    }


    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];

        public Dictionary()
        {
            key[0] = "книга";
            value[0] = "book";
            key[1] = "ручка";
            value[1] = "pen";
            key[2] = "солнце";
            value[2] = "sun";
            key[3] = "яблоко";
            value[3] = "apple";
            key[4] = "стол";
            value[4] = "table";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                        return key[i] + " - " + value[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }

        public void Demo()
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}