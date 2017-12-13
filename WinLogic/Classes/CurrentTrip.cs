﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;
using System.Linq.Expressions;
using System.ComponentModel;

namespace Tripper.WinLogic.Classes
{
    public static class CurrentTrip 
    {
        private static Trip _trip;
        public static Trip Trip
        {
            get
            {
                return _trip;
            }
            set
            {
                _trip = value;
            }
        }

    }
}