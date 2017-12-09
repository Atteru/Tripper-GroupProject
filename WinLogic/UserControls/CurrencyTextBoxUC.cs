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
    public partial class CurrencyTextBoxUC : UserControl
    {
        public CurrencyTextBoxUC()
        {
            InitializeComponent();
            base.AutoScaleMode = AutoScaleMode.None;
        }

        // Property Content odnosi się do textBoxa zawartego w kotrolce
        public TextBox Content
        {
            get
            {
                return textBox;
            }
        }

        [Browsable(true)]
        public override string Text
        {
            get
            {
                return textBox.Text;
            }

            set
            {
                textBox.Text = value;
            }
        }

        [Browsable(true)]
        public new bool Enabled
        {
            get
            {
                return textBox.Enabled && messageLabel.Enabled;
            }
            set
            {
                textBox.Enabled = messageLabel.Enabled = value;
                if (!textBox.Enabled)
                    messageLabel.BackColor = SystemColors.Control;
                else
                    messageLabel.BackColor = SystemColors.Window;
            }
        }


        // Property Message odnosi się do labela zawartego w kotrolce
        // label służy do wyświetlania komunikatów na textboxie w stylu: "Podaj imię"
        // Docelowo label będzie obsługiwał walidację danych
        public Label Message
        {
            get
            {
                return messageLabel;
            }
        }

        // Property ustawia widoczność komunikatu
        public bool MessageVisibility
        {
            get
            {
                return messageLabel.Visible;
            }

            set
            {
                messageLabel.Visible = value;
            }
        }

        // Tekst jaki zostanie wyświetlony na labelu
        [Browsable(true)]
        public string LabelMessage
        {
            get
            {
                return messageLabel.Text;
            }

            set
            {
                messageLabel.Text = value;
            }
        }


        private Font _Font = DefaultFont;
        [Bindable(true)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font
        {
            get { return _Font; }
            set
            {
                _Font = base.Font = value;
                this.textBox.Font = _Font;
                this.messageLabel.Font = _Font;
            }
        }

        public Decimal Value
        {
            get
            {
                return Decimal.Parse(textBox.Text);
            }
        }

        public void GetData(decimal value)
        {
              MessageVisibility = false;
              Text = value.ToString();
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tbox = sender as TextBox;
            if (tbox.Text == string.Empty || tbox.Text == "0,00")
            {
                MessageVisibility = true;
            }
        }



        private void messageLabel_Click(object sender, EventArgs e)
        {
            if (MessageVisibility == true)
                MessageVisibility = false;
            textBox.Focus();
        }


        private void textBox_MessageLabelHide(object sender, EventArgs e)
        {
            if (MessageVisibility == true)
                MessageVisibility = false;
        }

    }
}
