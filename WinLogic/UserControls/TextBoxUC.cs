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
    public partial class TextBoxUC : UserControl
    {
        public TextBoxUC()
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

        [Browsable(true)]
        public bool PasswordChar
        {
            set
            {
                if (value == true)
                    textBox.PasswordChar = '*';
            }
        }

        private Font _Font = UserControl.DefaultFont;
        [Bindable(true)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font
        {
            get { return _Font; }
            set
            {
                _Font = value;
                messageLabel.Font = _Font;
                textBox.Font = _Font;
            }
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tbox = sender as TextBox;
            if (tbox.Text == string.Empty)
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

        private void textBox_Click(object sender, EventArgs e)
        {
            if (MessageVisibility == true)
                MessageVisibility = false;
        }
    }
}
