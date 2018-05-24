using System;

namespace CSharp.Essential.Unit7
{
    public struct Notebook
    {
        private string model;
        private string vendor;
        private double price;

        public string Model => model;

        public string Vendor => vendor;

        public double Price => price;


        public Notebook(string model, string vendor, double price)
        {
            this.model = model;
            this.vendor = vendor;
            this.price = price;
        }

        public Notebook(string model) : this(model, "",0)
        {
        }

        public Notebook(double price) : this("", "",price)
        {
        }

        public void ShowNotebookInfo()
        {
            Console.WriteLine("Vendor of Laptop is {0}, model is {1}, price {2}", vendor, model, price);
        }
    }
}