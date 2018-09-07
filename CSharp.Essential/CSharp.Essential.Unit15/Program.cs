using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit15
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unit 15 tasks");
            Console.WriteLine(new String('-', 50));

            //Ex1Demo();
            //Console.WriteLine(new String('-', 50));
            //Ex2Demo();
            Console.WriteLine(new String('-', 50));
            Ex3Demo();
            //Console.WriteLine(new String('-', 50));
            //Ex4Demo();
            //            Console.WriteLine(new String('-', 50));
            //Ex5Demo();
            Console.ReadLine();
        }

        public static void Ex1Demo()
        {
            Console.WriteLine("Task 1");
            Calculator.Calc();
        }

        public static void Ex2Demo()
        {
            Console.WriteLine("Task 2");
            WorkerClass wc = new WorkerClass();
            //wc.FillWorkers();
            wc.AutoFillWorkers();
            Console.WriteLine("Show all workers:");
            wc.ShowWorkers();
            wc.SortWorkers();
            Console.WriteLine(new String('+', 50));
            Console.WriteLine("Sort workers and show sorted workers:");
            wc.ShowWorkers();

            Console.WriteLine("Find workers by experience.");
            //Console.WriteLine("Type experience in years");
            wc.SearchWorkerByExp();

        }

        public static void Ex3Demo() {
            Console.WriteLine("Task 3");

            Stores str = new Stores();

            str.AutoFillProducts();
            str.ShowProducts();

            Console.WriteLine("Sorting array by Store");
            str.SortProducts();
            str.ShowProducts();

            try
            {
                str.SearchProductByStore();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
            }
            
        }


        public static void Ex5Demo()
        {

            string hdate = "2010";
            string fullDate = hdate + ".01.01 00:00:00";
            DateTime dt = DateTime.Parse(fullDate);

            int years = DateTime.Now.Year - dt.Year;

            Console.WriteLine("Years: {0}", years);




            Console.WriteLine("Now:{0} = {0:yyy}", dt);

            TimeSpan ts = DateTime.Now.Subtract(dt);

            //Console.WriteLine("{0:yyyy}",ts);

            //Console.WriteLine("Subtract date {0:Y}", DateTime.Now.Subtract(dt));
            Console.WriteLine("-",50);


           

            //DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
            //DateTime date2 = new DateTime(2015, 7, 20, 15, 30, 25); // 20.07.2015 15:30:25
            //Console.WriteLine(date1.Subtract(date2)); // 03:00:00
        }
    }
}
