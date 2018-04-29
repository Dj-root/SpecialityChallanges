using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit3
{
    class Plane: Vehicle
    {
        public int altitude;
        public int passengersQty;

        public int Altitude
        {
            get { return altitude; }
            set
            {
                if (value >= 0)
                {
                    altitude = value;
                }
                else
                {
                    value = 0;
                }
            }
        }
        public int PassengersQty
        {
            get { return passengersQty; }
            set
            {
                if (value>0)
                {
                    passengersQty = value;
                }
                else
                {
                    passengersQty = 0;
                }

            } }

        public Plane(double latitude, double longitude, double cost, int speed, int manufacturingYear, int altitude, int passengersQty)
            : base(latitude, longitude, cost, speed, manufacturingYear)
        {
            Altitude = altitude;
            PassengersQty = passengersQty;
        }

        public override void ShowVehicleInfo()
        {
            Console.WriteLine("This is a Ship.");

            if (Latitude == 0 & Longitude == 0 & Altitude == 0)
            {
                Console.WriteLine("Geo position is N 0, E 0 and Altitude 0.\n" +
                    "Plane is not a ship and it fell on the Null Island");
            }
            else
            {
                Console.WriteLine("Geo position is N {0}, E {1} and Altitude {2}", Latitude, Longitude, Altitude);
            }
            Console.WriteLine("Plane costs ${0}, has max speed {1} km/h and manufactured at {2} year",
                Cost, Speed, ManufacturingYear);
            Console.WriteLine("Plane can transfer till {0} passengers", PassengersQty);
            Console.WriteLine(new String('-', 50));
        }

    }
}
