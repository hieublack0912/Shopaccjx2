using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using shopAcc.ApiIntegration;
using shopAcc.Utilities.Constants;
using shopAcc.ViewModels.Sales;
using shopAcc.ViewModels.System.Transactions;
using shopAcc.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace shopAcc.Client.Controllers
{
    public class UserController : Controller
    {
        private readonly ITransactionApiClient _transactionApiClient;
        private readonly IConfiguration _configuration;
        private readonly IUserApiClient _userApiClient;
        private readonly IOrderApiClient _orderApiClient;

        public UserController(ITransactionApiClient transactionApiClient, IOrderApiClient orderApiClient,
            IConfiguration configuration, IUserApiClient userApiClient)
        {
            _configuration = configuration;
            _transactionApiClient = transactionApiClient;
            _userApiClient = userApiClient;
            _orderApiClient = orderApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            //if (User.Identity.Name != null)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            var request = new LoginRequest()
            {
                UserName = userName,
                Password = password,
            };
            if (!ModelState.IsValid)
            {
                ModelState.Clear();
                ModelState.AddModelError("", "Vui lòng nhập đầy đủ trường tài khoản và mật khẩu");
                return View(ModelState);
            }

            var result = await _userApiClient.LoginMember(request);
            if (result.ResultObj == null)
            {
                ModelState.AddModelError("", "Nhập sai tài khoản hoặc mật khẩu");
                return View();
            }
            var userPrincipal = this.ValidateToken(result.ResultObj);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                IsPersistent = false
            };
            HttpContext.Session.SetString(SystemConstants.AppSettings.Token, result.ResultObj);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, authProperties);
            TempData["Message"] = "Đăng nhập thành công";
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(string firstName, string lastName, DateTime dob, string email, string phoneNumber, string userName, string passWord, string passWordre)
        {
            var registerRequest = new RegisterRequest()
            {
                FirstName = firstName,
                LastName = lastName,
                Dob = dob,
                Email = email,
                PhoneNumber = phoneNumber,
                UserName = userName,
                Password = passWord,
                ConfirmPassword = passWordre
            };
            if (passWord != passWordre)
            {
                ModelState.AddModelError("", "Mật khẩu nhập lại không khớp");
                return View(registerRequest);
            }
            if (!ModelState.IsValid)
            {
                ModelState.Clear();
                ModelState.AddModelError("", "Vui lòng nhập đầy đủ các trường");
                return View(registerRequest);
            }

            var result = await _userApiClient.RegisterUser(registerRequest);
            if (!result.IsSuccessed)
            {
                ModelState.AddModelError("", result.Message);
                return View();
            }
            var loginResult = await _userApiClient.LoginMember(new LoginRequest()
            {
                UserName = registerRequest.UserName,
                Password = registerRequest.Password,
                RememberMe = true
            });

            var userPrincipal = this.ValidateToken(loginResult.ResultObj);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                IsPersistent = false
            };
            HttpContext.Session.SetString(SystemConstants.AppSettings.Token, loginResult.ResultObj);
            await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        userPrincipal,
                        authProperties);
            TempData["Message"] = "Đăng ký thành công hệ thống đã tự động đăng nhập";
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Details()
        {
            var result = await _userApiClient.GetByName(User.Identity.Name);
            return View(result.ResultObj);
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var result = await _userApiClient.GetByName(User.Identity.Name);
            if (result.IsSuccessed)
            {
                var user = result.ResultObj;
                var updateRequest = new UserMemUpdateRequest()
                {
                    Dob = user.Dob,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber
                };
                return View(updateRequest);
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string passWord, string firstName, string lastName, DateTime dob, string email, string phoneNumber)
        {
            if (passWord == null)
            {
                ModelState.AddModelError("", "Vui lòng nhập trường mật khẩu không khớp");
                return View();
            }
            var user = await _userApiClient.GetByName(User.Identity.Name);
            var request = new UserMemUpdateRequest()
            {
                Id = user.ResultObj.Id,
                Password = passWord,
                FirstName = firstName,
                LastName = lastName,
                Dob = dob,
                Email = email,
                PhoneNumber = phoneNumber
            };
            var result = await _userApiClient.UpdateMem(user.ResultObj.Id, request);
            if (result.IsSuccessed)
            {
                TempData["Message"] = "Thay đổi thông tin thành công";
                return RedirectToAction("Details");
            }

            ModelState.AddModelError("", result.Message);
            return View();
        }

        public IActionResult ChangePass()
        {
            if (User.Identity.Name == null)
            {
                ModelState.AddModelError("", "Cần đăng nhập để thực hiện chức năng");
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePass(string passWord, string passWordNew, string passWordNewre)
        {
            if (passWordNew == null || passWordNewre == null || passWord == null)
            {
                ModelState.AddModelError("", "Vui lòng nhập đủ các trường");
                return View();
            }
            if (passWordNew != passWordNewre)
            {
                ModelState.AddModelError("", "Mật khẩu nhập lại không khớp");
                return View();
            }
            var user = await _userApiClient.GetByName(User.Identity.Name);
            var request = new ChangePassWordRequest()
            {
                Id = user.ResultObj.Id,
                PassWord = passWord,
                NewPassWord = passWordNew
            };
            var result = await _userApiClient.ChangePassWord(user.ResultObj.Id, request);
            if (result.IsSuccessed)
            {
                TempData["Message"] = "Đổi mật khẩu thành công";
                return RedirectToAction("Details");
            }

            ModelState.AddModelError("", result.Message);
            return View();
        }

        public async Task<IActionResult> Trans(string keyword, string userName, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetTransactionPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                UserName = userName
            };
            var data = await _transactionApiClient.GetPagings(request);
            ViewBag.Keyword = keyword;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }

        public async Task<IActionResult> Paylist(string userName, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetOrderUserPagingRequest()
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                UserName = userName
            };
            var data = await _orderApiClient.GetUserPagings(request);
            ViewBag.Keyword = userName;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }

        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();

            validationParameters.ValidateLifetime = true;

            validationParameters.ValidAudience = _configuration["Tokens:Issuer"];
            validationParameters.ValidIssuer = _configuration["Tokens:Issuer"];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));

            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

            return principal;
        }
    }
}