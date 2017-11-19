using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.WinLogic.UserControls;

namespace Tripper.WinLogic.Forms
{
    public partial class TransportDetailsView : Form
    {
        List<TransportListRow> tranportList = new List<TransportListRow>();

        public TransportDetailsView()
        {
            InitializeComponent();
            /*  tcTransportView.Appearance = TabAppearance.FlatButtons;
              tcTransportView.ItemSize = new Size(0, 1);
              tcTransportView.SizeMode = TabSizeMode.Fixed; */



            if (tranportList.Count == 0)
            {
                tcTransportView.SelectTab(newTransport);
            }
        }

        private void bAddRow_Click(object sender, EventArgs e)
        {
            TransportListRow transportRow = new TransportListRow();
            pTransportTable.Controls.Add(transportRow); 
            transportRow.Dock = DockStyle.Top; 

        }

        private void bAddPlane_Click(object sender, EventArgs e)
        {
            NewTransportCreator newTransport = new NewTransportCreator();
            newTransport.TopLevel = false;
            newTransport.Parent = this.pNewTicketView;
            newTransport.Dock = DockStyle.Fill;
            newTransport.Show();
        }
    }
}
