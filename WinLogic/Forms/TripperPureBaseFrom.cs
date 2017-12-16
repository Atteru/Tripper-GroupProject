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
    public partial class TripperPureBaseFrom : Form
    {

        public TripperPureBaseFrom()
        {
            InitializeComponent();
            AlreadyOpened = true;
        }

        public bool AlreadyOpened
        {
            get; set;
        }

        virtual public bool CanBeClosed()
        {
            return true;
        }

    }
}
