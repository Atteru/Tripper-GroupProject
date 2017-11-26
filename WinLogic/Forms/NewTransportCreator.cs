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

        private Vehicle _selectedVehicle;
        public Vehicle SelectedVehicle
        {
            get
            {
                return _selectedVehicle;
            }
            set
            {
                _selectedVehicle = value;
                ShowVehicleProperties(_selectedVehicle);

            }
        }

        public NewTransportCreator()
        {
            InitializeComponent();
            selectedTransport = new Transport();
        }

        public NewTransportCreator(Transport row)
        {
            InitializeComponent();

            selectedTransport = Connection.TripperData.Transports.Single(transport => transport.Equals(row));
            SelectedVehicle = selectedTransport.Vehicle;
            tLocalizationDeparture.FillLocalizationFields(selectedTransport.DepartureLocalization);
            tLocalizationArrival.FillLocalizationFields(selectedTransport.ArrivalLocalization);
            tFlightNo.GetData<string>(selectedTransport.FlightNumber);
            tSeats.GetData<string>(selectedTransport.Seats);
            tConfirmationNo.GetData<string>(selectedTransport.ConfirmationNumber);
            tTransportCost.GetData(selectedTransport.Cost);
            dtpDeparture.GetDate(selectedTransport.DepartureTime);
            dtpDeparture.GetDate(selectedTransport.DepartureTime);
            dtpArrival.GetDate(selectedTransport.ArrivalTime);
            tTransporter.GetData<string>(selectedTransport.TransportOperator);
        }

        private void saveChanges()
        {
            if(validationCheck())
            {
                selectedTransport.Vehicle = SelectedVehicle;
                AddIfChanged(selectedTransport.DepartureLocalization, tLocalizationDeparture.GetLocalizationFromFields());
                AddIfChanged(selectedTransport.ArrivalLocalization, tLocalizationArrival.GetLocalizationFromFields());
                AddIfChanged(selectedTransport.DepartureTime, dtpDeparture.Value());
                AddIfChanged(selectedTransport.ArrivalTime, dtpArrival.Value());
                AddIfChanged(selectedTransport.FlightNumber, tFlightNo.Text);
                AddIfChanged(selectedTransport.Seats, tSeats.Text);
                AddIfChanged(selectedTransport.ConfirmationNumber, tConfirmationNo);
                AddIfChanged(selectedTransport.Cost, tTransportCost.Value);
            }
        }

        private bool validationCheck()
        {
            if (ValidateCantBeNull(tLocalizationDeparture.GetLocalizationFromFields()))
                return false;

            if (ValidateCantBeNull(tLocalizationArrival.GetLocalizationFromFields()))
                return false;

            if (ValidateCantBeNull(dtpDeparture.Value()))
                return false;

            if (ValidateCantBeNull(dtpArrival.Value()))
                return false;

            return true;

        }


        private bool ValidateCantBeNull(object source)
        {
            if (source is string)
            {
                if (source as string != string.Empty)
                    return true;

                return false;
            }
            else
            {
                if (source != null)
                    return true;

                return false;
            }
        }

        private bool ValidateMustBeUnique()
        {
            return false;
        }


        private void AddIfChanged(object target, object source)
        {
            if (target != source)
                target = source;
        }


        public void ShowPublicProperties()
        {
            pInfoPlanePublic.Visible = true;
        }

        public void ShowPlaneProperties()
        {
            pInfoPlane.Visible = pInfoPlanePublic.Visible = true;
        }

        private void hideVehiclePanel()
        {
            pInfoPlane.Visible = pInfoPlanePublic.Visible = false;
        }

        private void tAdditionalInformations_Enter(object sender, EventArgs e)
        {
            tAdditonalInformations.Height = 26*3 - 10;
        }

        private void tAdditionalInformations_Leave(object sender, EventArgs e)
        {
            tAdditonalInformations.Height = 26;
        }

        public void ShowVehicleProperties(Vehicle vehicle)
        {
            hideVehiclePanel();
            if(vehicle == LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.Plane))
            {
                pInfoPlane.Visible = pInfoPlanePublic.Visible = true;
            }
            else if(vehicle == LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.Public))
            {
                pInfoPlanePublic.Visible = true;
            }     
        }


    }
}
