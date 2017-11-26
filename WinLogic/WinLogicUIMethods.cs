using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



namespace Tripper.DbLogic.LinqToSQL
{
    partial class Country
    {
        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }

    partial class Localization
    {
        public override string ToString()
        {
            return string.Format("{0}", City);
        }
    }
}


