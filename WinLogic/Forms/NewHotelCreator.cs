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
using Tripper.WinLogic.Classes;
using Tripper.WinLogic.Forms;
using Tripper.BusinessLogic;

namespace Tripper.WinLogic.Forms
{
    public partial class NewHotelCreator : TripperDetailsEditPureForm
    {
        Stayment selecteStayment;

        public NewHotelCreator() :base()
        {
            InitializeComponent();
            Mode = BusinessLogic.CreatorMode.AddNew;
            Status = CreatorStatus.Edit;
            dtpDateFrom.Date.ValueChanged += dtpDateFrom_ValueChangedDate;
            dtpDateTo.Date.ValueChanged += dtpDateTo_ValueChangedDate;
            selecteStayment = new Stayment();

        }


        public NewHotelCreator(Stayment row) : base()
        {
            Mode = BusinessLogic.CreatorMode.Edit;
            InitializeComponent();
            selecteStayment = Connection.TripperData.Stayments.Single(transport => transport.Equals(row));
            tLocalization.FillLocalizationFields(selecteStayment.LocalizationID);
            tHotelName.GetData<string>(selecteStayment.Name);
            tHotelAddress.GetData<string>(selecteStayment.Address);
           // tConfirmationNo.GetData<string>(selecteStayment.PhoneNumber);
            tStaymentCost.GetData(selecteStayment.Cost);
            dtpDateFrom.GetDate(selecteStayment.DateFrom);
            dtpDateTo.GetDate(selecteStayment.DateTo);
            tAdditonalInformations.GetData<string>(selecteStayment.AdditionalInformation);
        }

        protected override void changeEditable(bool value)
        {
            tLocalization.Enabled = value;
            dtpDateFrom.Enabled = value;
            dtpDateTo.Enabled = value;
            tHotelAddress.Enabled = value;
            tHotelName.Enabled = value;
            tHotelPhone.Enabled = value;
            tAdditonalInformations.Enabled = value;
            tStaymentCost.Enabled = value;
            bAdd.Visible = value;
        }

        private bool saveChanges()
        {

            if (validationCheck())
            {
                selecteStayment.Name = tHotelName.Text;
                selecteStayment.Localization = Connection.TripperData.Localizations.Single(c => c.LocalizationID == tLocalization.SelectedLocalization.LocalizationID);
                selecteStayment.DateFrom = dtpDateFrom.ValueNotNull();
                selecteStayment.DateTo = dtpDateTo.ValueNotNull();
                selecteStayment.Address = tHotelAddress.Text;
                selecteStayment.Cost = tStaymentCost.Value;
                //selecteStayment.PhoneNumber = tHotelPhone.Text;
                selecteStayment.AdditionalInformation = tAdditonalInformations.Text;
  
                if (Mode == BusinessLogic.CreatorMode.AddNew)
                {
                    selecteStayment.TripID = CurrentTrip.Trip.TripID;
                    Connection.TripperData.Stayments.InsertOnSubmit(selecteStayment);
                }
                return true;
            }

            return false;
        }


        private void SubmitChanges()
        {
            if (saveChanges())
            {
                DialogResult result = TripperMessageBox.Show("Czy chcesz dodać zakwaterowanie?", "Nowe zakwaterowanie");
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Connection.TripperData.SubmitChanges();
                        Status = CreatorStatus.Confirmed;
                    }
                    catch (Exception exept)
                    {
                        TripperMessageBox.Show(exept.ToString(), "Błąd");
                    }

                    if (Mode == BusinessLogic.CreatorMode.AddNew)
                        this.Close();
                    else
                        OnAfterUpdate(EventArgs.Empty);
                }
            }
        }

        private bool validationCheck()
        {
            bool validationResult = true;

            if (!tHotelName.CheckValidation())
                validationResult = false;

            if (!tLocalization.CheckValidation())
                validationResult = false;

            if (!dtpDateFrom.CheckValidation())
                validationResult = false;

            if (!dtpDateTo.CheckValidation())
                validationResult = false;

            if (dtpDateTo.Value() < dtpDateFrom.Value())
                validationResult = false;

            return validationResult;
        }


        private void dtpDateFrom_ValueChangedDate(object sender, EventArgs e)
        {
            dtpDateTo.MinDate = dtpDateFrom.Date.Value;
            dtpDateTo.Enabled = true;
        }

        private void dtpDateTo_ValueChangedDate(object sender, EventArgs e)
        {
            lDaysCount.Text = "Dni łącznie: " + (Convert.ToInt32((dtpDateTo.Date.Value - dtpDateFrom.Date.Value).TotalDays)).ToString();
            lDaysCount.Visible = true;
        }

        private void tAdditionalInformations_Enter(object sender, EventArgs e)
        {
            tAdditonalInformations.Height = 26 * 3 - 10;

        }

        private void tAdditionalInformations_Leave(object sender, EventArgs e)
        {
            tAdditonalInformations.Height = 32;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            SubmitChanges();
        }

        public override void GoBackToParent()
        {
            this.Close();
        }

    }
}
