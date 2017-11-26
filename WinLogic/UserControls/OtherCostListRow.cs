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


        // true -> button dodaje, false -> button usuwa
        private bool _buttonStatus = true;
        public bool ButtonStatus
        {
            get
            {
                return _buttonStatus;
            }
            set
            {
                _buttonStatus = value;
                if (!value)
                {

                }
            }
        }

        public OtherCostListTableUC()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public new bool Enabled
        {
            get
            {
                return  tCostName.Enabled && tCost.Enabled;
            }

            set
            {
                tCostName.Enabled = tCost.Enabled = value;
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

   

        private void buttonChangeAdd()
        {
            button.Text = "Dodaj";
            button.Click += button_ClickAdd;
        }


        private void buttonChangeDelete()
        {
            button.Text = "Usuń";
        }

        private void button_ClickAdd(object sender, EventArgs e)
        {
            contextMenuStrip.Show(button, 0, button.Height);

        }


        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            lCategory.Text = e.ClickedItem.ToString();
            this.Enabled = true;

        }
    }
}
