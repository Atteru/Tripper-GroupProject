using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.WinLogic.Forms;
using Tripper.DbLogic.LinqToSQL;
using Tripper.DbLogic;
using Tripper.WinLogic.Classes;

namespace Tripper.WinLogic.UserControls
{
    public partial class TripListRow : ListRowPureControl
    {
        NewTripCreator tripDetails;

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

        public TripListRow()
        {
            InitializeComponent();
        }

        public TripListRow(Trip trip)
        {
            SelectedTrip = trip;
            InitializeComponent();
            setTripInfo(trip);
            pictureBox.Image = imageAvatarList.Images[trip.ImageIndex];
        }

        public Button EditButton
        {
            get
            {
                return bEdit;
            }
        }
        public LinkLabel Label
        {
            get
            {
                return lTripName;
            }
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

        private void bEdit_Click(object sender, EventArgs e)
        {
            CurrentSelected.Trip = SelectedTrip;
        }

        private void lTripName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentSelected.Trip = SelectedTrip;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = TripperMessageBox.Show("Czy chcesz usunąć podróż?", "Czy napewno?");
            if (result == DialogResult.Yes)
            {
                Connection.TripperData.Trips.DeleteOnSubmit(SelectedTrip);

                try
                {
                    this.Visible = false;
                    Connection.TripperData.Transports.DeleteAllOnSubmit(Connection.TripperData.Transports.Where(t => t.Trip == SelectedTrip));
                    Connection.TripperData.Stayments.DeleteAllOnSubmit(Connection.TripperData.Stayments.Where(t => t.Trip == SelectedTrip));
                    Connection.TripperData.OtherCosts.DeleteAllOnSubmit(Connection.TripperData.OtherCosts.Where(t => t.Trip == SelectedTrip));
                    Connection.TripperData.SubmitChanges();
                    OnAfterUpdate(EventArgs.Empty);
                }
                catch (Exception exept)
                {
                    TripperMessageBox.Show(exept.ToString(), "Błąd");
                }

            }
        }
    }
}
