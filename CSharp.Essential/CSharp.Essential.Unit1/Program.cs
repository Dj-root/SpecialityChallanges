using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1Demo();
            Console.WriteLine(new string('-',50));
            Ex2Demo();
            Console.WriteLine(new string('-', 50));
            Ex3Demo();


            Console.ReadLine();
        }

        public static void Ex1Demo()
        {
            Rectangle rect = new Rectangle(1, 2);

            Console.WriteLine("The Area of Rectangle is: {0}", rect.Area);
            Console.WriteLine("The Perimetr of Rectangle is: {0}", rect.Perimetr);
        }

        public static void Ex2Demo()
        {
            Book book = new Book("Tora");
            book.Author = "Moses";
            book.Content = "Five units with rules and a lot of Hystory";

            book.Show();
        }

        public static void Ex3Demo()
        {
            Figure triangle = new Figure(new Point(1,1,"A"), new Point(2,2,"B"), new Point(3,3,"C") );
            triangle.PerimeterCalculator();

            Figure sqare = new Figure(new Point(1, 1, "A"), new Point(2, 2, "B"), new Point(3, 3, "C"), 
                            new Point(4,4,"D"));
            sqare.PerimeterCalculator();

            Figure star = new Figure(new Point(1, 1, "A"), new Point(2, 2, "B"), new Point(3, 3, "C"),
                new Point(4, 4, "D"), new Point(5,5,"E"));
            star.PerimeterCalculator();
        }
    }
}
