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
using System.Threading;

namespace Tripper.WinLogic.Forms
{
    public partial class TransportDetailsView : TripperContainerPureForm
    {
        private Button selectedVehicleButton;

        Color standardColor = Color.Teal;
        Color clickedColor = Color.FromArgb(26, 147, 147);

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

        public Button SelectedVehicleButton
        {
            set
            {
                if (selectedVehicleButton != null)
                    selectedVehicleButton.BackColor = standardColor;
                selectedVehicleButton = value;
                selectedVehicleButton.BackColor = clickedColor;
            }
        }


        List<Transport> transportList = new List<Transport>();
        List<TransportListRow> transportRowList = new List<TransportListRow>();
        NewTransportCreator newTransportPanel;
        
        public TransportDetailsView(Trip selectedTrip)
        {
            InitializeComponent();
            SelectedTrip = selectedTrip;
            tcTransportView.Appearance = TabAppearance.FlatButtons;
            tcTransportView.ItemSize = new Size(0, 1);
            tcTransportView.SizeMode = TabSizeMode.Fixed;
            loadTransportList();
            if (transportList.Count == 0)
            {

                bAdd_Click(bAdd, null);
            }
        }

        private void loadTransportList()
        {
            if (transportList.Count > 0)
            {
                transportList.Clear();
                foreach(TransportListRow row in transportRowList)
                    row.Visible = false;
                transportRowList.Clear();
            }
                

            transportList = Connection.TripperData.Transports.Where(trans => trans.TripID == SelectedTrip.TripID).ToList();
            transportList = transportList.OrderBy(trans => trans.DepartureTime).ToList();

            foreach (Transport row in transportList)
            {
                TransportListRow transportRow = new TransportListRow(row);
                transportRowList.Add(transportRow);
                pTransportTable.Controls.Add(transportRow);
                transportRow.Dock = DockStyle.Top;
            }
        }


        private void bAddRow_Click(object sender, EventArgs e)
        {
          /* TransportListRow transportRow = new TransportListRow();
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
            loadTransportPanel();
            newTransportPanel.SelectedVehicle = LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.Plane);
            tcTransportView.SelectTab(newTransportPage);
            newTransportPanel.FormClosing += newTransportPanel_FormClosing;
            SelectedVehicleButton = bAddPlane;
        }

        private void bAddPlane_Click(object sender, EventArgs e)
        {
            newTransportPanel.SelectedVehicle = LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.Plane);
            SelectedVehicleButton = bAddPlane;
        }

        private void bAddCar_Click(object sender, EventArgs e)
        {
            newTransportPanel.SelectedVehicle = LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.Car);
            SelectedVehicleButton = bAddCar;
        }

        private void bAddPublic_Click(object sender, EventArgs e)
        {
            newTransportPanel.SelectedVehicle = LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.Public);
            SelectedVehicleButton = bAddPublic;
        }

        private void bAddOtherVehicle_Click(object sender, EventArgs e)
        {
            newTransportPanel.SelectedVehicle = LocalizableStrings.GetValue.GetVehicle(LocalizableStrings.OtherVehicle);
            SelectedVehicleButton = bAddOtherVehicle;
        }

        private void newTransportPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadTransportList();
            this.Refresh();
            tcTransportView.SelectTab(transportListPage);
            

        }

    }
}
