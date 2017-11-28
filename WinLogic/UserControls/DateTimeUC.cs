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
    public partial class DateTimeUC : UserControl
    {
        public event EventHandler ValueChangedDate;
        public event EventHandler ValueChangedTime;

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
        public DateTime GetDate
        {
            get
            {
                return dtpDate.Value;
            }
        }

        private Font _Font = DefaultFont;
        [Bindable(true)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font
        {
            get { return _Font; }
            set
            {
                _Font = base.Font = value;
                this.dtpDate.Font = _Font;
                this.dtpTime.Font = _Font;
                this.lDateMessage.Font = _Font;
                this.lTimeMessage.Font = _Font;
            }
        }

        [Browsable(true)]
        public string TimeLabelMessage
        {
            get
            {
                return lTimeMessage.Text;
            }
            set
            {
                lTimeMessage.Text = value;
            }
        }

        [Browsable(true)]
        public DateTime MinDate
        {
            get
            {
                return dtpDate.MinDate;
            }
            set
            {
                dtpDate.MinDate = value;
            }
        }

        [Browsable(true)]
        public string DatelabelMessage
        {
            get
            {
                return lDateMessage.Text;
            }
            set
            {
                lDateMessage.Text = value;
            }
        }

        [Browsable(true)]
        public new bool  Enabled
        {
            get
            {
                return dtpDate.Enabled && dtpTime.Enabled;
            }
            set
            {
                dtpDate.Enabled = dtpTime.Enabled = value;
            }
        }

        public DateTimeUC()
        {
            InitializeComponent();
            base.AutoScaleMode = AutoScaleMode.None;
            dtpTime.CustomFormat = "\tHH:mm";
        }

        public DateTime Value()
         {
             return DateTime.Parse(this.Date.Text + " " + this.Time.Text + ":00");
         }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (pDateMessage.Visible)
                pDateMessage.Visible = false;
        }


        private void pTimeMessage_Click(object sender, EventArgs e)
        {
            pTimeMessage.Visible = false;
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            if(pTimeMessage.Visible)
                pTimeMessage.Visible = false;
        }

        private void pDateMessage_Click(object sender, EventArgs e)
        {
            dtpDate.Focus();
        }
    }
}
