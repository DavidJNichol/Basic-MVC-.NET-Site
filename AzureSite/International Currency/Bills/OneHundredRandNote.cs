using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.International_Currency
{
    public class OneHundredRandNote : SouthAfricanCoin
    {
        public OneHundredRandNote()
        {
            this.MonetaryValue = 100M;
            this.Name = "One Hundred Rand";
            this.Portait = "Nelson Mandela";
        }
    }
}
