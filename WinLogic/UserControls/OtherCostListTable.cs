using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;

namespace Tripper.WinLogic.UserControls
{
    public partial class OtherCostListTableUC : UserControl
    {
        // private List<OtherCostsCatergory> categoryList = Connection.TripperData.OtherCostsCatergories.ToList();
        private List<OtherCostsCatergory> categoryList = new List<OtherCostsCatergory>();

        public OtherCostListTableUC()
        {
            InitializeComponent();
            FillContextMenu(categoryList);
        }

        [Browsable(true)]
        public new bool Enabled
        {
            get
            {
                return lRowNumber.Enabled && lCategory.Enabled && tCostName.Enabled && tCost.Enabled;
            }

            set
            {
                lRowNumber.Enabled = lCategory.Enabled = tCostName.Enabled = tCost.Enabled = value;
            }
        }

        public int RowNumber
        {
            get
            {
                return int.Parse(lRowNumber.Text);
            }
            set
            {
                lRowNumber.Text = value.ToString() + ".";
            }
        }

        public bool RowIsAdded
        {
            get; set;
        }

        private void button_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(button, 0, button.Height);
        }



        private void FillContextMenu(List<OtherCostsCatergory> categoryList)
        {

            for (int i = 0; i < categoryList.Count(); i++)
            {
                ToolStripMenuItem toolStripItem = new ToolStripMenuItem();
                toolStripItem.Text = categoryList.ElementAt(i).ToString();
                contextMenuStrip.Items.Add(toolStripItem);
            }
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var category = e.ClickedItem;
            

        }
    }
}
