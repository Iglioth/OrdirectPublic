using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdirectWebsite
{
    public interface IAccountContext
    {
        Account GetAccountByID(int id);

        bool CreateAccount(string voornaam, string achternaam, string email, string wachtwoord, int RestaurantID, string Rol);

        Account Check(string Email);
    }
}
