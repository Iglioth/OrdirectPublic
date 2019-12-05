using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class AccountConverter : IViewModelConverterContext<Account, AccountDetailViewModel>
    {

        public AccountDetailViewModel ModelToDetailViewModel(Account a)
        {
            return new AccountDetailViewModel
            {
                AccountID = a.AccountID,
                Achternaam = a.Achternaam,
                Email = a.Email,
                Voornaam = a.Voornaam,
                Wachtwoord = a.Wachtwoord,
                RestaurantID = a.RestaurantID,
                Rol = a.Rol
            };
        }

        public Account DetailViewModelToModel(AccountDetailViewModel vm)
        {
            return new Account()
            {
                AccountID = vm.AccountID,
                Voornaam = vm.Voornaam,
                Achternaam = vm.Achternaam,
                Email = vm.Email,
                Wachtwoord = vm.Wachtwoord,
                RestaurantID = vm.RestaurantID,
                Rol = vm.Rol
            };
        }

        public List<Account> ViewModelToModels(List<AccountDetailViewModel> vms)
        {
            List<Account> accounts = new List<Account>();
            foreach (AccountDetailViewModel vm in vms)
            {
                accounts.Add(
                    new Account()
                    {
                        AccountID = vm.AccountID,
                        Voornaam = vm.Voornaam,
                        Achternaam = vm.Achternaam,
                        Email = vm.Email,
                        Wachtwoord = vm.Wachtwoord,
                        RestaurantID = vm.RestaurantID,
                        Rol = vm.Rol
                    });
            }
            return accounts;
        }

        public List<AccountDetailViewModel> ModelsToViewModel(List<Account> ms)
        {
            List<AccountDetailViewModel> accountDetailViewModels = new List<AccountDetailViewModel>();
            foreach (Account a in ms)
            {
                accountDetailViewModels.Add(
                    new AccountDetailViewModel
                    {
                        AccountID = a.AccountID,
                        Achternaam = a.Achternaam,
                        Email = a.Email,
                        Voornaam = a.Voornaam,
                        Wachtwoord = a.Wachtwoord,
                        RestaurantID = a.RestaurantID,
                        Rol = a.Rol
                    });
            }
            return accountDetailViewModels;
        }
    }
}
