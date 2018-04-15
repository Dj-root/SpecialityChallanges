using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit2.Task3
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private Position position;
        private int expirience;


        public Position Position
        {
            get { return position; }
            set
            {
                if (value == null)
                {
                    position = Position.Worker;
                }
                else
                {
                    position = value;
                }
            }
        }

        public int Expirience
        {
            get { return expirience; }
            set
            {
                if (value == null)
                {
                    expirience = 1;
                }
                else
                {
                    expirience = value;
                }
            }
        }



        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        private double GetRates()
        {
            double rate = 0;
            if (Expirience < 3)
            {
                rate = 1;
            }
            else if (Expirience >= 3 & Expirience < 10)
            {
                rate = 1.1;
            }
            else if (Expirience >= 10 & Expirience < 20)
            {
                rate = 1.2;
            }
            else if (Expirience >= 20)
            {
                rate = 1.3;
            }


            return rate;
        }

        public double GetTaxAmount()
        {
            double taxAmount;
            double taxRate = 0.195;
            taxAmount = this.GetGrossSalary() * taxRate;

            return taxAmount;
        }

        public double GetGrossSalary()
        {
            double salary;
            double baseSalary=0;

            if (position == Position.Worker)
            {
                baseSalary = 4205.50;
            }else if (position == Position.AdminStuff)
            {
                baseSalary = 6834.25;
            }
            else if (position == Position.Manager)
            {
                baseSalary = 12500.10;
            }else if (position == Position.Ceo)
            {
                baseSalary = 31050.99;
            }
            
            salary = baseSalary * this.GetRates();

            return salary;
        }

        public double GetNetSalary()
        {
            double netSalary;
            netSalary = this.GetGrossSalary() - this.GetTaxAmount();

            return netSalary;
        }

        public void ShowPayments()
        {
            Console.WriteLine("Worker's information:\nFirst Name:\t\t{0},\nLast Name:\t\t{1},\nPosition:\t\t{2},\n" +
                              "Expirience:\t\t{3} years\nGross Salary:\t\t{4} UAH,\nNet Salary:\t\t{5} UAH,\n" +
                              "Amount Taxes:\t\t{6} UAH", FirstName, LastName, Position,Expirience,this.GetGrossSalary(),
                this.GetNetSalary(), this.GetTaxAmount());
        }
    }
}
