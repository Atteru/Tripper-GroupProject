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
    public partial class TripperPureBaseFrom : Form
    {
        protected List<TripperPureBaseFrom> DisplayedFormList = new List<TripperPureBaseFrom>();

        public TripperPureBaseFrom()
        {
            InitializeComponent();
        }

        public virtual bool CanBeClosed()
        {
            return true;
        }

        public virtual void GoBackToParent()
        {
            
        }

        protected void CloseDisplayedForms()
        {
           int count = DisplayedFormList.Count;
           for (int i = 0; i<count; i++)
               DisplayedFormList[0].GoBackToParent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if(this.ParentForm != null)
            {
                TripperPureBaseFrom parentForm = this.ParentForm as TripperPureBaseFrom;
                parentForm.DisplayedFormList.Remove(this);
            }
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            Form form = this.ParentForm;
            if (form is TripperContainerPureForm)
            {
                TripperContainerPureForm ParentForm = form as TripperContainerPureForm;
                ParentForm.DisplayedForm = this;
            }
        }

    }
}
