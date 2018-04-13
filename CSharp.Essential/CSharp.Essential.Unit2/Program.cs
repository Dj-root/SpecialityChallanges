using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
