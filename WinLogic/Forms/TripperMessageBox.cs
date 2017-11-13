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
    public partial class TripperMessageBox : Form
    {
        public TripperMessageBox()
        {
            InitializeComponent();
            
        }

        static TripperMessageBox MsgBox;
        static DialogResult result = DialogResult.No;
        public static DialogResult Show(string text, string caption)
        {
            MsgBox = new TripperMessageBox();
            MsgBox.lMessage.Text = text;
            MsgBox.Text = caption;
            MsgBox.ShowDialog();
            MsgBox.lMessage.Left = MsgBox.panel1.Width / 2 - MsgBox.lMessage.Width / 2;
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MsgBox.Close();
        }


    }
}
