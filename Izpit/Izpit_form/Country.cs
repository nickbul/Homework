using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit_form
{
    public class Country
    {
        public string Countr { get; set; }

        public string Capital { get; set; }

        public long Population { get; set; }

        public string CastToDataBaseRow()
        {
            return string.Format("{0}|{1}|{2}", this.Countr, this.Capital, this.Population);
        }
    }
}
