using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace Tripper.WinLogic.UserControls
{
    class DatePickerUC : DateTimePicker
    {
        private ComboBoxState btnvisualState = ComboBoxState.Normal;
        private Rectangle buttonRectangle;

        public DatePickerUC()
        {
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            buttonRectangle = new Rectangle(this.ClientRectangle.Width - 25, 0, 25, this.ClientRectangle.Height);
            this.ValueChanged += datePickerUC_ValueChanged;

        }

        private void datePickerUC_ValueChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {

                if (buttonRectangle.Contains(e.Location))
                {
                    btnvisualState = ComboBoxState.Hot;
                }
                else if (btnvisualState == ComboBoxState.Hot)
                {
                    btnvisualState = ComboBoxState.Normal;
                }
            
            base.OnMouseMove(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (this.Enabled & e.Button == MouseButtons.Left)
            {

                if (buttonRectangle.Contains(e.Location))
                {
                    btnvisualState = ComboBoxState.Pressed;
                    this.Refresh();
                }

            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            if (this.Enabled)
            {
                btnvisualState = ComboBoxState.Normal;
            }
            base.OnMouseLeave(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (this.Enabled & e.Button == MouseButtons.Left)
            {
                if (buttonRectangle.Contains(e.Location))
                {
                    btnvisualState = ComboBoxState.Normal;
                    this.Refresh();
                }
            }
            base.OnMouseUp(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            buttonRectangle = new Rectangle(this.ClientRectangle.Width - 20, 0, 20, this.ClientRectangle.Height);
            this.Refresh();
            base.OnSizeChanged(e);
        }


        protected override void OnPaint(PaintEventArgs e)
        {

            Color textColor = Color.Red;
            if (this.Focused)
            {
                textColor = SystemColors.HighlightText;

            }

            e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });
            ComboBoxRenderer.DrawDropDownButton(e.Graphics, buttonRectangle, btnvisualState);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
        }


    }
}
