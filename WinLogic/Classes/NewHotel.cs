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
            String hotelPhoneNumber, String additionalInfo, DateTime arrivalDate, DateTime dispatchDate, Decimal hotelCost)
        {
            Stayment newHotel = new Stayment();

            if (hotelName == "")
            {
                MessageBox.Show("Uzupełnij nazwę hotelu");
                return null;
            }
            else
                newHotel.Name = hotelName;
            newHotel.Address = hotelAddress;
            
            newHotel.DateTo = dispatchDate;
            newHotel.DateFrom = arrivalDate;

            newHotel.CreateDate = DateTime.Now;
            newHotel.AdditionalInformation = additionalInfo;
            newHotel.ModifiedDate = newHotel.CreateDate;
            newHotel.Cost = hotelCost;

            return newHotel;
        }

        public static bool CompareDateAndTime(DateTime first, DateTime second)
        {
            if (first.Date != second.Date)
            {
                return false;
            }
            if (first.Hour != second.Hour)
            {
                return false;
            }
            if (first.Minute != second.Minute)
            {
                return false;
            }
            if (first.Second != second.Second)
            {
                return false;
            }
            return true;
        }

    }
}