using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit3
{ 
    class Ship : Vehicle
    {
        public int passengersQty;

        public int PassengersQty
        {
            get { return passengersQty; }
            set
            {
                if (value > 0)
                {
                    passengersQty = value;
                }
                else
                {
                    passengersQty = 0;
                }

            }
        }
        public string Port { get; set; }

        public Ship(double latitude, double longitude, double cost, int speed, int manufacturingYear, int passengersQty, string port)
            :base(latitude, longitude, cost, speed, manufacturingYear)
        {
            PassengersQty = passengersQty;
            Port = port;
        }

        public override void ShowVehicleInfo()
        {
            Console.WriteLine("This is a Ship.");

            if (Latitude == 0 & Longitude == 0)
            {
                Console.WriteLine("Geo position is N 0 and E 0, and Your ship position is the Null Island");
            }
            else
            {
                Console.WriteLine("Geo position is N {0} and E {1}", Latitude, Longitude);
            }
            Console.WriteLine("Ship costs ${0}, has max speed {1} knots and manufactured at {2} year",
                Cost, Speed, ManufacturingYear);
            Console.WriteLine("Ship can transfer till {0} passengers and registered in {1}", PassengersQty, Port);
            Console.WriteLine(new String('-', 50));
        }

    }
}
