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
        public int UserID
        {
            get;
            private set;
        }

        TripDetailsView tripDetailsView;

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

           DisplayedForm = new TripMainList();
           if (DisplayedForm is TripMainList)
              ((TripMainList)DisplayedForm).DockForm(pCenter);
            
        }

        public void OpenTripDetalis()
        {
            tripDetailsView = new TripDetailsView(CurrentTrip.Trip);
            DisplayedForm = tripDetailsView;
            ((TripDetailsView)DisplayedForm).DockForm(pCenter);
            tcFilter.SelectTab(tripDetailsFilterPage);
        } 

        private void bTransport_Click(object sender, EventArgs e)
        {
            if(tripDetailsView == null)
                OpenTripDetalis();
            ((TripDetailsView)DisplayedForm).ShowTransportDetails();
        }

        private void bStayment_Click(object sender, EventArgs e)
        {
            if (tripDetailsView == null)
                OpenTripDetalis();
           ((TripDetailsView)DisplayedForm).ShowStaymentDetails();
        }

        private void bTripMainList_Click(object sender, EventArgs e)
        {
            OpenTripMainList();
        }

        private void bBackToTripList_Click(object sender, EventArgs e)
        {
            OpenTripMainList();
        }

        private void pCenter_ControlAdded(object sender, ControlEventArgs e)
        {
            if(e.Control is TripMainList)
            {
                 tcFilter.SelectTab(mainFilterPage);
            }
        }
    }
}
