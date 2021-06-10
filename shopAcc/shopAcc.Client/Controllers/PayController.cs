using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopAcc.Client.Controllers
{
    public class PayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Banking()
        {
            return View();
        }

        public IActionResult DigitalWallet()
        {
            return View();
        }
    }
}