using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;
using Tripper.WinLogic.UserControls;
using Tripper.WinLogic.Classes;
using System.Globalization;
using Tripper.BusinessLogic;

namespace Tripper.WinLogic.Forms
{
    public partial class NewTransportCreator : Form
    {
        Transport selectedTransport;
        List<Vehicle> vehicleList = Connection.TripperData.Vehicles.ToList();

        public NewTransportCreator()
        {
            InitializeComponent();
        }




        public NewTransportCreator(Transport row)
        {
            InitializeComponent();


            selectedTransport = Connection.TripperData.Transports.Single(transport => transport.Equals(row));

            tLocalizationDeparture.GetLocalization(selectedTransport.DepartureLocalization);
            tLocalizationArrival.GetLocalization(selectedTransport.ArrivalLocalization);
            tFlightNo.GetData<string>(selectedTransport.FlightNumber);
            tSeats.GetData<string>(selectedTransport.Seats);
            tConfirmationNo.GetData<string>(selectedTransport.ConfirmationNumber);
            tTransportCost.GetData(selectedTransport.Cost);
            dtpDeparture.GetDate(selectedTransport.DepartureTime);
            dtpDeparture.GetDate(selectedTransport.DepartureTime);
            dtpArrival.GetDate(selectedTransport.ArrivalTime);
            tTransporter.GetData<string>(selectedTransport.TransportOperator);
        }

        private void tAdditionalInformations_Enter(object sender, EventArgs e)
        {
            tAdditonalInformations.Height = 26*3 - 10;
        }

        private void tAdditionalInformations_Leave(object sender, EventArgs e)
        {
            tAdditonalInformations.Height = 26;
        }

        public void SelectVehicle(Vehicle vehicle)
        {

            if(vehicle == LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.Car))
            {

            }
            
        
            
    

        }

        private void tSeats_Load(object sender, EventArgs e)
        {

        }

        private void tFlightNo_Load(object sender, EventArgs e)
        {

        }

        private void NewTransportCreator_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUC5_Load(object sender, EventArgs e)
        {

        }
    }
}
