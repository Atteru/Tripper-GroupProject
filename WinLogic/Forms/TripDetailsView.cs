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
    public partial class TripDetailsView : TripperContainerPureForm
    {
        TransportDetailsView transportDetails;

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


        public TripDetailsView(Trip selectedTrip)
        {
            InitializeComponent();
            SelectedTrip = selectedTrip;
        }

        public void ShowTransportDetails()
        {
            if(DisplayedForm == null)
            {
                transportDetails = new TransportDetailsView(SelectedTrip);
                transportDetails.DockForm(pCurrentView);
                DisplayedForm = transportDetails;
            }
        }

        
    }
}
