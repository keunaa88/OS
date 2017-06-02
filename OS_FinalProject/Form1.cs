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


        public float totalFuelPurchaseLitre = 0, totalFuelPurchaseCost = 0;
        public int totalServices = 0, vehicleId = 1;
        float journeyKilometres = 0;
        float reqiredServiceKilometres = 0;


        List<Vehicle> listVehicle = new List<Vehicle>();
        List<Vehicle> listJourney = new List<Vehicle>();

        public Form1()
        {
            InitializeComponent();
            initView();

            txtManufacturer.Text = "Ford";
            txtModel.Text = "T812";
            txtYear.Text = "2014";
            txtNo.Text = "1 ABD 760";
        }

        public void initView()
        {
            //Vehicle View
            listViewVehicle.View = View.Details;
            //Set Columns
            listViewVehicle.Columns.Add("Id");
            listViewVehicle.Columns.Add("Manufacturer");
            listViewVehicle.Columns.Add("Model");
            listViewVehicle.Columns.Add("Make Year");
            listViewVehicle.Columns.Add("Registration No");
            listViewVehicle.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Journey View 
            listViewJourney.View = View.Details;
            //Set Columns
            listViewJourney.Columns.Add("Id");
            listViewJourney.Columns.Add("Manufacturer");
            listViewJourney.Columns.Add("Model");
            listViewJourney.Columns.Add("Make Year");
            listViewJourney.Columns.Add("Registration No");
            listViewJourney.Columns.Add("Total Kilometres Travelled");
            listViewJourney.Columns.Add("Total services");
            listViewJourney.Columns.Add("Revenue recorded");
            listViewJourney.Columns.Add("Kilometres since the last service");
            listViewJourney.Columns.Add("Fuel economy");
            listViewJourney.Columns.Add("Requires a service");
            listViewJourney.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            int YearOfManufacture = 0;

            //Declaring new model of vehicle 
            //Set the data into the model
            Vehicle vehicle = new Vehicle();
            int.TryParse(txtYear.Text, out YearOfManufacture);
            vehicle.Manufacturer      = txtManufacturer.Text;
            vehicle.Model             = txtModel.Text;
            vehicle.YearOfManufacture = YearOfManufacture;
            vehicle.RegistrationNo    = txtNo.Text;
            vehicle.Id                = vehicleId;

            Vehicle Vehicle = new Vehicle(vehicle.Id, vehicle.Manufacturer, vehicle.Model, vehicle.RegistrationNo, vehicle.YearOfManufacture, new Journey(), new FuelPurchase(), new PerDayRental(), new PerKmRental(), vehicle.NumberOfService);
            listVehicle.Add(Vehicle);

            //Calling the PrintToScreen method with vehicle parameters.
            VehiclePrintToScreen(listVehicle);
            vehicleId++;
        }

        private void VehiclePrintToScreen(List<Vehicle> listVehicle)
        {
            listViewVehicle.Items.Clear();
            //Fill Rows
            ListViewItem lvi;
            if (listVehicle != null && listVehicle.Count > 0)
            {
                foreach(Vehicle vehicle in listVehicle)
                {
                    //invoiceList.Items.Add("ID: " + c.customerNo + ", Name: " + c.invoiceNo);
                    lvi = new ListViewItem(new string[] { vehicle.Id.ToString(), vehicle.Manufacturer, vehicle.Model, vehicle.YearOfManufacture.ToString(), vehicle.RegistrationNo });
                    listViewVehicle.Items.Add(lvi);
                }
            }
            listViewVehicle.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

       

        private void btnSaveJourney_Click(object sender, EventArgs e)
        {
           
            int vehicleId;
           
            //Storing Id which gets from the TextBox.
            Int32.TryParse(txtVehicleId.Text, out vehicleId);
            
            Vehicle vehicle  = new Vehicle();
            foreach (Vehicle v in listVehicle)
            {
                if (vehicleId == v.Id)
                {
                    vehicle = v;
                }
            }
            
            //if user input invalid value or nonexist Id, message box is popped up.    
            if (vehicleId == 0 || vehicle.Id == 0)
            {
                MessageBox.Show("Please input valid Id.");

            }
            else
            {
                if (vehicle.Journey.requireService && !checkBox1.Checked)
                {
                    MessageBox.Show("Please get service to keep using this vehicle.");
                }
                else
                {
                    if (vehicle.Journey.requireService && checkBox1.Checked)
                    {
                        vehicle.calculateService();
                        checkBox1.Checked = false;
                    }
                    /* Calculate Service Method */
                    CalculateService(vehicle);

                    /* Calculate Revenue */
                    CalculateRevenue(vehicle);

                    /* Calculate FuelPurchase */
                    CalculateFuelPurchase(vehicle);

                    Vehicle Vehicle = new Vehicle(vehicle.Id, vehicle.Manufacturer, vehicle.Model, vehicle.RegistrationNo, vehicle.YearOfManufacture, vehicle.Journey, vehicle.FuelPurchase, vehicle.PerDayRental, vehicle.PerKmRental, vehicle.NumberOfService);
                    listJourney.Add(Vehicle);

                    //Calling the PrintToScreen method with vehicle parameters.
                    JourneyPrintToScreen(listJourney);
                }
            }

        }

        public void CalculateService(Vehicle v)
        {
            //Declaring variables
           
            float.TryParse(txtKilometres.Text, out journeyKilometres);

            //Declaring variables to check if service is needed
            double dividedOldTotal, dividedNewTotal;
           
            Journey journey = new Journey();
            //if it's the first journey
            //Create new journey model

            journey.vehicleId = vehicleId;
            
         
            //Storing quotient of totalkilometer diveded by 100 to check it needs service
            dividedOldTotal = Math.Floor(v.Journey.totalKilometres / 100);
            //Storing quotient of totalkilometer diveded by 100 to check it needs service
            dividedNewTotal = Math.Floor((v.Journey.totalKilometres+journeyKilometres) / 100);
            if (dividedOldTotal != dividedNewTotal)
            {
                reqiredServiceKilometres = v.Journey.totalKilometres + journeyKilometres;
                journey.requireService = true;
            }

            //update totalKolometres
            journey.totalKilometres = v.Journey.totalKilometres + journeyKilometres;

            if (v.NumberOfService > 0)
            {
                journey.kilometresAfterService = journey.totalKilometres - reqiredServiceKilometres;
            }

            v.Journey = journey;



        }

        public void CalculateRevenue(Vehicle v)
        {
            PerDayRental perDayRental = new PerDayRental();
            PerKmRental  perKmRental = new PerKmRental();
            int days = 0;

            if (radiobykilo.Checked)
            {
                perKmRental.revenue = v.Journey.totalKilometres;
                v.PerKmRental = perKmRental;
            }
            else
            {
                int.TryParse(txtDays.Text, out days);
                perDayRental.day = v.PerDayRental.day + days;
                perDayRental.revenue = perDayRental.Revenue;

                v.PerDayRental = perDayRental;
            }

        }

        public void CalculateFuelPurchase(Vehicle v)
        {
            /*
            *  Fuel Economy : (total litre * 100) / total journey
            *  Fuel Average : (total cost  * 100) / total journey
            */

            float fuelEconomy = 0, fuelPurchaseLitre = 0;

            ////Declaring new model of FuelPurchase 
            FuelPurchase fuelPurchase = new FuelPurchase();
            float.TryParse(txtFuelPurchase.Text, out fuelPurchaseLitre);
            fuelPurchase.FuelPurchaseLitre = v.FuelPurchase.FuelPurchaseLitre + fuelPurchaseLitre;
            
            //calculate fuelEconomy and value is changed to have one decimal place.
            fuelEconomy = (fuelPurchase.FuelPurchaseLitre * 100) / v.Journey.totalKilometres;
            fuelPurchase.FuelEconomy = fuelEconomy.ToString("####0.0") + "L/100km";


            v.FuelPurchase = fuelPurchase;

           // float.TryParse(txtFuelCost.Text, out fuelPurchaseCost);
           // totalFuelPurchaseCost += fuelPurchaseCost;
            //fuelPurchase.FuelCostAverage = "$" + ((totalFuelPurchaseCost * 100) / totalKilometres).ToString("####0.00") + "/100km";

        }


        private void JourneyPrintToScreen(List<Vehicle> listJourney)
        {
            listViewJourney.Items.Clear();
            //Fill Rows
            ListViewItem lvi;
            string requireService = "No";
            float revenue;
            
            if (listJourney != null && listJourney.Count > 0)
            {
                foreach (Vehicle vehicle in listJourney)
                {
                    revenue = vehicle.PerKmRental.revenue + vehicle.PerDayRental.revenue;

                    requireService = vehicle.Journey.requireService ? "Yes" : "No";
                    //invoiceList.Items.Add("ID: " + c.customerNo + ", Name: " + c.invoiceNo);
                    lvi = new ListViewItem(new string[] { vehicle.Id.ToString(), vehicle.Manufacturer, vehicle.Model, vehicle.YearOfManufacture.ToString(), vehicle.RegistrationNo,
                                                          vehicle.Journey.totalKilometres.ToString(), vehicle.NumberOfService.ToString(), "$"+revenue, vehicle.Journey.kilometresAfterService.ToString(), vehicle.FuelPurchase.FuelEconomy, requireService });
                    listViewJourney.Items.Add(lvi);
                }
            }
            listViewJourney.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

    }
}
