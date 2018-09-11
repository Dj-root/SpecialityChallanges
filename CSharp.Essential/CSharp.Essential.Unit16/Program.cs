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

            Ex1Demo();
            Console.WriteLine(new String('-', 50));
            Ex2Demo();
            Console.WriteLine(new String('-', 50));
            Ex3Demo();
            Console.WriteLine(new String('-', 50));
            Ex4Demo();
            Console.WriteLine(new String('-', 50));
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

            House h1 = new House(100, 2, new Location("Kiev", "Khreschatyk 1"));
            House h2 = (House)h1.Clone();
            House h3 = (House)h1.DeepClone();

            Console.WriteLine("House 1 Original. Square: {0}, Floors: {1}, City: {2}, Street: {3}", h1.Square, h1.FloorQty, h1.City, h1.Street);
            Console.WriteLine("House 2 Clone. Square: {0}, Floors: {1}, City: {2}, Street: {3}", h2.Square, h2.FloorQty, h2.City, h2.Street);
            Console.WriteLine("House 3 Deep Clone. Square: {0}, Floors: {1}, City: {2}, Street: {3}", h3.Square, h3.FloorQty, h3.City, h3.Street);

            Console.WriteLine("\nChange House 2 to 100 and 1");
            h2.Square = 100;
            h2.FloorQty = 1;
            h2.City = "Vyshneve";
            h2.Street = "Yevropeyska 2";

            Console.WriteLine("House 1 Original. Square: {0}, Floors: {1}, City: {2}, Street: {3}", h1.Square, h1.FloorQty, h1.City, h1.Street);
            Console.WriteLine("House 2 Clone. Square: {0}, Floors: {1}, City: {2}, Street: {3}", h2.Square, h2.FloorQty, h2.City, h2.Street);
            Console.WriteLine("House 3 Deep Clone. Square: {0}, Floors: {1}, City: {2}, Street: {3}", h3.Square, h3.FloorQty, h3.City, h3.Street);

            Console.WriteLine("\nChange House 3 to 450 and 3");
            h3.Square = 450;
            h3.FloorQty = 3;
            h3.City = "Boyarka";
            h3.Street = "Khreschtyk 55";

            Console.WriteLine("House 1 Original. Square: {0}, Floors: {1}, City: {2}, Street: {3}", h1.Square, h1.FloorQty, h1.City, h1.Street);
            Console.WriteLine("House 2 Clone. Square: {0}, Floors: {1}, City: {2}, Street: {3}", h2.Square, h2.FloorQty, h2.City, h2.Street);
            Console.WriteLine("House 3 Deep Clone. Square: {0}, Floors: {1}, City: {2}, Street: {3}", h3.Square, h3.FloorQty, h3.City, h3.Street);

        }

        public static void Ex4Demo()
        {
            Console.WriteLine("Task 4");

            DateStore d1 = new DateStore(DateTime.Now);
            DateStore d2 = new DateStore(DateTime.Parse("04.08.2015"));

            Console.WriteLine("Date 1: {0}", d1);
            Console.WriteLine("Date 2: {0}", d2);

            DateStore d3 = d1 + d2;
            DateStore d4 = d3 - d1;

            Console.WriteLine(d3);
            Console.WriteLine(d4);
        }
    }
}
