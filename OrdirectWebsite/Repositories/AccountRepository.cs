using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public class AccountRepository
    {
        IAccountContext Context;

        public AccountRepository(IAccountContext context)
        {
            Context = context;
        }

        public Account GetByID(int id)
        {
                return Context.GetAccountByID(id);
        }

        public bool CreateAccount(string voornaam, string achternaam, string wachtwoord, string email, string RestaurantID, string Rol)
        {
            return Context.CreateAccount(voornaam, achternaam, email, wachtwoord, RestaurantID, Rol);
        }

        public Account GetByEmail(string Email)
        {
            return Context.GetAccountByEmail(Email);
        }
    }
}
