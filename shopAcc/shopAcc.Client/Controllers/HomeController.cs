using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using shopAcc.ApiIntegration;
using shopAcc.Client.Models;
using shopAcc.Utilities.Constants;
using shopAcc.ViewModels.System.Users;
using System;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISlideApiClient _slideApiClient;
        private readonly IAccountApiClient _accountApiClient;

        public HomeController(ISlideApiClient slideApiClient,
            IAccountApiClient accountApiClient)
        {
            _slideApiClient = slideApiClient;
            _accountApiClient = accountApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                FeaturedProducts = await _accountApiClient.GetFeaturedAccounts(SystemConstants.AccountSettings.NumberOfFeaturedAccounts),
                LatestProducts = await _accountApiClient.GetLatestAccounts(SystemConstants.AccountSettings.NumberOfLatestAccounts),
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}