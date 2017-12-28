using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.WinLogic.UserControls;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;
using Tripper.BusinessLogic;
using System.Threading;

namespace Tripper.WinLogic.Forms
{
    public partial class StaymentDetailsView : TripperDetailsViewPureForm
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


        List<Stayment> StaymentList = new List<Stayment>();
        List<StaymentListRow> StaymentRowList = new List<StaymentListRow>();
        NewHotelCreator newStaymentPanel;

        public StaymentDetailsView(Trip selectedTrip)
        {
            InitializeComponent();
            Mode = DetailsViewMode.ListView;
            SelectedTrip = selectedTrip;
            tcStaymentView.Appearance = TabAppearance.FlatButtons;
            tcStaymentView.ItemSize = new Size(0, 1);
            tcStaymentView.SizeMode = TabSizeMode.Fixed;
            loadStaymentList();

        }

        private void loadStaymentList()
        {
            if (StaymentList.Count > 0)
            {
                StaymentList.Clear();
                foreach (StaymentListRow row in StaymentRowList)
                    row.Visible = false;
                StaymentRowList.Clear();
            }


            StaymentList = Connection.TripperData.Stayments.Where(trans => trans.TripID == SelectedTrip.TripID).ToList();
            StaymentList = StaymentList.OrderBy(stay => stay.DateFrom).ToList();

            foreach (Stayment row in StaymentList)
            {
                StaymentListRow StaymentRow = new StaymentListRow(row);
                StaymentRowList.Add(StaymentRow);
                pStaymentTable.Controls.Add(StaymentRow);
                StaymentRow.Dock = DockStyle.Top;
            }
        }


        private void loadStaymentPanel()
        {
            newStaymentPanel = new NewHotelCreator();
            newStaymentPanel.TopLevel = false;
            newStaymentPanel.Parent = this.pNewStaymentView;
            newStaymentPanel.Dock = DockStyle.Fill;
            newStaymentPanel.Show();
        }


        private void newStaymentPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadStaymentList();
            this.Refresh();
            tcStaymentView.SelectTab(StaymentListPage);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            loadStaymentPanel();
            tcStaymentView.SelectTab(newStaymentPage);
            newStaymentPanel.FormClosing += newStaymentPanel_FormClosing;
        }



        private void tcStaymentView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcStaymentView.SelectedTab == newStaymentPage)
                Mode = DetailsViewMode.AddNew;
            else
                Mode = DetailsViewMode.ListView;
        }
    }
}
