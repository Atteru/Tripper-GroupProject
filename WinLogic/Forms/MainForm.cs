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

namespace Tripper.WinLogic.Forms
{
    public partial class MainForm : TripperContainerPureForm
    {
        TripDetailsView tripDetails;
        TripMainList tripList;
        private Trip _selectedTrip;
   
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
           // OpenTripDetalis();
        }


        private void OpenTripMainList()
        {
            tripList = new TripMainList();
            tripList.DockForm(pCenter);
            CurrentContainer = tripList;
        }


     /*   private void OpenTripDetalis()
        {
            tripDetails = new TripDetailsView();
            tripDetails.DockForm(pCenter);
            CurrentContainer = tripDetails;
        } */

        private void bTransport_Click(object sender, EventArgs e)
        {
            //OpenTripDetalis();
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
    }
}
