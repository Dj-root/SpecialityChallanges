using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit3
{
    class Vehicle
    {
        private double latitude;
        private double longitude;
        public double cost;
        public int speed;

        public double Latitude
        {
            get { return latitude; }
            set
            {
                if (value >= 0 & value <= 180)
                {
                    latitude = value;
                }
                else
                {
                    latitude = 0;
                }
            }
        }
        public double Longitude
        {
            get { return longitude; }
            set
            {
                if (value >= -90 & value <= 90)
                {
                    longitude = value;
                }
                else
                {
                    longitude = 0;
                }

            }
        }
        public double Cost
        {
            get { return cost; }
            set
            {
                if (value > 0)
                {
                    cost = value;
                }
                else
                {
                    cost = 0;
                }
            }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 0)
                {
                    speed = value;
                }
                else { speed = 0; }
            }
        }
        public int ManufacturingYear { get; set; }

        public Vehicle(double latitude, double longitude, double cost, int speed, int manufacturingYear)
        {
            Latitude = latitude;
            Longitude = longitude;
            Cost = cost;
            Speed = speed;
            ManufacturingYear = manufacturingYear;
        }

        public virtual void ShowVehicleInfo()
        { }

        public static void GetInfo(Vehicle vehicle)
        {
            vehicle.ShowVehicleInfo();
        }
    }
}
