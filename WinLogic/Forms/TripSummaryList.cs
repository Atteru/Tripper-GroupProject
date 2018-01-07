using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;
using Tripper.BusinessLogic;    

namespace Tripper.WinLogic.Forms
{
    public partial class TripSummaryList : Tripper.WinLogic.Forms.TripperDetailsViewPureForm
    {
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

        private bool _transportVisibility;
        public bool TransportVisibility
        {
            get
            {
                return _transportVisibility;
            }
            set
            {
                _transportVisibility = value;
                pTransportHeader.Visible = value;
                TransportDetailsVisibility = value;
            }
        }

        private bool _staymentVisibility;
        public bool StaymentVisibility
        {
            get
            {
                return _staymentVisibility;
            }
            set
            {
                _staymentVisibility = value;
                pStaymentHeader.Visible = value;
                StaymentDetailsVisibility = value;
            }
        }

        private bool _costVisibility;
        public bool CostsVisibility
        {
            get
            {
                return _costVisibility;
            }
            set
            {
                _costVisibility = value;
                pCostsHeader.Visible = value;
                CostsDetailsVisibility = value;
            }
        }

        private bool _transportDetailsVisibility;
        public bool TransportDetailsVisibility
        {
            get
            {
                return _transportDetailsVisibility;
            }

            set
            {
                _transportDetailsVisibility = value;
                dgvTransport.Visible = value;
                pTransportTotal.Visible = value;
                setHeaderLabel(lTransportHeader, LocalizableStrings.Transport, transportTotal, value);
            }
        }

        private bool _staymentDetailsVisibility;
        public bool StaymentDetailsVisibility
        {
            get
            {
                return _staymentDetailsVisibility;
            }

            set
            {
                _staymentDetailsVisibility = value;
                dgvStayment.Visible = value;
                pStaymentTotal.Visible = value;
                setHeaderLabel(lStaymentHeader, LocalizableStrings.Stayment, staymentTotal, value);
            }
        }

        private bool _costsDetailsVisibility;
        public bool CostsDetailsVisibility
        {
            get
            {
                return _costsDetailsVisibility;
            }

            set
            {
                _costsDetailsVisibility = value;
                dgvCosts.Visible = value;
                pCostsTotal.Visible = value;
                setHeaderLabel(lCostsHeader, LocalizableStrings.Costs, costsTotal, value);
            }
        }

        private Decimal transportTotal;
        private Decimal staymentTotal;
        private Decimal costsTotal;

        private List<Label> headersCouterList = new List<Label>();

        public TripSummaryList(Trip selectedTrip)
        {
            InitializeComponent();

            tcOrganizer.Appearance = TabAppearance.FlatButtons;
            tcOrganizer.ItemSize = new Size(0, 1);
            tcOrganizer.SizeMode = TabSizeMode.Fixed;

            SelectedTrip = selectedTrip;
            dgvTransport.DataSource = Connection.TripperData.TransprtByTripID(SelectedTrip.TripID);
            dgvStayment.DataSource = Connection.TripperData.StaymentByTripID(SelectedTrip.TripID);
            dgvCosts.DataSource = Connection.TripperData.OtherCostsByTripID(SelectedTrip.TripID);

            staymentTotal = Connection.TripperData.StaymentByTripID(SelectedTrip.TripID).Sum(c => c.Koszt);
            costsTotal = Connection.TripperData.OtherCostsByTripID(SelectedTrip.TripID).Sum(c => c.Koszt);
            setDetails();
            loadNotesForm(SelectedTrip);
            ifNoInfoToDisplay();



        }

        private void ifNoInfoToDisplay()
        {
            if(!TransportVisibility && !StaymentVisibility && !CostsVisibility)
            {
                lNoInfo.Visible = true;
            }
        }

        private void setHeaderLabel(Label header, string text, Decimal value, bool visibility)
        {
            int number = headersCouterList.IndexOf(header) + 1; 

            if (visibility)
            {
                header.Text = number.ToString() + ". " + text;
            }
            else
            {
                header.Text = number.ToString() + ". " + text + " - " + value.ToString() + " PLN";
            }
        }

        private void setDetails()
        {
            if(TransportVisibility = Connection.TripperData.TransprtByTripID(SelectedTrip.TripID).Any())
            {
                transportTotal = Connection.TripperData.TransprtByTripID(SelectedTrip.TripID).Sum(c => c.Koszt);
                lTransportTotal.Text = "Suma: " + transportTotal.ToString();
                headersCouterList.Add(lTransportHeader);
                TransportDetailsVisibility = true;
            }

            if (StaymentVisibility = Connection.TripperData.StaymentByTripID(SelectedTrip.TripID).Any())
            {
                staymentTotal = Connection.TripperData.StaymentByTripID(SelectedTrip.TripID).Sum(c => c.Koszt);
                lStaymentTotal.Text = "Suma: " + staymentTotal.ToString();
                headersCouterList.Add(lStaymentHeader);
                StaymentDetailsVisibility = true;
            }

            if (CostsVisibility = Connection.TripperData.OtherCostsByTripID(SelectedTrip.TripID).Any())
            {
                costsTotal = Connection.TripperData.OtherCostsByTripID(SelectedTrip.TripID).Sum(c => c.Koszt);
                lCostsTotal.Text = "Suma: " + costsTotal.ToString();
                headersCouterList.Add(lCostsHeader);
                CostsDetailsVisibility = true;
            }
        }

        private void loadNotesForm(Trip selectedTrip)
        {
            OrganizerForm notesForm = new OrganizerForm(selectedTrip);
            notesForm.TopLevel = false;
            notesForm.Parent = this.pNotes;
            notesForm.Dock = DockStyle.Fill;
            notesForm.Show();
            //pTicketPanel.Height = transportDetails.Height;
        }

        private void lTransportHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TransportDetailsVisibility = !TransportDetailsVisibility;
        }

        private void lStaymentHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StaymentDetailsVisibility = !StaymentDetailsVisibility;
        }

        private void lCostsHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CostsDetailsVisibility = !CostsDetailsVisibility;
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            dataGridView.Height = dataGridView.Rows[0].Height * (dataGridView.RowCount > 10 ? 10 : dataGridView.RowCount) + dataGridView.ColumnHeadersHeight;
        }

        private void bNotes_Click(object sender, EventArgs e)
        {
            tcOrganizer.SelectedTab = notesPage;
        }

        private void bInfo_Click(object sender, EventArgs e)
        {
            tcOrganizer.SelectedTab = infoPage;
        }
    }
}
