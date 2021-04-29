using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.International_Currency.Coins
{
    public class OneCentRandCoin : SouthAfricanCoin
    {
        public OneCentRandCoin()
        {
            MonetaryValue = .01M;
            Name = "One cent rand";
            Portait = "Two Birds";
        }
    }
}
