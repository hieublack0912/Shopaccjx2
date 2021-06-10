using Microsoft.AspNetCore.Mvc;
using shopAcc.ApiIntegration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.Client.Controllers.Components
{
    public class BalanceViewComponent : ViewComponent
    {
        private readonly IBalanceApiClient _balanceApiClient;

        public BalanceViewComponent(IBalanceApiClient balanceApiClient)
        {
            _balanceApiClient = balanceApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await _balanceApiClient.GetAll();
            return View(items);
        }
    }
}