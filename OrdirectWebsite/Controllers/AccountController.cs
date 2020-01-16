using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Ordirect.Core;
using Microsoft.Extensions.Configuration;

namespace OrdirectWebsite
{
    public class AccountController : Controller
    {
        //properties
        AccountRepository accountRepository;
        IAccountContext accountContext;

        //converter
        AccountConverter AccountConverter = new AccountConverter();

        //constructor
        public AccountController(IConfiguration config)
        {
            accountContext = new AccountMSSQLContext(config.GetConnectionString("DefaultConnection"));
            accountRepository = new AccountRepository(accountContext);
        }

        //go to account details
        [HttpGet]
        public IActionResult DetailOwn()
        {
            int AccountID = (int)HttpContext.Session.GetInt32("AccountID");

            Account a = accountContext.GetAccountByID(AccountID);

            AccountDetailViewModel viewModel = AccountConverter.ModelToDetailViewModel(a);
            return View(viewModel);
        }

        //go to account editing for the logged in account
        [HttpGet]
        public IActionResult EditOwn()
        {
            int AccountID = (int)HttpContext.Session.GetInt32("AccountID");

            Account a = accountRepository.GetByID(AccountID);

            AccountDetailViewModel viewModel = AccountConverter.ModelToDetailViewModel(a);

            return View(viewModel);
        }

        //Edits your own account name and password
        [HttpPost]
        public IActionResult EditOwn(AccountDetailViewModel vm)
        {
            int AccountID = (int)HttpContext.Session.GetInt32("AccountID");
            Account newa = AccountConverter.DetailViewModelToModel(vm);
            Account a = accountRepository.GetByID(AccountID);
            bool result = accountRepository.UpdateAccount(newa.Voornaam, newa.Achternaam, newa.Wachtwoord, a.AccountID);

            HttpContext.Session.SetString("AccountNaam", newa.Voornaam);

            if (result)
                return View(viewName: "EditSucces");
            else
                return View(viewName: "EditFail");
        }

        
        [HttpGet]
        public IActionResult CreateOwn()
        {
            return View();
        }


        //Create your own account.
        [HttpPost]
        public IActionResult CreateOwn(AccountDetailViewModel vm)
        {
            Account a = AccountConverter.DetailViewModelToModel(vm);

            bool Succes = accountRepository.CreateAccount(a.Voornaam, a.Achternaam, a.Email, a.Wachtwoord, 0, "Klant");

            if (Succes)
                return View("CreateSucces");
            else
                return View("CreateFail");

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Maak een account aan voor een werknemer of manager.
        [HttpPost]
        public IActionResult Create(AccountDetailViewModel vm)
        {
            Account a = AccountConverter.DetailViewModelToModel(vm);

            if (HttpContext.Session.GetString("AccountRol") == "Admin")
            {
                bool succes = accountContext.CreateAccount(a.Voornaam, a.Achternaam, a.Email, a.Wachtwoord, a.RestaurantID, a.Rol);
                if (succes)
                {
                    return View(viewName: "CreateSucces");
                }
            }
            else if (HttpContext.Session.GetString("AccountRol") == "Manager")
            {
                bool succes = accountContext.CreateAccount(a.Voornaam, a.Achternaam, a.Email, a.Wachtwoord, (int)HttpContext.Session.GetInt32("RestaurantID"), "Werknemer");
                if (succes)
                {
                    return View(viewName: "CreateSucces");
                }
            }
            return View(viewName: "CreateFail");
        }

        //Get a list of all or select accounts differing whether the user is an admin or manager.
        [HttpGet]
        public IActionResult Index()
        {
            AccountViewModel vm = new AccountViewModel();
            List<Account> accounts = new List<Account>();

            if (HttpContext.Session.GetString("AccountRol") == "Admin")
            {
                accounts = accountRepository.GetAll();
            }
            else if(HttpContext.Session.GetString("AccountRol") == "Manager")
            {
                accounts = accountRepository.GetRestaurantAccounts((int)HttpContext.Session.GetInt32("RestaurantID"));
            }
            if(accounts == null)
            {
                return View("Index", vm);
            }
            else
            {
                vm.AccountDetailViewModels = AccountConverter.ModelsToViewModel(accounts);
                return View("Index", vm);

            }
        }

        //Deletes an account.
        [HttpGet]
        public IActionResult Delete(int id)
        {
            bool succes = accountRepository.DeleteAccount(id);

            if (succes)
                return RedirectToAction("Index");
            else
                return View();
        }
    }
}