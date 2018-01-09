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
    public partial class StaymentListRow : ListRowPureControl
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

                if (value)
                    bEdit.Text = "Anuluj";
                else
                    bEdit.Text = "Edytuj";
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
            lStaymentInfo.Text = SetInfo();
        }

        private void StaymentDetails_AfterUpdate(object sender, EventArgs e)
        {
            lStaymentInfo.Text = SetInfo();
            OnAfterUpdate(EventArgs.Empty);
        }

        protected override string SetInfo()
        {
            string localization = SelectedStayment.Localization.City;
            string date = SelectedStayment.DateFrom.Date.ToShortDateString() + " - " + SelectedStayment.DateTo.Date.ToShortDateString();

            return localization + " " + date;
        }


        private void ShowStaymentDatails(bool editable)
        {
            StaymentDetails = new NewHotelCreator(SelectedStayment);
            StaymentDetails.AfterUpdate += StaymentDetails_AfterUpdate;
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
                ShowStaymentDatails(true);
                EditPanelVisible = true;
            }
            else if (EditPanelVisible && StaymentDetails.Editable == false)
            {
                StaymentDetails.Editable = true;
            }
            else
            {
                EditPanelVisible = false;
                StaymentDetails.Close();
            }
        }

        private void lStaymentInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!EditPanelVisible)
            {
                ShowStaymentDatails(false);
               EditPanelVisible = true;
            }
            else
            {
                EditPanelVisible = false;
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
