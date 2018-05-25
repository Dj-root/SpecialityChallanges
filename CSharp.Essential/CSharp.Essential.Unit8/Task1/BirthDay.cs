using System;
using System.Runtime.CompilerServices;

namespace CSharp.Essential.Unit8
{
    public struct BirthDay
    {
        private DateTime dayOfBirth;


        public DateTime DayOfBirth
        {
            get { return dayOfBirth; }
        }

        public void SetBithDate()
        {
            Console.Write("\nType your Birth date (dd-mm-yyyy): ");
            string bd = Console.ReadLine();
//            string bd = "01-06-2011";
            dayOfBirth = DateTime.Parse(bd);
        }

        public void GetQtyDaysToNextBithday()
        {
            DateTime now = DateTime.Today;
            DateTime thisYearBirthDay = new DateTime(now.Year, dayOfBirth.Month, dayOfBirth.Day);
            TimeSpan left;

            if (thisYearBirthDay < now)
            {
                thisYearBirthDay = new DateTime(now.Year+1, dayOfBirth.Month, dayOfBirth.Day);
                left = thisYearBirthDay - now;
                Console.WriteLine("Day to Bithday left: {0}", left.TotalDays);
            }
            else
            {
                left = thisYearBirthDay - now;
                Console.WriteLine("Day to Bithday left: {0}", left.TotalDays);
            }

        }
    }
}