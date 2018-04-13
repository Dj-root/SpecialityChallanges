using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit2
{
    class Converter
    {
        public double UsdRate { get; private set; }
        public double EurRate { get; private set; }
        public double RurRate { get; private set; }


        public Converter(double usdRate, double eurRate, double rurRate)
        {
            UsdRate = usdRate;
            EurRate = eurRate;
            RurRate = rurRate;
        }

        public double GetExchangeInUah(double amount, Currency currency)
        {
            double result;
            double rate = 0;

            switch (currency)
            {
                case Currency.Usd:
                    rate = UsdRate;
                    break;
                case Currency.Eur:
                    rate = EurRate;
                    break;
                case Currency.Rur:
                    rate = RurRate;
                    break;
            }


            if (amount > 0)
            {
                result = amount * rate;
                return result;
            }

            return 0;

        }

        public double GetExchangeInCurrency(double amount, Currency currency)
        {
            double result;
            double rate = 0;

            switch (currency)
            {
                case Currency.Usd:
                    rate = UsdRate;
                    break;
                case Currency.Eur:
                    rate = EurRate;
                    break;
                case Currency.Rur:
                    rate = RurRate;
                    break;
            }


            if (amount > 0)
            {
                result = amount / rate;
                return result;
            }

            return 0;

        }
    }
}
