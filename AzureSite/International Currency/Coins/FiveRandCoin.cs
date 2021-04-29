using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.International_Currency
{
    public class FiveRandCoin : SouthAfricanCoin
    {
        public FiveRandCoin()
        {
            this.MonetaryValue = 5M;
            this.Name = "Five Rand";
            this.Portait = "White-Tailed Gnu";
        }
    }
}
