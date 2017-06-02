using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_FinalProject
{
    public class PerDayRental
    {
        public int revenue;

        public int day { get; set; }

        public int Revenue
        {
            get
            {
                revenue = day * 100;
                return revenue;
            }
            set
            {
                this.revenue = value;
            }
        }
    }
}
