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
        public event EventHandler AfterUpdate;

        public ListRowPureControl()
        {
            InitializeComponent();
        }

        protected virtual string SetInfo()
        {
            return string.Empty;
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
