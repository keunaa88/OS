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

        public Vehicle(int pid, string pManufacturer, string pModel, string pRegistrationNo, int pYearOfManufacture, Journey pJourney, FuelPurchase pFuelPurchase, PerDayRental pPerDayRental, PerKmRental pPerKmRental, int pNumberOfService)
        {
            Id = pid;
            Manufacturer = pManufacturer;
            Model = pModel;
            RegistrationNo = pRegistrationNo;
            YearOfManufacture = pYearOfManufacture;
            Journey = pJourney;
            FuelPurchase = pFuelPurchase;
            PerDayRental = pPerDayRental;
            PerKmRental = pPerKmRental;
            NumberOfService = pNumberOfService;
        }

        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string RegistrationNo { get; set; }

        public int YearOfManufacture { get; set; }

        public int TatalRevenue { get; set; }

        public int NumberOfService { get; set; }

        public Journey Journey { get; set; }

        public PerDayRental PerDayRental { get; set; }

        public PerKmRental PerKmRental { get; set; }

        public FuelPurchase FuelPurchase { get; set; }

        public void calculateService()
        {
            NumberOfService++;
        }

    }
}
