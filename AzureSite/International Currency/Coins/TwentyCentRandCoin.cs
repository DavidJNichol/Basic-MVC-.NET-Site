using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.International_Currency
{
    public class TwentyCentRandCoin : SouthAfricanCoin
    {
        public TwentyCentRandCoin()
        {
            this.MonetaryValue = .2M;
            this.Name = "Twenty Cents Rand";
            this.Portait = "King Protea Flower";
        }
    }
}
