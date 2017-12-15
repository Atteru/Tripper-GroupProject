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
    public partial class TripperContainerPureForm : TripperPureBaseFrom
    {
        private TripperPureBaseFrom _displayedForm;
        public TripperPureBaseFrom DisplayedForm
        {
            get
            {
                return _displayedForm;
            }
            set
            {
                if (_displayedForm != null)
                {
                    if (_displayedForm.CanBeClosed())
                    {
                        _displayedForm.Close();
                        _displayedForm = value;
                    }
                }
                else if(_displayedForm == null)
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


        public override bool CanBeClosed()
        {
            if (DisplayedForm != null)
                return DisplayedForm.CanBeClosed();

            return true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (DisplayedForm != null)
                DisplayedForm.Close();
        }

    }
}
