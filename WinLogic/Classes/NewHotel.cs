using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.DbLogic.LinqToSQL;

namespace Tripper.WinLogic.Classes
{
    class NewHotel
    {
        static int numberOfCheckInfNotEmptyExecution = 0;
        public static Stayment AddNewHotel(String hotelName, String hotelAddress, 
            String hotelPhoneNumber, String additionalInfo, DateTime arrivalDate, DateTime dispatchDate, Decimal hotelCost)
        {
            Stayment newHotel = new Stayment();

            newHotel.Name = hotelName;
            newHotel.Address = hotelAddress;
            newHotel.DateFrom = arrivalDate;
            newHotel.DateTo = dispatchDate;
            newHotel.CreateDate = DateTime.Today;
            newHotel.AdditionalInformation = additionalInfo;
            newHotel.ModifiedDate = newHotel.CreateDate;
            newHotel.Cost = hotelCost;

            return newHotel;
        }

        private static String checkIfNotEmpty(String temporaryString)
        {
            if (temporaryString != "" && (numberOfCheckInfNotEmptyExecution == 1 || numberOfCheckInfNotEmptyExecution == 2 ||
                numberOfCheckInfNotEmptyExecution == 3) )
                return temporaryString;
            else
                switch (numberOfCheckInfNotEmptyExecution)
                {
                    case 1:
                        MessageBox.Show("Podaj nazwę hotelu");
                        numberOfCheckInfNotEmptyExecution = 0;
                        return null;
                    case 3:
                        MessageBox.Show("Data przybycia jest pusta");
                        numberOfCheckInfNotEmptyExecution = 0;
                        return null;
                    case 4:
                        MessageBox.Show("Data wyjazdu jest pusta");
                        numberOfCheckInfNotEmptyExecution = 0;
                        return null;
                    default:
                        return null;

                }
         } 
    }
}
