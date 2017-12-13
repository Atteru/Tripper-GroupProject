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
    public partial class TripperDetailsEditPureForm : Form
    {
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


    }
}
