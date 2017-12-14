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
                return EnabledDate && EnabledTime;
            }
            set
            {
                EnabledDate = EnabledTime = value;
            }
        }

        [Browsable(true)]
        public bool EnabledDate
        {
            get
            {
                return dtpDate.Enabled && pDateMessage.Enabled && lDateMessage.Enabled;
            }
            set
            {
                dtpDate.Enabled = pDateMessage.Enabled = lDateMessage.Enabled = value;
            }
        }

        [Browsable(true)]
        public bool EnabledTime
        {
            get
            {
                return dtpTime.Enabled && pTimeMessage.Enabled && lTimeMessage.Enabled;
            }
            set
            {
                dtpTime.Enabled = pTimeMessage.Enabled = lTimeMessage.Enabled = value;
            }
        }

        private bool _isSelected = false;

        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }
        }

        public DateTimeUC()
        {
            InitializeComponent();
            base.AutoScaleMode = AutoScaleMode.None;
            this.EnabledTime = false;
            dtpTime.CustomFormat = "\tHH:mm";
        }

        public void GetDate(DateTime? date)
        {
            if(date != null)
            {
                pDateMessage.Visible = pTimeMessage.Visible = false;
                DateTime tempDate = (DateTime)date;
                dtpDate.Value = dtpTime.Value = tempDate;
                _isSelected = true;
            }
        }

        public DateTime? Value()
        {
            if(_isSelected)
                return DateTime.Parse(this.Date.Text + " " + this.Time.Text + ":00");
            return null;
        }

 


        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (pDateMessage.Visible)
                pDateMessage.Visible = false;

            if (!_isSelected)
            {
                _isSelected = true;
                EnabledTime = true;
            }
            this.Refresh();
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

        private void drawWarningBoeder(object sender)
        {
            DateTimePicker combo = sender as DateTimePicker;

            Graphics g = this.CreateGraphics();

            Pen blackPen = new Pen(Color.Firebrick, 4);
            int x = combo.Location.X;
            int y = combo.Location.Y;
            int width = combo.Width;
            int height = combo.Height;

            g.DrawRectangle(blackPen, x, y, width, height);
            g.Dispose();
        }

        public bool IsLaterThanValidation(DateTime? date)
        {
            if(date <= this.Value())
            {
                return true;
            }

            drawWarningBoeder(dtpDate);
            drawWarningBoeder(dtpTime);
            return false;
        }

        public bool CheckValidation()
        {
            if (Value() == null)
            {
                drawWarningBoeder(dtpDate);
                drawWarningBoeder(dtpTime);
                return false;
            }
            return true;
        }
    }
}
