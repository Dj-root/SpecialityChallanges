using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit3
{
    class Car:Vehicle
    {
        public Car(double latitude, double longitude, double cost, int speed, int manufacturingYear)
            :base(latitude, longitude, cost, speed, manufacturingYear) { }

        public override void ShowVehicleInfo()
        {
            Console.WriteLine("This is a Car.");

            if (Latitude == 0 & Longitude == 0)
            {
                Console.WriteLine("Geo position is N 0 and E 0, and Your car position is somewhere in Athlantic Ocean on the Null Island :) ");
            }
            else
            {
                Console.WriteLine("Geo position is N {0} and E {1}", Latitude, Longitude);
            }
            Console.WriteLine("Car costs ${0}, has max speed {1} km/h and manufactured at {2} year",
                Cost, Speed, ManufacturingYear);
            Console.WriteLine(new String('-', 50));
        }
    }
}

/*
 private double latitude;
        private double longitude;
        public double cost;
        public int speed;
public int ManufacturingYear
 */


