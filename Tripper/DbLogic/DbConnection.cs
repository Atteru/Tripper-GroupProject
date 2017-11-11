using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripper.DbLogic.LinqToSQL;

namespace Tripper.DbLogic
{
    public sealed class Connection
    {

        // Instancja klasy TripperDataDataContext - Connection.TriperData pozwala na odwoływanie się do obiektów bazy dalnych za pomocą metod LINQ
        // Zrealizowana w formie singletona 

        private static TripperDataDataContext _tripperData = null;
        private static readonly object _PadLock = new object();

        public static TripperDataDataContext TripperData
        {
            get
            {
                lock (_PadLock)
                {
                    if (_tripperData == null)
                    {
                        _tripperData = new TripperDataDataContext();
                    }
                    return _tripperData;
                }
            }
        }


    }
}
