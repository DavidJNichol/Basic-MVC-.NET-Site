using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency.International_Currency;
using Currency.International_Currency.Coins;

namespace Currency
{
    public class SouthAfricanCoin : Coin
    {
        public SouthAfricanCoin()
        {
            this.Name = "SACoin";
            this.Portait = "Default SA Portrait";
            this.ReverseMotif = "Suid-Afrika";
        }

        public override string About()
        {
            string strAbout = $"{this.Name} is from { System.DateTime.Now.Year }. It is worth R {MonetaryValue}.";

            return "South African " + strAbout;
        }

        public static List<ICoin> GetSACoinList()
        {
            List<ICoin> coinList = new List<ICoin>()
            {
                new FiveRandCoin(),
                new TwoRandCoin(),
                new OneRandCoin(),
                new FiftyCentRandCoin(),
                new TwentyCentRandCoin(),
                new TenCentRandCoin(),
                new OneCentRandCoin()         
            };

            return coinList;

        }
    }
}
