using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;
using Tripper.WinLogic.UserControls;
using Tripper.BusinessLogic;

namespace Tripper.WinLogic.Forms
{
    public partial class NewTripCreator : TripperDetailsEditPureForm
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

        private bool _aditionalInfoOpen;
        public bool AditionalInfoOpen
        {
            set
            {
                if (value == true)
                    tAdditonalInfo.Height = 26;
                else
                    tAdditonalInfo.Height = 26 * 3 - 10;

                _aditionalInfoOpen = value;
            }
        }

        public NewTripCreator()
        {
            InitializeComponent();
        }


        public NewTripCreator(Trip selectedTrip)
        {
            mode = CreatorMode.Edit;
            InitializeComponent();
            SelectedTrip = selectedTrip;

            tTripTitle.Text = selectedTrip.Name;
            tBudget.Text = selectedTrip.Budget.ToString();
            setAdditionalInformation();

            
        }

        private void setAdditionalInformation()
        {
            List<Stayment> staymentList = Connection.TripperData.Stayments.Where(stayment => stayment.TripID == SelectedTrip.TripID).ToList();
            if(staymentList.Count == 0)
                tBudget.MessageVisibility = false;
            else
                foreach (Stayment staymant in staymentList)
                {
                    string staymentInfoLocalization = Connection.TripperData.Localizations.Single(loc => loc.LocalizationID == staymant.LocalizationID).City;
                    Label staymentInfo = new Label();
                    staymentInfo.Text = staymentInfoLocalization + "    " + staymant.DateFrom.Date.ToShortDateString() + staymant.DateTo.Date.ToShortDateString();
                    staymentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    staymentInfo.ForeColor = Color.DarkSlateGray;
                    pStaymentListLayout.Controls.Add(staymentInfo);
                }
        }

        private void tAdditionalInformations_Enter(object sender, EventArgs e)
        {
            tAdditonalInfo.Height = 26 * 3 - 10;
        }

        private void tAdditionalInformations_Leave(object sender, EventArgs e)
        {
            tAdditonalInfo.Height = 26;
        }

        protected override void changeEditable(bool value)
        {
            tBudget.Enabled = value;
            tTripTitle.Enabled = value;
            tAdditonalInfo.Enabled = value;
            AditionalInfoOpen = value;
        }

    }
}
