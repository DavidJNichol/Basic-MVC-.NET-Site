using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    public class DollarCoin : USCoin
    {
        public DollarCoin(USCoinMintMark MintMark)
        {
            this.MonetaryValue = 1M;
            this.Name = "Dollar";
        }

        public DollarCoin() 
        {
            this.MonetaryValue = 1M;
            this.Name = "Dollar";
        }
    }
}