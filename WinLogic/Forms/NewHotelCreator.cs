using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripper.WinLogic.Forms
{
    public partial class NewHotelCreator : Form
    {
        public NewHotelCreator()
        {
            InitializeComponent();
            dtpDateFrom.Date.ValueChanged += dtpDateFrom_ValueChangedDate;
            dtpDateTo.Date.ValueChanged += dtpDateTo_ValueChangedDate;


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
            tAdditonalInformations.Height = 150;
        }

        private void tAdditionalInformations_Leave(object sender, EventArgs e)
        {
            tAdditonalInformations.Height = 26;
        }

    }
}
