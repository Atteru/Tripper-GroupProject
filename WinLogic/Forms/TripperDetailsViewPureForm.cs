using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tripper.BusinessLogic;

namespace Tripper.WinLogic.Forms
{
    public partial class TripperDetailsViewPureForm : Tripper.WinLogic.Forms.TripperContainerPureForm
    {
        private DetailsViewMode _mode;
        public DetailsViewMode Mode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode = value;
            }
        }

        public TripperDetailsViewPureForm()
        {
            InitializeComponent();
        }

        public override void GoBackToParent()
        {
            switch (Mode)
            {
                case DetailsViewMode.ListView:
                    this.ParentForm.Close();
                    break;
                case DetailsViewMode.AddNew:
                    CloseDisplayedForms();
                    break;
            }
        }
    }
}
