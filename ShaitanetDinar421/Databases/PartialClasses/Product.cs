using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaitanetDinar421.Databases
{
    public partial class Product
    {
        public string PriceString
        {
            get { return $"{((decimal)Price).ToString("N2")} руб."; }
        }
    }
}
