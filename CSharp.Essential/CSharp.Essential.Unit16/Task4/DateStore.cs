using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit16
{
    class DateStore
    {
        private readonly DateTime date;

        public DateStore(DateTime date)
        {
            this.date = date;
        }

        public static DateStore operator +(DateStore d1, DateStore d2)
        {
            TimeSpan ts = d1.date - d2.date;
            DateTime dt = d1.date.AddDays(ts.Days);
            return new DateStore(dt);

        }

        public static DateStore operator -(DateStore d1, DateStore d2)
        {
            TimeSpan ts = d1.date - d2.date;
            DateTime dt = d1.date.AddDays(-ts.Days);
            return new DateStore(dt);

        }

        public static DateStore  Add(DateStore d1, DateStore d2)
        {
            return d1 + d2;
        }

        public static DateStore Sub(DateStore d1, DateStore d2)
        {
            return d1 - d2;
        }

        public override string ToString()
        {
            return "Date: " + date.Date;
        }
    }
}
