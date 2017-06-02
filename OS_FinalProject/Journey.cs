using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_FinalProject
{
    public class Journey
    { 
        public Journey() {
            requireService = false;
        }

        public int vehicleId { get; set; }

        public float totalKilometres { get; set; }

        public float kilometresAfterService { get; set; }

        public bool requireService { get; set; }

   
    }
}
