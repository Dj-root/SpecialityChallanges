using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit17
{
    class AutoSalon
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ManufacturingYear { get; set; }
        public string Color { get; set; }

        public AutoSalon(string brand, string model, int manufacturingYear, string color)
        {
            Brand = brand;
            Model = model;
            ManufacturingYear = manufacturingYear;
            Color = color;
        }
    }

    class Retail
    {
        public string Model { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }

        public Retail(string model, string clientName, string clientPhone)
        {
            Model = model;
            ClientName = clientName;
            ClientPhone = clientPhone;
        }
    }
}
