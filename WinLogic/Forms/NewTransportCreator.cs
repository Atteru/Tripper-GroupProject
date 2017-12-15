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
    public partial class NewTransportCreator : TripperDetailsEditPureForm
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


        protected override void changeEditable(bool value)
        {
            tLocalizationDeparture.Enabled = value;
            tLocalizationArrival.Enabled = value;
            dtpDeparture.Enabled = value;
            dtpArrival.Enabled = value;
            tTransporter.Enabled = value;
            tTransportCost.Enabled = value;
            tSeats.Enabled = value;
            tConfirmationNo.Enabled = value;
            tFlightNo.Enabled = value;
            tAdditonalInformations.Enabled = value;
            bAdd.Visible = value;
        }

        public NewTransportCreator() : base()
        {
            mode = CreatorMode.AddNew;
            InitializeComponent();
            selectedTransport = new Transport();
        }

        public NewTransportCreator(Transport row) : base()
        {
            mode = CreatorMode.Edit;
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
            dtpArrival.GetDate(selectedTransport.ArrivalTime);
            tTransporter.GetData<string>(selectedTransport.TransportOperator);
           // tAdditonalInformations.GetData<StringInfo>(selectedTransport.AdditonalInformations);
        }

        private bool saveChanges()
        {

            if (validationCheck())
            {
                selectedTransport.VehicleID = SelectedVehicle.VehicleID;
                selectedTransport.DepartureLocalization = tLocalizationDeparture.GetLocalizationFromFields();
                selectedTransport.ArrivalLocalization = tLocalizationArrival.GetLocalizationFromFields();
                selectedTransport.DepartureTime = dtpDeparture.Value();
                selectedTransport.ArrivalTime = dtpArrival.Value();
                selectedTransport.TransportOperator = tTransporter.Text;
                selectedTransport.FlightNumber = tFlightNo.Text;
                selectedTransport.Seats = tSeats.Text;
                selectedTransport.ConfirmationNumber = tConfirmationNo.Text;
                selectedTransport.Cost = tTransportCost.Value;
                if (mode == CreatorMode.AddNew)
                {
                    selectedTransport.TripID = CurrentTrip.Trip.TripID;
                    Connection.TripperData.Transports.InsertOnSubmit(selectedTransport);
                }
                return true;
            }

            return false;
        }

        private void SubmitChanges()
        {
            if (saveChanges())
            {
                DialogResult result = TripperMessageBox.Show("Czy chcesz dodać nową podróż?", "Nowa podróż");
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Connection.TripperData.SubmitChanges();
                    }
                    catch (Exception exept)
                    {
                        TripperMessageBox.Show(exept.ToString(), "Błąd");
                    }

                    if (mode == CreatorMode.AddNew)
                        this.Close();
                    else
                        this.Parent.Refresh();
                }
            }
        }

        private bool validationCheck()
        {
            bool validationResult = true;

            if (!tLocalizationDeparture.CheckValidation())
                validationResult = false;

            if (!tLocalizationArrival.CheckValidation())
                validationResult = false;

            if (!dtpArrival.CheckValidation())
                validationResult = false;

            if (!dtpDeparture.CheckValidation())
                validationResult = false;

            if (dtpArrival.Value() < dtpDeparture.Value())
                validationResult = false;

            if (!dtpArrival.IsLaterThanValidation(dtpDeparture.Value()))
                validationResult = false;

           
            return validationResult;
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

        private void bAdd_Click(object sender, EventArgs e)
        {
            SubmitChanges();
        }

    }
}
