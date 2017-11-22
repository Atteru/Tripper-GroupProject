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
using Tripper.Enums;


namespace Tripper.WinLogic.Forms
{
    public partial class NewTransportCreator : Form
    {
        Transport selectedTransport;

        public NewTransportCreator()
        {
            int transportID = 1;
            selectedTransport = Connection.TripperData.Transports.Single(transport => transport.TransportID.Equals(transportID));
            InitializeComponent();
            tLocalizationDeparture.GetLocalization(selectedTransport.DepartureLocalization);
            tLocalizationArrival.GetLocalization(selectedTransport.ArrivalLocalization);
            tFlightNo.GetData<string>(selectedTransport.FlightNumber);
            tSeats.GetData<string>(selectedTransport.Seats);
            tConfirmationNo.GetData<string>(selectedTransport.ConfirmationNumber);
            tTransportCost.GetData(selectedTransport.Cost);
            dtpDeparture.GetDate(selectedTransport.DepartureTime);
            dtpDeparture.GetDate(selectedTransport.DepartureTime);
            dtpArrival.GetDate(selectedTransport.ArrivalTime);
        }

        private void tAdditionalInformations_Enter(object sender, EventArgs e)
        {
            tAdditonalInformations.Height = 150;
        }

        private void tAdditionalInformations_Leave(object sender, EventArgs e)
        {
            tAdditonalInformations.Height = 26;
        }
    }
}
