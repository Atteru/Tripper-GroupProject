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
    public partial class MainForm : Form
    {
        public int UserID
        {
            get;
            private set;
        }
        

        public MainForm(int userId)
        {
            InitializeComponent();
            UserID = userId;

        }


    }
}
