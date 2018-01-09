using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;
using Tripper.WinLogic.Classes;

namespace Tripper.WinLogic.Forms
{
    public partial class MainForm : TripperContainerPureForm
    {

        bool readyToClose = false;
        AddNewTripForm addNewTrip;

        private Traveler _selectedTraveler;
        public Traveler SelectedTraveler
        {
            get
            {
                return _selectedTraveler;
            }
            private set
            {
                _selectedTraveler = value;
            }
        }

        public int UserID
        {
            get;
            private set;
        }

        TripperContainerPureForm currentContainer;

        public MainForm(Traveler traveler)
        {
            InitializeComponent();
            SelectedTraveler = traveler;
            this.WindowState = FormWindowState.Maximized;
            OpenTripMainList();

            tcFilter.Appearance = TabAppearance.FlatButtons;
            tcFilter.ItemSize = new Size(0, 1);
            tcFilter.SizeMode = TabSizeMode.Fixed;
        }


        public void OpenTripMainList()
        {
            if (!(currentContainer is TripMainList))
            {
                if (currentContainer != null)
                    currentContainer.Close();

                currentContainer = new TripMainList(SelectedTraveler);
                ((TripMainList)currentContainer).DockForm(pCenter);
            }
        }

        public void OpenTripDetalis()
        {
            if(!(currentContainer is TripContainerView) && currentContainer != null)
            {
                if (currentContainer != null)
                    currentContainer.Close();

                currentContainer = new TripContainerView(CurrentSelected.Trip);
                ((TripContainerView)currentContainer).DockForm(pCenter);
                tcFilter.SelectTab(tripDetailsFilterPage);
                currentContainer.FormClosed += currentContainer_FormClosed;
            }
        }

        private void currentContainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            currentContainer.FormClosed -= currentContainer_FormClosed;
            currentContainer = new TripMainList(SelectedTraveler);
            ((TripMainList)currentContainer).DockForm(pCenter);
        }

        private void bTransport_Click(object sender, EventArgs e)
        {
            if(currentContainer.CanBeClosed())
            {
                OpenTripDetalis();
                ((TripContainerView)currentContainer).ShowTransportDetails();
            }
        }

        private void bStayment_Click(object sender, EventArgs e)
        {
            if (currentContainer.CanBeClosed())
            {
                OpenTripDetalis();
                ((TripContainerView)currentContainer).ShowStaymentDetails();
            }

        }

        private void bOtherCosts_Click(object sender, EventArgs e)
        {
            if (currentContainer.CanBeClosed())
            {
                OpenTripDetalis();
                ((TripContainerView)currentContainer).ShowOtherCoststDetails();
            }
        }

        private void bOrganizer_Click(object sender, EventArgs e)
        {
            if (currentContainer.CanBeClosed())
            {
                OpenTripDetalis();
                ((TripContainerView)currentContainer).ShowOrganizer();
            }
        }


        private void bMyAccount_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(SelectedTraveler);
            loginForm.ShowDialog();
        }

        private void bBackToTripList_Click(object sender, EventArgs e)
        {
            if (currentContainer.CanBeClosed())
            {
                CloseDisplayedForms();
            }
        }

        private void pCenter_ControlAdded(object sender, ControlEventArgs e)
        {
            if(e.Control is TripMainList)
            {
                 tcFilter.SelectTab(mainFilterPage);
            }
        }

        private void bAddNewTrip_Click(object sender, EventArgs e)
        {
            addNewTrip = new AddNewTripForm(SelectedTraveler);
            addNewTrip.AfterAdd += AddNewTrip_AfterAdd;
            addNewTrip.ShowDialog();
       
        }

        private void AddNewTrip_AfterAdd(object sender, EventArgs e)
        {
            if (currentContainer.CanBeClosed())
            {
                OpenTripDetalis();
                ((TripContainerView)currentContainer).ShowTransportDetails();
            }
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            CurrentSelected.Trip = null;
            CurrentSelected.Traveler = null;
            readyToClose = true;
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!readyToClose)
            {
                DialogResult result = TripperMessageBox.Show("Czy czcesz zamknąć program?", "Czy napewno?");
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
