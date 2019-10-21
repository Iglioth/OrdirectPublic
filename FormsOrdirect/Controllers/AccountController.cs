using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public class AccountController
    {
        AccountRepository repo;
        AccountConverter cvt = new AccountConverter();
        IAccountContext context;



        public AccountController()
        {
            context = new AccountMSSQLContext();
            repo = new AccountRepository(context);
        }


        public Account AccountDetailbyID(int id)
        {
            Account a = repo.GetByID(id);

            return a;
        }
        //hi
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
