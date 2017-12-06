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
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;
using Tripper.BusinessLogic;

namespace Tripper.WinLogic.Forms
{
    public partial class TransportDetailsView : Form
    {
        List<Transport> tranportList = new List<Transport>();
        NewTransportCreator newTransportPanel;

        public TransportDetailsView()
        {
            InitializeComponent();

            tcTransportView.Appearance = TabAppearance.FlatButtons;
            tcTransportView.ItemSize = new Size(0, 1);
            tcTransportView.SizeMode = TabSizeMode.Fixed;
            loadTransportPanel();
            loadTransportList();
            if (tranportList.Count == 0)
            {
                tcTransportView.SelectTab(newTransport);
            }
        }


        private void loadTransportList()
        {
            tranportList = Connection.TripperData.Transports.Where(trans => trans.TripID == 1).ToList();

            foreach (Transport row in tranportList)
            {
                TransportListRow transportRow = new TransportListRow(row);
                pTransportTable.Controls.Add(transportRow);
            }
            bAddPlane_Click(bAddPlane, null);
        }

        private void bAddRow_Click(object sender, EventArgs e)
        {
          /*  TransportListRow transportRow = new TransportListRow();
            pTransportTable.Controls.Add(transportRow); 
            transportRow.Dock = DockStyle.Top;  */
        }

        private void loadTransportPanel()
        {
            newTransportPanel = new NewTransportCreator();
            newTransportPanel.TopLevel = false;
            newTransportPanel.Parent = this.pNewTicketView;
            newTransportPanel.Dock = DockStyle.Fill;
            newTransportPanel.Show();
        }

 

        private void bAdd_Click(object sender, EventArgs e)
        {
            tcTransportView.SelectTab(newTransport);
            
        }



        private void bAddPlane_Click(object sender, EventArgs e)
        {
            newTransportPanel.SelectedVehicle = LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.Plane);
        }

        private void bAddCar_Click(object sender, EventArgs e)
        {
            newTransportPanel.SelectedVehicle = LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.Car);
        }

        private void bAddPublic_Click(object sender, EventArgs e)
        {
            newTransportPanel.SelectedVehicle = LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.Public);
        }

        private void bAddOtherVehicle_Click(object sender, EventArgs e)
        {
            newTransportPanel.SelectedVehicle = LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.OtherVehicle);
        }
    }
}
