using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

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
    }
}