using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.International_Currency
{
    public class FiftyCentRandCoin : SouthAfricanCoin
    {
        public FiftyCentRandCoin()
        {
            this.MonetaryValue = .5M;
            this.Name = "Fifty Cents Rand";
            this.Portait = "Crane Flower";
        }
    }
}
