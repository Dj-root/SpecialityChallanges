using System;

namespace CSharp.Essential.Unit8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unit 8 tasks");
            Console.WriteLine(new String('-', 50));

//            Ex1Demo();
            Console.WriteLine(new String('-', 50));
//            Ex2Demo();
            Console.WriteLine(new String('-', 50));
            Ex3Demo();
            Console.WriteLine(new String('-', 50));
            Ex4Demo();
            Console.ReadLine();
        }


        static void Ex1Demo()
        {
            BirthDay bd = new BirthDay();
            bd.SetBithDate();
            Console.WriteLine("\nYour Birthday is: {0}", bd.DayOfBirth.ToShortDateString());

            bd.GetQtyDaysToNextBithday();
        }

        static void Ex2Demo()
        {
            string strColorId;
            int colorId;
            bool covnerted = false;
            string stringToPrint;

            Console.WriteLine("Enum Demo\nConsole colors are:");
            for (System.ConsoleColor num = System.ConsoleColor.Black; num <= System.ConsoleColor.White; num++)
            {
                Console.WriteLine("{0} - {1}", (int) num, num);
            }


            Console.Write("Type Console color id: ");
            covnerted = Int32.TryParse(Console.ReadLine(), out colorId);
            if (covnerted & colorId >= 0 & colorId <= 15)
            {
                Console.WriteLine("Selected color is: {0}", Enum.GetName(typeof(System.ConsoleColor), colorId));
            }
            else
            {
                colorId = 0;
                Console.WriteLine("You selected incorrect color. Using {0} as default",
                    Enum.GetName(typeof(System.ConsoleColor), colorId));
            }

            Console.Write("\nType string to print: ");
            stringToPrint = Console.ReadLine();

            ColorPrinter.Print(stringToPrint, colorId);
        }

        static void Ex3Demo()
        {
            Console.WriteLine("Task 3");
            
            Accountant acc = new Accountant();

            Employees johnDoe = Employees.CEO;
            Employees blinkeyBill = Employees.CFO;
            Employees kumar = Employees.HRManager;
            Employees hans = Employees.ITStuff;
            Employees ivan = Employees.Worker;

            Console.Write("John Doe on {0} position worked for {1} hours and ",johnDoe.ToString(), 130);
            if (Accountant.AskForBonus(johnDoe, 130))
            {
                Console.WriteLine("he gets a bonus for good work");
            }
            else
            {
                Console.WriteLine("he've got a penalty for bad work");
            }
            
            Console.Write("Ivan on {0} position worked for {1} hours and ",ivan.ToString(), 170);
            if (Accountant.AskForBonus(ivan, 170))
            {
                Console.WriteLine("he gets a bonus for good work");
            }
            else
            {
                Console.WriteLine("he've got a penalty for bad work");
            }
            
            
        }

        static void Ex4Demo()
        {
        }
    }
}