using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Ordirect.Core;
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
        public LogInController(IConfiguration config)
        {
            accountContext = new AccountMSSQLContext(config.GetConnectionString("DefaultConnection"));
            accountRepository = new AccountRepository(accountContext);
        }
        
        //Brengt de gebruiker naar de login en registratie pagina.
        public IActionResult LogIn()
        {
            AccountDetailViewModel vm = new AccountDetailViewModel();
            return View(vm);
        }


        //Logt in op de website en brengt de gebruiker naar een pagina bepalend op de gebruiker's rol.
        [HttpPost]
        public IActionResult LogIn(AccountDetailViewModel vm)
        {
            Account simpleaccount = AccountConverter.DetailViewModelToModel(vm);
            string check = accountRepository.Check(simpleaccount.Email, simpleaccount.Wachtwoord);
            Account fullaccount = accountRepository.GetByEmail(simpleaccount.Email);
            if (check == "Correct")
            {
                HttpContext.Session.SetInt32("AccountID", fullaccount.AccountID);
                HttpContext.Session.SetString("AccountRol", fullaccount.Rol);
                HttpContext.Session.SetInt32("RestaurantID", fullaccount.RestaurantID);
                HttpContext.Session.SetString("AccountNaam", fullaccount.Voornaam);

                if(fullaccount.RestaurantID != 0)
                {
                    return RedirectToAction("IndexVoorRestaurant", controllerName: "Reservering");
                }
                else
                {
                    return RedirectToAction("Index", controllerName: "Restaurant");
                }
            }
            else
            {
                return View(check);
            }
        }

        //Cleart de sesssion en brengt de klant naar de logout view.
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View();
        }
    }
}
