using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Ordirect.Core;

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
        public AccountController()
        {
            accountContext = new AccountMSSQLContext();
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

            Account a = accountContext.GetAccountByID(AccountID);

            AccountDetailViewModel viewModel = AccountConverter.ModelToDetailViewModel(a);

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult EditOwn(AccountDetailViewModel vm)
        {
            int AccountID = (int)HttpContext.Session.GetInt32("AccountID");
            Account newa = AccountConverter.DetailViewModelToModel(vm);
            Account a = accountContext.GetAccountByID(AccountID);
            bool result = accountContext.UpdateAccount(newa.Voornaam, newa.Achternaam, newa.Wachtwoord, a.AccountID);

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

        [HttpPost]
        public IActionResult CreateOwn(AccountDetailViewModel vm)
        {
            Account a = AccountConverter.DetailViewModelToModel(vm);

            bool Succes = accountContext.CreateAccount(a.Voornaam, a.Achternaam, a.Email, a.Wachtwoord, 0, "Klant");

            if (Succes)
                return View("CreateSucces");
            else
                return View("CreateFail");

        }

        [HttpGet]
        public IActionResult Index()
        {
            AccountViewModel vm = new AccountViewModel();
            List<Account> accounts = new List<Account>();

            if (HttpContext.Session.GetString("AccountRol") == "Admin")
            {
                accounts = accountContext.GetAll();
            }
            else if(HttpContext.Session.GetString("AccountRol") == "Manager")
            {
                accounts = accountContext.GetRestaurantAccounts(HttpContext.Session.GetString("RestaurantID"));
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

        [HttpPost]
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