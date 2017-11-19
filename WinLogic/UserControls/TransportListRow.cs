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

namespace Tripper.WinLogic.UserControls
{
    public partial class TransportListRow : UserControl
    {
        NewTransportCreator transportDetails;

       [Browsable(true)]
        public bool EditPanelVisible
        {
            get
            {
                return TicketPanel.Visible;
            }

            set
            {
                TicketPanel.Visible = value;
            }
        }

        public TransportListRow()
        {
            InitializeComponent();

            
        }

        private void ShowTicket()
        {
            transportDetails = new NewTransportCreator();
            transportDetails.TopLevel = false;
            transportDetails.Parent = this.TicketPanel;
            transportDetails.Dock = DockStyle.Fill;
            transportDetails.Show();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (!EditPanelVisible)
            {
                ShowTicket();
                TicketPanel.Visible = true;
            }
            else
            {
                TicketPanel.Visible = false;
                transportDetails.Close();
            } 


        }


    }
}
