﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordirect.Core
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

        public bool CreateAccount(string voornaam, string achternaam, string wachtwoord, string email, int RestaurantID, string Rol)
        {
            return Context.CreateAccount(voornaam, achternaam, email, wachtwoord, RestaurantID, Rol);
        }

        public Account GetByEmail(string Email)
        {
            return Context.Check(Email);
        }

        public string Check(string Email, string Wachtwoord)
        {
            Account a = Context.Check(Email);
            if (a == null)
            {
                return "FEmail";
            }
            else if (a.Wachtwoord != Wachtwoord)
            {
                return "FWachtwoord";
            }
            else if (a.Wachtwoord == Wachtwoord && a.Email == Email)
            {
                return "Correct";
            }
            else
            {
                return "ValidationError";
            }
        }

        public bool DeleteAccount(int id)
        {
            return Context.DeleteAccount(id);
        }

        public List<Account> GetRestaurantAccounts(int RestaurantID)
        {
            return Context.GetRestaurantAccounts(RestaurantID);
        }

        public List<Account> GetAll()
        {
            return Context.GetAll();
        }

        public bool UpdateAccount(string voornaam, string achternaam, string wachtwoord, int accountID)
        {
            return Context.UpdateAccount(voornaam, achternaam, wachtwoord, accountID);
        }
    }
}
