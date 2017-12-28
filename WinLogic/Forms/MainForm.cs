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

namespace Tripper.WinLogic.Forms
{
    public partial class MainForm : TripperContainerPureForm
    {
        public int UserID
        {
            get;
            private set;
        }

        TripperContainerPureForm currentContainer;

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            OpenTripMainList();

            tcFilter.Appearance = TabAppearance.FlatButtons;
            tcFilter.ItemSize = new Size(0, 1);
            tcFilter.SizeMode = TabSizeMode.Fixed;
        }


        public void OpenTripMainList()
        {
            if (!(currentContainer is TripMainList))
            {
                if (currentContainer != null)
                    currentContainer.Close();

                currentContainer = new TripMainList();
                ((TripMainList)currentContainer).DockForm(pCenter);
            }
        }

        public void OpenTripDetalis()
        {
            if(!(currentContainer is TripContainerView) && currentContainer != null)
            {
                if (currentContainer != null)
                    currentContainer.Close();

                currentContainer = new TripContainerView(CurrentTrip.Trip);
                ((TripContainerView)currentContainer).DockForm(pCenter);
                tcFilter.SelectTab(tripDetailsFilterPage);
                currentContainer.FormClosed += currentContainer_FormClosed;
            }
        }

        private void currentContainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            currentContainer.FormClosed -= currentContainer_FormClosed;
            currentContainer = new TripMainList();
            ((TripMainList)currentContainer).DockForm(pCenter);
        }

        private void bTransport_Click(object sender, EventArgs e)
        {
            if(currentContainer.CanBeClosed())
            {
                OpenTripDetalis();
                ((TripContainerView)currentContainer).ShowTransportDetails();
            }
        }

        private void bStayment_Click(object sender, EventArgs e)
        {
            if (currentContainer.CanBeClosed())
            {
                OpenTripDetalis();
                ((TripContainerView)currentContainer).ShowStaymentDetails();
            }

        }

        private void bOtherCosts_Click(object sender, EventArgs e)
        {
            if (currentContainer.CanBeClosed())
            {
                OpenTripDetalis();
                ((TripContainerView)currentContainer).ShowOtherCoststDetails();
            }
        }


        private void bTripMainList_Click(object sender, EventArgs e)
        {
            OpenTripMainList();
        }

        private void bBackToTripList_Click(object sender, EventArgs e)
        {
            if (currentContainer.CanBeClosed())
            {
                CloseDisplayedForms();
            }
        }

        private void pCenter_ControlAdded(object sender, ControlEventArgs e)
        {
            if(e.Control is TripMainList)
            {
                 tcFilter.SelectTab(mainFilterPage);
            }
        }
    }
}
