using System;
using System.Collections;

namespace CSharp.Essential.Unit11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unit 11 tasks");
            Console.WriteLine(new String('-', 50));

            Ex1Demo();
            Console.WriteLine(new String('-', 50));
            Ex2Demo();
            Console.WriteLine(new String('-', 50));
            Ex3Demo();
            Console.WriteLine(new String('-', 50));
            Ex4Demo();
            Console.WriteLine(new String('-', 50));
            Ex5Demo();
            Console.ReadLine();
        }

        public static void Ex1Demo()
        {
            Console.WriteLine("Task 1:");

            ArrayList alDemo = new ArrayList();
            Double one = 1;

            alDemo.Add("One");
            alDemo.Add(1);
            alDemo.Add(one);

            Console.WriteLine("Print items using foreach");
            foreach (var item in alDemo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Print items using for:");
            for (int i = 0; i < alDemo.Capacity - 1; i++)
            {
                Console.WriteLine(alDemo[i]);
            }
        }

        public static void Ex2Demo()
        {
            Console.WriteLine("Task 2:");
            Console.WriteLine("Fill CarCollection");
            CarCollection<Car> cc = new CarCollection<Car>();

            cc.Add(new Car("Porsche", 2016));
            cc.Add(new Car("BMW", 2010));
            cc.Add(new Car("Pontiac", 2017));
            cc.Add(new Car("Lada", 2018));

            Console.WriteLine("Capacity of CarCollection is: {0}", cc.GetCarsCapacity());
            Console.WriteLine("Print cars list:");
            for (int i = 0; i < cc.GetCarsCapacity(); i++)
            {
                Console.WriteLine(cc[i]);
            }

            Console.WriteLine("Clear CarCollection");
            cc.Clear();
            Console.WriteLine("Capacity of CarCollection is: {0}", cc.GetCarsCapacity());
        }

        public static void Ex3Demo()
        {
            Console.WriteLine("Task 3:");
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("One", "Один");
            dict.Add("Two", "Два");
            dict.Add("Four", "Четыре");

            Console.WriteLine("Total pairs in Dictionary {0}", dict.GetDictCapacity());

            try
            {
                Console.WriteLine("Find pair for Two: {0}", dict["Two"]);
                Console.WriteLine("Find pair for Four: {0}", dict["Four"]);
                Console.WriteLine("Find pair for Three: {0}", dict["Three"]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Requested pair was not found");
            }
        }

        public static void Ex4Demo()
        {
            Console.WriteLine("Task 4:");
            Console.WriteLine("Self made ArrayList class");
            ArrList al = new ArrList(-1);
            Console.WriteLine("al capacity = {0}", al.Capacity);

            al.Add(1);
            al.Add(2.2);
            al.Add("To Delete");
            al.Add("Test");
            al.Add("2");
            al.Add("To Delete");

            Console.WriteLine("Print all elements:");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Current Capacity of ArrayList is: {0}", al.Capacity);
            Console.WriteLine("Find position of To Delete: {0}", al.IndexOf("Test"));
            
            Console.WriteLine(new String('+', 50));
            Console.WriteLine("Create second instance of Array List");
            
            ArrList al2 = new ArrList(8);
            al2.Add(1);
            al2.Add(2.2);
            al2.Add("To Delete");
            al2.Add("Test");
            al2.Insert(4,"Inserted Value");
            al2.Insert(1,"Inserted Another Value");
            
            
            Console.WriteLine("Print all elements:");
            foreach (var item in al2)
            {
                if (item==null)
                {
                    continue;
                }
                Console.WriteLine(item);
            }


        }
        
        public static void Ex5Demo()
        {
            Console.WriteLine("Task 5:");
            Console.WriteLine("Samples with Original Array:List");
            
            ArrayList al = new ArrayList(3);
//            ArrList al = new ArrList(-1);
            Console.WriteLine("al capacity = {0}", al.Capacity);

            al.Add(1);
            al.Add(2.2);
            al.Add("To Delete");
            al.Add("Test");
            al.Add("2");
            al.Add("To Delete");

            Console.WriteLine("Print all elements:");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Current Capacity of ArrayList is: {0}", al.Capacity);
            Console.WriteLine("Find position of To Delete: {0}", al.IndexOf("Test"));
            
            Console.WriteLine(new String('+', 50));
            Console.WriteLine("Create second instance of Array List");
            
            ArrayList al2 = new ArrayList(8);
            al2.Add(1);
            al2.Add(2.2);
            al2.Add("To Delete");
            al2.Add("Test");
            al2.Insert(4,"Inserted Value");
            al2.Insert(1,"Inserted Another Value");
            
            
            Console.WriteLine("Print all elements:");
            foreach (var item in al2)
            {
                if (item==null)
                {
                    continue;
                }
                Console.WriteLine(item);
            }


        }
    }
}