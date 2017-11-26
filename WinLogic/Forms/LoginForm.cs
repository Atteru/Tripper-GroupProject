using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;

namespace Tripper.WinLogic.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // Ustawienia startowe TabControl - pozwalają na schowanie przycisków stron
            tcLogin.Appearance = TabAppearance.FlatButtons;
            tcLogin.ItemSize = new Size(0, 1);
            tcLogin.SizeMode = TabSizeMode.Fixed;
            tPassword.PasswordChar = true;
            tNewPassword.PasswordChar = true;
            tNewPasswordConfirm.PasswordChar = true;

        }


        private void bLogin_Click(object sender, EventArgs e)
        {
            tUserName.Text = "user";
            tPassword.Text = "user";

            foreach (Traveler u in Connection.TripperData.Travelers)
            {
                // Metoda Compare(string1, string2, wielkośćZnaków) zwraca 0 jeśli łańcuchy są takie same
                if ((String.Compare(u.Login, tUserName.Text, true) == 0) && (String.Compare(u.Password, tPassword.Text, false) == 0))
                {
                    this.Hide();
                    //MainForm welcome = new MainForm(u.UserID);
                    MainForm welcome = new MainForm();
                    welcome.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Błędna nazwa użytkownika lub hasło");
                }
            }
        }
        // pilnuje położenia palenu logowania na środku formy
        private void LoginForm_ClientSizeChanged(object sender, EventArgs e)
        {
            pLogin.Left = (this.ClientSize.Width - pLogin.Width) / 2;
            pLogin.Top = (this.ClientSize.Height - pLogin.Height) / 2;
            pNewAccount.Left = (this.ClientSize.Width - pNewAccount.Width) / 2;
            pNewAccount.Top = (this.ClientSize.Height - pNewAccount.Height) / 2;
        }

        private void llNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tcLogin.SelectedTab = tabNewAccount;
        }

        private void bAddNewUser_Click(object sender, EventArgs e)
        {
            tcLogin.SelectedTab = tabLogin;
        }

    }
}
