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
using Tripper.DbLogic.LinqToSQL;
using Tripper.DbLogic;

namespace Tripper.WinLogic.UserControls
{
    public partial class TransportListRow : ListRowPureControl
    {
        
        NewTransportCreator transportDetails;


       [Browsable(true)]
        public bool EditPanelVisible
        {
            get
            {
                return pTicketPanel.Visible;
            }

            set
            {
                pTicketPanel.Visible = value;
                if (value)
                    bEdit.Text = "Anuluj";
                else
                    bEdit.Text = "Edytuj";
            }
        }

        Transport _selectedTransport;
        Transport SelectedTransport
        {
            get
            {
                return _selectedTransport;
            }
            set
            {
                _selectedTransport = value;
            }
        }

        public TransportListRow(Transport transport)
        {
            SelectedTransport = transport;
            InitializeComponent();
            lTransportInfo.Text = SetInfo();
        }

        private void TransportDetails_AfterUpdate(object sender, EventArgs e)
        {
            lTransportInfo.Text = SetInfo();
            OnAfterUpdate(EventArgs.Empty);
        }

        protected override string SetInfo()
        {
            return SelectedTransport.Localization.City + " - " + SelectedTransport.Localization1.City;
        }

        private void ShowTicket(bool editable)
        {
            transportDetails = new NewTransportCreator(SelectedTransport);
            transportDetails.AfterUpdate += TransportDetails_AfterUpdate;
            transportDetails.Editable = editable;
            transportDetails.TopLevel = false;
            transportDetails.Parent = this.pTicketPanel;
            transportDetails.Dock = DockStyle.Fill;
            transportDetails.Show();
            pTicketPanel.Height = transportDetails.Height;
             
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (!EditPanelVisible)
            {
                ShowTicket(true);
                EditPanelVisible = true;
            }
            else if (EditPanelVisible && transportDetails.Editable == false)
            {
                transportDetails.Editable = true;
            }
            else
            {
                EditPanelVisible = false;
                transportDetails.Close();
            }
        }

        private void lTransportInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!EditPanelVisible)
            {
                ShowTicket(false);
                EditPanelVisible = true;
            }
            else
            {
                EditPanelVisible = false;
                transportDetails.Close();
            }

        }

        private void bDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = TripperMessageBox.Show("Czy chcesz usunąć podróż?", "Czy napewno?");
            if (result == DialogResult.Yes)
            {
                Connection.TripperData.Transports.DeleteOnSubmit(SelectedTransport);
                
                try
                {
                    this.Visible = false;
                    Connection.TripperData.SubmitChanges();
                    OnAfterUpdate(EventArgs.Empty);
                }
                catch (Exception exept)
                {
                    TripperMessageBox.Show(exept.ToString(), "Błąd");
                }

            }
        }
    }
}
