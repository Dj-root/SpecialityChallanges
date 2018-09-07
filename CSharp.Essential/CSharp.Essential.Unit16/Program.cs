using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit 16 tasks");
            Console.WriteLine(new String('-', 50));

            //Ex1Demo();
            Console.WriteLine(new String('-', 50));
            //Ex2Demo();
            Console.WriteLine(new String('-', 50));
            Ex3Demo();
            Console.WriteLine(new String('-', 50));
            //Ex4Demo();
            //            Console.WriteLine(new String('-', 50));
            //Ex5Demo();
            Console.ReadLine();
        }

        public static void Ex1Demo()
        {
            Console.WriteLine("Task 1");

            Point p1 = new Point(1, 1, 1);
            Point p2 = new Point(2, 2, 2);

            Point p3 = p1 + p2;
            p3.ShowPoint3D();
        }
        public static void Ex2Demo()
        {
            Console.WriteLine("Task 2");

            Block b1 = new Block(2, 2, 1, 1);
            Block b2 = new Block(1, 1, 1, 1);
            Block b3 = new Block(2, 2, 1, 1);

            Console.WriteLine("Blocks:");
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);

            Console.WriteLine("b1 = b2: {0}", b1.Equals(b2));
            Console.WriteLine("b1 = b3: {0}", b1.Equals(b3));
        }

        public static void Ex3Demo()
        {
            Console.WriteLine("Task 3");

            House h1 = new House(500, 3);
            House h2 =(House) h1.Clone();

            Console.WriteLine("House 1. Square: {0}, Floors: {1}", h1.Square, h1.FloorQty);
            Console.WriteLine("House 2. Square: {0}, Floors: {1}", h2.Square, h2.FloorQty);

            Console.WriteLine("Change House 2 to 100 and 1");
            h2.Square = 100;
            h2.FloorQty = 1;

            Console.WriteLine("House 2. Square: {0}, Floors: {1}", h2.Square, h2.FloorQty);

        }
    }
}
