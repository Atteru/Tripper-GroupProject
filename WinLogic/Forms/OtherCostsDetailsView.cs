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
    public partial class OtherCostsDetailsView : TripperDetailsViewPureForm
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


        List<OtherCost> OtherCostsList = new List<OtherCost>();
        List<OtherCostsListRow> OtherCostsRowList = new List<OtherCostsListRow>();
        OtherCostsListRow NewOtherCostRow;

        public OtherCostsDetailsView(Trip selectedTrip)
        {
            InitializeComponent();
            Mode = DetailsViewMode.ListView;
            SelectedTrip = selectedTrip;
            tcOtherCostsView.Appearance = TabAppearance.FlatButtons;
            tcOtherCostsView.ItemSize = new Size(0, 1);
            tcOtherCostsView.SizeMode = TabSizeMode.Fixed;

            NewOtherCostRow = new OtherCostsListRow();
            pOtherCostsTable.Controls.Add(NewOtherCostRow);
            NewOtherCostRow.Dock = DockStyle.Top;
            NewOtherCostRow.AfterAdd += NewOtherCostRow_AfterAdd;
            loadOtherCostsList();
        }

        private void loadOtherCostsList()
        {
            if (OtherCostsList.Count > 0)
            {
                OtherCostsList.Clear();
                foreach (OtherCostsListRow row in OtherCostsRowList)
                    row.Visible = false;
                OtherCostsRowList.Clear();
            }

            OtherCostsList = Connection.TripperData.OtherCosts.Where(trans => trans.TripID == SelectedTrip.TripID).ToList();
            OtherCostsList = OtherCostsList.OrderBy(stay => stay.OtherCostsID).ToList();

            foreach (OtherCost row in OtherCostsList)
            {
                OtherCostsListRow OtherCostsRow = new OtherCostsListRow(row);
                OtherCostsRowList.Add(OtherCostsRow);
                pOtherCostsTable.Controls.Add(OtherCostsRow);
                OtherCostsRow.Dock = DockStyle.Top;
            }
        }

        private void NewOtherCostRow_AfterAdd(object sender, EventArgs e)
        {
            OtherCost lastInserted = Connection.TripperData.OtherCosts.Where(cost => cost.Trip == SelectedTrip).ToList().Last() ;
            OtherCostsList.Add(lastInserted);
            OtherCostsListRow OtherCostsRow = new OtherCostsListRow(lastInserted);
            pOtherCostsTable.Controls.Add(OtherCostsRow);
            OtherCostsRow.Dock = DockStyle.Top;
        }

    }
}
