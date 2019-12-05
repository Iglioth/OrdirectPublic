using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class LogInController : Controller
    {
        //properties
        AccountRepository accountRepository;
        IAccountContext accountContext;

        //converter
        AccountConverter AccountConverter = new AccountConverter();

        //constructor
        public LogInController()
        {
            accountContext = new AccountMSSQLContext();
            accountRepository = new AccountRepository(accountContext);
        }
        public IActionResult Logout()
        {
            return View();
        }

        
        public IActionResult LogIn()
        {
            AccountDetailViewModel vm = new AccountDetailViewModel();
            return View(vm);
        }

        [HttpPost]
        public IActionResult LogIn(AccountDetailViewModel vm)
        {
            Account a = AccountConverter.DetailViewModelToModel(vm);
            string check = accountRepository.Check(a.Email, a.Wachtwoord);
            Account fullaccount = accountRepository.GetByEmail(a.Email);
            if (check == "Correct")
            {
                HttpContext.Session.SetInt32("AccountID", fullaccount.AccountID);
                HttpContext.Session.SetString("AccountRol", fullaccount.Rol);
                HttpContext.Session.SetInt32("AccountRestaurantID", fullaccount.RestaurantID);
                return RedirectToAction("Index", controllerName: "Restaurant");
            }
            else
            {
                return View(check);
            }
        }

        
    }
}
