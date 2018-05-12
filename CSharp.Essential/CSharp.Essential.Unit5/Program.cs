using System;

namespace CSharp.Essential.Unit5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unit 5 tasks");
            Console.WriteLine(new String('-', 50));
//            Ex1Demo();
            Console.WriteLine(new String('-', 50));
//            Ex2Demo();
            Console.WriteLine(new String('-', 50));
//            Ex3Demo();
            Console.WriteLine(new String('-', 50));
            Ex4Demo();
            Console.ReadLine();
        }

        static void Ex1Demo()
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["стіл"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["солнце"]);
            Console.WriteLine(dictionary["сонце"]);


            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
        }

        static void Ex2Demo()
        {
            Console.WriteLine("Work with array");
            ArrayExample ae = new ArrayExample(5);
            ae.PrintAllInfo();
        }

        static void Ex3Demo()
        {
            MyMatrix mtrx = new MyMatrix(3,4);
            mtrx.PrintMatrix();

            Console.WriteLine("Value of 2,3: {0}",mtrx[2,3]);
            Console.WriteLine("\nChange matrix 3x4 to 2x2");
            
            mtrx.ResizeMartix(2,2);
            mtrx.PrintMatrix();
            Console.WriteLine("Value of 1,1: {0}",mtrx[1,1]);
            
            Console.WriteLine("\nChange matrix 2x2 to 3x5");
            mtrx.ResizeMartix(3,5);
            mtrx.PrintMatrix();
            Console.WriteLine("Value of 2,4: {0}",mtrx[1,3]);


            Console.WriteLine("\nAnother matrix 1x1");
            MyMatrix dot = new MyMatrix(1,0);
            dot.PrintMatrix();
        }

        static void Ex4Demo()
        {
            Store store = new Store();
            store.AddItem(new Article("Soap","Novus", 15.40));
            store.AddItem(new Article("Bread","Furshet", 9.10));
            store.AddItem(new Article("Juice","Auchan", 35.99));
            store.AddItem(new Article("Pepsi","Silpo", 7.77));
            store.AddItem(new Article("Chocolate","Fora", 27.14));

            store.AddItem(new Article("Banana","Furshet", 29.40),9);
           store.AddItem(new Article("Chips","MegaMarket", 21.58));


            Console.WriteLine("\nShow items by index:");
            Console.WriteLine(store[4]);
            Console.WriteLine(store[5]);

            Console.WriteLine("\nFing Items by name");

            Console.WriteLine(store["Banana"]);
            Console.WriteLine(store["Nothing"]);

            Console.WriteLine();
            store.ShowAllItems();
        }
    }
}