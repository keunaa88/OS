using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            txtManufacturer.Text = "Ford";
            txtModel.Text = "T812";
            txtYear.Text = "2014";
            txtNo.Text = "1 ABD 760";

        }

        public float totalKilometres = 0;
        public int totalServices = 0;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declaring variables
            float journeyKilometres = 0;
            int YearOfManufacture = 0; 
            float fuelEconomy = 0, fuelPurchaseCost = 0;

            //Declaring variables to check if service is needed
            double dividedOldTotal, dividedNewTotal;

            //Declaring new model of vehicle 
            //Set the data into the model
            Vehicle vehicle = new Vehicle();
            int.TryParse(txtYear.Text, out YearOfManufacture);
            vehicle.Manufacturer      = txtManufacturer.Text;
            vehicle.Model             = txtModel.Text;
            vehicle.YearOfManufacture = YearOfManufacture;
            vehicle.RegistrationNo    = txtNo.Text;

           
            //Converting string to float and then storing into 'journeyKilometres'
            float.TryParse(txtKilometres.Text, out journeyKilometres);

            //Storing quotient of totalkilometer diveded by 100 to check it needs service
            dividedOldTotal = Math.Floor(totalKilometres / 100);
            
            //Calculating total travelled kilometres
            totalKilometres += journeyKilometres;

            //Updating total services
            //if jorney is more than 100km, total service should be needed
            //if not, check the total kilometres is 
            if(journeyKilometres >= 100)
            {
                totalServices += 1;
            }
            else
            {
                //Storing quotient of totalkilometer diveded by 100 to check it needs service
                dividedNewTotal = Math.Floor(totalKilometres / 100);

                //if the quotient is changed, add 1 to the totalServices
                if (dividedOldTotal != dividedNewTotal)
                {
                    totalServices += 1;
                }
            }

            //Declaring new model of journey 
            //Set the data into the model
            Journey journey = new Journey();
            journey.totalKilometres = totalKilometres;
            journey.totalService = totalServices;

            //Declaring new model of journey 
            FuelPurchase fuelPurchase = new FuelPurchase();
            float.TryParse(txtFuelPurchase.Text, out fuelPurchaseCost);

            //calculate fuelEconomy and value is changed to have one decimal place.
            fuelEconomy = (fuelPurchaseCost * 100) / journeyKilometres;
            fuelPurchase.FuelEconomy = fuelEconomy.ToString("####0.0") + "L/100km";

            Vehicle Vehicle = new Vehicle(vehicle.Manufacturer, vehicle.Model, vehicle.RegistrationNo, vehicle.YearOfManufacture, journey, fuelPurchase);

            //Calling the PrintToScreen method with vehicle parameters.
            PrintToScreen(Vehicle);
        }

        private void PrintToScreen(Vehicle vehicle)
        {
            string output;

            output = "Manufacturer: " + vehicle.Manufacturer + "\r" +
                "Model: " + vehicle.Model + "\r" +
                "Make Year: " + vehicle.YearOfManufacture + "\r" +
                "Registration No: " + vehicle.RegistrationNo + "\r" +
                "Total Kilometres Travelled: " + vehicle.Journey.totalKilometres + "\r" +
                "Total Services: " + vehicle.Journey.totalService + "\r" +
                "Fuel Economy: " + vehicle.FuelPurchase.FuelEconomy;


            lblOutput.Text = output;

        }

    }
}
