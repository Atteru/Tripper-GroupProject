using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripper.WinLogic.UserControls
{
    class CustomDateTimePicker : DateTimePicker
    {

            protected override bool ShowFocusCues
            {
                get
                {
                    return false;
                }
            }

        

    }
}
