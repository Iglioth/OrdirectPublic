﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordirect.Core
{
    public interface IAccountContext
    {
        Account GetAccountByID(int id);
        bool CreateAccount(string voornaam, string achternaam, string email, string wachtwoord, int RestaurantID, string Rol);
        Account Check(string Email);
        bool UpdateAccount(string voornaam, string achternaam, string wachtwoord, int accountID);
        List<Account> GetAll();
        List<Account> GetRestaurantAccounts(int RestaurantID);
        bool DeleteAccount(int id);
    }
}
