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
            textBox.Text = "";
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
                messageLabel.Visible = false;
            }
        }

        [Browsable(true)]
        public bool ReadOnly
        {
            get
            {
                return textBox.ReadOnly;
            }

            set
            {
                textBox.ReadOnly = value;
            }
        }


        public bool Multiline
        {
            get
            {
                return textBox.Multiline;
            }

            set
            {
                textBox.Multiline = value;
            
            }
        }

        public Label Label
        {
            get
            {
                return messageLabel;
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

        public void GetData<T>(T value)
        {
            if(value != null)
            {
                MessageVisibility = false;
                Text = value.ToString();
            }
        }


        // Property Message odnosi się do labela zawartego w kotrolce
        // label służy do wyświetlania komunikatów na textboxie w stylu: "Podaj imię"
        // Docelowo label będzie obsługiwał walidację danych



        // Property ustawia widoczność komunikatu
        private bool _messageVisibility;
        public bool MessageVisibility
        {
            get
            {
                return _messageVisibility;
            }
            set
            {
                _messageVisibility = value;
                if (_messageVisibility && textBox.Text == string.Empty)
                    messageLabel.Visible = true;
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

     /*   [Bindable(true)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public TextAlignment TextAlignment
        {
            get { return ; }
            set
            {
                _Font = base.Font = value;
                this.textBox.Font = _Font;
                this.messageLabel.Font = _Font;
            }
        } */


        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tbox = sender as TextBox;
            if (tbox.Text == string.Empty && MessageVisibility && !messageLabel.Visible)
            {
                 messageLabel.Visible = true;
            }
        }


        private void messageLabel_Click(object sender, EventArgs e)
        {
            Refresh();
            if (MessageVisibility && messageLabel.Visible)
                messageLabel.Visible = false;
            textBox.Focus();
        }

        public void DrawWarningBoeder()
        {

            Graphics g = this.CreateGraphics();

            Pen blackPen = new Pen(Color.Firebrick, 2);
            int x = textBox.Location.X;
            int y = textBox.Location.Y;
            int width = textBox.Width;
            int height = textBox.Height;

            g.DrawRectangle(blackPen, x, y, width, height);
            g.Dispose();
        }

        public void Reset()
        {
            textBox.Text = string.Empty;
            messageLabel.Visible = true;
        }

        public bool CheckValidation()
        {
            if (this.Text == string.Empty)
            {
                DrawWarningBoeder();
                return false;
            }
            return true;
        }

    }
}
