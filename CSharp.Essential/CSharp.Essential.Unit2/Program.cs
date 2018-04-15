using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Essential.Unit2.Task3;

namespace CSharp.Essential.Unit2
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
            Console.WriteLine(new string('-', 50));
            Ex4Demo();


            Console.ReadLine();
        }

        public static void Ex1Demo()
        {
            Console.WriteLine("=== Creating new user ===");
            User user = new User("Anonymous", "Ivan", "Ivanov", 20);

            user.GetUserInfo();
        }

        public static void Ex2Demo()
        {
            Converter converterDemo = new Converter(27.05, 32.15, 0.41);

            Console.WriteLine("Converting 5 USD to UAH: {0}", converterDemo.GetExchangeInUah(5,Currency.Usd));


            Console.WriteLine("Converting 506 UAH to RUR: {0}", converterDemo.GetExchangeInCurrency(506, Currency.Rur));

        }

        public static void Ex3Demo()
        {
            Employee vasia = new Employee("Vasiliy", "Sen");
            vasia.Expirience = 12;

            vasia.ShowPayments();
            Console.WriteLine(new string('+', 50));
            Employee roma = new Employee("Roman", "Gerasimenko");
            roma.Expirience = 15;
            roma.Position = Position.Ceo;

            roma.ShowPayments();
        }

        public static void Ex4Demo()
        {
            Invoice order1 = new Invoice(1,"Ivan", "Auchan");
//            order1.Article = "";
//            order1.Price = -1;
//            order1.Quantity = 0;

            order1.ShowOrderInfo();
            Console.WriteLine(new string('+', 50));

            Invoice order2 = new Invoice(2, "Victor", "Olx", "Samovar", 2365, 2);
//            order2.Article = "Samovar";
//            order2.Price = 2540;
//            order2.Quantity = 3;

            order2.ShowOrderInfo();
        }
    }
}
