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
using Tripper.DbLogic;

namespace Tripper.WinLogic.Forms
{
    public partial class TripperDetailsEditPureForm : TripperPureBaseFrom
    {
        public event EventHandler AfterUpdate;

        public CreatorMode Mode
        {
            get;
            protected set;

        }
        public CreatorStatus Status
        {
            get;
            protected set;
        }

        protected string AddNewMessage;
        protected string EditMessage;

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


        public override bool CanBeClosed()
        {
            base.CanBeClosed();

            if (Mode == BusinessLogic.CreatorMode.AddNew && Status == CreatorStatus.Edit)
            {
                DialogResult result = TripperMessageBox.Show("Czy czcesz wyjść bez zapisana zmian?", "Czy napewno?");
                if (result != DialogResult.Yes)
                {
                    return false;
                }
            }
            return true;
        }

        public void confirmChanges(string newAddMessage, string editMessage = "Zapisać zmiany?", bool closeAfterAdd = true)
        {
            DialogResult result;
            if (Mode == CreatorMode.AddNew)
                result = TripperMessageBox.Show(newAddMessage, "");
            else
                result = TripperMessageBox.Show(editMessage, "");

            if (result == DialogResult.Yes)
            {
                try
                {
                    Connection.TripperData.SubmitChanges();
                    Status = CreatorStatus.Confirmed;
                    OnAfterUpdate(EventArgs.Empty);
                }
                catch (Exception exept)
                {
                    TripperMessageBox.Show(exept.ToString(), "Błąd");
                }

                if (Mode == BusinessLogic.CreatorMode.AddNew && closeAfterAdd)
                    this.Close();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (Status == CreatorStatus.Confirmed)
                Status = CreatorStatus.Edit;
            //this.Parent.Visible = false;
        }

        protected override void OnDockChanged(EventArgs e)
        {
            base.OnDockChanged(e);
            this.Parent.Height = this.Height;
            this.Parent.Refresh();
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
