using System;
using System.Threading;

namespace CSharp.Essential.Unit13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unit 13 tasks");
            Console.WriteLine(new String('-', 50));

//            Ex1Demo();
//            Console.WriteLine(new String('-', 50));
//            Ex2Demo();
//            Console.WriteLine(new String('-', 50));
//            Ex3Demo();
//            Console.WriteLine(new String('-', 50));
//            Ex4Demo();
//            Console.WriteLine(new String('-', 50));
//            Ex5Demo();
            Console.ReadLine();
            
        }

        public static void Ex1Demo()
        {
            Console.SetWindowSize(80, 40);

            CSharp.Essential.Unit13.Task1.Matrix instance;
            
            for (int i = 0; i < 30; i++)
            {
                instance = new CSharp.Essential.Unit13.Task1.Matrix(i * 2);
                new Thread(instance.Move).Start();
            }


            Console.ReadKey();
        }

        public static void Ex2Demo()
        {
            Console.SetWindowSize(80, 42);

            CSharp.Essential.Unit13.Task2.Matrix instance;

            for (int i = 0; i < 26; i++)
            {
                instance = new CSharp.Essential.Unit13.Task2.Matrix(i * 3, true);
                new Thread(instance.Move).Start();
            }
        }
    }
}