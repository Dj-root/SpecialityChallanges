using System;

namespace CSharp.Essential.Unit11
{
    public class Car
    {
        public string CarName { get; private set; }
        public int ManYear { get; private set; }

        public Car(string carName, int manYear)
        {
            CarName = carName;
            ManYear = manYear;
        }

        public override string ToString()
        {
            return string.Format("Car name: {0}, \t\tManufacturing year: {1}", CarName, ManYear);
        }
    }
}