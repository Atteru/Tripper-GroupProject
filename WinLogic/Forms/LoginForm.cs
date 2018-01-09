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
using Tripper.WinLogic.Classes;
using Tripper.WinLogic.UserControls;
using Tripper.BusinessLogic;

namespace Tripper.WinLogic.Forms
{
    public partial class LoginForm : TripperDetailsEditPureForm
    {
        private Traveler _selectedTraveler;
        public Traveler SelectedTraveler
        {
            get
            {
                return _selectedTraveler;
            }
            private set
            {
                _selectedTraveler = value;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
            Mode = CreatorMode.AddNew;
            tcLogin.Appearance = TabAppearance.FlatButtons;
            tcLogin.ItemSize = new Size(0, 1);
            tcLogin.SizeMode = TabSizeMode.Fixed;
            tPassword.PasswordChar = true;
            tNewPassword.PasswordChar = true;
            tNewPasswordConfirm.PasswordChar = true;
        }

        public LoginForm(Traveler traveler)
        {
            InitializeComponent();
            Mode = CreatorMode.Edit;
            SelectedTraveler = traveler;
            tcLogin.Appearance = TabAppearance.FlatButtons;
            tcLogin.ItemSize = new Size(0, 1);
            tcLogin.SizeMode = TabSizeMode.Fixed;
            tcLogin.SelectedTab = ChPassword;

            tChPasswordCurrent.PasswordChar = true;
            tChPasswordPassword.PasswordChar = true;
            tChPasswordConfirm.PasswordChar = true;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if(checkLoginValidation())
            {
                this.Hide();
                SplashForm.ShowSplashScreen();
                MainForm welcome = new MainForm(SelectedTraveler);
                CurrentSelected.Traveler = SelectedTraveler;
                SplashForm.CloseForm();
                welcome.ShowDialog();
                this.Close();
            }
        }

        private void bNewAdd_Click(object sender, EventArgs e)
        {
            if (checkNewValidation())
            {
                Traveler traveler = new Traveler();
                traveler.Login = tNewUserName.Text;
                traveler.Password = tNewPassword.Text;

                Connection.TripperData.Travelers.InsertOnSubmit(traveler);
                confirmChanges("Czy chcesz dodać użytkownika?", closeAfterAdd: false);
                this.Hide();
                MainForm welcome = new MainForm(traveler);
                welcome.ShowDialog();
                this.Close();
            }
        }


        private void bChPasswordConfirm_Click(object sender, EventArgs e)
        {
            if(checkChangePasswordValidation())
            {
                SelectedTraveler.Password = tChPasswordPassword.Text;
                confirmChanges("");
                this.Close();
            }
        }


        private bool checkLoginValidation()
        {
            if(!chceckValidationForTexBoxParams(tUserName, tPassword))
            {
                showErrorMesage(lError, "Uzupełnij wszystkie pola");
                return false;
            }
            else
            {
                if (!Connection.TripperData.Travelers.Any(t => t.Login == tUserName.Text))
                {
                    tUserName.DrawWarningBoeder();
                    showErrorMesage(lError, "Użytkownik o podanym loginie nie istnieje");
                    return false;
                }
                else
                {
                    SelectedTraveler = Connection.TripperData.Travelers.Single(t => t.Login == tUserName.Text);
                }

                if (!(String.Compare(SelectedTraveler.Password, tPassword.Text, false) == 0))
                {
                    tPassword.DrawWarningBoeder();
                    showErrorMesage(lError, "Nieprawidłowe hasło");
                    return false;
                }
            }


            return true;
        }

        private bool checkNewValidation()
        {
            if (!chceckValidationForTexBoxParams(tNewUserName, tNewPassword, tNewPasswordConfirm))
            {
                showErrorMesage(lNewError, "Uzupełnij wszystkie pola");
                return false;
            }
            else
            {
                if (Connection.TripperData.Travelers.Any(t => t.Login == tNewUserName.Text))
                {
                    tUserName.DrawWarningBoeder();
                    showErrorMesage(lNewError, "Użytkownik o podanej nazwie już istnieje");
                    return false;
                }
                else if (tNewPassword.Text != tNewPasswordConfirm.Text)
                {
                    tNewPasswordConfirm.DrawWarningBoeder();
                    showErrorMesage(lNewError, "Podane hasła są różne");
                    return false;
                }
            }
            

            return true;
        }

        private bool checkChangePasswordValidation()
        {

            if (!chceckValidationForTexBoxParams(tChPasswordCurrent, tChPasswordPassword, tChPasswordConfirm))
            {
                showErrorMesage(lChPasswordError, "Uzupełnij wszystkie pola");
                return false;
            }
            else
            {
                if (tChPasswordCurrent.Text != SelectedTraveler.Password)
                {
                    tChPasswordCurrent.DrawWarningBoeder();
                    showErrorMesage(lChPasswordError, "Nieprawidłowe hasło");
                    return false;
                }
                else if(tChPasswordPassword.Text != tChPasswordConfirm.Text)
                {
                    tChPasswordConfirm.DrawWarningBoeder();
                    showErrorMesage(lChPasswordError, "Podane hasła są różne");
                    return false;
                }
            }
            return true;
        }

        private bool chceckValidationForTexBoxParams(params TextBoxUC[] textBoxList )
        {
            bool result = true;
            foreach (TextBoxUC textBox in textBoxList)
            {
                if(!textBox.CheckValidation())
                {
                    result =  false;
                }
            }
            return result;
        }

        private void llNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tcLogin.SelectedTab = tabNewAccount;
            tUserName.Reset();
            tPassword.Reset();
        }

        private void bAddNewUser_Click(object sender, EventArgs e)
        {
            Traveler newUser = new Traveler();
            newUser = NewUser.AddNewUser(tNewUserName.Text, tNewPassword.Text, tNewPasswordConfirm.Text, tNewUserName.Text);
            if (newUser != null) { 
                Connection.TripperData.Travelers.InsertOnSubmit(newUser);
                Connection.TripperData.SubmitChanges();
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            tcLogin.SelectedTab = tabLogin;
        }

        private void bNewCancel_Click(object sender, EventArgs e)
        {
            tcLogin.SelectedTab = tabLogin;
            tNewUserName.Reset();
            tNewPassword.Reset();
            tNewPasswordConfirm.Reset();
        }

        private void showErrorMesage(Label label, string message)
        {
            var t = new Timer();
            label.Text = message;
            label.Visible = true;
            t.Interval = 5000; 
            t.Tick += (s, e) =>
            {
                label.Hide();
                t.Stop();
            };
            t.Start();
        }

        private void bChPasswordCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bLoginCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
