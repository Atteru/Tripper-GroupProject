using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;
using System.Linq.Expressions;

namespace Tripper.WinLogic.Classes
{
    public class NewTransport
    {
        private object _departureCountry;
        public object DepartureCountry
        {
            get;
            set;
        }

        private object _derprtureCity;
        public object DepartireCity
        {
            get;
            protected set;
        }

        private DateTime _departureTime;
        public DateTime DepartureTime
        {
            get;
            set;
        }

        private object _arrivalCountry;
        public object ArrivalCountry
        {
            get
            {
                return _arrivalCountry;
            }
            set
            {
                _arrivalCountry = value;
            }
        }

        private object _arrivalCity;
        public object ArrivalCity
        {
            get;
            set;
        }

        private DateTime _arrivalTime;
        public DateTime ArrivalTime
        {
            get;
            set;
        }

        private string _vehicle;
        public string Vehicle
        {
            get
            {
                return _vehicle;
            }
            set
            {
                _vehicle = value;
            }
        }

        private Decimal _ticetCost;
        public Decimal TicketCost
        {
            get
            {
                return _ticetCost;
            }
            set
            {
                _ticetCost = value;
            }
        }

        private Decimal _ticektOtherCosts;
        public Decimal TicektOtherCosts
        {
            get
            {
                return _ticektOtherCosts;
            }
            set
            {
                _ticektOtherCosts = value;
            }
        }

        public NewTransport()
        {
            this.DepartureCountry = Connection.TripperData.Countries.Single(country => country.CountryID.Equals("POL"));
        }

    }
}
