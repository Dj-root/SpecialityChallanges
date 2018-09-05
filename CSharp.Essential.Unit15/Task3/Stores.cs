using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit15
{
    class Stores
    {
        struct Price
        {
            string productName;
            string storeName;
            decimal productPrice;

            public Price(string pName, string sName, decimal pPrice)
            {
                productName = pName;
                storeName = sName;
                try
                {
                    if (pPrice <= 0)
                    {
                        throw new ArgumentException();
                    }

                    productPrice = pPrice;
                }
                catch (ArgumentException e)
                {
                    throw;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetType());
                    throw;
                }
            }

            public string ProductName { get { return productName; } }
            public string StoreName { get { return storeName; } }
            public decimal ProductPrice { get { return productPrice; } }

            public override string ToString()
            {
                return string.Format("Product name: {0} \nStore Name: {1} \nProduct Price: {2}",
                    ProductName, StoreName, ProductPrice);
            }
        }

        private Price[] products = new Price[2];






        private Price FillProduct()
        {
            //string firstName = "Ivan";
            //string lastName = "Ivanov";
            //string position = "UI";
            //string hireDate = "2015";

            string productName = "Bread";
            string storeName = "Silpo";
            decimal productPrice = 10.50M;

            Console.WriteLine("Type info about product:");
            Console.Write("Product name: ");
            productName = Console.ReadLine();

            Console.Write("Store name: ");
            storeName = Console.ReadLine();

            Console.Write("Product Price: ");
            try
            {
                productPrice = Decimal.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
            }

            try
            {
                return new Price(productName, storeName, productPrice);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Somethig happens");
                Console.WriteLine(e.GetType());
                throw;
            }
        }

        public void AutoFillProducts()
        {
            Console.WriteLine("We need to type information about {0} products", products.Length);

            products[0] = new Price("Soap", "Silpo", 15.05M);
            products[1] = new Price("Condoms", "Apotheke", 99.95M);
        }

        public void FillProducts()
        {
            Console.WriteLine("We need to type information about {0} products", products.Length);

            for (int i = 0; i < products.Length; i++)
            {
                try
                {
                    products[i] = FillProduct();
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Incorrect date type. Try again");
                    i--;
                }
            }
        }

        public void ShowProducts()
        {
            Console.WriteLine("List of products:");

            foreach (Price item in products)
            {
                Console.WriteLine(item);
                Console.WriteLine(new String('~', 50));
            }
        }

        public bool SortProducts()
        {
            Price[] sortedProducts = SortByAsc(products);

            try
            {
                this.products = sortedProducts;
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }



        private Price[] FindProductByStore(string storeName)
        {
            int position = -1;
            //int 
            Price[] foundProducts = new Price[products.Length];

            foreach (Price item in products)
            {

                if (item.StoreName.CompareTo(storeName)==0)
                {
                    foundProducts[++position] = item;
                }
            }

            if (position == -1)
            {
                return null;
            }
            else
            {
                return ResizeArray(foundProducts, ++position);
            }
        }

        private Price[] ResizeArray(Price[] array, int size)
        {
            int i;
            Price[] tmp = new Price[size];

            if (array.Length < size)
            {
                i = array.Length - 1;
            }
            else
            {
                i = tmp.Length - 1;
            }


            for (i = 0; i < tmp.Length; i++)
            {
                tmp[i] = array[i];
            }

            return tmp;
        }

        public void SearchProductByStore()
        {
            string storeName;
            Price[] foundProducts;

            Console.Write("\nType Store name criteria for search: ");

            storeName = Console.ReadLine();

            foundProducts = FindProductByStore(storeName);

            if (foundProducts == null)
            {
                throw new ArgumentException();
                //Console.WriteLine("No products found for store {0}", storeName);
            }
            else
            {
                PrintProductInfo(foundProducts);
            }
        }

        private void PrintProductInfo(Price[] itm)
        {
            Console.WriteLine("\nFound products list:");
            foreach (var item in itm)
            {
                Console.WriteLine("Product name: {0}, \nStore Name: {1} \nProduct Price: {2}", item.ProductName, item.StoreName, item.ProductPrice);
            }
        }


        #region Sorting Algorithm

        private static Price[] SortByAsc(Price[] srcProducts)
        {

            Price[] sortedProducts = srcProducts;
            QuickSort(ref sortedProducts, 0, sortedProducts.Length - 1);

            return sortedProducts;
        }

        //        Using Quick Sort method

        static void QuickSort(ref Price[] srcProducts, int loIdx, int hiIdx)
        {
            int splitPoint;
            if (loIdx < hiIdx)
            {
                splitPoint = Partition(ref srcProducts, loIdx, hiIdx);
                QuickSort(ref srcProducts, loIdx, splitPoint);
                QuickSort(ref srcProducts, splitPoint + 1, hiIdx);
            }
        }

        static int Partition(ref Price[] srcProducts, int loIdx, int hiIdx)
        {
            Price pivot = srcProducts[loIdx];
            int left, right, rslt;
            Price swap, tmp;

            left = loIdx - 1;
            right = hiIdx + 1;

            while (true)
            {
                do
                {
                    left++;
                    tmp = srcProducts[left];
                    rslt = tmp.StoreName.CompareTo(pivot.StoreName);
                } while (rslt < 0);

                do
                {
                    right--;
                    tmp = srcProducts[right];
                    rslt = tmp.StoreName.CompareTo(pivot.StoreName);
                } while (rslt > 0);

                if (left >= right)
                {
                    return right;
                }

                swap = srcProducts[left];
                srcProducts[left] = srcProducts[right];
                srcProducts[right] = swap;
            }
        }

        #endregion

    }
}
