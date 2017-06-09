using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_FinalProject
{
    public class PerKmRental
    {
        private double revenue;
        private double fuel_rate = 1;
        private double journeyKilometres;

        public double Revenue
        {
            get { return (revenue); }
            set { revenue = value; }
        }

        public int JourneyKilometres
        {
            get { return (JourneyKilometres); }
            set { JourneyKilometres = value; }
        }

        public PerKmRental() { }

        public PerKmRental(double pkilometres)
        {
            journeyKilometres = pkilometres;
        }

        public double calculate_revenue()
        {
            revenue = journeyKilometres * fuel_rate;
            return revenue;
        }

    }
}
