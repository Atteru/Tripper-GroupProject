using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tripper.DbLogic.LinqToSQL;
using Tripper.DbLogic;
using Tripper.WinLogic.Classes;



namespace Tripper.WinLogic.Forms
{
    public partial class NewTripCreatorForm : Form
    {
       
        NewTrip tripCreator = new NewTrip();
        NewTransportCreator transportCreator;

        List<String> vehicles = new List<String>();
        
        

        public NewTripCreatorForm()
        {
            InitializeComponent();
            vehicles.Add("Samolot");
            vehicles.Add("Samochód");
            vehicles.Add("Pociąg");
            vehicles.Add("Bus");

        
        }

      
        private void bAddVehicle_Click(object sender, EventArgs e)
        {

           /* if(sender == bAddVehiclePlane)
            {
                transportCreator = new NewTransportCreator(Vehicle.Samolot);
            }
            else if (sender == bAddVehicleCar)
            {
                transportCreator = new NewTransportCreator(Vehicle.Samochód);
            }
            else if (sender == bAddVehicleTrain)
            {
                transportCreator = new NewTransportCreator(Vehicle.Pociąg);
            }
            else
            {
                transportCreator = new NewTransportCreator(Vehicle.Bus);
            }

            transportCreator.ShowDialog(); */

        }

        private void bHotel_Click(object sender, EventArgs e)
        {
            NewHotelCreator hotelCreator = new NewHotelCreator();
            hotelCreator.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewOtherCostsList otherCostsList = new NewOtherCostsList();
            otherCostsList.ShowDialog();
           
        }
    }
}
