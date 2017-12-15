using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.BusinessLogic;

namespace Tripper.WinLogic.Forms
{
    public partial class TripperDetailsEditPureForm : TripperPureBaseFrom
    {
        protected CreatorMode mode;
        protected CreatorStatus cratorStatus; 


        private bool _editable;
        public bool Editable
        {
            set
            {
                changeEditable(value);
                _editable = value;

            }
            get
            {
                return _editable;
            }
        }

        protected virtual void changeEditable(bool value)
        {

        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            Form form = this.ParentForm;
            if(form is TripperContainerPureForm)
            {
                TripperContainerPureForm ParentForm = form as TripperContainerPureForm;
                ParentForm.DisplayedForm = this;
            }
        }

        public override bool CanBeClosed()
        {
            if(mode == CreatorMode.AddNew && cratorStatus == CreatorStatus.Edit)
            {
               DialogResult result = TripperMessageBox.Show("Czy czcesz wyjść bez zapisana zmian?", "Czy napewno?");
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (cratorStatus == CreatorStatus.Confirmed)
                cratorStatus = CreatorStatus.Edit;
        }


    }
}
