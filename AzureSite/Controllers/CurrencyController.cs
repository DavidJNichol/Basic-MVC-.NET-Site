using AzureSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Currency;
using Currency.US;
using Microsoft.AspNetCore.Http;

namespace AzureSite.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly ILogger<CurrencyController> _logger;

        ICurrencyRepo repo { get; set; }
        RepoViewModel vm;

        public CurrencyController(ILogger<CurrencyController> logger)
        {
            this._logger = logger;
            repo = new USCurrencyRepo();
            vm = new RepoViewModel(repo);
        }

        [Route("{Amount:Int}")]
        [HttpPost]
        public IActionResult MakeChange(int Amount)
        {
            decimal amount;
            amount = Convert.ToDecimal(Amount);
            vm.MakeChange(amount);

            return View(vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
