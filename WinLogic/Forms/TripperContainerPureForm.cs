using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.WinLogic.Classes;

namespace Tripper.WinLogic.Forms
{
    public partial class TripperContainerPureForm : TripperPureBaseFrom
    {
        public event EventHandler AfterUpdate;

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
                     if (_displayedForm is TripperContainerPureForm)
                          _displayedForm.Close();
                     _displayedForm = value;
                }
                else 
                {
                    _displayedForm = value;
                }

                DisplayedFormList.Add(value);
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
            bool canBeClosed = true;
            foreach (TripperPureBaseFrom form in DisplayedFormList)
            {
                if (!form.CanBeClosed())
                {
                    canBeClosed = false;
                }
            }

            return canBeClosed;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.DisplayedFormList.Clear();
        }

        protected virtual void OnAfterUpdate(EventArgs e)
        {
            EventHandler handler = AfterUpdate;
            if (handler != null)
            {
                handler(this, e);
            }
        }

    }
}
