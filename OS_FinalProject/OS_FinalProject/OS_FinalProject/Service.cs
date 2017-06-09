using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_FinalProject
{
    public class Service
    {

        public int NumberOfService { get; set; }

        public void calculateService()
        {
            NumberOfService++;
        }
    }
}
