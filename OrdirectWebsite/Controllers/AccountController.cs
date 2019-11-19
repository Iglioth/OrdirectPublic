using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrdirectWebsite
{
    public class AccountController : Controller
    {
        AccountRepository repo; 
        AccountConverter cvt = new AccountConverter();
        IAccountContext context;

         

        public AccountController()
        {
            context = new AccountMSSQLContext();
            repo = new AccountRepository(context);
        }

        /*[HttpPost]
        public IActionResult LogIn(AccountDetailViewModel vm)
        {
            Account a = cvt.ViewModelToModel(vm);
            if (repo.GetByEmail(a.Email) != null)
                return View(vm);
            else
                return
            return NotImplementedException sduoh;

        }*/

        [HttpGet]
        public IActionResult LogIn()
        {
            AccountDetailViewModel vm = new AccountDetailViewModel();
            return View(vm);
        }

        public Account AccountDetailbyID(int id)
        {
            Account a = repo.GetByID(id);

            return a;
        }
        
        public bool CreateAccount(string voornaam, string achternaam, string wachtwoord, string email, string restaurantID, string Rol)
        {
            return repo.CreateAccount(voornaam, achternaam, wachtwoord, email, restaurantID, Rol);
        }

        public Account GetAccountByEmail(string Email)
        {
            Account a = repo.GetByEmail(Email);
            return a;
        }

       
    }
}
