using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_FinalProject
{
    public class Vehicle
    {
        public Vehicle() { }

        public Vehicle(string pManufacturer, string pModel, string pRegistrationNo, int pYearOfManufacture, Journey pJourney, FuelPurchase pFuelPurchase)
        {
            Manufacturer = pManufacturer;
            Model = pModel;
            RegistrationNo = pRegistrationNo;
            YearOfManufacture = pYearOfManufacture;
            Journey = pJourney;
            FuelPurchase = pFuelPurchase;
        }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string RegistrationNo { get; set; }

        public int YearOfManufacture { get; set; }

        public Journey Journey { get; set; }

        public FuelPurchase FuelPurchase { get; set; }

    }
}
