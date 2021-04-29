using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.International_Currency
{
    public class TwoHundredRandNote : SouthAfricanCoin
    {
        public TwoHundredRandNote()
        {
            this.MonetaryValue = 200M;
            this.Name = "Two Hundred Rand";
            this.Portait = "Nelson Mandela";
        }
    }
}
