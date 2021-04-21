using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Currency;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureSite.Models
{
    public class RepoViewModel 
    {
        ICurrencyRepo repo;

        public RepoViewModel(ICurrencyRepo repo)
        {
            this.repo = repo;
        }

        public decimal TotalValue
        {
            get { return repo.TotalValue(); }
        }

        public void MakeChange(decimal Amount)
        {
            repo = USCurrencyRepo.MakeChange(Amount);
        }

        public List<ICoin> Coins
        {
            get { return repo.Coins; }
        }

    }
}
