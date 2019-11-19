using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class AccountConverter
    {
        public Account ViewModelToModel(AccountDetailViewModel vm)
        {
            Account k = new Account()
            {
                AccountID = vm.AccountID,
                Voornaam = vm.Voornaam,
                Achternaam = vm.Achternaam,
                Email = vm.Email,
                Wachtwoord = vm.Wachtwoord,
                RestaurantID = vm.RestaurantID,
                Rol = vm.Rol
            };

            return k;
        }

        public AccountDetailViewModel ModelToViewModel(Account a)
        {
            AccountDetailViewModel vm = new AccountDetailViewModel
            {
                AccountID = a.AccountID,
                Achternaam = a.Achternaam,
                Email = a.Email,
                Voornaam = a.Voornaam,
                Wachtwoord = a.Wachtwoord,
                RestaurantID = a.RestaurantID,
                Rol = a.Rol
            };

            return vm;
        }
    }
}
