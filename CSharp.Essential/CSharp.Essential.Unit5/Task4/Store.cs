using System;

namespace CSharp.Essential.Unit5
{
    public class Store
    {
        private Article[] items = new Article[3];
        private int itemsQty = 0;
        private int pos = 0;


        public string this[string itemName]
        {
            get
            {
                int itemPos = FindItemPosByName(itemName);
                if (itemPos != -1)
                {
                    return items[itemPos].ShowAItemInfo();
                }
                else
                {
                    return string.Format("Item {0} was not found. Please try another search", itemName);
                }
            }
        }

/*
        public Article this[int index]
        {
            get
            {
                /* return the specified index here #1#
                if (index <= items.Length & items[index] != null)
                {
                    return items[index];
                }
                else
                {
                    Console.WriteLine("\nIndex out of Array. Return first item:");
                    return items[0];
                }
            }
            set { AddItem(value, index); }
        }
*/
         
        public string this[int index]
        {
            get
            {
                if (index <= items.Length & items[index] != null)
                {
                    return items[index].ShowAItemInfo();
                }
                else
                {
                    return string.Format("Index out of Array. Item does not exists");
                }
            }
        }
       

        

        public void AddItem(Article item)
        {
            int emptyPos = this.FindEmptyPos();

            if (itemsQty == 0)
            {
                items[0] = item;
                itemsQty = this.CountItems();
            }
            else if (items.Length > itemsQty)
            {
//                items[itemsQty] = item;
                items[emptyPos] = item;
                itemsQty = this.CountItems();
            }
            else if (items.Length <= itemsQty)
            {
                Article[] temp = new Article[itemsQty + 3];
                for (int i = 0; i < items.Length; i++)
                {
                    temp[i] = items[i];
                }

                items = temp;

                emptyPos = this.FindEmptyPos();

//                items[itemsQty] = item;
                items[emptyPos] = item;
                itemsQty = this.CountItems();
            }
        }

        public void AddItem(Article item, int position)
        {
            if (position < items.Length)
            {
                items[position] = item;
                itemsQty = this.CountItems();
            }
            else if (position >= items.Length)
            {
                Article[] temp = new Article[position + 1];
                for (int i = 0; i < items.Length; i++)
                {
                    temp[i] = items[i];
                }

                items = temp;


                items[position] = item;
                itemsQty = this.CountItems();
            }
        }

        private int FindItemPosByName(string itemName)
        {
            int position = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null) // & items[i].ItemName == itemName)
                {
                    if (items[i].ItemName == itemName)
                    {
                        position = i;
                    }
                }
            }

            if (position == 0)
            {
                position = -1;
            }

            return position;
        }

        private int CountItems()
        {
            int counter = 0;
            foreach (Article item in items)
            {
                if (item != null)
                {
                    counter++;
                }
            }

            return counter;
        }

        private int FindEmptyPos()
        {
            int position = 0;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    position = i;
                    break;
                }
            }

            if (position == 0)
            {
                position = -1;
            }

            return position;
        }

        public void ShowAllItems()
        {
            Console.WriteLine("All goods from all stores:");
            foreach (Article item in items)
            {
                if (item != null)
                {
                    item.ShowArticleInfo();
                }
            }
        }
    }
}