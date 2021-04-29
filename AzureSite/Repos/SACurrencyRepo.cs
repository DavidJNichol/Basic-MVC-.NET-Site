using Currency.International_Currency;
using Currency.International_Currency.Coins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    public class SACurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }

        public SACurrencyRepo()
        {
            Coins = new List<ICoin>();
        }

        public string About()
        {
            return "South African Currency Repo";
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
            SACurrencyRepo currencyRepo = new SACurrencyRepo();

            foreach(ICoin coin in SouthAfricanCoin.GetSACoinList())
            {
                int count = (int)(Amount / coin.MonetaryValue);
                Amount -= count * coin.MonetaryValue;

                if(count > 0)
                {
                    for (int i= 0; i < count; i++)
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
