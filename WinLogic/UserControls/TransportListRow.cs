﻿using System;
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
    public partial class TransportListRow : UserControl
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
            lTransportInfo.Text = Connection.TripperData.Localizations.Single(loc => loc.LocalizationID == transport.DepartureLocalization) + " - " + Connection.TripperData.Localizations.Single(loc => loc.LocalizationID == transport.ArrivalLocalization).ToString();
        }

        private void ShowTicket()
        {
            transportDetails = new NewTransportCreator(SelectedTransport);
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
                ShowTicket();
                pTicketPanel.Visible = true;
            }
            else
            {
                pTicketPanel.Visible = false;
                transportDetails.Close();
            } 
        }


    }
}