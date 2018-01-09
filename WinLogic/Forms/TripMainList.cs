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
using Tripper.WinLogic.UserControls;
using Tripper.WinLogic.Classes;

namespace Tripper.WinLogic.Forms
{
    public partial class TripMainList : TripperContainerPureForm
    {
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

        List<Trip> tripList;

        public TripMainList(Traveler traveler)
        {
            InitializeComponent();
            SelectedTraveler = traveler;
            tcTripView.Appearance = TabAppearance.FlatButtons;
            tcTripView.ItemSize = new Size(0, 1);
            tcTripView.SizeMode = TabSizeMode.Fixed;
            loadTransportList();
        }

        private void loadTransportList()
        {
            tripList = Connection.TripperData.Trips.Where(trip => trip.Traveler == SelectedTraveler).OrderBy(trip => trip.TripID).ToList();

            if(tripList.Count == 0)
            {
                lNoTrip.Visible = true;
            }

            foreach (Trip row in tripList)
            {
                TripListRow tripRow = new TripListRow(row);
                pTripTable.Controls.Add(tripRow);
                tripRow.Dock = DockStyle.Top;
                tripRow.EditButton.Click += bEdit_Click;
                tripRow.Label.LinkClicked += bEdit_Click;
            }
        }


        private void bEdit_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm.OpenTripDetalis();
            this.Close(); 
        }

    }
}
