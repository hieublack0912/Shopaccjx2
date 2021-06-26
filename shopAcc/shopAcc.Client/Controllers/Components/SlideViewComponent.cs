using eShopSolution.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using shopAcc.ApiIntegration;
using shopAcc.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.Client.Controllers.Components
{
    public class SlideViewComponent : ViewComponent
    {
        private readonly ISlideApiClient _slideApiClient;

        public SlideViewComponent(ISlideApiClient slideApiClient)
        {
            _slideApiClient = slideApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewModel = await _slideApiClient.GetAll();
            return View(viewModel);
        }
    }
}