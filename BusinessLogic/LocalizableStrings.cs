using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;

namespace Tripper.BusinessLogic
{
    public static class LocalizableStrings
    {
        #region Vehicles

        public const string Plane = "Samolot";
        public const string Car = "Samochód";
        public const string Public = "Transport publiczny";
        public const string OtherVehicle = "Inne";

        #endregion



        public static class GetValue
        {
            #region LocalizeVehicles

            public static Vehicle GetVehicle(string vehicle)
            {
                  return Connection.TripperData.Vehicles.Single(v => v.Name == vehicle);
            }
            #endregion
        }

    }
}

