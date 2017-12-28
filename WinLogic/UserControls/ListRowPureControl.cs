using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripper.WinLogic.UserControls
{
    public partial class ListRowPureControl : UserControl
    {
        public ListRowPureControl()
        {
            InitializeComponent();
        }

        protected virtual string SetInfo()
        {
            return string.Empty;
        }
    }
}
