using System;
using System.Collections.Generic;
using Currency.US;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    public class USCurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }

        public USCurrencyRepo()
        {
            Coins = new List<ICoin>();
        }

        public string About()
        {
            return null;
        }

        public void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        public int GetCoinCount()
        {
            return Coins.Count;
        }

        public static ICurrencyRepo MakeChange(decimal Amount)
        {
            USCurrencyRepo currencyRepo = new USCurrencyRepo();

            foreach (ICoin coin in USCoin.GetUSCoinList())
            {
                int count = (int)(Amount / coin.MonetaryValue);
                Amount -= count * coin.MonetaryValue;   

                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        currencyRepo.AddCoin(coin);
                    }
                }
            }

            return currencyRepo;
        }

        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            return this;
        }

        public ICoin RemoveCoin(ICoin c)
        {
            Coins.Remove(c);
            return c;
        }

        public decimal TotalValue()
        {
            decimal total = 0;
            foreach (ICoin c in Coins)
            {
                total += c.MonetaryValue;
            }

            return total;
        }
    }
}
