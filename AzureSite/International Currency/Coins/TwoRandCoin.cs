using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.International_Currency
{
    public class TwoRandCoin : SouthAfricanCoin
    {
        public TwoRandCoin()
        {
            this.MonetaryValue = 2M;
            this.Name = "Two Rand";
            this.Portait = "Greater Kudu";
        }
    }
}
