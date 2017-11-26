using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;

using System.Reflection;
using System.Linq.Expressions;
using System.ComponentModel;

namespace Tripper.WinLogic.Classes
{
    public class NewTrip 
    {
        private string _tipName;
        public string TripName
        {
            get
            {
                return _tipName;
            }
            set
            {
                _tipName = value;
            }
        }

        public List<NewTransport> transportList;


        public void SetValueFormField(string field, string propertyName, string errorMessage)
        {
             Type myType = typeof(NewTrip);
             PropertyInfo propertyInfo = myType.GetProperty(propertyName);
             propertyInfo.SetValue(this, field, null);      
        }




    }
}