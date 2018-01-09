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
using Tripper.WinLogic.Classes;

namespace Tripper.WinLogic.Forms
{
    public partial class TripContainerView : TripperContainerPureForm
    {
        private TripperContainerPureForm _detailsView;
        public TripperContainerPureForm DetailsView
        {
            get
            {
                return _detailsView;
            }
            set
            {
                _detailsView = value;
                _detailsView.AfterUpdate += _detailsView_AfterUpdate;
            }
        }

        private void _detailsView_AfterUpdate(object sender, EventArgs e)
        {
            setTripInfo(SelectedTrip);
        }

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
            SplashForm.ShowSplashScreen();
            DetailsView = new TransportDetailsView(SelectedTrip);
            SplashForm.CloseForm();
            DetailsView.DockForm(pCurrentView);

        }

        public void ShowStaymentDetails()
        {
            SplashForm.ShowSplashScreen();
            DetailsView = new StaymentDetailsView(SelectedTrip);
            SplashForm.CloseForm();
            DetailsView.DockForm(pCurrentView);

        }

        public void ShowOtherCoststDetails()
        {
            SplashForm.ShowSplashScreen();
            DetailsView = new OtherCostsDetailsView(SelectedTrip);
            SplashForm.CloseForm();
            DetailsView.DockForm(pCurrentView);
        }

        public void ShowOrganizer()
        {
            SplashForm.ShowSplashScreen();
            DetailsView = new TripSummaryList(SelectedTrip);
            SplashForm.CloseForm();
            DetailsView.DockForm(pCurrentView);
        }

        private void setTripInfo(Trip trip)
        {
            lTripName.Text = trip.Name;
            pictureBox.Image = imageAvatarList.Images[trip.ImageIndex];

            if (Connection.TripperData.Transports.Any(t => t.Trip == trip))
            {
                setInfoByTransport(trip);
            }
            else if (Connection.TripperData.Stayments.Any(t => t.Trip == trip))
            {
                setInfoByStayment(trip);
            }
            else
            {
                lDestination.Text = "Nie ustalono kierunku podrózy";
                lStartDate.Text = "Nie ustalono terminu";
                lDaysCount.Text = string.Empty;
            }

            lTotal.Text = "Łączny koszt: " + setTotalInfo(SelectedTrip) + " PLN"; 
        }

        private void setInfoByTransport(Trip trip)
        {

                Transport firstTransport = Connection.TripperData.Transports.Where(transport => transport.Trip.Equals(trip)).OrderBy(transport => transport.DepartureTime).First();
                Localization city = Connection.TripperData.Localizations.Single(loc => loc.LocalizationID.Equals(firstTransport.ArrivalLocalization));
                lDestination.Text = Connection.TripperData.Countries.Single(country => country.CountryID.Equals(city.CountryID)).Name.ToString() + ", " + city.City;
                if (firstTransport.DepartureTime != null)
                {
                    DateTime date = DateTime.Parse(firstTransport.DepartureTime.ToString());

                    lStartDate.Text = date.ToShortDateString();
                }

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

        private void setInfoByStayment(Trip trip)
        {
                Stayment firstStayment = Connection.TripperData.Stayments.Where(stayment => stayment.Trip.Equals(trip)).OrderBy(stayment => stayment.DateFrom).First();
                Localization city = Connection.TripperData.Localizations.Single(loc => loc.LocalizationID.Equals(firstStayment.LocalizationID));
                lDestination.Text = Connection.TripperData.Countries.Single(country => country.CountryID.Equals(city.CountryID)).Name.ToString() + ", " + city.City;
                if (firstStayment.DateFrom != null)
                {
                    DateTime date = DateTime.Parse(firstStayment.DateFrom.ToString());

                    lStartDate.Text = date.ToShortDateString();
                }

                if (firstStayment.DateFrom > DateTime.Today)
                {
                    TimeSpan tempDays = DateTime.Parse(firstStayment.DateFrom.ToString()).Date - DateTime.Today.Date;
                    int daysTo = int.Parse(tempDays.Days.ToString());

                    string day = daysTo > 1 ? "dni" : "dzień";
                    lDaysCount.Text = "Podróż rozpocznie się za " + daysTo + " " + day;
                }
                else
                    lDaysCount.Text = "Podróż odbyła się";
        }


        private decimal setTotalInfo(Trip selectedTirp)
        {
            decimal total = 0;
            if(Connection.TripperData.Transports.Any(r => r.Trip == selectedTirp))
                total += Connection.TripperData.Transports.Where(r => r.Trip == selectedTirp).Sum(r => r.Cost);
            if (Connection.TripperData.Stayments.Any(r => r.Trip == selectedTirp))
                total += Connection.TripperData.Stayments.Where(r => r.Trip == selectedTirp).Sum(r => r.Cost);
            if (Connection.TripperData.OtherCosts.Any(r => r.Trip == selectedTirp))
                total += Connection.TripperData.OtherCosts.Where(r => r.Trip == selectedTirp).Sum(r => r.Cost);

            return total;
        }

        public override void GoBackToParent()
        {
            CloseDisplayedForms();
        }


        private void lTripName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewTripForm tripForm = new AddNewTripForm(SelectedTrip);
            tripForm.FormClosed += TripForm_FormClosed;
            tripForm.ShowDialog();
        }

        private void TripForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            setTripInfo(SelectedTrip);

        }
    }
}
