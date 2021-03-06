﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;

namespace Tripper.WinLogic.Classes
{
    class NewUser
    {
        public static Traveler AddNewUser(string userAccountName,string userPassword, string userPasswordConfirm, string userName)
        {
            if (userAccountName == "" || userPassword == "" || userPasswordConfirm == "" || userName == "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
                return null;
            }
            if (userPassword.Length < 8)
            {
                MessageBox.Show("Hasło musi mieć conajmniej 8 znaków");
                return null;
            }
            if (userPassword.Any(c => char.IsUpper(c)) == false || userPassword.Any(c => char.IsDigit(c)) == false)
            {
                MessageBox.Show("Hasło musi zawierać conajmniej jedną wielką literę i cyfrę");
                return null;
            }
            if (userAccountName.Length < 6)
            {
                MessageBox.Show("Nazwa użytkownika musi zawierać conajmniej 6 znaków");
                return null;
            }

            
            foreach (Traveler user in Connection.TripperData.Travelers)
            { 
                if ((String.Compare(user.Login, userAccountName, true) == 0))
                {
                    MessageBox.Show("Użytkownik o podanej nazwie już istnieje");
                    return null;
                }
            }
            Traveler newUser = new Traveler();

            newUser.Login = userAccountName;
            newUser.Password = userPassword;
            MessageBox.Show("Użytkownik " + newUser.Login.ToString() + " został stwożony");
            return newUser;
        }
     
    }
}
