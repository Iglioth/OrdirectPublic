using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Ordirect.Core;

namespace OrdirectWebsite
{
    public class GerechtController
    {
        GerechtRepository repo;
        IGerechtContext context;

        public GerechtController(IConfiguration config)
        {
            context = new GerechtMSSQLContext(config.GetConnectionString("DefaultConnection"));
            repo = new GerechtRepository(context);
        }
    }
}
