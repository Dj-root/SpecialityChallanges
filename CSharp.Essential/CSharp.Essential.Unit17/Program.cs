using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit17
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
            //Ex4Demo();
            Console.WriteLine(new String('-', 50));
            //Ex5Demo();
            Console.ReadLine();
        }

        public static void Ex1Demo()
        {
            Console.WriteLine("Task 1\n");

            Console.WriteLine("50 + 12 = {0}", SimpleCalc.Add(50, 12));
            Console.WriteLine("50 - 12 = {0}", SimpleCalc.Sub(50, 12));
            Console.WriteLine("50 * 12 = {0}", SimpleCalc.Mul(50, 12));
            Console.WriteLine("50 / 12 = {0}", SimpleCalc.Div(50, 12));
            Console.WriteLine("50 / 0 = {0}", SimpleCalc.Div(50, 0));
        }

        public static void Ex2Demo()
        {
            Console.WriteLine("Task 2\n");

            var cars = new List<AutoSalon>
            {
                new AutoSalon("Zaz", "Forza", 2017, "Green"),
                new AutoSalon("Zaz", "Vida", 2016, "Orange"),
                new AutoSalon("Vaz", "Kalina", 2016, "Violet"),
                new AutoSalon("Opel", "Omega", 2017, "White"),
                new AutoSalon("Mercedes", "Vito", 2018, "Black"),
                new AutoSalon("Mercedes", "S500", 2018, "Black"),
                new AutoSalon("Mercedes", "A160", 2017, "White"),
                new AutoSalon("BMW", "X6", 2018, "Black"),
                new AutoSalon("BMW", "Z7", 2018, "Black")
            };

            var customers = new List<Retail>
            {
                new Retail("Vito", "Ivan Ivanov", "098 888-77-66"),
                new Retail("Vida", "Petr Petrov", "050 555-66-77"),
                new Retail("Z7", "Nikolay Nikolayev", "066 666-55-44"),
                new Retail("S500", "Vasiliy Vasiliev", "067 777-88-99"),
                new Retail("S500", "Ivan Petrov", "099-999-99-88")
            };

            var queryCars = from car in cars
                            orderby car.Model
                            select car;

            var queryCustomers = from customer in customers
                                 orderby customer.ClientName
                                 select customer;

            var queryOwners = from cust in customers
                              orderby cust.ClientName
                              join salon in cars on cust.Model equals salon.Model
                              where salon.Color == "Orange"
                              select new { cust.ClientName, salon.Brand, salon.Model, salon.ManufacturingYear, salon.Color };

            ////Select cars
            //foreach (var car in queryCars)
            //{
            //    Console.WriteLine(car.Brand + " " + car.Model + " " + car.ManufacturingYear + " " + car.Color);
            //}

            //// select customers
            //foreach (var customer in queryCustomers)
            //{
            //    Console.WriteLine(customer.Model+" "+customer.ClientName+" "+customer.ClientPhone);
            //}

            foreach (var owner in queryOwners)
            {
                Console.WriteLine(owner.ClientName + " " + owner.Brand + " " + owner.Model + " " +
                                  owner.ManufacturingYear + " " + owner.Color);
            }
        }

        public static void Ex3Demo()
        {
            var dictionary = new Dictionary<dynamic, dynamic>
            {
                {new {Key = "table"}, new {Value = "стол"}},
                {new {Key = "apple"}, new {Value = "яблоко"}},
                {new {Key = "pen"}, new {Value = "ручка"}},
                {new {Key = "pencil"}, new {Value = "карандаш"}},
                {new {Key = "task"}, new {Value = "задание"}},
                {new {Key = "key"}, new {Value = "ключ"}},
                {new {Key = "customer"}, new {Value = "покупатель"}},
                {new {Key = "ship"}, new {Value = "корабль"}},
                {new {Key = "car"}, new {Value = "машина"}},
                {new {Key = "cap"}, new {Value = "чашка"}}

                //{"table",   "стол"},
                //{"apple",    "яблоко"},
                //{"pen",      "ручка"},
                //{"pencil",   "карандаш"},
                //{"task",     "задание"},
                //{"key",      "ключ"},
                //{"customer", "покупатель"},
                //{"ship",     "корабль"},
                //{"car",      "машина"},
                //{"cap",      "чашка"}
            };
            foreach (var item in dictionary)
            {
                Console.WriteLine("{0}-{1}", item.Key, item.Value);

            }
        }
    }
}
