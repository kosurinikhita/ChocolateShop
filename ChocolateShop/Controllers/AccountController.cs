using ChocolateShop.Models;
using System.Web.Mvc;
using ChocolateShop.DAL;
using ChocolateShop.BL;
using ChocolateShop.entity;

namespace ChocolateShop.Controllers
{
    public class AccountController : Controller
    {
        //public AccountContext accountContext = new AccountContext();
        // GET: Account
        AccountBL accountBL = new AccountBL();
        //AccountRepository accountRepository = new AccountRepository();
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [AllowAnonymous]
        public ActionResult Signup()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Signup(SignupViewModel signupViewModel)
        {
            AccountEntity account = new AccountEntity();
            account.Name = signupViewModel.Name;
            account.UserId = signupViewModel.UserId;
            account.Email = signupViewModel.Email;
            account.Password = signupViewModel.Password;
            account.Gender = signupViewModel.Gender;
            account.City = signupViewModel.City;
           
                AccountBL acc = new AccountBL();
                acc.Signup(account);

                return View("Login");
                // return RedirectToAction("DisplayDB","Database");
            
           //ModelState.AddModelError("","Error occured");
           //return View(signupViewModel);
        }
    }
}