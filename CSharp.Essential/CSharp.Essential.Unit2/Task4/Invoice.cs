using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit2
{
    class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

        private string article;
        private int quantity;
        private double price;

        public Invoice(int account, string customer, string provider, string article, int quantity, double price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.Article = article;
            this.Quantity = quantity;
            this.Price = price;
        }

        public Invoice(int account, string customer, string provider):this(account, customer, provider,null,0,0)
        {
        }

        public string Article
        {
            get { return article; }
            set
            {
                if ( value== null |value == "")
                {
                    article = "Balalayka";
                }
                else
                {
                    article = value;
                }
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if ( value <= 0)
                {
                    quantity = 128;
                }
                else
                {
                    quantity = value;
                }
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if ( value <= 0)
                {
                    price = 1024;
                }
                else
                {
                    price = value;
                }
            }
        }

        public double CostWithVat()
        {
            double cost;
            cost = Quantity * Price;
            return cost;
        }

        public double CostWithoutVat()
        {
            double cost;
            cost = CostWithVat() / 1.2;
            return cost;
        }

        public void ShowOrderInfo()
        {
            Console.WriteLine("Order No is:\t\t{0} \nCustomer: \t\t{1} \nSupplier: \t\t{2} " +
                              "\nGoods type: \t\t{3} \nQuantity: \t\t{4} pcs \nPrice: \t\t\t{5} " +
                              "\nCost without VAT: \t{6} UAH \nCost with VAT: \t\t{7} UAH",
                this.account, this.customer, this.provider, this.Article, this.Quantity,
                this.Price, this.CostWithoutVat(), this.CostWithVat());
        }
    }
}
