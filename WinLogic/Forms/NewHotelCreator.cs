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

        private void textBoxUC3_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUC3_Enter(object sender, EventArgs e)
        {
            textBoxUC3.Height = 150;
        }

        private void textBoxUC3_Leave(object sender, EventArgs e)
        {
            textBoxUC3.Height = 26;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stayment newHotel = new Stayment();
            String temporaryStringForCost = textBoxUC5.Text;
            Decimal temporaryDecimal = (Decimal)0.00;
            if (temporaryStringForCost != "")
            {
                temporaryDecimal = decimal.Parse(temporaryStringForCost);
            }

            newHotel = NewHotel.AddNewHotel(textBoxUC2.Text, textBoxUC1.Text, textBoxUC4.Text, textBoxUC3.Text
                , dtpDateFrom.Value(), dtpDateTo.Value(), temporaryDecimal);
            if (newHotel != null)
            {
                Connection.TripperData.Stayments.InsertOnSubmit(newHotel);
                Connection.TripperData.SubmitChanges();
            }

        }
    }
}
