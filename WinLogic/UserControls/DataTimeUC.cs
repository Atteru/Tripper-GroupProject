using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripper.WinLogic.UserControls
{
    public partial class DataTimeUC : UserControl
    {

        public DateTimePicker Date
        {
            get
            {
                return dtpDate;
            }
        }

        public DateTimePicker Time
        {
            get
            {
                return dtpTime;
            }
        }

        public DataTimeUC()
        {
            InitializeComponent();
            dtpTime.CustomFormat = "HH:mm";
         
        }

        public DateTime Value()
        {
            return DateTime.Parse(this.Date.Text + " " + this.Time.Text + ":00");
        }

    }
}
