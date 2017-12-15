using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.DbLogic.LinqToSQL;

namespace Tripper.WinLogic.Classes
{
    class NewHotel
    {
        public static Stayment AddNewHotel(String hotelName, String hotelAddress,
            String hotelPhoneNumber, String additionalInfo, DateTime  arrivalDate, DateTime dispatchDate, int tripID)
        {
            Stayment newHotel = new Stayment();
            newHotel.TripID = tripID;

            newHotel.Name = hotelName;
            newHotel.Address = hotelAddress;
            
            newHotel.DateTo = dispatchDate; //can't add if datafield is empty as control does not return default valuea valid for DateTime, instead it return Now or Today
            newHotel.DateFrom = arrivalDate; //same as line above

            newHotel.CreateDate = DateTime.Now;
            newHotel.AdditionalInformation = additionalInfo;
            newHotel.ModifiedDate = newHotel.CreateDate;

            return newHotel;
        }

        
    }
}