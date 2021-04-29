using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.International_Currency
{
    public class OneRandCoin : SouthAfricanCoin
    {
        public OneRandCoin()
        {
            this.MonetaryValue = 1M;
            this.Name = "One Rand";
            this.Portait = "Springbok";
        }
    }
}
