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

        List<Trip> tripList;

        public TripMainList()
        {
            InitializeComponent();

            tcTripView.Appearance = TabAppearance.FlatButtons;
            tcTripView.ItemSize = new Size(0, 1);
            tcTripView.SizeMode = TabSizeMode.Fixed;
            loadTransportList();
        }

        private void loadTransportList()
        {
            tripList = Connection.TripperData.Trips.Where(trip => trip.TravelerID == 1).OrderBy(trip => trip.TripID).ToList();

            foreach (Trip row in tripList)
            {
                TripListRow tripRow = new TripListRow(row);
                pTripTable.Controls.Add(tripRow);
                tripRow.Dock = DockStyle.Top;
                tripRow.EditButton.Click += bEdit_Click;
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
