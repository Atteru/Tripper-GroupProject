using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.DbLogic.LinqToSQL;
using Tripper.DbLogic;

namespace Tripper.WinLogic.Forms
{
    public partial class TripContainerView : TripperContainerPureForm
    {
        TripperContainerPureForm detailsView;


        private Trip _selectedTrip;
        public Trip SelectedTrip
        {
            get
            {
                return _selectedTrip;
            }
            set
            {
                _selectedTrip = value;
            }
        }


        public TripContainerView(Trip selectedTrip)
        {
            InitializeComponent();
            SelectedTrip = selectedTrip;
            ShowTransportDetails();
            setTripInfo(SelectedTrip);
        }

        public void ShowTransportDetails()
        {
            detailsView = new TransportDetailsView(SelectedTrip);
            detailsView.DockForm(pCurrentView);
        }

        public void ShowStaymentDetails()
        {
            detailsView = new StaymentDetailsView(SelectedTrip);
            detailsView.DockForm(pCurrentView);
        }

        public void ShowOtherCoststDetails()
        {
            detailsView = new OtherCostsDetailsView(SelectedTrip);
            detailsView.DockForm(pCurrentView);
        }

        private void setTripInfo(Trip trip)
        {
            lTripName.Text = trip.Name;
            Transport firstTransport = Connection.TripperData.Transports.Where(transport => transport.Trip.Equals(trip)).OrderBy(transport => transport.DepartureTime).First();
            Localization city = Connection.TripperData.Localizations.Single(loc => loc.LocalizationID.Equals(firstTransport.ArrivalLocalization));
            lDestination.Text = Connection.TripperData.Countries.Single(country => country.CountryID.Equals(city.CountryID)).Name.ToString() + ", " + city.City;
            if (firstTransport.DepartureTime != null)
            {
                DateTime date = DateTime.Parse(firstTransport.DepartureTime.ToString());

                lStartDate.Text = date.ToShortDateString();
            }
            else
                lStartDate.Text = "Nie ustalono terminu";

            if (firstTransport.DepartureTime > DateTime.Today)
            {
                TimeSpan tempDays = DateTime.Parse(firstTransport.DepartureTime.ToString()).Date - DateTime.Today.Date;
                int daysTo = int.Parse(tempDays.Days.ToString());

                string day = daysTo > 1 ? "dni" : "dzień";
                lDaysCount.Text = "Podróż rozpocznie się za " + daysTo + " " + day;
            }
            else
                lDaysCount.Text = "Podróż odbyła się";
        }

        public override void GoBackToParent()
        {
            CloseDisplayedForms();
        }

        private void pTripView_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
