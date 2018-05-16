using System;

namespace CSharp.Essential.Unit6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unit 6 tasks");
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
            Console.WriteLine("Basic calculator");
            Console.WriteLine("64 + 32 = {0}", Calculator.Add(64, 32));
            Console.WriteLine("64 - 32 = {0}", Calculator.Subtract(64, 32));
            Console.WriteLine("64 / 30 = {0}", Calculator.Divide(64, 30));
            Console.WriteLine("64 * 32 = {0}", Calculator.Multiply(64, 32));
        }

        static void Ex2Demo()
        {
            Book b = new Book();
            FindAndReplaceManager.FindNext("Hello");
        }

        static void Ex3Demo()
        {
            Book.Note note = new Book.Note();

            note.Text = "Good book";
            note.Text = "I like it!";

            Console.WriteLine(note.Text);
        }

        static void Ex4Demo()
        {
            int[] nums = new[] {0, 9, 7, 8, 6, 5, 4, 3, 2, 1};
//            nums.

            Console.WriteLine("Source array:");
            foreach (int num in nums)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine();

            nums.SortByAsc();
            
            Console.WriteLine("Sorted array:");
            foreach (int num in nums)
            {
                Console.Write("{0} ", num);
            }
        }

        
    }
}
