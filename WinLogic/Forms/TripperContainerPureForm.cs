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
    public partial class TripperContainerPureForm : Form
    {
        private Form _displayedForm;
        public Form DisplayedForm
        {
            get
            {
                return _displayedForm;
            }
            set
            {
                _displayedForm = value;
            }
        }


        public void DockForm(Control parentPanel)
        {
            this.TopLevel = false;
            this.Parent = parentPanel;
            this.Dock = DockStyle.Fill;
            this.Show();
        }

    }
}
