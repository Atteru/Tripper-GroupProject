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
        TripDetailsView tripDetails;
        TripMainList tripList;


        public int UserID
        {
            get;
            private set;
        }


        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            OpenTripMainList();

            tcFilter.Appearance = TabAppearance.FlatButtons;
            tcFilter.ItemSize = new Size(0, 1);
            tcFilter.SizeMode = TabSizeMode.Fixed;
        }


        public void OpenTripMainList()
        {
             tripList = new TripMainList();
             tripList.DockForm(pCenter);
             tcFilter.SelectTab(mainFilterPage);
             DisplayedForm = tripList;
        }


        public void OpenTripDetalis()
        {
            tripDetails = new TripDetailsView(CurrentTrip.Trip);
            tripDetails.DockForm(pCenter);
            tcFilter.SelectTab(tripDetailsFilterPage);
            DisplayedForm = tripDetails;

        } 

        private void bTransport_Click(object sender, EventArgs e)
        {
            OpenTripDetalis();
            tripDetails.ShowTransportDetails();
        }

        private void bStayment_Click(object sender, EventArgs e)
        {
            OpenTripDetalis();
            tripDetails.ShowStaymentDetails();
        }

        private void bTripMainList_Click(object sender, EventArgs e)
        {
            OpenTripMainList();
        }

        private void bBackToTripList_Click(object sender, EventArgs e)
        {
            //if (tripList != null)
              //  tripList.Close();
            OpenTripMainList();
        }


    }
}
