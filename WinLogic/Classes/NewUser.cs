using System;
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
        public static User AddNewUser(string userAccountName,string userPassword, string userPasswordConfirm)//, string userName)
        {
            if (userAccountName == "" || userPassword == "" || userPasswordConfirm == "")// userName != "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
                return null;
            }
            foreach (User user in Connection.TripperData.Users)
            { 
                if ((String.Compare(user.Login, userAccountName, true) == 0))
                {
                    MessageBox.Show("Użytkownik o podanej nazwie już istnieje");
                    return null;
                }
            }
            User newUser = new User();

            newUser.Login = userAccountName;
            newUser.Password = userPassword;
            //newUser.Name = userName;
            MessageBox.Show("Użytkownik " + newUser.Login.ToString() + " został stwożony");
            return newUser;
        }
     
    }
}
