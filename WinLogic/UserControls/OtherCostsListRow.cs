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
using Tripper.BusinessLogic;
using Tripper.DbLogic;

namespace Tripper.WinLogic.UserControls
{
    public partial class OtherCostsListRow : ListRowPureControl
    {

        NewOtherCostsCreator OtherCostDetails;
        public event EventHandler AfterAdd;

        [Browsable(true)]
        public bool EditPanelVisible
        {
            get
            {
                return pOtherCostsPanel.Visible;
            }

            set
            {
                pOtherCostsPanel.Visible = value;
                if (CreateNewMode)
                {
                    bAdd.Visible = !value;
                    bCancel.Visible = value;
                }
            }
        }

        private OtherCost _selectedOtherCost;
        public OtherCost SelectedOtherCost
        {
            get
            {
                return _selectedOtherCost;
            }
            private set
            {
                _selectedOtherCost = value;
            }
        }

        private bool _createNewMode = false;
        public bool CreateNewMode
        {
            get
            {
                return _createNewMode;
            }
            private set
            {
                _createNewMode = value;
                bAdd.Visible = value;
                bEdit.Visible = !value;
                bDelete.Visible = !value;
            }
        }

        public OtherCostsListRow(OtherCost OtherCost)
        {
            SelectedOtherCost = OtherCost;
            InitializeComponent();
            lOtherCostsInfo.Text = SetInfo();
            CreateNewMode = false;
        }

        private void OtherCostDetails_AfterUpdate(object sender, EventArgs e)
        {
            lOtherCostsInfo.Text = SetInfo();
        }

        public OtherCostsListRow()
        {
            SelectedOtherCost = new OtherCost();
            InitializeComponent();
            CreateNewMode = true;
        }

        protected override string SetInfo()
        {
            string otherCostInfo;

            if (SelectedOtherCost != null)
                otherCostInfo = SelectedOtherCost.Name + " - " + SelectedOtherCost.Cost + " PLN";
            else
                otherCostInfo = "Dodaj koszt";

            return otherCostInfo;
        }

        private void ShowOtherCost(bool editable)
        {
            if(CreateNewMode)
            {
                OtherCostDetails = new NewOtherCostsCreator();
            }

            else
            {
                OtherCostDetails = new NewOtherCostsCreator(SelectedOtherCost);
                OtherCostDetails.AfterUpdate += OtherCostDetails_AfterUpdate;
            }

            OtherCostDetails.FormClosing += OtherCostDetails_FormClosing;
            OtherCostDetails.Editable = editable;
            OtherCostDetails.TopLevel = false;
            OtherCostDetails.Parent = this.pOtherCostsPanel;
            OtherCostDetails.Dock = DockStyle.Fill;
            OtherCostDetails.Show();
            pOtherCostsPanel.Height = OtherCostDetails.Height;

        }

        private void OtherCostDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            EditPanelVisible = false;
            Form form = this.ParentForm;
            if (form is TripperContainerPureForm)
            {
                TripperContainerPureForm ParentForm = form as TripperContainerPureForm;
               // ParentForm.DisplayedForm = null;
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (!EditPanelVisible)
            {
                ShowOtherCost(true);
                EditPanelVisible = true;
                OtherCostDetails.AfterAdd += OtherCostDetails_AfterAdd;
            }
            else if (EditPanelVisible && OtherCostDetails.Editable == false)
            {
                OtherCostDetails.Editable = true;
            }
            else
            {
                OtherCostDetails.Close();
            }
        }

        private void lOtherCostInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!EditPanelVisible)
            {
                ShowOtherCost(false);
                EditPanelVisible = true;
            }
            else
            {
                OtherCostDetails.Close();
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = TripperMessageBox.Show("Czy napewno usunąć?", "Czy napewno?");
            if (result == DialogResult.Yes)
            {
                Connection.TripperData.OtherCosts.DeleteOnSubmit(SelectedOtherCost);

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

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (OtherCostDetails.CanBeClosed())
            {
                OtherCostDetails.Close();

            }
        }

        private void OtherCostDetails_AfterAdd(object sender, EventArgs e)
        {
            OnAfterAdd(EventArgs.Empty);
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
