using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.International_Currency
{
    public class TenCentRandCoin : SouthAfricanCoin
    {
        public TenCentRandCoin()
        {
            this.MonetaryValue = .10M;
            this.Name = "Ten Cents Rand";
            this.Portait = "Arum Lily Flower";
        }
    }
}
