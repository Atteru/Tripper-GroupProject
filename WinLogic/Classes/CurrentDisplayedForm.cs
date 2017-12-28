using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.WinLogic.Forms;

namespace Tripper.WinLogic.Classes
{
    static class CurrentDisplayedForm
    {
        public static TripperPureBaseFrom CurrentForm
        {
            get;
            set;
        }

        public static TripperPureBaseFrom CurentFormParent
        {
            get;
            set;
        }

    }
}
