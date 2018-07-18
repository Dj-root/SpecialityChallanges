using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit 10 tasks");
            Console.WriteLine(new String('-', 50));

            Ex1Demo();
            Console.WriteLine(new String('-', 50));
            Ex2Demo();
            Console.WriteLine(new String('-', 50));
            Ex3Demo();
            Console.WriteLine(new String('-', 50));
            Ex4Demo();
            Console.ReadLine();
        }

        public static void Ex1Demo()
        {
            Console.WriteLine("Task 1\n");
            Console.WriteLine("Build MyFactory class as int");
            int i = MyFactory<int>.FactoryMethod();

            Console.WriteLine("Object bult type is " + i.GetType().Name);

            Console.WriteLine("Build MyFactory class as Program");
            Program p = MyFactory<Program>.FactoryMethod();

            Console.WriteLine("Object bult type is " + p.GetType().Name);

            Console.ReadKey();
        }

        public static void Ex2Demo()
        {
            Console.WriteLine("Task 2\n");

            Console.WriteLine("Creating int list:");

            MyList<int> intList = new MyList<int>(3);
            intList.AddItem(1);
            intList.AddItem(4);
            intList.AddItem(3);
            intList.AddItem(1);
            intList.AddItem(6);

            Console.WriteLine("Quantity of items in intList: {0}", intList.Length);

            Console.WriteLine("\nWrite items in intList:");
            for (int i = 0; i < intList.Length; i++)
            {
                Console.WriteLine(intList[i]);
            }


            Console.WriteLine("\nCreating string list with -3 elements");
            MyList<string> strList = new MyList<string>(-3);
//            Console.WriteLine("Quantity of items in strList: {0}", strList.Length);
            strList.AddItem("One");
            strList.AddItem("Two");
            strList.AddItem("Three");

            Console.WriteLine("Quantity of items in strList: {0}", strList.Length);

            Console.WriteLine("\nWrite items in strList:");
            for (int i = 0; i < strList.Length; i++)
            {
                Console.WriteLine(strList[i]);
            }
        }

        public static void Ex3Demo()
        {
            Console.WriteLine("Task 3\n");

            Console.WriteLine("Creating String Sictionary");

            MyDictionary<string, string> strDict = new MyDictionary<string, string>(-3);
            strDict.AddPairs("книга", "book");
            strDict.AddPairs("ручка", "pen");
            strDict.AddPairs("солнце", "sun");
            strDict.AddPairs("яблоко", "apple");
            strDict.AddPairs("стол", "table");

            Console.WriteLine("Write all pairs");
            for (int i = 0; i < strDict.Length; i++)
            {
                Console.WriteLine(strDict[i]);
            }

            Console.WriteLine("\nFind some words:");
            Console.WriteLine(strDict["книга"]);
            Console.WriteLine(strDict["собака"]);
            Console.WriteLine(strDict["яблоко"]);


            Console.WriteLine("\n\nCreating Int and String Sictionary");

            MyDictionary<int, string> intDict = new MyDictionary<int, string>();
            intDict.AddPairs(1, "one");
            intDict.AddPairs(2, "two");
            intDict.AddPairs(4, "four");

            Console.WriteLine("Write all pairs");
            for (int i = 0; i < intDict.Length; i++)
            {
                Console.WriteLine(intDict[i]);
            }

            Console.WriteLine("\nFind some words:");
            Console.WriteLine(intDict[1]);
            Console.WriteLine(intDict[3]);
        }

        public static void Ex4Demo()
        {
            Console.WriteLine("Task 4\n");
            Console.WriteLine("Creating array from MyList instance and print result of GetArray():");

            MyList<string> strList = new MyList<string>();
            strList.AddItem("One");
            strList.AddItem("Two");
            strList.AddItem("Three");

            string[] listArr = strList.GetArray();

            foreach (string s in listArr)
            {
                Console.WriteLine(s);
            }
        }
    }
}