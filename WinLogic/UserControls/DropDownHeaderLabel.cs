using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripper.WinLogic.UserControls
{
    public partial class DropDownHeaderLabel : Label
    {

        public DropDownHeaderLabel()
        {
            InitializeComponent();
            Text = "";
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (Enabled)
                _borderColor = SystemColors.WindowFrame;
            else
                _borderColor = Color.Silver ;

        }


        private Color _borderColor = SystemColors.WindowFrame;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        private static int WM_PAINT = 0x000F;


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

                if (m.Msg == WM_PAINT)
                {
                    Graphics g = Graphics.FromHwnd(Handle);
                    Rectangle bounds = new Rectangle(0, 0, Width, Height);
                    ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);
               }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

  

        private void DropDownHeaderLabel_Leave(object sender, EventArgs e)
        {
            _borderColor = SystemColors.WindowFrame;
        }

        private void DropDownHeaderLabel_Click(object sender, EventArgs e)
        {
            _borderColor = SystemColors.Highlight;
            Focus();
        }
    }
}
