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
            Mode = BusinessLogic.CreatorMode.AddNew;
            Status = CreatorStatus.Edit;
            InitializeComponent();
            selectedTransport = new Transport();
        }

        public NewTransportCreator(Transport row) : base()
        {
            Mode = BusinessLogic.CreatorMode.Edit;
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
                selectedTransport.Localization = Connection.TripperData.Localizations.Single(c => c.LocalizationID == tLocalizationDeparture.SelectedLocalization.LocalizationID);
                selectedTransport.Localization1 = Connection.TripperData.Localizations.Single(c => c.LocalizationID == tLocalizationArrival.SelectedLocalization.LocalizationID);
                selectedTransport.DepartureTime = dtpDeparture.Value();
                selectedTransport.ArrivalTime = dtpArrival.Value();
                selectedTransport.TransportOperator = tTransporter.Text;
                selectedTransport.FlightNumber = tFlightNo.Text;
                selectedTransport.Seats = tSeats.Text;
                selectedTransport.ConfirmationNumber = tConfirmationNo.Text;
                selectedTransport.Cost = tTransportCost.Value;
                if (Mode == BusinessLogic.CreatorMode.AddNew)
                {
                    selectedTransport.TripID = CurrentSelected.Trip.TripID;
                    Connection.TripperData.Transports.InsertOnSubmit(selectedTransport);
                }
                return true;
            }
            showErrorMesage(lError);
            return false;
        }

        private void SubmitChanges()
        {
            if (saveChanges())
            {
                confirmChanges("Czy chcesz dodać trasport?");
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
            tAdditonalInformations.Height = tTransporter.Height * 2;
        }

        private void tAdditionalInformations_Leave(object sender, EventArgs e)
        {
            tAdditonalInformations.Height = tTransporter.Height + 5;
        }

        public void ShowVehicleProperties(Vehicle vehicle)
        {
            string courseTerm = "Kierunek - ";
            string courseTermDeparture = "Wyjazd";
            string courseTermArrival = "Przyjazd";
            setSeatsLabel(vehicle);
            hideVehiclePanel();

            if(vehicle == LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.Plane))
            {
                courseTermDeparture = "Wylot";
                courseTermArrival = "Przylot";
                pInfoPlane.Visible = pInfoPlanePublic.Visible = true;
                setSeatsLabel(vehicle);
            }
            else
            {
                pInfoPlanePublic.Visible = true;
            }

            lDepartureCourse.Text = courseTerm + courseTermDeparture;
            lArrivalCourse.Text = courseTerm + courseTermArrival;

        }

       private void setSeatsLabel(Vehicle vehicle)
       {
            bool result = true;
            if (vehicle == LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.Car) || vehicle == LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.OtherVehicle))
                result = false;
            tSeats.Visible = lSeats.Visible = result;

       }
      

        private void bAdd_Click(object sender, EventArgs e)
        {
            SubmitChanges();
        }

        public override void GoBackToParent()
        {
            this.Close();
        }

        private void showErrorMesage(Label label)
        {
            var t = new Timer();
            label.Visible = true;
            t.Interval = 5000;
            t.Tick += (s, e) =>
            {
                label.Hide();
                t.Stop();
            };
            t.Start();
        }
    }
}
