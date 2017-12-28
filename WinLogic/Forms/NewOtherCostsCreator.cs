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
    public partial class NewOtherCostsCreator : TripperDetailsEditPureForm
    {
        public event EventHandler AfterAdd;

        OtherCost selectedOtherCosts;

        public NewOtherCostsCreator() :base()
        {
            InitializeComponent();
            Mode = CreatorMode.AddNew;
            Status = CreatorStatus.Edit;
            cbOtherCostsCategory.DataSource = Connection.TripperData.OtherCostsCatergories.ToList();
            selectedOtherCosts = new OtherCost();
        }


            public NewOtherCostsCreator(OtherCost row) : base()
        {
            Mode = BusinessLogic.CreatorMode.Edit;
            InitializeComponent();
            cbOtherCostsCategory.DataSource = Connection.TripperData.OtherCostsCatergories.ToList();
            selectedOtherCosts = row;
            tOtherCostName.GetData<string>(selectedOtherCosts.Name);
            cbOtherCostsCategory.SelectedItem = Connection.TripperData.OtherCostsCatergories.Single(category => category.OtherCategoryID == selectedOtherCosts.OtherCategoryID);
            tCost.GetData(selectedOtherCosts.Cost);
            //tAdditonalInformations.GetData<string>(selectedOtherCosts.AdditonalInformations);

        }

        protected override void changeEditable(bool value)
        {
            tOtherCostName.Enabled = value;
            cbOtherCostsCategory.Enabled = value;
            tCost.Enabled = value;
            tAdditonalInformations.Enabled = value;
            bAdd.Visible = value;
        }

        private bool saveChanges()
        {

            if (validationCheck())
            {
                selectedOtherCosts.Name = tOtherCostName.Text;
                selectedOtherCosts.OtherCategoryID = ((OtherCostsCatergory)cbOtherCostsCategory.SelectedItem).OtherCategoryID;
                selectedOtherCosts.Cost = tCost.Value;
                //selectedOtherCosts.AdditonalInformations = tAdditonalInformations.Text; 

                if (Mode == BusinessLogic.CreatorMode.AddNew)
                {
                    selectedOtherCosts.TripID = CurrentTrip.Trip.TripID;
                    Connection.TripperData.OtherCosts.InsertOnSubmit(selectedOtherCosts);
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
                        OnAfterAdd(EventArgs.Empty);
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

            if (!tOtherCostName.CheckValidation())
                validationResult = false;


            return validationResult;
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

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Status = CreatorStatus.Confirmed;
        }

        protected virtual void OnAfterAdd(EventArgs e)
        {
            EventHandler handler = AfterAdd;
            if (handler != null)
            {
                handler(this, e);
            }
        }

    }
}
