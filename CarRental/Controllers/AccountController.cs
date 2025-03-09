using System.Security.Claims;
using CarRental.Models;
using CarRental.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using CarRental.Services;

namespace CarRental.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly EmailService _emailService;
        
        public AccountController(AppDbContext accesDb, EmailService emailService)
        {

            _context = accesDb;
            _emailService = emailService;

        }
        public IActionResult Index()
        {
            return View(_context.UserAccounts.ToList());
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(SignupViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserAccount account = new UserAccount();
                account.Email = model.Email;
                account.FirstName = model.FirstName;
                account.LastName = model.LastName;
                account.Password = model.Password;
                account.Username = model.Username;

                try
                {
                    _context.UserAccounts.Add(account);
                    _context.SaveChanges();

                    ModelState.Clear();
                    ViewBag.Message = $"{account.FirstName} {account.LastName} registered successfully. Please login.";

                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError("", "Please enter a unique email or Password");
                    return View(model);
                }
                return View();
            }
            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.UserAccounts.Where(x => (x.Username == model.UsernameOrEmail || x.Email == model.UsernameOrEmail) && x.Password == model.Password).FirstOrDefault();

                if (user != null)
                {
                    //success login
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Email),
                        new Claim("Name", user.FirstName),
                        new Claim(ClaimTypes.Role, "User"),
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    return RedirectToAction("SecurePage");
                }
                else
                {
                    ModelState.AddModelError("", "Username/Email or Password is incorrect");
                }
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult SecurePage()
        {
            ViewBag.Name = HttpContext.User.Identity.Name;
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ForgotPassword(ForgotPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _context.UserAccounts.FirstOrDefault(u => u.Email == model.Email);
            if (user == null)
            {
                ViewBag.ErrorMessage = "User not found.";
                return View();
            }

            // Generate verification code
            Random random = new Random();
            string verificationCode = random.Next(100000, 999999).ToString();

            // Store in TempData instead of database
            TempData["VerificationCode"] = verificationCode;
            TempData["Email"] = model.Email;

            // Send email
            _emailService.SendVerificationEmail(model.Email, verificationCode);

            return RedirectToAction("VerifyCode");
        }

        public IActionResult VerifyCode()
        {
            return View();
        }


        [HttpPost]
        public IActionResult VerifyCode(string email, string code)
        {
            if (TempData["VerificationCode"] != null && TempData["VerificationCode"].ToString() == code)
            {
                TempData["Email"] = email; // Save email for next step
                return RedirectToAction("ResetPassword");
            }

            ViewBag.ErrorMessage = "Invalid code.";
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _context.UserAccounts.FirstOrDefault(u => u.Email == model.Email);
            if (user != null)
            {
                if (model.NewPassword != model.ConfirmPassword)
                {
                    ViewBag.ErrorMessage = "Passwords do not match.";
                    return View(model);
                }

                user.Password = model.NewPassword;
                _context.SaveChanges();

                TempData.Clear(); // Clear TempData after successful reset

                return RedirectToAction("Login"); // Redirect to Login Page
            }

            ViewBag.ErrorMessage = "Error resetting password.";
            return View();
        }

    }
}