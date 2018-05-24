using System;
using System.Runtime.CompilerServices;

namespace CSharp.Essential.Unit7
{
    public struct Train
    {
        private string destination;

//        private string trainNumber;
        private int trainNumber;
        private DateTime departureTime;

        public Train(string destination, int trainNumber, DateTime departureTime)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }

        public string Destination => destination;

        public int TrainNumber => trainNumber;

        public DateTime DepartureTime => departureTime;


        public static Train FillTrainInfo()
        {
            string dest;
            int number;
            DateTime departure;
            Console.WriteLine("\nCreating new train");
            Console.Write("Type destination point: ");
            dest = Console.ReadLine();
            Console.Write("Type train's route number: ");
            number = Int32.Parse(Console.ReadLine());
            Console.Write("Type departure time: ");
            departure = DateTime.Parse(Console.ReadLine());

            return new Train(dest, number, departure);
        }

        public static bool FindTrainByNumber(Train[] trainsList)
        {
            string trainNumber = Console.ReadLine();

            if (trainNumber == "exit" | trainNumber == "EXIT")
            {
                Console.WriteLine("Exiting from Train finder");
                return false;
            }

            int trainNo;

            if (Int32.TryParse(trainNumber, out trainNo))
            {
                FindTrain(trainsList, trainNo);
                return true;
            }
            else
            {
                Console.WriteLine("{0} it isn't train number", trainNumber);
                return true;
            }
        }

        private static void FindTrain(Train[] trainsList, int trainNo)
        {
            string dest = null;
            DateTime departs = DateTime.Now;
//            Train foundTrain;
            foreach (Train train in trainsList)
            {
                if (train.TrainNumber == trainNo)
                {
                    dest = train.Destination;
                    departs = train.DepartureTime;
                    
                    break;
                }
                
            }

            if (dest != null) 
            {
                Console.WriteLine("Train number {0} with destination {1} departures at {2}", trainNo, dest,
                    departs.ToShortTimeString());
            }
            else
            {
                Console.WriteLine("Train with number {0} was not found", trainNo);
            }
        }


/*

            return null;
        }

        static DateTime GenerateDptTime(string hours)
        {
            DateTime deptHours = DateTime.Parse(hours);
        }

        */


        public void ShowTrainInfo()
        {
            Console.WriteLine("Train number {0} with destination {1} departures at {2}", trainNumber, destination,
                departureTime.ToShortTimeString());
        }
    }
}