using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ordirect.Core;

namespace OrdirectWebsite
{
    public class AccountTestContext : IAccountContext
    {
        List<Account> TestAccounts = new List<Account>();
        int id = 1;

        public Account Check(string Email)
        {
            foreach (Account account in TestAccounts)
            {
                if (account.Email == Email)
                {
                    return account;
                }
            }
            return null;
        }

        public bool CreateAccount(string voornaam, string achternaam, string email, string wachtwoord, int RestaurantID, string Rol)
        {
            if (voornaam == null || achternaam == null || email == null || wachtwoord == null || Rol == null)
            {
                return false;
            }

            Account account = new Account()
            {
                Voornaam = voornaam,
                Achternaam = achternaam,
                Email = email,
                RestaurantID = RestaurantID,
                Rol = Rol,
                Wachtwoord = wachtwoord,
                AccountID = id
            };

            id++;

            TestAccounts.Add(account);

            if(GetAccountByID(account.AccountID) == account)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteAccount(int id)
        {
            throw new NotImplementedException();
        }

        public Account GetAccountByID(int id)
        {
            foreach(Account account in TestAccounts)
            {
                if(account.AccountID == id)
                {
                    return account;
                }
            }
            return null;
        }

        public List<Account> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Account> GetRestaurantAccounts(string v)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAccount(string voornaam, string achternaam, string wachtwoord, int accountID)
        {
            throw new NotImplementedException();
        }
    }
}
