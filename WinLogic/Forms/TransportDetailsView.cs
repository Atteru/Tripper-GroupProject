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
    public partial class TransportDetailsView : Form
    {
        private Button selectedVehicleButton;

        Color standardColor = Color.Teal;
        Color clickedColor = Color.FromArgb(26, 147, 147);
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


        List<Transport> tranportList = new List<Transport>();
        NewTransportCreator newTransportPanel;

        public TransportDetailsView()
        {
            InitializeComponent();

            tcTransportView.Appearance = TabAppearance.FlatButtons;
            tcTransportView.ItemSize = new Size(0, 1);
            tcTransportView.SizeMode = TabSizeMode.Fixed;
            loadTransportList();
            if (tranportList.Count == 0)
            {
                tcTransportView.SelectTab(newTransport);
            }
        }

        private void loadTransportList()
        {
            tranportList = Connection.TripperData.Transports.Where(trans => trans.TripID == 1).ToList();
            tranportList = tranportList.OrderBy(trans => trans.DepartureTime).ToList();

            foreach (Transport row in tranportList)
            {
                TransportListRow transportRow = new TransportListRow(row);
                pTransportTable.Controls.Add(transportRow);
                transportRow.Dock = DockStyle.Right;
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
            tcTransportView.SelectTab(newTransport);
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
    }
}
