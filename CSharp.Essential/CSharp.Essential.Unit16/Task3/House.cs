using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit16
{
    class House : ICloneable
    {
        int square, floorQty;
        Location city;
        Location street;

        public House(int square, int floorQty, Location city, Location str)
        {
            this.square = square;
            this.floorQty = floorQty;
            this.city = city;
            this.street = str;
        }

        public int Square
        {
            get { return square; }
            set { this.square = value; }
        }
        public int FloorQty
        {
            get { return floorQty; }
            set { this.floorQty = value; }
        }

        public Location City { get { return city; } set { this.city = value; } }
        public Location Street { get { return street; } set { this.street = value; } }

        public object Clone()
        {
            return this;
        }

        public object DeepClone()
        {
            return new House(this.Square, this.FloorQty, this.city.Clone() as Location, this.street.Clone() as Location);
        }
    }

    class Location
    {
        string city;
        string street;

        public Location(string city, string street)
        {
            this.city = city;
            this.street = street;
        }

        public string City { get { return city; } }
        public string Street { get { return street; } }

        public object Clone()
        {
            return new Location(this.City, this.Street);
        }
    }
}
