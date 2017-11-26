using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripper.WinLogic.Forms
{
    public partial class TripDetailsView : Form
    {
        TransportDetailsView transportDetails;

        private Form _displayedForm;
        public Form DisplayedForm
        {
            get
            {
                return _displayedForm;
            }
            set
            {
                _displayedForm = value;
            }
        }

        public TripDetailsView()
        {
            InitializeComponent();
        }

        

        public void ShowTransportDetails()
        {
            if(DisplayedForm == null)
            {
                transportDetails = new TransportDetailsView();
                transportDetails.TopLevel = false;
                transportDetails.Parent = this.pCurrentView;
                transportDetails.Dock = DockStyle.Fill;
                transportDetails.Show();
                DisplayedForm = transportDetails;
            }
        }

        
    }
}
