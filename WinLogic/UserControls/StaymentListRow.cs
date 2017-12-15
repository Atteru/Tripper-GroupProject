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
    public partial class StaymentListRow : UserControl
    {

        NewHotelCreator StaymentDetails;


        [Browsable(true)]
        public bool EditPanelVisible
        {
            get
            {
                return pStaymentPanel.Visible;
            }

            set
            {
                pStaymentPanel.Visible = value;
            }
        }

        Stayment _selectedStayment;
        Stayment SelectedStayment
        {
            get
            {
                return _selectedStayment;
            }
            set
            {
                _selectedStayment = value;
            }
        }

        public StaymentListRow(Stayment Stayment)
        {
            SelectedStayment = Stayment;
            InitializeComponent();
            lStaymentInfo.Text = setStaymentInfo();


        }

        private string setStaymentInfo()
        {
            string localization = Connection.TripperData.Localizations.Single(loc => loc.LocalizationID == SelectedStayment.LocalizationID).City;
            string date = SelectedStayment.DateFrom.Date.ToShortDateString() + " - " + SelectedStayment.DateTo.Date.ToShortDateString();

            return localization + " " + date;

        }


        private void ShowTicket(bool editable)
        {
            StaymentDetails = new NewHotelCreator(SelectedStayment);
            StaymentDetails.Editable = editable;
            StaymentDetails.TopLevel = false;
            StaymentDetails.Parent = this.pStaymentPanel;
            StaymentDetails.Dock = DockStyle.Fill;
            StaymentDetails.Show();
            pStaymentPanel.Height = StaymentDetails.Height;

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (!EditPanelVisible)
            {
                ShowTicket(true);
                pStaymentPanel.Visible = true;
            }
            else if (EditPanelVisible && StaymentDetails.Editable == false)
            {
                StaymentDetails.Editable = true;
            }
            else
            {
                pStaymentPanel.Visible = false;
                StaymentDetails.Close();
            }
        }

        private void lStaymentInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!EditPanelVisible)
            {
                ShowTicket(false);
                pStaymentPanel.Visible = true;
            }
            else
            {
                pStaymentPanel.Visible = false;
                StaymentDetails.Close();
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = TripperMessageBox.Show("Czy chcesz usunąć zakwaterowanie?", "Czy napewno?");
            if (result == DialogResult.Yes)
            {
                Connection.TripperData.Stayments.DeleteOnSubmit(SelectedStayment);

                try
                {
                    this.Visible = false;
                    Connection.TripperData.SubmitChanges();
                }
                catch (Exception exept)
                {
                    TripperMessageBox.Show(exept.ToString(), "Błąd");
                }

            }
        }
    }
}
