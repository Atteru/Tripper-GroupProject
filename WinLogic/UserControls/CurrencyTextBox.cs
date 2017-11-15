using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripper.WinLogic.UserControls
{
    class CurrencyTextBox : TextBox
    {

        public CurrencyTextBox()
            :base()
        {
            this.KeyPress += tCurrency_KeyPress;
            this.Validating += tCurrency_Validating;
            this.Click += tCurrency_Click;
            this.Text = "0,00";

        }

        private void tCurrency_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!textBox.Text.Contains(","))
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void tCurrency_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == string.Empty)
                textBox.Text = "0,00";

            Decimal value;
            if (Decimal.TryParse(textBox.Text, out value))
            {
                textBox.Text = value.ToString("F");
            }
            else
            {
                textBox.Text = "0,00";
            }
        }

        private void tCurrency_Click(object sender, EventArgs e)
        {
            if(this.Text == "0,00")
             this.SelectAll();
        }

     

        private void tCurrency_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tCurrency_Validating(sender, null);
            }
        }
    }
}
