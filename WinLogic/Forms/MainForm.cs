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

   
        TripperContainerPureForm _currentContainer;
        TripperContainerPureForm CurrentContainer
        {
            get
            {
                return _currentContainer;
            }
            set
            {
                if(_currentContainer != null)
                {
                    _currentContainer.Close();
                    
                }
                _currentContainer = value;
            }
        }

        public int UserID
        {
            get;
            private set;
        }




        /*  public MainForm(int userId)
          {
              InitializeComponent();
              UserID = userId;
          }*/

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
            CurrentContainer = tripList;
            tcFilter.SelectTab(mainFilterPage);
        }


        public void OpenTripDetalis()
        {
            tripDetails = new TripDetailsView(CurrentTrip.Trip);
            tripDetails.DockForm(pCenter);
            CurrentContainer = tripDetails;
            tcFilter.SelectTab(tripDetailsFilterPage);

        } 

        private void bTransport_Click(object sender, EventArgs e)
        {
            OpenTripDetalis();
            if(tripDetails != null)
                if (tripDetails.DisplayedForm != null)
                {
                    tripDetails.DisplayedForm.Close();
                    tripDetails.DisplayedForm = null;
                }
            tripDetails.ShowTransportDetails();
        }

        private void bStayment_Click(object sender, EventArgs e)
        {
            if (tripDetails.DisplayedForm != null)
            {
                tripDetails.DisplayedForm.Close();
                tripDetails.DisplayedForm = null;
            }   
        }

        private void bTransportMainList_Click(object sender, EventArgs e)
        {
            OpenTripMainList();
        }

        private void bBackToTripList_Click(object sender, EventArgs e)
        {
            CurrentContainer.Close();
            OpenTripMainList();
        }
    }
}
