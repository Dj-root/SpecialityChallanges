using System;
using System.Collections;

namespace CSharp.Essential.Unit14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unit 14 tasks");
            Console.WriteLine(new String('-', 50));

//            Ex1Demo();
            Console.WriteLine(new String('-', 50));
//            Ex2Demo();
            Console.WriteLine(new String('-', 50));
            Ex3Demo();
//            Console.WriteLine(new String('-', 50));
//            Ex4Demo();
//            Console.WriteLine(new String('-', 50));
//            Ex5Demo();
            Console.ReadLine();
        }

        public static void Ex1Demo()
        {
            int[] nums = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 14};

            EvenNums en = new EvenNums(nums);
            foreach (var num in en)
            {
                Console.WriteLine(num);
            }
        }

        public static void Ex2Demo()
        {
            MyList<string> ml = new MyList<string>();
            ml.AddItem("Zero");
            ml.AddItem("One");
            ml.AddItem("Two");
            ml.AddItem("Three");
            ml.AddItem("Four");

            Console.WriteLine("How many records: {0}", ml.GetItemsQty);

            Console.WriteLine("Print all records:");
            foreach (var item in ml)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Print record 0: {0}", ml[0]);
            Console.WriteLine("Print record 3: {0}", ml[3]);
//            Console.WriteLine("Print record 6: {0}", ml[6]);
        }

        public static void Ex3Demo()
        {
            MyDictionary<int, string> md = new MyDictionary<int, string>();
            md.AddItem(1, "One");
            md.AddItem(2, "Two");

            Console.WriteLine("Qty items in dictionary: {0}", md.GetItemsQty);

            foreach (var item in md)
            {
                Console.WriteLine(item);
            }
        }
    }
}