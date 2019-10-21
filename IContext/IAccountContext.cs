using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsOrdirect
{
    public interface IAccountContext
    {
        Account GetAccountByID(int id);

        bool CreateAccount(string voornaam, string achternaam, string email, string wachtwoord, string RestaurantID, string Rol);

        Account GetAccountByEmail(string Email);
    }
}
