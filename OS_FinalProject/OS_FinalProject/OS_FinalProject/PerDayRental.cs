using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_FinalProject
{
    public class PerDayRental
    {

        public PerDayRental() { }

        private double revenue;
        private double day_rate = 100;
        private int day;

        public double Revenue {
            get { return (revenue); }
            set { revenue = value; }
        }

        public int Day { 
           get { return (day); }
           set { day = value; }
        }


        public PerDayRental(int pdays)
        {
            day = pdays;
        }

        public double calculate_revenue()
        {
            revenue = day * day_rate;
            return revenue;
        }
    }
}

