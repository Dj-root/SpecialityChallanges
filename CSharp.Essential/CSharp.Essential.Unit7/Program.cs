using System;


namespace CSharp.Essential.Unit7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unit 7 tasks");
            Console.WriteLine(new String('-', 50));
            Ex1Demo();
            Console.WriteLine(new String('-', 50));
            Ex2Demo();
            Console.WriteLine(new String('-', 50));
            Ex3Demo();
            Console.WriteLine(new String('-', 50));
//            Ex4Demo();
            Console.ReadLine();
        }


        static void Ex1Demo()
        {
            Console.WriteLine("Sample of Structure");
            Notebook laptop = new Notebook("T460", "Lenovo", 890);
            Console.WriteLine("Using properties:\nVendor: {0}, Model: {1}, Price: {2}", laptop.Vendor, laptop.Model,
                laptop.Price);
            Console.WriteLine("Using method:");
            laptop.ShowNotebookInfo();

            Console.WriteLine("Another netbook");
            Notebook netbook = new Notebook("T61");
            netbook.ShowNotebookInfo();
        }

        static void Ex2Demo()
        {
            bool rslt;

            Console.WriteLine("Trains demo with Structure");
            Console.WriteLine("AutoFilled trains list");

            Train[] trainsList = new[]
            {
                new Train("Kamenets Podolsky", 687, DateTime.Parse("19-05-2018 18:50")),
                new Train("Lviv", 12, DateTime.Parse("19-05-2018 14:10")),
                new Train("Minsk", 1013, DateTime.Parse("19-05-2018 1:05")),
                new Train("Uzhgorod", 03, DateTime.Parse("19-05-2018 22:24")),
                new Train("Kharkiv", 028, DateTime.Parse("19-05-2018 10:32")),
                new Train("Ivano-Frankivsk", 144, DateTime.Parse("19-05-2018 14:50")),
                new Train("Dnipro", 364, DateTime.Parse("19-05-2018 12:03")),
                new Train("Melitopol", 512, DateTime.Parse("19-05-2018 17:36")),
            };

            Console.WriteLine("Show all Trains:");
            foreach (Train train in trainsList)
            {
                train.ShowTrainInfo();
            }

            trainsList.SortByAsc();

            Console.WriteLine("\nShow sorted Trains:");
            foreach (Train train in trainsList)
            {
                train.ShowTrainInfo();
            }

            // Find train by number
            do
            {
                Console.Write("\nTo find a train, or type route No or 'exit': ");
                rslt = Train.FindTrainByNumber(trainsList);
            } while (rslt);


            Console.WriteLine(new String('+', 50));


            // Manual typed trains
            Console.WriteLine("\nAutoFilled trains list");


            Train[] manualTypedTrains = new Train[8];

            Console.WriteLine("\nType info about trains into the array:");

            for (int i = 0; i < manualTypedTrains.Length; i++)
            {
                manualTypedTrains[i] = Train.FillTrainInfo();
            }


            Console.WriteLine("\nShow all typed trains:");
            foreach (Train train in manualTypedTrains)
            {
                train.ShowTrainInfo();
            }

            manualTypedTrains.SortByAsc();

            Console.WriteLine("\nShow sorted trains:");
            foreach (Train train in manualTypedTrains)
            {
                train.ShowTrainInfo();
            }

            // Find train by number
            do
            {
                Console.Write("\nTo find a train, or type route No or 'exit': ");
                rslt = Train.FindTrainByNumber(manualTypedTrains);
            } while (rslt);
        }

        static void Ex3Demo()
        {
            MyClass myClass = new MyClass();
            myClass.change = "Not Changed!";

            MyStruct myStruct = new MyStruct();
            myStruct.change = "Not Changed!";

            Console.WriteLine("\nInitial values");
            Console.WriteLine("myClass.change value is '{0}'", myClass.change.ToString());
            Console.WriteLine("myStruct.change value is '{0}'", myStruct.change);

            Console.WriteLine("\nUsing ClassTaker and StructTaker methods");
            Task3Demo.ClassTaker(myClass);
            Task3Demo.StructTaker(ref myStruct);
            
            Console.WriteLine("myClass.change value is '{0}'", myClass.change);
            Console.WriteLine("myStruct.change value is '{0}'", myStruct.change);
        }

        static void Ex4Demo()
        {
            // Task 4 is not present in current Unit
        }
    }
}